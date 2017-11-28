using System.Linq;
using Akka.Actor;
using Sample.Tasks.Console.Messages;

namespace Sample.Tasks.Console
{
    internal static class Program
    {
        private static void Main()
        {
            var system = ActorSystem.Create("system");

            IActorRef inputProcessor = null;

            while (true)
            {
                System.Console.WriteLine("Give publication number >");                

                var publicationNumber = System.Console.ReadLine();
                
                while (true)
                {
                    System.Console.WriteLine("Give inventor name (or stop by entering empty) >");                    
                    var inventorName = System.Console.ReadLine();                    
                }
                
                var cmd = new CreatePublication(publicationNumber, Enumerable.Empty<string>());

                inputProcessor.Ask(cmd);
            }
        }
    }
}
