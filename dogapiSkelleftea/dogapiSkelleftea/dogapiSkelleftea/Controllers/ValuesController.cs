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
            ////https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Collections.Generic.IEnumerable%601);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.1
            return dogs.Select(d => d.BreedName).ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return dogs.Where(x => x.BreedName == id).Select(dog => JsonConvert.SerializeObject(dog)).FirstOrDefault();
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Linq.Enumerable.FirstOrDefault%60%601);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.1
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
