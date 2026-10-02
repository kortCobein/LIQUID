// TIPO: Interfaz de administración.
// PROPÓSITO: Preparar las operaciones que ofrecerá el servicio de productos.
// POO: Abstracción para comunicar controladores y servicios.
// SOLID PRINCIPAL: I - Responsabilidad del contrato limitada a productos.
// DEPENDENCIAS: Solicitudes de productos y RespuestaInformacionProducto.
// PISTA: Las firmas describen operaciones; no contienen reglas del negocio.
// PENDIENTE: Desarrollar la administración en US06, US07 y US08.

using TiendaPC.Productos.Solicitudes;

namespace TiendaPC.Productos.Interfaces;

public interface InterfazAdministrarProductos
{
    RespuestaInformacionProducto RegistrarProducto(SolicitudRegistrarProducto solicitud);
    RespuestaInformacionProducto ModificarProducto(Guid idProducto, SolicitudModificarProducto solicitud);
    void EliminarProducto(Guid idProducto);
    RespuestaInformacionProducto? ConsultarProducto(Guid idProducto);
    IReadOnlyList<RespuestaInformacionProducto> ConsultarProductos();
}
