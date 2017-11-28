using System;
using System.Threading.Tasks;
using Akka.Actor;
using Sample.Tasks.Console.Messages;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Console.Actors
{
    public sealed class Persister : ReceiveActor
    {
        private readonly IInventorPersister inventorPersister;

        public Persister(IInventorPersister inventorPersister)        
        {
            this.inventorPersister = inventorPersister;
        }
    
        private async Task Persist(CreatePublication message)
        {
            RandomFailure.Fail();                        
            await inventorPersister.Persist(message.PublicationNumber, message.Inventors);            
            Context.System.EventStream.Publish(new PublicationCreated(message));
        }

        private static class RandomFailure
        {
            private static readonly Random R = new Random();
            public static void Fail()
            {
                if (R.Next(0, 2) == 0)
                {
                    throw new InvalidOperationException("Random failure");
                }
            }
        }
    }
}