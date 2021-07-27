using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarDAO : PostContext
    {
        public int AddCar(CAR cars)
        {
            try
            {
                db.CARS.Add(cars);
                db.SaveChanges();
                return cars.ID;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AddImage(CARIMAGE item)
        {
            try
            {
                db.CARIMAGES.Add(item);
                db.SaveChanges();
                return item.ID;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AddTag(CARTAG item)
        {
            db.CARTAGs.Add(item);
            db.SaveChanges();
            return item.ID;

        }
    }
}
