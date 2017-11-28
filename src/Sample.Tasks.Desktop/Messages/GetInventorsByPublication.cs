using Sample.Tasks.Desktop.Infrastructure;

namespace Sample.Tasks.Desktop.Messages
{
    public sealed class GetInventorsByPublication : Message
    {
        public readonly IEnvelope Envelope;
        public readonly string PublicationNumber;

        public GetInventorsByPublication(IEnvelope envelope, string publicationNumber)
        {
            Envelope = envelope;
            PublicationNumber = publicationNumber;
        }
    }
}