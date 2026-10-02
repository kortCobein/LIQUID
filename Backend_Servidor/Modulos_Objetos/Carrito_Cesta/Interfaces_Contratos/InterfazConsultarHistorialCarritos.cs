// TIPO: Interfaz de consulta.
// PROPÓSITO: Definir la consulta futura del historial de carritos.
// POO: Permite polimorfismo entre implementaciones de consulta.
// SOLID PRINCIPAL: I - Segregación de Interfaces.
// DEPENDENCIAS: Respuestas de historial y detalle del módulo Carrito.
// PISTA: El historial se consulta por separado de la modificación del carrito.
// PENDIENTE: Implementar las consultas durante US12.

using TiendaPC.Carrito.Respuestas;

namespace TiendaPC.Carrito.Interfaces;

public interface InterfazConsultarHistorialCarritos
{
    IReadOnlyList<RespuestaHistorialCarrito> ConsultarHistorialCarritos();
    IReadOnlyList<RespuestaHistorialCarrito> ConsultarHistorialCarritosPorUsuario(Guid idUsuario);
    RespuestaDetalleCarrito? ConsultarDetalleCarrito(Guid idCarrito);
}
