using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class Region
    {
        [Key]
        public int RegionalID { set; get; }
        public string RegionName { get; set; }
   
        public string RegionManager { get; set; }

        public string ZoneName { get; set; }
        public virtual ICollection< SdcDetails> SdcDetails { get; set; }
        public virtual Zone Zone { get; set; }
    }
}