using System.Collections.Generic;

namespace CatalogoExpress.Models
{
    public class Catalogo
    {
        private List<Item> Productos;

        public Catalogo()
        {
            Productos = new List<Item>();
            Productos.Add(new Item("Laptop", "Electrónica", 2022, 999.99, "Laptop de alta gama con procesador Intel i7 y 16GB de RAM."));
            Productos.Add(new Item("Smartphone", "Electrónica", 2023, 799.99, "Smartphone con pantalla AMOLED de 6.5 pulgadas y cámara de 48MP."));
            Productos.Add(new Item("Cámara DSLR", "Fotografía", 2021, 499.99, "Cámara DSLR con sensor de 24MP y lente de 18-55mm."));
            Productos.Add(new Item("Televisor 4K", "Electrónica", 2022, 1199.99, "Televisor 4K de 55 pulgadas con tecnología HDR y Smart TV."));
        }

        public List<Item> ObtenerProductos()
        {
            return Productos;
        }

        public Item ObtenerProductoPorNombre(string nombre)
        {
            foreach (var Producto in Productos)
            {
                if (Producto.ObtenerNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return Producto;
                }
            }
            return null; // Retorna null si no se encuentra el Producto
        }

    }
}