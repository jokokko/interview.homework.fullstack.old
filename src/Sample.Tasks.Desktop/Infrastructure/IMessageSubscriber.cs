namespace Sample.Tasks.Desktop.Infrastructure
{
    public interface IMessageSubscriber
    {
        void Subscribe<T>(IMessageHandler<T> handler) where T : Message;
    }
}