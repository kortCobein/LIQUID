// TIPO: Controlador técnico.
// PROPÓSITO: Comprobar la conexión HTTP sin ejecutar historias de usuario.
// POO: Clase que hereda de ControllerBase.
// SOLID PRINCIPAL: S - Una sola responsabilidad técnica.
// DEPENDENCIAS: ASP.NET Core MVC.
// PISTA: Angular consulta exclusivamente esta ruta.
// PENDIENTE: Ninguno; este endpoint queda operativo en la cimentación.

using Microsoft.AspNetCore.Mvc;

namespace TiendaPC;

[Controller]
[ApiController]
[Route("api/estado")]
public class ControladorEstadoSistema : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ConsultarEstado()
    {
        return Ok(new { estado = "Backend funcionando" });
    }
}
