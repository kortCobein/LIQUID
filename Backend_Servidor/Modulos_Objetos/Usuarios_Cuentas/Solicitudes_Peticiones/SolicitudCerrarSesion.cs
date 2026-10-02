// TIPO: Solicitud.
// PROPÓSITO: Identificar la sesión que se querrá cerrar.
// POO: Clase de entrada sin lógica de negocio.
// SOLID PRINCIPAL: S - Describir una petición de cierre.
// DEPENDENCIAS: Identificador de sesión.
// PISTA: El identificador aún no se busca ni se elimina.
// PENDIENTE: US02 implementará el cierre de sesión.

namespace TiendaPC.Usuarios.Solicitudes;

public class SolicitudCerrarSesion
{
    public Guid IdSesion { get; set; }
}
