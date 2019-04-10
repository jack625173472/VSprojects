using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Tsung0410.Controllers
{
    public class PhotoController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            string fileName = "";
            if (photo != null)
            {
                if (photo.ContentLength > 0)
                {
                    fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);
                    photo.SaveAs(path);

                    ViewBag.url = path;
                }
            }
            return View();
        }
    }
}