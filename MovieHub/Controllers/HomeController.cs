using Services;
using System.Web.Mvc;

namespace MovieHub.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MovieService _movieService;


        public HomeController()
        {
            _movieService = new MovieService();
        }

        public ActionResult Index()
        {
            var movie = _movieService.GetMovies();

            return View(movie);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}