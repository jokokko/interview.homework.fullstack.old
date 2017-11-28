namespace Sample.Tasks.Desktop.Infrastructure
{
    public interface IMessageHandler<T> where T : Message
    {
        void Handle(T message);
    }
}