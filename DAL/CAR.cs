//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAR
    {
        public CAR()
        {
            this.CARIMAGES = new HashSet<CARIMAGE>();
            this.CARTAGs = new HashSet<CARTAG>();
            this.REVIEWS = new HashSet<REVIEW>();
        }
    
        public int ID { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Engine { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public decimal FuelCapacity { get; set; }
        public bool AutoDriving { get; set; }
        public bool AutoSteering { get; set; }
        public int MaxSeating { get; set; }
        public string DriveTrain { get; set; }
        public int Doors { get; set; }
        public bool FogLight { get; set; }
        public bool SunRoof { get; set; }
        public decimal TopSpeed { get; set; }
        public decimal HorsePower { get; set; }
        public decimal Torque { get; set; }
        public bool Bluetooth { get; set; }
        public bool Cruise { get; set; }
        public string Keys { get; set; }
        public string StartType { get; set; }
        public bool TouchScreenMonitor { get; set; }
        public bool USBPort { get; set; }
        public string Seats { get; set; }
        public bool PowerDriveSeats { get; set; }
        public string Security { get; set; }
        public bool HeatedSeat { get; set; }
        public bool Turbo { get; set; }
        public int CrashTestRating { get; set; }
        public bool ColiisionDetection { get; set; }
        public string Color { get; set; }
        public string Brakes { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public decimal CargoCapacity { get; set; }
        public decimal Weigth { get; set; }
        public decimal Mileage { get; set; }
        public string EngineWarranty { get; set; }
        public string TransmissionWarranty { get; set; }
        public string Suspension { get; set; }
        public int AirBags { get; set; }
        public bool BackupCamera { get; set; }
        public bool LaneDetection { get; set; }
        public string TowingCapacity { get; set; }
        public bool Import { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Tires { get; set; }
        public string Rims { get; set; }
        public string ExtraFeatures { get; set; }
        public string SeoLink { get; set; }
        public System.DateTime AddDate { get; set; }
        public int AddUserID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int LastUpdateUserID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public bool Slider { get; set; }
        public bool Area1 { get; set; }
        public bool Area2 { get; set; }
        public bool Area3 { get; set; }
    
        public virtual ICollection<CARIMAGE> CARIMAGES { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
        public virtual ICollection<CARTAG> CARTAGs { get; set; }
        public virtual ICollection<REVIEW> REVIEWS { get; set; }
    }
}
