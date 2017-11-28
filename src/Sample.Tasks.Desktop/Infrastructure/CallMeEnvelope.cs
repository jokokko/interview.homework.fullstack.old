namespace Sample.Tasks.Desktop.Infrastructure
{
    public sealed class CallMeEnvelope : IEnvelope
    {
        public void Reply<T>(T message) where T : Message
        {
            throw new System.NotImplementedException();
        }
    }
}