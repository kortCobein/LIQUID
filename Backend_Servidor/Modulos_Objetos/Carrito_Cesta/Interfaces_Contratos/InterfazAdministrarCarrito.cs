// TIPO: Interfaz de servicio.
// PROPÓSITO: Definir las operaciones futuras del carrito personal.
// POO: Expresa una abstracción que distintas clases pueden implementar.
// SOLID PRINCIPAL: I - Segregación de Interfaces; D - Inversión de Dependencias.
// DEPENDENCIAS: Solicitudes y respuestas del módulo Carrito.
// PISTA: Describe qué operaciones existen, sin decidir cómo realizarlas.
// PENDIENTE: Implementar las operaciones durante US09 y US10.

using TiendaPC.Carrito.Respuestas;
using TiendaPC.Carrito.Solicitudes;

namespace TiendaPC.Carrito.Interfaces;

public interface InterfazAdministrarCarrito
{
    RespuestaResumenCarrito ConsultarCarritoPersonal(Guid idUsuario);
    RespuestaResumenCarrito AgregarProductoCarrito(Guid idUsuario, SolicitudAgregarProductoCarrito solicitud);
    RespuestaResumenCarrito CambiarCantidadCarrito(Guid idUsuario, Guid idProducto, SolicitudCambiarCantidadCarrito solicitud);
    RespuestaResumenCarrito QuitarProductoCarrito(Guid idUsuario, Guid idProducto);
    void VaciarCarrito(Guid idUsuario);
    decimal CalcularSubtotalProducto(Guid idUsuario, Guid idProducto);
    decimal CalcularTotalCarrito(Guid idUsuario);
    bool VerificarProducto(Guid idProducto);
    bool VerificarCantidad(Guid idProducto, int cantidad);
}
