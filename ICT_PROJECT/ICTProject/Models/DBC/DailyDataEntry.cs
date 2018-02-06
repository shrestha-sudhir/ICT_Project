using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class DailyDataEntry
    {
        public IEnumerable<DailyData> dailyDatas { get; set; }
        public IEnumerable<SdcDetails> sdcDetails { get; set; }
        public IEnumerable<PDTopics> pdTopics { get; set; }
    }
}