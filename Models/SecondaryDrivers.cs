using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsatracker.Models
{
    public class SecondaryDrivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SecondaryDrivers()
        {
        }
        public SecondaryDrivers(string name)
        {
            Name = name;
            Description = Description;
        }

    }
}
