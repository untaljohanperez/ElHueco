using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElHueco.Controllers
{
    public class SoporteUploaderController : Controller
    {
        // GET: SoporteUploader
        public ActionResult Index()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase soporteCompra)
        {
            if(soporteCompra?.ContentLength > 0)
            {
                var ruta = Server.MapPath("/Uploads");
                var nombreArchivo = soporteCompra.FileName;
                var ramdomString = new Guid();
                nombreArchivo += ramdomString;
                nombreArchivo += Path.GetExtension(soporteCompra.FileName);
                 ruta = $"{ruta}/{nombreArchivo}";
                soporteCompra.SaveAs(ruta);

                return View();
            }
            return View();
        }

    }
}