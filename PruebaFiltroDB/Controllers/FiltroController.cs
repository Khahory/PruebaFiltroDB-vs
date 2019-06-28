using DatosLibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaFiltroDB.Controllers
{
    public class FiltroController : Controller
    {

        private VentasEntities db = new VentasEntities();

        // GET: Filtro
        public ActionResult Index()
        {
            return View(db.View_1);
        }

        // GET: Filtro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Filtro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filtro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filtro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Filtro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filtro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Filtro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        //buscar solo el nombre del proveedor ejemplo: /controller/action?nombre_proveedor=angel
        public ActionResult BuscarFiltro(string Nombre_proveedor, string id_producto)
        {
            //creadno listBox
            ViewBag.id_producto = new SelectList(db.View_1, "id_producto", "Nombre_producto", "Nombre_proveedor");

            var proveedor = from s in db.View_1 select s;
            if (!String.IsNullOrEmpty(Nombre_proveedor))
            {
                proveedor = proveedor.Where(j => j.nombre_proveedor.Contains(Nombre_proveedor));

            }

            //para buscar con el listBox
            if (!String.IsNullOrEmpty(id_producto))
            {
                int gr = Convert.ToInt32(id_producto);
                return View(proveedor.Where(x => x.id_producto == gr));
            }
            else
            {
                return View(proveedor);
            }
        }
    }
}
