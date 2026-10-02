// TIPO: Modelo de dominio.
// PROPÓSITO: Representar un carrito asociado con un usuario.
// POO: Usa constructor, encapsulamiento y composición de líneas de productos.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: ModeloProductoCarrito.
// PISTA: La colección se expone como solo lectura; aquí no se calculan importes.
// PENDIENTE: Añadir las reglas del carrito durante US09 y US10.

namespace TiendaPC.Carrito.Modelos;

public class ModeloCarritoCompra
{
    public Guid IdCarrito { get; private set; }
    public Guid IdUsuario { get; private set; }
    public DateTimeOffset FechaCreacion { get; private set; }
    public IReadOnlyList<ModeloProductoCarrito> Productos { get; }

    public ModeloCarritoCompra(
        Guid idCarrito,
        Guid idUsuario,
        DateTimeOffset fechaCreacion,
        IEnumerable<ModeloProductoCarrito> productos)
    {
        IdCarrito = idCarrito;
        IdUsuario = idUsuario;
        FechaCreacion = fechaCreacion;
        Productos = new List<ModeloProductoCarrito>(productos).AsReadOnly();
    }
}
