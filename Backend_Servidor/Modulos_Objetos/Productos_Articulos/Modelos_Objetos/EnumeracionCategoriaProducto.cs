// TIPO: Enumeración.
// PROPÓSITO: Representar la categoría que pertenece a cada producto.
// POO: Tipo que limita los valores de una propiedad del modelo.
// SOLID PRINCIPAL: S - Describe solamente categorías de productos.
// DEPENDENCIAS: Ninguna.
// PISTA: Una categoría es una característica del producto, no otro módulo.
// PENDIENTE: Usar estos valores al implementar US04, US06 y US07.

namespace TiendaPC.Productos.Modelos;

public enum EnumeracionCategoriaProducto
{
    Procesadores,
    TarjetasGraficas,
    MemoriasRam,
    Almacenamiento,
    TarjetasMadre,
    FuentesPoder,
    Gabinetes,
    Refrigeracion,
    Monitores,
    Teclados,
    Ratones,
    Audifonos,
    OtrosPerifericos
}
