namespace Sample.Tasks.Domain.Model
{
    public sealed class BiblioData
    {
        public readonly string PublicationNumber;
        public readonly string InventionTitle;

        public BiblioData(string publicationNumber, string inventionTitle)
        {
            PublicationNumber = publicationNumber;
            InventionTitle = inventionTitle;
        }        
    }
}