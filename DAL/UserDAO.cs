using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class UserDAO:PostContext
    {
        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            USER user = db.USERS.FirstOrDefault(x => x.UserName == model.Username && x.Password == model.Password);
            if(user!=null && user.ID!=0)
            {
                dto.ID = user.ID;
                dto.Username = user.UserName;
                dto.FirstName = user.FirstName;
                dto.LastName = user.LastName;
                dto.ImagePath = user.ImagePath;
                dto.isAdmin = user.isAdmin;
            }
            return dto;
        }

        public List<UserDTO> GetUsers()
        {
            List<USER> list = db.USERS.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            List<UserDTO> userlist = new List<UserDTO>();
            foreach (var item in list)
            {
                UserDTO dto = new UserDTO();
                dto.ID = item.ID;
                dto.FirstName = item.FirstName;
                dto.LastName = item.LastName;
                dto.Username = item.UserName;
                dto.ImagePath = item.ImagePath;
                userlist.Add(dto);

            }
            return userlist;
        }

        public UserDTO GetUserWithID(int ID)
        {
            USER user = db.USERS.First(x => x.ID == ID);
            UserDTO dto = new UserDTO();
            dto.ID = user.ID;
            dto.FirstName = user.FirstName;
            dto.LastName = user.LastName;
            dto.Username = user.UserName;
            dto.Password = user.Password;
            dto.isAdmin = user.isAdmin;
            dto.Email = user.Email;
            dto.ImagePath = user.ImagePath;
            return dto;
        }

        public string UpdateUser(UserDTO model)
        {
            try
            {
                USER user = db.USERS.First(x => x.ID == model.ID);
                string oldImagePath = user.ImagePath;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.Username;
                if(model.ImagePath!=null)
                {
                    user.ImagePath = model.ImagePath;
                }
                user.Email = model.Email;
                user.Password = model.Password;
                user.LastUpdateDate = DateTime.Now;
                user.LastUpdateUserID = UserStatic.UserID;
                user.isAdmin = model.isAdmin;
                db.SaveChanges();
                return oldImagePath;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int AddUser(USER user)
        {
            try
            {
                db.USERS.Add(user);
                db.SaveChanges();
                return user.ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
