using LibreriaAPI_Infraestructura.DataBase.Context;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaMVC.Controllers
{
    public class GenerosController : Controller
    {

        private readonly ApplicationContext _applicationContext;

        public GenerosController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        // GET: GenerosController
        public ActionResult GenerosView()
        {
            var generos = _applicationContext.Generos.ToList();
            return View(generos);
        }

        // GET: GenerosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: GenerosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: GenerosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
