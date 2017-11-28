using System;
using System.Threading.Tasks;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Services
{
    public sealed class EpoBiblioProvider : IBiblioProvider
    {
        public Task<BiblioData> GetData(string publicationNumber)
        {
            throw new NotImplementedException();
        }
    }
}
