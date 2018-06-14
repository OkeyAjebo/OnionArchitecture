using System.Web.Mvc;

namespace MovieHub.Controllers
{
    public class MovieController : Controller
    {
        public MovieController()
        {

        }
        // GET: Movie
        public ActionResult Create()
        {
            return View();
        }
    }
}