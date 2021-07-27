﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class AdvertisementController : Controller
    {
        AdsBLL bll = new AdsBLL();
        // GET: Advertisement

        public ActionResult AdsList()
        {
            List<AdsDTO> Adslist = new List<AdsDTO>();
            Adslist = bll.GetAds();
            return View(Adslist);
        }
        public ActionResult AddAds()
        {
            AdsDTO dto = new AdsDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult AddAds(AdsDTO model)
        {
            if(model.AdsImage==null)
            {
                ViewBag.ProcessState = General.Messages.ImageMissing;

            }else if(ModelState.IsValid)
            {
                string filename = "";
                HttpPostedFileBase postedfile = model.AdsImage;
                Bitmap userImage = new Bitmap(postedfile.InputStream);
                Bitmap resizeImage = new Bitmap(userImage, 128, 128);
                string ext = Path.GetExtension(postedfile.FileName);
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
                {
                    string uniqueNumber = Guid.NewGuid().ToString();
                    filename = uniqueNumber + postedfile.FileName;
                    resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/AdsImage/" + filename));
                    model.ImagePath = filename;
                    bll.AddAds(model);
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new AdsDTO();
                    
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

        public ActionResult UpdateAds(int ID)
        {
            AdsDTO dto = bll.GetAdsWithID(ID);
            return View(dto);
        }
        [HttpPost]
        public ActionResult UpdateAds(AdsDTO model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;
            }
            else
            {
                if (model.AdsImage != null)
                {
                    string filename = "";
                    HttpPostedFileBase postedfile = model.AdsImage;
                    Bitmap userImage = new Bitmap(postedfile.InputStream);
                    Bitmap resizeImage = new Bitmap(userImage, 128, 128);
                    string ext = Path.GetExtension(postedfile.FileName);
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
                    {
                        string uniqueNumber = Guid.NewGuid().ToString();
                        filename = uniqueNumber + postedfile.FileName;
                        resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/AdsImage/" + filename));
                        model.ImagePath = filename;
                    }
                }
                string oldImagePath = bll.UpdateAds(model);
                if(model.AdsImage!=null)
                {
                    if(System.IO.File.Exists(Server.MapPath("~/Areas/Admin/Content/AdsImage/" + oldImagePath)))
                    {
                        System.IO.File.Delete(Server.MapPath("~/Areas/Admin/Content/AdsImage/" + oldImagePath));
                    }
                }
                ViewBag.ProcessState = General.Messages.UpdateSuccess;
            }
            return View(model);
        }
    }
}