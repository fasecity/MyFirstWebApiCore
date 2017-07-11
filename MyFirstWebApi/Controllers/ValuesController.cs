using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Jobs> Get()
        {
            return new Jobs[] { new Jobs {id=1, name ="cash money" },new Jobs {id=2, name ="great connections" } };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public Jobs Get(int id)
        {
            return new Jobs {id=id, name= "value" };
        }

        // POST api/values
        [HttpPost]
        //[Produces("application/json", Type = typeof(Jobs))] ---->json only filter
        [Produces(typeof(Jobs))]
        public IActionResult Post([FromBody]Jobs jobs)
        {
            return CreatedAtAction("Get", new { id = jobs.id}, jobs);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
    public class Jobs
    {
        public int id { get; set; }
        public string name { get; set; }
    

    }
}
