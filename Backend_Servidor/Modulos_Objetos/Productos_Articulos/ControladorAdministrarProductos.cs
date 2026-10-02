// TIPO: Controlador HTTP.
// PROPÓSITO: Preparar las rutas REST de administración de productos.
// POO: Constructor explícito y composición mediante el servicio abstracto.
// SOLID PRINCIPAL: S - Entrada HTTP. D - Dependencia de InterfazAdministrarProductos.
// DEPENDENCIAS: InterfazAdministrarProductos y solicitudes de productos.
// PISTA: Controller permite descubrir el nombre español; las rutas responden 501.
// PENDIENTE: Conectar las rutas con el servicio al desarrollar US06, US07 y US08.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Productos.Interfaces;
using TiendaPC.Productos.Solicitudes;

namespace TiendaPC.Productos;

[Controller]
[ApiController]
[Route("api/productos")]
[ProducesResponseType(StatusCodes.Status501NotImplemented)]
public class ControladorAdministrarProductos : ControllerBase
{
    private readonly InterfazAdministrarProductos _administracionProductos;

    public ControladorAdministrarProductos(InterfazAdministrarProductos administracionProductos)
    {
        _administracionProductos = administracionProductos;
    }

    [HttpPost]
    public IActionResult RegistrarProducto([FromBody] SolicitudRegistrarProducto solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de registro durante US06.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Registro de productos pendiente de US06." });
    }

    [HttpPut("{idProducto:guid}")]
    public IActionResult ModificarProducto(Guid idProducto, [FromBody] SolicitudModificarProducto solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de modificación durante US07.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Modificación de productos pendiente de US07." });
    }

    [HttpDelete("{idProducto:guid}")]
    public IActionResult EliminarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de eliminación durante US08.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Eliminación de productos pendiente de US08." });
    }

    [HttpGet("{idProducto:guid}")]
    public IActionResult ConsultarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta administrativa durante las historias de productos.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Consulta administrativa de producto pendiente." });
    }

    [HttpGet]
    public IActionResult ConsultarProductos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el listado administrativo durante las historias de productos.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Listado administrativo de productos pendiente." });
    }
}
