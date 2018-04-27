using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICT_Project.Models.DBC;

namespace ICT_Project.Models
{
    public class DataEntryViewModels
    {
        public SdcDetails SDC_Details { get; set; }
        public DailyData    DailyData { get; set; }
        public PDTopics Topics { get; set; }

    }
}