// TIPO: Respuesta de historial.
// PROPÓSITO: Preparar una entrada resumida del historial de carritos.
// POO: Encapsula valores de salida mediante un constructor explícito.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: Ninguna dependencia de acceso a datos.
// PISTA: Los valores se asignan sin contar productos ni calcular el total.
// PENDIENTE: Preparar las entradas del historial durante US12.

namespace TiendaPC.Carrito.Respuestas;

public class RespuestaHistorialCarrito
{
    public Guid IdCarrito { get; }
    public Guid IdUsuario { get; }
    public DateTimeOffset FechaCreacion { get; }
    public int CantidadProductos { get; }
    public decimal Total { get; }

    public RespuestaHistorialCarrito(
        Guid idCarrito,
        Guid idUsuario,
        DateTimeOffset fechaCreacion,
        int cantidadProductos,
        decimal total)
    {
        IdCarrito = idCarrito;
        IdUsuario = idUsuario;
        FechaCreacion = fechaCreacion;
        CantidadProductos = cantidadProductos;
        Total = total;
    }
}
