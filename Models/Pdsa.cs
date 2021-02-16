using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsatracker.Models
{
    public class Pdsa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Shared { get; set; }
        public string Gap { get; set; }
        public string Plan { get; set; }
        public string Doing { get; set; }
        public string Study { get; set; }

        public Pdsa()
        {

        }

        public Pdsa(string name, string gap, string plan, string doing, string study) 
            {
                Name = name;
                Gap = gap;
                Plan = plan;
                Doing = doing;
                Study = study;
            }
    }
};
