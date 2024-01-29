using System;

namespace Supermercado
{
    // Clase para productos de precio fijo
    class ProductoPrecioFijo : Producto
    {
        public ProductoPrecioFijo(string nombre, double precio) : base(nombre, precio)
        {
        }

        // Sobrescribe el método de la clase base para mostrar la información específica
        public override void MostrarInfo()
        {
            Console.WriteLine($"Producto de precio fijo - Nombre: {Nombre}, Precio: {Precio}");
        }
    }
}
