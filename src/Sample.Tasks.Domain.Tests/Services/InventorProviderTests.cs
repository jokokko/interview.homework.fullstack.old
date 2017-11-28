using System.Collections.Generic;
using Sample.Tasks.Domain.Services;
using Xunit;
using Xunit.Extensions;

namespace Sample.Tasks.Domain.Tests.Services
{
    public sealed class InventorProviderTests
    {
        private readonly InventorProvider sut;

        public InventorProviderTests()
        {
            sut = new InventorProvider();
        }

        [Fact]
        public void SutIsIInventorProvider()
        {
            Assert.IsAssignableFrom<IInventorProvider>(sut);
        }

        [Theory]
        [ClassData(typeof(InventorTestData))]
        public void CanGetInventorsByPublicationNumber(string publicationNumber, IEnumerable<string> expectedInventors)
        {
            var inventors = sut.GetInventorName(publicationNumber);
            Assert.Equal(expectedInventors, inventors);
        }
    }
}