using System.Collections.Generic;

namespace Sample.Tasks.Desktop.Messages
{
    public sealed class GetInventorsByPublicationOk
    {
        public readonly IEnumerable<string> Inventors;

        public GetInventorsByPublicationOk(IEnumerable<string> inventors)
        {
            Inventors = inventors;
        }
    }
}