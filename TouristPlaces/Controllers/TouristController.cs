using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TouristPlaces.Dal;
using TouristPlaces.Models;

namespace TouristPlaces.Controllers
{
    public class TouristController : Controller
    {
        TouristPlaceContext context = null;
        public TouristController()
        {
            context=new TouristPlaceContext();
        }
        public ActionResult UploadTouristPlace()
        {
            return View();
        }
        public ActionResult SaveTouristPlace(TouristPlace tp)
        {
            tp.Files=Request.Files;
            HttpPostedFileBase file = tp.Files[0];
            string filepath="~/Images/TouristPlaces/"+file.FileName;
            tp.ImagePath=filepath;
            file.SaveAs(Server.MapPath(filepath));
            context.touristPlaces.Add(tp);
            context.SaveChanges();
            List<TouristPlace>tplist=context.touristPlaces.ToList();
            return View("DisplayTouristPlaces",tplist);
        }
       
        public ActionResult Index()
        { 
            return View();  
        }
    }
}