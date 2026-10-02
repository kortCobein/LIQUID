// TIPO: Modelo de una línea del carrito.
// PROPÓSITO: Representar la referencia a un producto, su cantidad y precio.
// POO: Encapsula sus propiedades y recibe los valores por constructor.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: Ninguna dependencia de servicios o repositorios.
// PISTA: IdProducto vincula la línea con el producto sin copiar todo su modelo.
// PENDIENTE: Añadir cambios y reglas de cantidad durante US09 y US10.

namespace TiendaPC.Carrito.Modelos;

public class ModeloProductoCarrito
{
    public Guid IdProducto { get; private set; }
    public int Cantidad { get; private set; }
    public decimal PrecioUnitario { get; private set; }

    public ModeloProductoCarrito(Guid idProducto, int cantidad, decimal precioUnitario)
    {
        IdProducto = idProducto;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
    }
}
