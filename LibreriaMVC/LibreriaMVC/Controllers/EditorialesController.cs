using LibreriaAPI_Infraestructura.DataBase.Context;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaMVC.Controllers
{
    public class EditorialesController : Controller
    {

        private readonly ApplicationContext _applicationContext;

        public EditorialesController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        // GET: EditorialesController
        public ActionResult EditorialesView()
        {
            var editoriales = _applicationContext.Editoriales.ToList();
            return View(editoriales);
        }

        // GET: EditorialesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: EditorialesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: EditorialesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
