using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBinario.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Baleada Sencilla";
            producto1.Precio = 15;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Baleada Con Huevo";
            producto2.Precio = 20;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Baleada Con Huevo y Carne";
            producto3.Precio = 25;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Baleada Con Todo";
            producto4.Precio = 30;

            var ListaProductos = new List<Producto>();
            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
            ListaProductos.Add(producto4);

            return ListaProductos;

        }
    }
}
