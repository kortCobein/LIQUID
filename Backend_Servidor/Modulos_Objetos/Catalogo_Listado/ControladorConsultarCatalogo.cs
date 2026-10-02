// TIPO: Controlador HTTP.
// PROPÓSITO: Preparar las rutas de consulta del catálogo.
// POO: Constructor explícito y composición mediante InterfazConsultarCatalogo.
// SOLID PRINCIPAL: S - Entrada HTTP. D - Dependencia de una abstracción.
// DEPENDENCIAS: InterfazConsultarCatalogo y solicitudes del catálogo.
// PISTA: Los atributos descubren el controlador español; todas sus rutas devuelven 501.
// PENDIENTE: Conectar las consultas con el servicio durante US03, US04 y US05.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Catalogo.Solicitudes;

namespace TiendaPC.Catalogo;

[Controller]
[ApiController]
[Route("api/catalogo")]
[ProducesResponseType(StatusCodes.Status501NotImplemented)]
public class ControladorConsultarCatalogo : ControllerBase
{
    private readonly InterfazConsultarCatalogo _consultaCatalogo;

    public ControladorConsultarCatalogo(InterfazConsultarCatalogo consultaCatalogo)
    {
        _consultaCatalogo = consultaCatalogo;
    }

    [HttpGet]
    public IActionResult ObtenerCatalogo()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de catálogo durante US03.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Consulta del catálogo pendiente de US03." });
    }

    [HttpGet("{idProducto:guid}")]
    public IActionResult ConsultarDetalleProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de detalle durante US05.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Detalle de producto pendiente de US05." });
    }

    [HttpGet("categorias")]
    public IActionResult ObtenerCategoriasDisponibles()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de categorías durante US04.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Consulta de categorías pendiente de US04." });
    }

    [HttpGet("buscar")]
    public IActionResult BuscarProductos([FromQuery] SolicitudBuscarCatalogo solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de búsqueda durante US03.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Búsqueda del catálogo pendiente de US03." });
    }

    [HttpGet("filtrar")]
    public IActionResult FiltrarProductos([FromQuery] SolicitudFiltrarCatalogo solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de filtrado durante US04.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "Filtrado del catálogo pendiente de US04." });
    }
}
