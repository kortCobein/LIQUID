// TIPO: Respuesta de detalle.
// PROPÓSITO: Preparar los datos de un carrito seleccionado del historial.
// POO: Usa composición de líneas y propiedades de salida de solo lectura.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: ModeloProductoCarrito.
// PISTA: La consulta futura del historial deberá construir este objeto.
// PENDIENTE: Resolver el detalle de cada carrito durante US12.

using TiendaPC.Carrito.Modelos;

namespace TiendaPC.Carrito.Respuestas;

public class RespuestaDetalleCarrito
{
    public Guid IdCarrito { get; }
    public Guid IdUsuario { get; }
    public DateTimeOffset FechaCreacion { get; }
    public IReadOnlyList<ModeloProductoCarrito> Productos { get; }
    public decimal Total { get; }

    public RespuestaDetalleCarrito(
        Guid idCarrito,
        Guid idUsuario,
        DateTimeOffset fechaCreacion,
        IReadOnlyList<ModeloProductoCarrito> productos,
        decimal total)
    {
        IdCarrito = idCarrito;
        IdUsuario = idUsuario;
        FechaCreacion = fechaCreacion;
        Productos = productos;
        Total = total;
    }
}
