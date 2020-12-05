using System.Web.Mvc;
using Model;

namespace ASIGNACIÓN_4_HERRAMIENTAS_DE_DISEÑO.Controllers
{
    public class CurriculumController : Controller
    {
        public Contactos MiContacto = new Contactos();

        public ActionResult Index(int Contactos_id = 11)
        {
            return View(MiContacto.MostrarMiContacto(Contactos_id));
        }

    }
}