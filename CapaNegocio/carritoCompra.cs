using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class carritoCompra
    {
        private static int precioTotal = 0;
        private static int numeroCarritos = 0;
        private int precioCarrito;

        public carritoCompra()
        {
            carritoCompra.numeroCarritos++;
            carritoCompra.precioTotal = carritoCompra.precioTotal + precioCarrito;
        }

        public static int NumeroCarritos { get => numeroCarritos; }
        public static int PrecioTotal { get => precioTotal;}
        public int PrecioCarrito { get => precioCarrito; }
        public static void agregarFinal(int precio)
        {
            carritoCompra.precioTotal = carritoCompra.precioTotal + precio;
        }
        public void AddPrecio(int precio)
        {
            precioCarrito = precioCarrito + precio;

        }
    }
}
