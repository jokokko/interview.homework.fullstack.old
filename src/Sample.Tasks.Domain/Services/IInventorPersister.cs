using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Tasks.Domain.Services
{
    public interface IInventorPersister
    {
        /// <summary>
        /// Persist inventors for a given publication number
        /// </summary>
        /// <param name="publicationNumber">publication number</param>
        /// <param name="inventors">inventor names for the publication</param>        
        Task Persist(string publicationNumber, IEnumerable<string> inventors);
    }
}