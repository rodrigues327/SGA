using SGA.Application.Interfaces;
using StructureMap;
using System.Collections.Generic;
using System.Web.Http;

namespace SGA.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IContainer _iocContaine;

        public ValuesController(IContainer iocContaine)
        {
            _iocContaine = iocContaine;
            var test = iocContaine.GetInstance<IInstituicaoAppService>();
            var test2 = test.GetAll();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}