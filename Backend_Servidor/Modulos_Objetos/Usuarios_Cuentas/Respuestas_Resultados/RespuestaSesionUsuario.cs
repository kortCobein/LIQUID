// TIPO: Respuesta.
// PROPÓSITO: Preparar los datos de una futura sesión y su perfil.
// POO: Composición de datos de usuario en una respuesta.
// SOLID PRINCIPAL: S - Describir el resultado del inicio.
// DEPENDENCIAS: RespuestaInformacionUsuario.
// PISTA: No contiene tokens JWT ni genera una sesión.
// PENDIENTE: US01 construirá el resultado del inicio de sesión.

namespace TiendaPC.Usuarios.Respuestas;

public class RespuestaSesionUsuario
{
    public Guid IdSesion { get; set; }
    public DateTimeOffset FechaInicio { get; set; }
    public RespuestaInformacionUsuario Usuario { get; set; } = new RespuestaInformacionUsuario();
}
