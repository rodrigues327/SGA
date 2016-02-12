using StructureMap;
using System.Collections.Generic;
using System.Web.Http;

namespace SGA.WebApi.Controllers
{
    public class InstituicaoController : ApiController
    {
        private readonly IContainer _iocContainer;

        public InstituicaoController(IContainer iocContainer)
        {
            _iocContainer = iocContainer;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            //   var instituicaoAppService = _iocContainer.GetInstance<IInstituicaoAppService>();

            //    var test = instituicaoAppService.GetAll();

            return new string[] { "value1", "value2" };
        }
    }
}