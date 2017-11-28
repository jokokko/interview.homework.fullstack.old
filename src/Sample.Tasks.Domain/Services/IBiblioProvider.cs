using System.Threading.Tasks;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Services
{
    /// <summary>
    /// Provide bibliographic patent data from EPO
    /// </summary>
    public interface IBiblioProvider
    {
        /// <summary>
        /// Get bibliographic data for patent by publication number
        /// </summary>
        /// <param name="publicationNumber">publication number</param>        
        /// <returns>Bibliographic data for the publication</returns>
        Task<BiblioData> GetData(string publicationNumber);
    }
}