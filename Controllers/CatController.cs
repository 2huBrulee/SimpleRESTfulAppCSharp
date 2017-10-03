using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRESTfulApp.Controllers
{
    [Route("api/cat")]
    public class CatController : Controller
    {
        // GET: api/cat
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "negricio", "gringo" };
        }

        // GET api/cat/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "chobi";
        }

        // POST api/cat
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cat/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cat/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
