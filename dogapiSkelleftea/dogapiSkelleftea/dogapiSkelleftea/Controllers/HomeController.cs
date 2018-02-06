using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dogapiSkelleftea.Models;
using System.IO;
using Newtonsoft.Json;

namespace dogapiSkelleftea.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {


        [HttpGet]
        public IEnumerable<string> Get()
        {
            var files = Directory.GetFiles("DogFiles/", "*.json");
            List<Dog> dogs = new List<Dog>();

            foreach (var file in files)
            {
                string text = System.IO.File.ReadAllText(file);
                var dog = JsonConvert.DeserializeObject<Dog>(text);
                dogs.Add(dog);
            }

            return dogs.Select(a => a.BreedName).ToArray();


        }
    }
}