using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaFiltroDB_Dos.Controllers
{
    public class FiltroController : Controller
    {
        private DBContextADO db = new DBContextADO();

        // GET: Filtro
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Create(Productos model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("BuscarFiltro", model);
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
        public ActionResult BuscarFiltro(string Nombre_producto, string id_producto)
        {
            //creadno listBox
            ViewBag.id_producto = new SelectList(db.Productos, "id_producto", "Nombre_producto", "refe_producto");

            //consulta a todos
            var proveedor = from s in db.Productos select s;
            if (!String.IsNullOrEmpty(Nombre_producto))
            {
                //trae la lista filtrada
                proveedor = proveedor.Where(j => j.nombre_producto.Contains(Nombre_producto));

            }

            //para buscar con el listBox
            //https://www.youtube.com/watch?v=Z6QuwR8g3UI&index=30&list=WL&t=598s
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
