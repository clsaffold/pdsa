using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsatracker.Models
{
    public class Drivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Drivers()
        {
        }
        public Drivers(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
