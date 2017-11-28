using Akka.Actor;

namespace Sample.Tasks.Console.Actors
{
    /// <summary>
    /// Delegates work to <see cref="Persister"/> actors
    /// </summary>    
    /// <remarks>In facse of failure, restarts children until succesful</remarks>
    public sealed class PersistenceSupervisor : ReceiveActor
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