using LibreriaAPI_Infraestructura.DataBase.Context;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaMVC.Controllers
{
    public class AutoresController : Controller
    {
        private readonly ApplicationContext _applicationContext;

        public AutoresController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        // GET: AutoresController
        public ActionResult AutoresView()
        {
            var autores = _applicationContext.Autores.ToList();
            return View(autores);
        }

        // GET: AutoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: AutoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: AutoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
