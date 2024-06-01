using LibreriaAPI_Infraestructura.DataBase.Context;
using LibreriaAPI_Infraestructura.DataBase.Entities.Autores;
using LibreriaMVC.Models.Contracts.Autores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult AutoresCreate(AutoresContract autor)
        {
            if (ModelState.IsValid)
            {
                AutoresEntities autorEntities = new()
                {
                    Codigo_autor = autor.Codigo_autor,
                    Nombre_autor = autor.Nombre_autor,
                    Nacionalidad = autor.Nacionalidad
                };

                _applicationContext.Autores.Add(autorEntities);
                _applicationContext.SaveChanges();

                return RedirectToAction("AutoresView", "Autores");
            }

            // Si hay errores de validación, vuelve a mostrar el formulario de creación con los errores
            return View(autor);
        }

        // GET: AutoresController/Edit
        public ActionResult AutoresEdit(string codigo)
        {
            var autores = _applicationContext.Autores.FirstOrDefault(a => a.Codigo_autor == codigo);
            return View(autores);
        }
        
        // GET: AutoresController/Edit/
        public ActionResult Edit(AutoresContract autor)
        {
            if (ModelState.IsValid)
            {
                AutoresEntities autorEntities = new()
                {
                    Codigo_autor = autor.Codigo_autor,
                    Nombre_autor = autor.Nombre_autor,
                    Nacionalidad = autor.Nacionalidad
                };

                _applicationContext.Autores.Update(autorEntities);
                _applicationContext.SaveChanges();

                return RedirectToAction("AutoresView", "Autores");
            }
            return RedirectToAction("AutoresEditView", "Autores");
        }

        // GET: AutoresController/Delete
        public ActionResult AutoresDelete(string codigo)
        {
            if (ModelState.IsValid)
            {
                AutoresEntities autorEntities = new()
                {
                    Codigo_autor = autor.Codigo_autor,
                    Nombre_autor = autor.Nombre_autor,
                    Nacionalidad = autor.Nacionalidad
                };

                _applicationContext.Autores.Update(autorEntities);
                _applicationContext.SaveChanges();

                return RedirectToAction("AutoresView", "Autores");
            }
            return RedirectToAction("AutoresEditView", "Autores");
        }

    }
}
