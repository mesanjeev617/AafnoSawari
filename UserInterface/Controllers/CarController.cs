using BLL;
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
    public class CarController : Controller
    {
        CarBLL bll = new CarBLL();
        // GET: Car
       public ActionResult Index()
        {
            return View();
        }
       

        public ActionResult AddCar()
        {
            CarDTO model = new CarDTO();
            return View(model);
        }
        
        
    }
}