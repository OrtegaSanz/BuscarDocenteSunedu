using Docente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Docente.Controllers
{
    public class DocenteConcytecController : Controller
    {
        private CONCYTECEntities db = new CONCYTECEntities();
        string dni = "";
        //public string connectionString = @"Data Source=192.168.1.200\SQLSERVER;Initial Catalog=CONCYTEC;Persist Security Info=True;User ID=Chucktesta;Password=12345";
        // GET: DocenteConcytec
        public ActionResult BuscarDocente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuscarDocente(DOCENTES_CONCYTEC Docentes)
        {
            dni = Request["txtDNI"];
            foreach (DOCENTES_CONCYTEC e in db.DOCENTES_CONCYTEC.ToList())
            {
                if (e.DNI_Carnet == dni)
                {
                    Docentes.Nombres = e.Nombres;
                    Docentes.ApellidoPaterno = e.ApellidoPaterno;
                }
            }
            ViewData["Nombre"] = Docentes.Nombres;
            ViewData["ApePaterno"] = Docentes.ApellidoPaterno;
            //return RedirectToAction("Resultado");
            return View();
        }

        /*public ActionResult Resultado(DOCENTES_CONCYTEC Docentes)
        {
            string nombre ="", apePaterno = "";
            foreach (DOCENTES_CONCYTEC e in db.DOCENTES_CONCYTEC.ToList())
            {
                if (e.DNI_Carnet == dni)
                {
                    nombre = e.Nombres;
                    apePaterno = e.ApellidoPaterno;
                }
            }
            ViewData["Nombres"] = dni;//Docentes.Nombres;
            //ViewData["ApellidoPaterno"] = apePaterno ;//Docentes.ApellidoPaterno;
            return View();
        }*/
    }
}