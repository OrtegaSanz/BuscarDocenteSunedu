using System.Data.SqlClient;
using System.Web.Mvc;
using Docente.Models;

namespace Docente.Controllers
{
	public class DocenteController : Controller
	{
		// GET: Docente
		public ActionResult Docente()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Docente(DOCENTES_CONCYTEC docenteBuscado)
		{
			string dni;
			dni = Request["txtDNI"];
			SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=CONCYTEC;Integrated Security=True");
			conn.Open();

			SqlCommand command = new SqlCommand("Select Nombres,ApellidoPaterno from DOCENTES_CONCYTEC where DNI_Carnet=" + dni, conn);
			int result = command.ExecuteNonQuery();

			// result gives the -1 output.. but on insert its 1
			using (SqlDataReader reader = command.ExecuteReader())
			{
				docenteBuscado.Nombres = reader.GetString(0);
				docenteBuscado.ApellidoPaterno = reader.GetString(1);
			}

			conn.Close();
			//ViewData["Nombres"] = docenteBuscado.Nombres;
			//ViewData["ApellidoPaterno"] = docenteBuscado.ApellidoPaterno;
			return RedirectToAction(docenteBuscado);
		}
	}
}