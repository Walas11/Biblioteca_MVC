using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaMVC.Controllers
{
    public class EditorialesController : Controller
    {
        // GET: EditorialesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EditorialesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EditorialesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EditorialesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EditorialesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EditorialesController/Edit/5
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

        // GET: EditorialesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EditorialesController/Delete/5
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
