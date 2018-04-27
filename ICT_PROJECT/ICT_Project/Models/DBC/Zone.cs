using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class Zone
    {
        public int ZoneID { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDirector { get; set; }
        public string ZoneGoal { get; set; }
        public int InternationalID { get; set; }

        public virtual ICollection<Region> Region { get; set; }
        public virtual International International { get; set; }
        
    }
}