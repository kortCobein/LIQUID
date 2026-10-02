// TIPO: Respuesta de servicio.
// PROPÓSITO: Preparar la información que mostrará el carrito personal.
// POO: Compone líneas del carrito y recibe valores por constructor.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: ModeloProductoCarrito.
// PISTA: Los importes se reciben; este objeto no implementa su cálculo.
// PENDIENTE: Construir esta respuesta durante US09 y US10.

using TiendaPC.Carrito.Modelos;

namespace TiendaPC.Carrito.Respuestas;

public class RespuestaResumenCarrito
{
    public Guid IdCarrito { get; }
    public Guid IdUsuario { get; }
    public IReadOnlyList<ModeloProductoCarrito> Productos { get; }
    public decimal Subtotal { get; }
    public decimal Total { get; }

    public RespuestaResumenCarrito(
        Guid idCarrito,
        Guid idUsuario,
        IReadOnlyList<ModeloProductoCarrito> productos,
        decimal subtotal,
        decimal total)
    {
        IdCarrito = idCarrito;
        IdUsuario = idUsuario;
        Productos = productos;
        Subtotal = subtotal;
        Total = total;
    }
}
