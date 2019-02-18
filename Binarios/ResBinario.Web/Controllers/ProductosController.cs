using ResBinario.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResBinario.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Baleada Sencilla";
            producto1.Precio = 15;

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Baleada Con Huevo";
            producto2.Precio = 15;

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Baleada Con Huevo y Carne";
            producto3.Precio = 15;

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Baleada Con Todo";
            producto4.Precio = 15;

            var ListaProductos = new List<ProductoModel>();
            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
            ListaProductos.Add(producto4);


            return View(ListaProductos);
        }
    }
}