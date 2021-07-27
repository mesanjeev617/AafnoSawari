using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class CarDTO
    {
        public int ID { get; set; }

        public List<CarImageDTO> carImages { get; set; }
        [Display(Name ="Car Image")]
        public List<HttpPostedFileBase> CarImage { get; set; }
        public List<TagDTO> Taglist { get; set;}

        public string TagText { get; set; }
        public int ViewCount { get; set; }

        [Required(ErrorMessage="Please Fill VIN")]
        public string VIN { get; set; }
        [Required(ErrorMessage = "Please Fill Make")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please Fill Model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please Fill Body")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Please Fill Year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please Fill Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please Fill number of Engine")]
        public int  Engine { get; set; }
        [Required(ErrorMessage = "Please Fill Engine Type")]
        public string EngineType { get; set; }
        [Required(ErrorMessage = "Please Fill Transmission Type")]
        public string Transmission { get; set; }
        [Required(ErrorMessage = "Please Fill Fuel type")]
        public string FuelType { get; set; }
        [Required(ErrorMessage = "Please Fill Fuel Capacity")]
        public decimal  FuelCapacity { get; set; }
        [Required(ErrorMessage = "Please Fill if it is autodriving")]
        public bool AutoDriving { get; set; }
        [Required(ErrorMessage = "Please Fill if it is auto steering")]
        public bool AutoSteering { get; set; }
        [Required(ErrorMessage = "Please Fill Maximum Seating")]
        public int MaxSeating { get; set; }
        [Required(ErrorMessage = "Please Fill DriveTrain")]
        public string DriveTrain { get; set; }
        [Required(ErrorMessage = "Please Fill Number of Doors")]
        public int Doors { get; set; }
        [Required(ErrorMessage = "Please Fill if it has FogLight")]
        public bool FogLight { get; set; }
        [Required(ErrorMessage = "Please Fill if it has SUnRoof")]
        public bool SunRoof { get; set; }
        [Required(ErrorMessage = "Please Fill Top Speed")]
        public decimal TopSpeed { get; set; }
        [Required(ErrorMessage = "Please Fill HorsePower")]
        public decimal HorsePower { get; set; }
        [Required(ErrorMessage = "Please Fill Torque")]
        public decimal Torque { get; set; }
        [Required(ErrorMessage = "Please Fill if it has bluetooth")]
        public bool Bluetooth { get; set; }
        [Required(ErrorMessage = "Please Fill if it has Cruise Control")]
        public bool Cruise { get; set; }
        [Required(ErrorMessage = "Please Fill the type of Keys")]
        public string Keys { get; set; }
        [Required(ErrorMessage = "Please Fill the start type")]
        public string StartType { get; set; }
        [Required(ErrorMessage = "Please Fill if it has TouchMonitor")]
        public bool TouchScreenMonitor { get; set; }
        [Required(ErrorMessage = "Please Fill if it has USB Port")]
        public bool USBPort { get; set; }
        [Required(ErrorMessage = "Please Fill type of Seats")]
        public string Seats { get; set; }
        [Required(ErrorMessage = "Please Fill if it has power drive seats")]
        public bool PowerDriveSeats { get; set; }
        [Required(ErrorMessage = "Please Fill the type of security the car has ")]
        public string Security { get; set; }
        [Required(ErrorMessage = "Please Fill if it has heated Seats")]
        public bool HeatedSeat { get; set; }
        [Required(ErrorMessage = "Please Fill if it has Turbo")]
        public bool Turbo { get; set; }
        [Required(ErrorMessage = "Please Fill the Crash Rating ")]
        public int CrashRating { get; set; }
        [Required(ErrorMessage = "Please Fill if it has Colllision Detection")]
        public bool CollisionDetection { get; set; }
        [Required(ErrorMessage = "Please Fill Color")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Please Fill type of Brakes")]
        public string Brakes { get; set; }
        [Required(ErrorMessage = "Please Fill the Length")]
        public decimal Length { get; set; }
        [Required(ErrorMessage = "Please Fill Width")]
        public decimal Width { get; set; }
        [Required(ErrorMessage = "Please Fill Height")]
        public decimal Height { get; set; }
        [Required(ErrorMessage = "Please Fill Cargo Capacity")]
        public decimal CargoCapacity { get; set; }
        [Required(ErrorMessage = "Please Fill Width")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "Please Fill Mileage")]
        public decimal Mileage { get; set; }
        [Required(ErrorMessage = "Please Fill Engine Warranty")]
        public string EngineWarranty { get; set; }
        [Required(ErrorMessage = "Please Fill Transmission Warranty")]
        public string TransmissionWarranty { get; set; }
        [Required(ErrorMessage = "Please Fill Suspension")]
        public string Suspension { get; set; }
        [Required(ErrorMessage = "Please Fill Number of AirBags")]
        public int AirBags { get; set; }
        [Required(ErrorMessage = "Please Fill if it has Backup Camera")]
        public bool BackupCamera { get; set; }
        [Required(ErrorMessage = "Please Fill if it can detect Lanes")]
        public bool LaneDetection { get; set; }
        [Required(ErrorMessage = "Please Fill Towing Capacity")]
        public string TowingCapacity { get; set; }
        [Required(ErrorMessage = "Please Fill if the car is Imported")]
        public bool Import { get; set; }
        [Required(ErrorMessage = "Please Fill Country Of Origin")]
        public string CountryOfOrigin { get; set; }
        [Required(ErrorMessage = "Please Fill Tires")]
        public string Tires { get; set; }
        [Required(ErrorMessage = "Please Fill RIms")]
        public string Rims { get; set; }
        [Required(ErrorMessage = "Please Fill Extra Features")]
        public string ExtraFeatures { get; set; }
       
        public string SeoLink { get; set; }
        public bool Slider { get; set; }
        public bool Area1 { get; set; }
        public bool Area2 { get; set; }
        public bool Area3 { get; set; }
        public bool Notification { get; set; }

    }
}
