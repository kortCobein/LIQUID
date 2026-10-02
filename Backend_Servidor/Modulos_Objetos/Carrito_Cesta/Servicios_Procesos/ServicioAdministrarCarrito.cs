// TIPO: Servicio.
// PROPÓSITO: Preparar las operaciones futuras del carrito personal.
// POO: Recibe sus colaboradores mediante un constructor explícito.
// SOLID PRINCIPAL: S - Responsabilidad Única; D - Inversión de Dependencias.
// DEPENDENCIAS: InterfazAlmacenarCarritos e InterfazAlmacenarProductos.
// PISTA: Aquí vivirán reglas del carrito; la información de productos se consulta.
// PENDIENTE: Implementar las operaciones durante US09 y US10.

using TiendaPC.Carrito.Interfaces;
using TiendaPC.Carrito.Respuestas;
using TiendaPC.Carrito.Solicitudes;
using TiendaPC.Productos.Interfaces;

namespace TiendaPC.Carrito.Servicios;

public class ServicioAdministrarCarrito : InterfazAdministrarCarrito
{
    private readonly InterfazAlmacenarCarritos _almacenamientoCarritos;
    private readonly InterfazAlmacenarProductos _almacenamientoProductos;

    public ServicioAdministrarCarrito(
        InterfazAlmacenarCarritos almacenamientoCarritos,
        InterfazAlmacenarProductos almacenamientoProductos)
    {
        _almacenamientoCarritos = almacenamientoCarritos;
        _almacenamientoProductos = almacenamientoProductos;
    }

    public RespuestaResumenCarrito ConsultarCarritoPersonal(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public RespuestaResumenCarrito AgregarProductoCarrito(Guid idUsuario, SolicitudAgregarProductoCarrito solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public RespuestaResumenCarrito CambiarCantidadCarrito(Guid idUsuario, Guid idProducto, SolicitudCambiarCantidadCarrito solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public RespuestaResumenCarrito QuitarProductoCarrito(Guid idUsuario, Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public void VaciarCarrito(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public decimal CalcularSubtotalProducto(Guid idUsuario, Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public decimal CalcularTotalCarrito(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public bool VerificarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public bool VerificarCantidad(Guid idProducto, int cantidad)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }
}
