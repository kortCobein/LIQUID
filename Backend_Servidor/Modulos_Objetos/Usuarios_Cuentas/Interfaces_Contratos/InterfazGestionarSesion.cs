// TIPO: Interfaz.
// PROPÓSITO: Definir las operaciones futuras de inicio y cierre.
// POO: Abstracción para polimorfismo mediante interfaces.
// SOLID PRINCIPAL: I - Contrato enfocado; D - Dependencia abstracta.
// DEPENDENCIAS: Solicitudes de sesión y RespuestaSesionUsuario.
// PISTA: Indica qué se hará, sin decidir cómo.
// PENDIENTE: US01 y US02 implementarán estas operaciones.

using TiendaPC.Usuarios.Respuestas;
using TiendaPC.Usuarios.Solicitudes;

namespace TiendaPC.Usuarios.Interfaces;

public interface InterfazGestionarSesion
{
    RespuestaSesionUsuario IniciarSesion(SolicitudIniciarSesion solicitud);
    void CerrarSesion(SolicitudCerrarSesion solicitud);
}
