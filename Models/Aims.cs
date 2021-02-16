using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsatracker.Models
{
    public class Aims
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Aims()
        {
        }
        public Aims(string name)
        {
            Name = name;
        }
    }
}
