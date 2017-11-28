using Akka.Actor;

namespace Sample.Tasks.Console.Actors
{
    public sealed class InputProcessor : ReceiveActor
    {
        protected override void PreStart()
        {
            base.PreStart();
            Become(Active);
        }

        private void Active(object message)
        {            
        }
    }
}