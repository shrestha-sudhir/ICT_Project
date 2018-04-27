using System;
using ICT_Project.Models.DBC;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICT_Project.Datas
{
    public class DataContext: DbContext
    {
        public DataContext(): base("ICT_Project")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<DailyData> Dailydata { get; set; }
        public DbSet<SdcDetails> SdcDetails { get; set; }
        public DbSet<SdcNightly> SdcNightly { get; set; }
        public DbSet<Notices> Notices { get; set; }
        public DbSet<International> International { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<PDTopics> PDTopics { get; set; }
    }
    
}