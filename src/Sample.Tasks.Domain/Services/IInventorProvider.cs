using System.Collections.Generic;

namespace Sample.Tasks.Domain.Services
{
    public interface IInventorProvider
    {
        /// <summary>
        /// Return inventor names by publication number
        /// </summary>
        /// <param name="publicationNumber">publication number</param>
        /// <returns>Inventor names</returns>
        IEnumerable<string> GetInventorName(string publicationNumber);
    }
}