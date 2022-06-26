using SimulacroClientWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimulacroClientWeb.Controllers
{
    public class ExamenController : Controller
    {
        // GET: Examen
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ExamenIns(string titulo, string descripcion, int duracion, DateTime fechapub, )
        {
            string result = "";

            if (frase != null && frase.Trim().Length > 0)
            {
                frases f = new frases();
                f.idautor = idautor;
                f.frase = frase;
                daoFrases.frasesIns(f);
            }
            else
            {
                result = "Ingrese texto de Frase";
            }
            return Json(new { msg = result, JsonRequestBehavior.AllowGet });
        }
    }
}