using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uploadimage.Models;
namespace Uploadimage.Controllers
{
    public class ImageController : Controller
    {

        // GET: Image
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Image imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            imageModel.ImageFile.SaveAs(fileName);
            using (sampleEntities s = new sampleEntities())
            {
                s.Images.Add(imageModel);
                s.SaveChanges();
            }
            ModelState.Clear();
            return View();
           
        }

        public ActionResult List()
        {
            sampleEntities s = new sampleEntities();
            List<Image> im = s.Images.ToList();
            return View(im);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Image imageModel = new Image();

            using (sampleEntities db = new sampleEntities())
            {
                imageModel = db.Images.Where(x => x.ImageID == id).FirstOrDefault();
            }

            return View(imageModel);
        }
    }
}