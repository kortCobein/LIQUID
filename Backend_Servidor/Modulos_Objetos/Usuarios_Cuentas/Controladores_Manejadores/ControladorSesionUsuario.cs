// TIPO: Controlador.
// PROPÓSITO: Preparar las rutas HTTP de inicio y cierre de sesión.
// POO: Herencia de ControllerBase y constructor con una interfaz.
// SOLID PRINCIPAL: S - Recibir HTTP; D - Dependencia del contrato de sesión.
// DEPENDENCIAS: InterfazGestionarSesion y solicitudes de sesión.
// PISTA: [Controller] permite descubrir este nombre español.
// PENDIENTE: US01 y US02 sustituirán las respuestas 501.

using Microsoft.AspNetCore.Mvc;
using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Solicitudes;

namespace TiendaPC.Usuarios.Controladores;

[Controller]
[ApiController]
[Route("api/usuarios/sesion")]
public class ControladorSesionUsuario : ControllerBase
{
    private readonly InterfazGestionarSesion _gestionSesion;

    public ControladorSesionUsuario(InterfazGestionarSesion gestionSesion)
    {
        _gestionSesion = gestionSesion;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status501NotImplemented)]
    public IActionResult IniciarSesion([FromBody] SolicitudIniciarSesion solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01: conectar la ruta con el servicio de inicio.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "US01 pendiente: inicio de sesión." });
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status501NotImplemented)]
    public IActionResult CerrarSesion([FromBody] SolicitudCerrarSesion solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US02: conectar la ruta con el servicio de cierre.
        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = "US02 pendiente: cierre de sesión." });
    }
}
