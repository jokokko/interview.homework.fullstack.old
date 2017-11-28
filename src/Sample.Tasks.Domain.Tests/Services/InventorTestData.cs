using System.Collections;
using System.Collections.Generic;

namespace Sample.Tasks.Domain.Tests.Services
{
    internal sealed class InventorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "EP2531303", new List<string> {"Kalle Keksijä", "Keke Kehittäjä" }
            };
            yield return new object[]
            {
                "WO2014164896", new List<string> { "Pelle Peloton" }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}