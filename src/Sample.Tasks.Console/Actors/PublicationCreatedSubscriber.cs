using Akka;
using Akka.Actor;
using Sample.Tasks.Console.Messages;

namespace Sample.Tasks.Console.Actors
{
    public sealed class PublicationCreatedSubscriber : ReceiveActor
    {    
        private void Published(object @event)
        {
            @event.Match().With<PublicationCreated>(e =>
            {
                System.Console.WriteLine(
                    $"Created {e.Request.PublicationNumber} with inventors {string.Join(", ", e.Request.Inventors)}");
            });
        }
    }
}