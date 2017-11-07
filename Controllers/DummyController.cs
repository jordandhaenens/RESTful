using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTful.Controllers
{
    [Route("/[controller]")]
    public class DummyController : Controller
    {
        // GET /dummy
        [HttpGet]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /dummy/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST /dummy
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT /dummy/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE /dummy/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
