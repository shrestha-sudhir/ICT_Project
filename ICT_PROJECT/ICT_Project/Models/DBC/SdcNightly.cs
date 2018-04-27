using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class SdcNightly
    {
        [Key]
        public int SdcNightID { set; get; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0;dd-mm-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Date { set; get; }
        public virtual ICollection<DailyData> DailyData { set; get; }

    }
}