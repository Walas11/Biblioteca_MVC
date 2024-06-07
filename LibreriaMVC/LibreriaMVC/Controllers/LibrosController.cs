using LibreriaAPI_Infraestructura.DataBase.Context;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaMVC.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationContext _applicationContext;

        public LibrosController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        // GET: LibrosController
        public ActionResult LibrosView()
        {
            var libros = _applicationContext.Libros.ToList();
            return View(libros);
        }

        // GET: LibrosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: LibrosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: LibrosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
