using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class PDTopics
    {
        public int PDTopicsID { get; set; }
        public String Comment { get; set; }
        public String RegionName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0;dd-mm-yyyy}")]
        public DateTime Date { get; set; }
        public virtual Region Region { get; set; }
    }
}