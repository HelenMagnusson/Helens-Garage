namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Garage2;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2.DataAccessLayer.VehicleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2.DataAccessLayer.VehicleContext context)
        {
            context.Vehicles.AddOrUpdate(
              v => v.RegNr,
              new Vehicle { Name = "Helens bil", RegNr = "ABC123", Color = ConsoleColor.Red, NrWheels = 4, vehicleType = VehicleType.Car, ParkingTime = DateTime.Now },
              new Vehicle { Name = "Helens MC", RegNr = "SDF234", Color = ConsoleColor.Black, NrWheels = 4, vehicleType = VehicleType.MC, ParkingTime = DateTime.Now },
              new Vehicle { Name = "Helens Cykel", RegNr = "DFG345", Color = ConsoleColor.Blue, NrWheels = 4, vehicleType = VehicleType.Bike, ParkingTime = DateTime.Now }
            );

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
