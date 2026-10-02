// TIPO: Datos iniciales hardcodeados.
// PROPÓSITO: Crear doce productos ficticios para iniciar el almacenamiento temporal.
// POO: Construye objetos ModeloProducto mediante su constructor explícito.
// SOLID PRINCIPAL: S - Define exclusivamente la información inicial.
// DEPENDENCIAS: ModeloProducto y EnumeracionCategoriaProducto.
// PISTA: El repositorio conserva esta lista; aquí no viven consultas ni reglas.
// PENDIENTE: Desarrollar las operaciones de productos y catálogo en sus servicios.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos;

public static class DatosProductosIniciales
{
    public static List<ModeloProducto> CrearProductos()
    {
        return new List<ModeloProducto>
        {
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000001"),
                "Ryzen 7 7800X3D", "AMD", "Procesador de demostración para equipos de alto rendimiento.",
                7499m, 8, EnumeracionCategoriaProducto.Procesadores, "imagenes/ryzen-7800x3d.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000002"),
                "Core i5 14600K", "Intel", "Procesador de demostración para trabajo y juegos.",
                5899m, 10, EnumeracionCategoriaProducto.Procesadores, "imagenes/core-i5-14600k.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000003"),
                "GeForce RTX 4060", "NVIDIA", "Tarjeta gráfica de demostración para equipos de escritorio.",
                8999m, 6, EnumeracionCategoriaProducto.TarjetasGraficas, "imagenes/geforce-rtx-4060.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000004"),
                "Radeon RX 7600", "AMD", "Tarjeta gráfica ficticia de demostración para juegos.",
                6299m, 7, EnumeracionCategoriaProducto.TarjetasGraficas, "imagenes/radeon-rx-7600.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000005"),
                "Fury Beast 16 GB", "Kingston", "Memoria RAM de demostración para equipos de escritorio.",
                999m, 20, EnumeracionCategoriaProducto.MemoriasRam, "imagenes/fury-beast-16gb.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000006"),
                "Vengeance 32 GB", "Corsair", "Kit de memoria RAM de demostración.",
                1899m, 14, EnumeracionCategoriaProducto.MemoriasRam, "imagenes/vengeance-32gb.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000007"),
                "SSD 980 1 TB", "Samsung", "Unidad de almacenamiento sólido de demostración.",
                1499m, 18, EnumeracionCategoriaProducto.Almacenamiento, "imagenes/ssd-980-1tb.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000008"),
                "SSD NV2 500 GB", "Kingston", "Unidad de almacenamiento de demostración para una PC.",
                699m, 25, EnumeracionCategoriaProducto.Almacenamiento, "imagenes/ssd-nv2-500gb.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000009"),
                "Prime B650M-A", "ASUS", "Tarjeta madre de demostración para procesadores AMD.",
                2899m, 9, EnumeracionCategoriaProducto.TarjetasMadre, "imagenes/prime-b650m-a.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000010"),
                "Pro B760M-P", "MSI", "Tarjeta madre de demostración para procesadores Intel.",
                2499m, 11, EnumeracionCategoriaProducto.TarjetasMadre, "imagenes/pro-b760m-p.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000011"),
                "CX650 650 W", "Corsair", "Fuente de poder de demostración para equipos de escritorio.",
                1299m, 12, EnumeracionCategoriaProducto.FuentesPoder, "imagenes/cx650.webp"),
            new ModeloProducto(
                Guid.Parse("10000000-0000-0000-0000-000000000012"),
                "Ratón G203", "Logitech", "Ratón de demostración para trabajo y juegos.",
                499m, 30, EnumeracionCategoriaProducto.Ratones, "imagenes/raton-g203.webp")
        };
    }
}
