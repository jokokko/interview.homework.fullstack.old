namespace Sample.Tasks.Console.Messages
{
    public sealed class PublicationCreated
    {
        public readonly CreatePublication Request;

        public PublicationCreated(CreatePublication request)
        {
            Request = request;
        }
    }
}