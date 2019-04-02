using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public City(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
