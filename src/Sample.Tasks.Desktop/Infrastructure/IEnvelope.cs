namespace Sample.Tasks.Desktop.Infrastructure
{
    public interface IEnvelope
    {
        void Reply<T>(T message) where T : Message;
    }
}