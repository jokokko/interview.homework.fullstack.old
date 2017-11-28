using System.Collections.Generic;

namespace Sample.Tasks.Console.Messages
{
    public sealed class CreatePublication
    {
        public readonly string PublicationNumber;
        public readonly IEnumerable<string> Inventors;

        public CreatePublication(string publicationNumber, IEnumerable<string> inventors)
        {
            PublicationNumber = publicationNumber;
            Inventors = inventors;
        }
    }
}