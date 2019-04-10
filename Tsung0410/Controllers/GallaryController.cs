using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tsung0410.Models;

namespace Tsung0410.Controllers
{
    public class GallaryController : Controller
    {
        // GET: Gallary
        public ActionResult Index()
        {
            string[] Ptitle = new string[] { "第一張", "第二張", "第三張" };
            string[] Pfile = new string[] { "p01.jpg", "p02.jpg", "p03.jpg" };
            string relpath = "../Photos/";
            List<Photo> myPhoto = new List<Photo>();
            for (var i = 0; i < Ptitle.Length; i++)
            {
                Photo onePhoto = new Photo();
                onePhoto.Pid = i + 1;
                onePhoto.PhotoName = Ptitle[i];
                onePhoto.PhotoUrl = relpath + Pfile[i];
                myPhoto.Add(onePhoto);
            }
            return View(myPhoto);
        }
    }
}