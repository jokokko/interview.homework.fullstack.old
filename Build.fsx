#r @"src/packages/FAKE/tools/FakeLib.dll"
open System.IO
open Fake
open Fake.AssemblyInfoFile
open Fake.Git.Information
open Fake.SemVerHelper
open Fake.Testing

let baseVersion = "0.1.0"
let semVersion : SemVerInfo = parse baseVersion
let versionBase = semVersion.ToString()
let packagesPath = FullName "./src/packages"
let artifactPath = FullName "./artifacts"

let branch = (fun _ ->
  getBranchName (".")
)

let informationalVersion = (fun _ ->
  let branchName = (branch ".")
  let label = " (" + branchName + "/" + (getCurrentSHA1 ".").[0..7] + ")"
  (versionBase + label)
)

let versionInformational =  informationalVersion()

Target "Clean" (fun _ ->
  ensureDirectory artifactPath
  
  CleanDir artifactPath
)

Target "RestoreNugetPackages" (fun _ -> 
     "./src/Sample.Tasks.sln"
     |> RestoreMSSolutionPackages (fun p ->
         { p with
             OutputPath = packagesPath
             Retries = 2 })
)

Target "Version" (fun _ ->
  CreateCSharpAssemblyInfo @".\src\VersionInfo.cs"
    [ Attribute.Title "Sample Tasks"
      Attribute.Description "A set of simple coding tasks"
      Attribute.Product "SampleTasks"
      Attribute.Version versionBase
      Attribute.FileVersion versionBase
      Attribute.InformationalVersion versionInformational
    ]
)

Target "Build" (fun _ ->    
  let setParams defaults = { 
    defaults with
        Verbosity = Some(Quiet)
        Targets = ["Clean"; "Build"]
        Properties =
            [
                "Optimize", "True"
                "DebugSymbols", "True"
                "RestorePackages", "True"
                "Configuration", "Release"
                "SignAssembly", "True"                
                "TargetFrameworkVersion", "v4.5"
                "Platform", "Any CPU"
            ]
  }

  build setParams @".\src\Sample.Tasks.sln"
      |> DoNothing
)

let testFiles = [ "./src/Sample.Tasks.Domain.Tests/bin/Release/Sample.Tasks.Domain.Tests.dll" ]

Target "Tests" (fun _ ->
    testFiles
        |> xUnit (fun p -> 
            {p with
                HtmlOutputPath  = Some(artifactPath @@ "output.html") })
)


Target "Default" (fun _ ->
  trace "Building..."
)

"Clean"
  ==> "Version"
  ==> "RestoreNugetPackages"  
  ==> "Build"
  ==> "Tests"
  ==> "Default"
 
RunTargetOrDefault "Default"