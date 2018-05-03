using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICT_Project.Models.DBC;
	

	

namespace ICT_Project.Models
{
    public class RecordViewModels
    {
        public virtual SdcDetails SDC_Details { get; set; }
        public virtual Region Region { get; set; }
    }
}