// TIPO: Controlador HTTP de consulta.
// PROPÓSITO: Preparar rutas para historial global, por usuario y detalle.
// POO: Hereda ControllerBase y utiliza una interfaz recibida por constructor.
// SOLID PRINCIPAL: S - Responsabilidad Única; D - Inversión de Dependencias.
// DEPENDENCIAS: InterfazConsultarHistorialCarritos.
// PISTA: Su responsabilidad es HTTP; el historial se resolverá en el servicio.
// PENDIENTE: Conectar las consultas durante US12.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Carrito.Interfaces;

namespace TiendaPC.Carrito.Controladores;

[Controller]
[ApiController]
[Route("api/carritos/historial")]
[ProducesResponseType(StatusCodes.Status501NotImplemented)]
public class ControladorHistorialCarritos : ControllerBase
{
    private readonly InterfazConsultarHistorialCarritos _consultaHistorial;

    public ControladorHistorialCarritos(InterfazConsultarHistorialCarritos consultaHistorial)
    {
        _consultaHistorial = consultaHistorial;
    }

    [HttpGet]
    public IActionResult ConsultarHistorialCarritos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "La consulta del historial de carritos está pendiente de implementar durante US12." });
    }

    [HttpGet("usuarios/{idUsuario:guid}")]
    public IActionResult ConsultarHistorialCarritosPorUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "El historial de carritos por usuario está pendiente de implementar durante US12." });
    }

    [HttpGet("{idCarrito:guid}")]
    public IActionResult ConsultarDetalleCarrito(Guid idCarrito)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "La consulta del detalle del historial está pendiente de implementar durante US12." });
    }
}
