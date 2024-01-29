using System;

namespace Supermercado
{
    // Clase base para los productos
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        // Constructor
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Método virtual para mostrar la información del producto
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}");
        }
    }
}
