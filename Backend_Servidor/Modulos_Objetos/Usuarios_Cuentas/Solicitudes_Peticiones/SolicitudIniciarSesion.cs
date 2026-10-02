// TIPO: Solicitud.
// PROPÓSITO: Preparar la entrada JSON del futuro inicio de sesión.
// POO: Clase con propiedades para transporte de datos.
// SOLID PRINCIPAL: S - Describir una petición de inicio.
// DEPENDENCIAS: Ninguna.
// PISTA: Recibir credenciales no implica validarlas.
// PENDIENTE: US01 implementará el inicio de sesión.

namespace TiendaPC.Usuarios.Solicitudes;

public class SolicitudIniciarSesion
{
    public string NombreUsuario { get; set; } = string.Empty;
    public string Contrasena { get; set; } = string.Empty;
}
