﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;
using System.Drawing;
using System.IO;

namespace UserInterface.Controllers
{
    public class UserController : Controller
    {
        UserBLL bll = new UserBLL();

        public ActionResult UserList()
        {
            List<UserDTO> model = new List<UserDTO>();
            model = bll.GetUsers();
            return View(model);
        }
        // GET: User
       public ActionResult AddUser()
        {
            UserDTO model = new UserDTO();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO model)
        {
            if(model.UserImage==null)
            {
                ViewBag.ProcessState = General.Messages.ImageMissing;
            }else if(ModelState.IsValid)
            {
                string filename = "";
                HttpPostedFileBase postedfile = model.UserImage;
                Bitmap userImage = new Bitmap(postedfile.InputStream);
                Bitmap resizeImage = new Bitmap(userImage, 128, 128);
                string ext = Path.GetExtension(postedfile.FileName);
                if(ext==".jpg"||ext==".jpeg"||ext==".png"||ext==".gif")
                {
                    string uniqueNumber = Guid.NewGuid().ToString();
                    filename = uniqueNumber + postedfile.FileName;
                    resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/UserImage/" + filename));
                    model.ImagePath = filename;
                    bll.AddUser(model);
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new UserDTO();
                }
                else
                {
                    ViewBag.ProcessState = General.Messages.ExtensionError;
                }

            }
            else
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;
            }
            return View(model);
        }
        
        public ActionResult UpdateUser(int ID)
        {
            UserDTO dto = new UserDTO();
            dto = bll.getUserWithID(ID);
            return View(dto);
        }
        [HttpPost]
        public ActionResult UpdateUser(UserDTO model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;
            }else
            {
                if (model.UserImage != null)
                {
                    string filename = "";
                    HttpPostedFileBase postedfile = model.UserImage;
                    Bitmap userImage = new Bitmap(postedfile.InputStream);
                    Bitmap resizeImage = new Bitmap(userImage, 128, 128);
                    string ext = Path.GetExtension(postedfile.FileName);
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
                    {
                        string uniqueNumber = Guid.NewGuid().ToString();
                        filename = uniqueNumber + postedfile.FileName;
                        resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/UserImage/" + filename));
                        model.ImagePath = filename;
                    }
                   

                }
                string oldImagePath = bll.UpdateUser(model);
                if(model.UserImage!=null)
                {
                    if(System.IO.File.Exists(Server.MapPath("~/Areas/Admin/Content/UserImage/" + oldImagePath)))
                    {
                        System.IO.File.Delete(Server.MapPath("~/Areas/Admin/Content/UserImage/" + oldImagePath));
                    }
                    ViewBag.ProcessState = General.Messages.UpdateSuccess;
                }
            }
            return View(model);
        }
    }
}