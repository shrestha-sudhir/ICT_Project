using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class Notices
    {
        public int NoticesID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0;dd-mm-yyyy}")]
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public String RegionName { get; set; }
        public virtual Region Region { get; set; }
    }
}