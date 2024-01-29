using System;

namespace Supermercado
{
    // Clase para productos de precio variable
    class ProductoPrecioVariable : Producto
    {
        public double Peso { get; set; }

        public ProductoPrecioVariable(string nombre, double precio, double peso) : base(nombre, precio)
        {
            Peso = peso;
        }

        // Sobrescribe el método de la clase base para mostrar la información específica
        public override void MostrarInfo()
        {
            Console.WriteLine($"Producto de precio variable - Nombre: {Nombre}, Precio por kilogramo: {Precio}, Peso: {Peso} kg, Precio total: {Precio * Peso}");
        }
    }
}
