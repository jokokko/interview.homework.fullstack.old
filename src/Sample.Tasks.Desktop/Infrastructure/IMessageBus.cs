namespace Sample.Tasks.Desktop.Infrastructure
{
    public interface IMessageBus
    {
        void Publish(Message message);
    }
}