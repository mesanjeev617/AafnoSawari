using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdsDAO : PostContext
    {
        public int AddAds(ADVERTISEMENT ads)
        {
            try
            {
                db.ADVERTISEMENTs.Add(ads);
                db.SaveChanges();
                return ads.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AdsDTO> GetAds()
        {
            List<ADVERTISEMENT> list = db.ADVERTISEMENTs.Where(x => x.isDeleted == false).OrderBy(x=>x.AddDate).ToList();
            List<AdsDTO> dtolist = new List<AdsDTO>();
            foreach (var item in list)
            {
                AdsDTO dto = new AdsDTO();
                dto.ID = item.ID;
                dto.Name = item.Name;
                dto.Link = item.Link;
                dto.ImagePath = item.ImagePath;
                dtolist.Add(dto);

            }
            return dtolist;
        }

        public string UpdateAds(AdsDTO model)
        {
            try
            {
                ADVERTISEMENT ads = db.ADVERTISEMENTs.First(x => x.ID == model.ID);
                string oldimagepath = ads.ImagePath;
                ads.Name = model.Name;
                ads.Link = model.Link;
                if (model.ImagePath != null)
                {
                    ads.ImagePath = model.ImagePath;
                }
                    ads.Size = model.ImageSize;
                    ads.LastUpdateDate = DateTime.Now;
                    ads.LastUpdateUserID = UserStatic.UserID;
                    db.SaveChanges();
                    return oldimagepath;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public AdsDTO GetAdsWithID(int ID)
        {
            ADVERTISEMENT ads = db.ADVERTISEMENTs.First(x => x.ID == ID);
            AdsDTO dto = new AdsDTO();
            dto.ID = ads.ID;
            dto.Name = ads.Name;
            dto.Link = ads.Link;
            dto.ImagePath = ads.ImagePath;
            dto.ImageSize = ads.Size;
            return dto;
        }
    }
}
