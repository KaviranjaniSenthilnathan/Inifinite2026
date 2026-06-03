using System.Web.Mvc;

using MoviesMVC.Models;
using MoviesMVC.Repository;
namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieRepository repo = new MovieRepository();

        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            repo.Add(movie);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movies movie)
        {
            repo.Update(movie);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult ByDirector(string director)
        {
            return View(repo.GetByDirector(director));
        }

        public ActionResult ByYear(int year)
        {
            return View(repo.GetByYear(year));
        }
    }
}