# Tasks by project #

## Sample.Tasks.Domain & Sample.Tasks.Domain.Tests ##

Complete EpoBiblioProvider so that tests in *EpoBiblioProviderTests* pass. Use the EPO REST API: http://www.epo.org/searching-for-patents/technical/espacenet/ops.html

Complete InventorProvider so that tests in *InventorProviderTests* pass.
Use NPoco to fetch data from *data\SampleData.sqlite*.

Complete InventorPersister so that it can be used to persist inventors for a publication. Use NPoco.

## Sample.Tasks.Web ##

Display bibliographic EPO data in web view. Fetch data from 
EpoBiblioController. Use AngularJS: https://angularjs.org/ 

## Sample.Tasks.Desktop ##

Complete project so that inventor data can be fetched by publication number and displayed in the main view.

## Sample.Tasks.Console ##

Complete project so that inventor data can be persisted from user input. Use Akka.NET. In case of persistence failures, retry persistence until succesful.
Print persisted information on screen.

# Finally #

**Build.bat must pass.**

## Other Stuff ##

Feel free to upgrade any used libraries.
Feel free to use any new libraries, but give rationale for introducing new dependencies.

Visual Studio Community: https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx (VS 2013 .. 2017 is fine too)