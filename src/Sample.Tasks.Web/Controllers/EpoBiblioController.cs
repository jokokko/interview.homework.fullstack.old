using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Web.Controllers
{
    public sealed class EpoBiblioController : ApiController
    {
        private readonly IBiblioProvider biblioProvider;

        public EpoBiblioController(IBiblioProvider biblioProvider)
        {
            this.biblioProvider = biblioProvider;
        }

        public async Task<HttpResponseMessage> Get(string id)
        {
            try
            {
                var biblioData = await biblioProvider.GetData(id);
                return Request.CreateResponse(HttpStatusCode.OK, biblioData);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
