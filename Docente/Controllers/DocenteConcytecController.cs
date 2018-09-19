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
        //public string connectionString = @"Data Source=192.168.1.200\SQLSERVER;Initial Catalog=CONCYTEC;Persist Security Info=True;User ID=Chucktesta;Password=12345";
        // GET: DocenteConcytec
        public ActionResult BuscarDocente()
        {
            return View();
        }
        private string dni { get; set; }
        [HttpPost]
        public ActionResult BuscarDocente(DOCENTES_CONCYTEC Docentes)
        {
            dni = Request["txtDNI"];
            return RedirectToAction("Resultado");
        }

        public ActionResult Resultado(DOCENTES_CONCYTEC Docentes)
        {
            foreach (DOCENTES_CONCYTEC e in db.DOCENTES_CONCYTEC.ToList())
            {
                if (e.DNI_Carnet == dni)
                {
                    Docentes.Nombres = e.Nombres;
                    Docentes.ApellidoPaterno = e.ApellidoPaterno;
                }
            }
            ViewData["Nombres"] = Docentes.Nombres;
            ViewData["ApellidoPaterno"] = Docentes.ApellidoPaterno;
            return View();
        }
    }
}