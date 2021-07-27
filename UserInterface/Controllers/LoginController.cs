using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UserInterface.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userbll = new UserBLL();
        // GET: Login
        public ActionResult Index()
        {
            UserDTO dto = new UserDTO();
            return View(dto);

        }
        [HttpPost]
        public ActionResult Index(UserDTO model)
        {
            if(ModelState.IsValid)
            {
                UserDTO user = userbll.GetUserWithUsernameAndPassword(model);
                if(user.ID !=0)
                {
                    UserStatic.UserID = user.ID;
                    UserStatic.isAdmin = user.isAdmin;
                    UserStatic.FirstName = user.FirstName;
                    UserStatic.Lastname = user.LastName;
                    UserStatic.ImagePath = user.ImagePath;
                    LogBLL.AddLog(General.ProcessType.Login, General.TableName.login, 12);
                    return RedirectToAction("Index", "Car");
                }else
                return View(model);

            }
            else          
            return View(model);
        }
    }
}