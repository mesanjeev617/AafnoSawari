using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdressDAO : PostContext
    {
        public int AddAddress(ADDRESS ads)
        {
            try
            {
                db.ADDRESSes.Add(ads);
                db.SaveChanges();
                return ads.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AddressDTO> GetAddresses()
        {
            List<ADDRESS> list = db.ADDRESSes.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            List<AddressDTO> dtolist = new List<AddressDTO>();
            foreach (var item in list)
            {
                AddressDTO dto = new AddressDTO();
                dto.ID = item.ID;
                dto.AddressContent = item.Address1;
                dto.Email = item.Email;
                dto.Fax = item.Fax;
                dto.LargeMapPath = item.MapPathLarge;
                dto.SmallMapPath = item.MapPathSmall;
                dto.Phone = item.Phone;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public void UpdateAddress(AddressDTO model)
        {
            try
            {
                ADDRESS ads = db.ADDRESSes.First(x => x.ID == model.ID);
                ads.Address1 = model.AddressContent;
                ads.Email = model.Email;
                ads.Fax = model.Fax;
                ads.MapPathLarge = model.LargeMapPath;
                ads.MapPathSmall = model.SmallMapPath;
                ads.Phone = model.Phone;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
