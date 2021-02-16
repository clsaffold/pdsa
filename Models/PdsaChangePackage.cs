using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsatracker.Models
{
    public class PdsaChangePackage
    {
        public int PdsaID { get; set; }
        public Pdsa Pdsa { get; set; }

        public int AimID { get; set; }
        public Aims Aims { get; set; }

        public int DriverID { get; set; }
        public Drivers Drivers { get; set; }

        public int TacticID { get; set; }
        public Tactics Tactics { get; set; }

        public int SecondaryDriverID { get; set; }
        public SecondaryDrivers SecondaryDrivers { get; set; }
    }
}
