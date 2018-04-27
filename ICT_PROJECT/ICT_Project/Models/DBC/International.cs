using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class International
    {
        
        public int InternationalID { get; set; }
        public string Continent { get; set; }
        public virtual ICollection<Zone> Zone { get; set; }
    }
}