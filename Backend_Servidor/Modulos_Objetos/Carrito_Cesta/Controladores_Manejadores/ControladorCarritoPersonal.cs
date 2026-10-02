// TIPO: Controlador HTTP.
// PROPÓSITO: Preparar las rutas REST del carrito de cada usuario.
// POO: Hereda ControllerBase y recibe un servicio por constructor.
// SOLID PRINCIPAL: S - Responsabilidad Única; D - Inversión de Dependencias.
// DEPENDENCIAS: InterfazAdministrarCarrito y solicitudes del módulo.
// PISTA: Las rutas devuelven 501 hasta que el equipo desarrolle las historias.
// PENDIENTE: Conectar las rutas con el servicio durante US09 y US10.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Carrito.Interfaces;
using TiendaPC.Carrito.Solicitudes;

namespace TiendaPC.Carrito.Controladores;

[Controller]
[ApiController]
[Route("api/carrito")]
[ProducesResponseType(StatusCodes.Status501NotImplemented)]
public class ControladorCarritoPersonal : ControllerBase
{
    private readonly InterfazAdministrarCarrito _administracionCarrito;

    public ControladorCarritoPersonal(InterfazAdministrarCarrito administracionCarrito)
    {
        _administracionCarrito = administracionCarrito;
    }

    [HttpGet("{idUsuario:guid}")]
    public IActionResult ConsultarCarritoPersonal(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "La consulta del carrito personal está pendiente de implementar durante US10." });
    }

    [HttpPost("{idUsuario:guid}")]
    public IActionResult AgregarProductoCarrito(Guid idUsuario, [FromBody] SolicitudAgregarProductoCarrito solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Agregar productos al carrito está pendiente de implementar durante US09." });
    }

    [HttpPut("{idUsuario:guid}/productos/{idProducto:guid}")]
    public IActionResult CambiarCantidadCarrito(Guid idUsuario, Guid idProducto, [FromBody] SolicitudCambiarCantidadCarrito solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Cambiar la cantidad del carrito está pendiente de implementar durante US10." });
    }

    [HttpDelete("{idUsuario:guid}/productos/{idProducto:guid}")]
    public IActionResult QuitarProductoCarrito(Guid idUsuario, Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Quitar productos del carrito está pendiente de implementar durante US10." });
    }

    [HttpDelete("{idUsuario:guid}")]
    public IActionResult VaciarCarrito(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Vaciar el carrito está pendiente de implementar durante US10." });
    }
}
