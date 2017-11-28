using System;
using System.Threading.Tasks;
using Sample.Tasks.Domain.Services;
using Xunit;
using Xunit.Extensions;

namespace Sample.Tasks.Domain.Tests.Services
{
    public sealed class EpoBiblioProviderTests
    {
        private readonly EpoBiblioProvider sut;

        public EpoBiblioProviderTests()
        {
            sut = new EpoBiblioProvider();
        }

        [Fact]
        public void SutIsIBiblioProvider()
        {
            Assert.IsAssignableFrom<IBiblioProvider>(sut);
        }

        [Fact]
        public void ThrowsOnNullPublicationNumber()
        {
            Assert.Throws<ArgumentNullException>(() => sut.GetData(null));
        }

        [Theory]
        [InlineData("EP2531303", "MULTI-STAGE DISCHARGER FOR GRINDING MILLS")]
        [InlineData("WO2014164896", "TWO-WHEEL ACTUATOR STEERING SYSTEM AND METHOD FOR POOL CLEANER")]
        public async Task CanGetInventionTitle(string publicationNumber, string expectedTitle)
        {
            var dataFromSut = await sut.GetData(publicationNumber);
            
            Assert.Equal(expectedTitle, dataFromSut.InventionTitle);
        }
    }
}
