using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Tasks.Domain.Services
{
    // TODO: Use NPoco to persist data in Data\SampleData.sqlite SQLite database
    public sealed class InventorPersister : IInventorPersister
    {
        public Task Persist(string publicationNumber, IEnumerable<string> inventors)
        {
            throw new System.NotImplementedException();
        }
    }
}