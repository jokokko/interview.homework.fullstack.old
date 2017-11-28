using System;
using System.Collections.Generic;

namespace Sample.Tasks.Domain.Services
{
    // TODO: Use NPoco to read Data\SampleData.sqlite SQLite database & return inventor names from there
    public sealed class InventorProvider : IInventorProvider
    {
        public IEnumerable<string> GetInventorName(string publicationNumber)
        {
            throw new NotImplementedException();
        }
    }
}