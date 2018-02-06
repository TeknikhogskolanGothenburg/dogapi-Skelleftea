using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dogapiSkelleftea.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        

       List<Models.Dog> dogs = new List<Models.Dog>();


         
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return dogs.Select(d => d.BreedName).ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return dogs.Where(x => x.BreedName == id).Select(dog => JsonConvert.SerializeObject(dog)).FirstOrDefault();
        }




        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
          
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
}
