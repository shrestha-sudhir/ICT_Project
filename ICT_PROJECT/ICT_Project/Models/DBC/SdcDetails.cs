using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class SdcDetails
    {
        public int SdcDetailsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string IsTeamCoordinator { get; set; }
        public Boolean IsFullTime { get; set; }
        public int SdcSequenceNum { get; set; }
        public string RegionName { get; set; }
        public string Fullname { get { return FirstName + " " + LastName; } }

        public virtual Region Region { get; set; }
    }
}