namespace ICT_Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ICT_Project.Datas.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ICT_Project.Datas.DataContext context)
        {
            /**
            context.SdcDetails.AddOrUpdate(new Models.DBC.SdcDetails
            {
                DateAdded = DateTime.Now,
                FirstName = "name1",
                LastName = "Last1",
                IsFullTime = false,
                IsTeamCoordinator = "Yes",
                RegionName = "R1",
                SdcSequenceNum = 1
            });
    */

          //  context.Region.AddOrUpdate(new Models.DBC.Region { RegionManager = "M1", RegionName = "R1", });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
