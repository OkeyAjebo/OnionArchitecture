using Domain.Entities;
using MovieHub.ViewModels;
using Services;
using System.Linq;
using System.Web.Mvc;

namespace MovieHub.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService<Movie> _movieService;
        private readonly MovieService<Genre> _genreService;


        public MovieController()
        {
            _movieService = new MovieService<Movie>();
            _genreService = new MovieService<Genre>();
        }

        // GET: Movie
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = _genreService.GetAll().ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _genreService.GetAll().ToList();
                return View("Create", viewModel);
            }


            var movie = new Movie
            {
                Name = viewModel.Name,
                Director = viewModel.Director,
                GenreId = viewModel.Genre,
                Description = viewModel.Description,
                ReleaseDate = viewModel.GetDateTime()

            };

            _movieService.Add(movie);
            _movieService.Save();

            return RedirectToAction("Index", "Home");
        }
    }
}