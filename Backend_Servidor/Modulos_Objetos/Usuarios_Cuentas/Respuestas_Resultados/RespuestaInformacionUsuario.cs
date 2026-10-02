// TIPO: Respuesta.
// PROPÓSITO: Preparar información pública de una cuenta sin contraseña.
// POO: Clase de salida separada del modelo interno.
// SOLID PRINCIPAL: S - Describir la información consultable.
// DEPENDENCIAS: EnumeracionRolUsuario.
// PISTA: El servicio decidirá cómo construir esta respuesta.
// PENDIENTE: US11 implementará la consulta de usuarios.

using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Respuestas;

public class RespuestaInformacionUsuario
{
    public Guid IdUsuario { get; set; }
    public string NombreUsuario { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;
    public string CorreoElectronico { get; set; } = string.Empty;
    public EnumeracionRolUsuario Rol { get; set; }
}
