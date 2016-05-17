using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "Reg Nr is required")]
        [Display(Name = "Reg Nr")]
        public string RegNr { get; set; }
        public ConsoleColor Color { get; set; }
        [Required(ErrorMessage = "Number of wheels is required")]
        [Display(Name = "Number of wheels")]
        public int NrWheels { get; set; }
        [Required(ErrorMessage = "Vehicle Type is required")]
        [Display(Name = "Vehicle Type")]
        public VehicleType vehicleType { get; set; }
        [Display(Name = "Parking Time")]
        [ScaffoldColumn(false)]
        public DateTime ParkingTime { get; set; } = DateTime.Now;

    }
    public enum VehicleType { Car, MC, Bike, Plane, Bus };
}