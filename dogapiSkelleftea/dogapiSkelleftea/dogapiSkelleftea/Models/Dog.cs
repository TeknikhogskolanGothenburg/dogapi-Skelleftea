using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dogapiSkelleftea.Models
{
    public class Dog
    {

        public string BreedName { get; set; }
        public string WikipediaUrl { get; set; }
        public string Description { get; set; }

        //internal object Select(Func<object, object> p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
