using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peages.Controllers
{
    public class PeageController : Controller
    {
        // GET: PeageController
        public ActionResult Index()
        {
            return View(); // view named Index
        }

        // GET: PeageController/Details/5
        public ActionResult Details(int id)
        {
            // pass some data to view
            ViewData["id"] = id;
            ViewData["message"] = "message from controller detail";
            ViewBag.City = "Toulouse";
            ViewBag.Cities = new string[] { "Pau", "Toulouse", "Valence" };
            return View(); // view named Details
            // return View("Index"); // view Index (! refactoring)
            // return View(nameof(Index)); // same view as method Index

        }

        // GET: PeageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: create data here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
