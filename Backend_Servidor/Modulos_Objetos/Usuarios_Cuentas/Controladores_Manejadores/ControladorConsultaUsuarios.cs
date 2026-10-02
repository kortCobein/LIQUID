// TIPO: Controlador.
// PROPÓSITO: Preparar las rutas HTTP de consulta de cuentas.
// POO: Herencia de ControllerBase e inyección explícita por constructor.
// SOLID PRINCIPAL: S - Recibir HTTP; D - Usar un contrato abstracto.
// DEPENDENCIAS: InterfazConsultarUsuarios.
// PISTA: La ruta existe pero no lista datos ficticios todavía.
// PENDIENTE: US11 sustituirá las respuestas 501 por consultas reales.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Usuarios.Interfaces;

namespace TiendaPC.Usuarios.Controladores;

[Controller]
[ApiController]
[Route("api/usuarios")]
public class ControladorConsultaUsuarios : ControllerBase
{
    private readonly InterfazConsultarUsuarios _consultaUsuarios;

    public ControladorConsultaUsuarios(InterfazConsultarUsuarios consultaUsuarios)
    {
        _consultaUsuarios = consultaUsuarios;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status501NotImplemented)]
    public IActionResult ConsultarUsuarios()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US11: conectar la consulta de usuarios con su servicio.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "US11 pendiente: consulta de usuarios." });
    }

    [HttpGet("{idUsuario:guid}")]
    [ProducesResponseType(StatusCodes.Status501NotImplemented)]
    public IActionResult ConsultarUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US11: conectar la consulta de un usuario con su servicio.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "US11 pendiente: consulta de un usuario." });
    }
}
