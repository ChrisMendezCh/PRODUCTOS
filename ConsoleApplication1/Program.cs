using System;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear algunos productos
            Producto producto1 = new ProductoPrecioFijo("Coca cola", 1.5);
            Producto producto2 = new ProductoPrecioFijo("Leche", 2.0);
            Producto producto3 = new ProductoPrecioVariable("Carne", 10.0, 0.5); // Precio por kg
            Producto producto4 = new ProductoPrecioVariable("Manzanas", 2.0, 1.5); // Precio por kg

            // Mostrar la información de los productos
            MostrarInformacionProducto(producto1);
            MostrarInformacionProducto(producto2);
            MostrarInformacionProducto(producto3);
            MostrarInformacionProducto(producto4);
        }

        // Método para mostrar la información de un producto
        static void MostrarInformacionProducto(Producto producto)
        {
            producto.MostrarInfo();
        }
    }
}
