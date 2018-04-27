using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class DailyData
    {
        public int DailyDataID { get; set; }
        [DataType(DataType.Date) ]
        

        public DateTime Date { get; set; }
        public int WorkingSDC { get; set; }
        public int Appointments { get; set; }
        public int Presentations { get; set; }
        public String SuccessfulPresentations { get; set; }
        public int Attendance { get; set; }
        public int Members { get; set; }
        public int NinthKyus { get; set; }
        public int Classes { get; set; }
        public float EquipmentSales { get; set; }
        public String Interviews { get; set; }
        public String RegionalName { get; set; }
        public string SdcName { get; set; }
        public String ZoneName { get; set; }
        public SdcDetails SDC_Details { get; set; }
        public PDTopics Topics { get; set; }
        
    }
}