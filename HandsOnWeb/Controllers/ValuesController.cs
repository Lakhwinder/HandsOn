using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace HandsOnWeb.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [Route("api/My/{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/My/{name:alpha}")]
        public string Get(string name)
        {
            return name;
        }
        [HttpPost]
        [Route("gstr4")]
        public HttpResponseMessage SubmitGSTR4([FromBody] RequestPayloadWithoutSign requestPayload)
        {
            return null;
        }

        [HttpPost]
        [Route("gstr4")]
        public HttpResponseMessage FileGSTR4([FromBody] RequestPayloadWithSign requestPayload)
        {
            return null;
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
