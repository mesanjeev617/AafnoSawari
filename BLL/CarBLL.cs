using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarBLL
    {
        CarDAO dao = new CarDAO();

        public bool AddCar(CarDTO model)
        {
            CAR cars = new CAR();

            cars.VIN = model.VIN;
            cars.Make = model.Make;
            cars.Model = model.Model;
            cars.Body = model.Body;
            cars.Year = model.Year;
            cars.Price = model.Price;
            cars.Engine = model.Engine;
            cars.EngineType = model.EngineType;
            cars.Transmission = model.Transmission;
            cars.FuelType = model.FuelType;
            cars.FuelCapacity = model.FuelCapacity;
            cars.AutoDriving = model.AutoDriving;
            cars.AutoSteering = model.AutoSteering;
            cars.MaxSeating = model.MaxSeating;
            cars.DriveTrain = model.DriveTrain;
            cars.Doors = model.Doors;
            cars.FogLight = model.FogLight;
            cars.SunRoof = model.SunRoof;
            cars.TopSpeed = model.TopSpeed;
            cars.HorsePower = model.HorsePower;
            cars.Torque = model.Torque;
            cars.Bluetooth = model.Bluetooth;
            cars.Cruise = model.Cruise;
            cars.Keys = model.Keys;

            cars.StartType = model.StartType;
            cars.TouchScreenMonitor = model.TouchScreenMonitor;
            cars.USBPort = model.USBPort;
            cars.Seats = model.Seats;
            cars.PowerDriveSeats = model.PowerDriveSeats;
            cars.Security = model.Security;
            cars.HeatedSeat = model.HeatedSeat;
            cars.Turbo = model.Turbo;
            cars.CrashTestRating = model.CrashRating;
            cars.ColiisionDetection = model.CollisionDetection;
            cars.Color = model.Color;
            cars.Brakes = model.Brakes;
            cars.length = model.Length;
            cars.width = model.Width;
            cars.height = model.Height;
            cars.CargoCapacity = model.CargoCapacity;
            cars.Weigth = model.Weight;
            cars.Mileage = model.Mileage;
            cars.EngineWarranty = model.EngineWarranty;
            cars.TransmissionWarranty = model.TransmissionWarranty;
            cars.Suspension = model.Suspension;
            cars.AirBags = model.AirBags;
            cars.BackupCamera = model.BackupCamera;
            cars.LaneDetection = model.LaneDetection;

            cars.TowingCapacity = model.TowingCapacity;
            cars.Import = model.Import;
            cars.CountryOfOrigin = model.CountryOfOrigin;
            cars.Tires = model.Tires;
            cars.Rims = model.Rims;
            //Using Extra features for Tag
          // cars.ExtraFeatures = model.ExtraFeatures;
            cars.Slider = model.Slider;
            cars.Area1 = model.Area1;
            cars.Area2 = model.Area2;
            cars.Area3 = model.Area3;

            cars.SeoLink = SeoLink.GenerateUrl(model.Make);

            cars.AddDate = DateTime.Now;
            cars.AddUserID = UserStatic.UserID;
            cars.LastUpdateUserID = UserStatic.UserID;
            cars.LastUpdateDate = DateTime.Now;


            int ID = dao.AddCar(cars);
            LogDAO.AddLog(General.ProcessType.CarAdd, General.TableName.Car, ID);
            SaveCarImage(model.carImages, ID);

            AddTag(model.ExtraFeatures, ID);
            return true;
            






        }

        private void AddTag(string extraFeatures, int iD)
        {
            string[] tags;
            tags = extraFeatures.Split(',');
            List<CARTAG> taglist = new List<CARTAG>();
            foreach (var item in tags)
            {
                CARTAG tag = new CARTAG();
                tag.CarID = iD;
                tag.TagContent = item;
                tag.AddDate = DateTime.Now;
                tag.LastUpdateDate = DateTime.Now;
                tag.LastUpdateUserID = UserStatic.UserID;
                taglist.Add(tag);
            }

            foreach (var item in taglist)
            {
                int tagID = dao.AddTag(item);
                LogDAO.AddLog(General.ProcessType.TagAdd, General.TableName.Tag, tagID);
            }
        }

        void SaveCarImage(List<CarImageDTO> list, int CarID)
        {
            List<CARIMAGE> imagelist = new List<CARIMAGE>();
            foreach (var item in list)
            {
                CARIMAGE image = new CARIMAGE();
                image.CarID = CarID;
                image.ImagePath = item.ImagePath;
                image.AddDate = DateTime.Now;
                image.LastUpdateDate = DateTime.Now;
                image.LastUpdateUserID = UserStatic.UserID;
                imagelist.Add(image);

            }

            foreach (var item in imagelist)
            {
                int imageID = dao.AddImage(item);
                LogDAO.AddLog(General.ProcessType.ImageAdd, General.TableName.Image, imageID);
            }
        }
    }
}
