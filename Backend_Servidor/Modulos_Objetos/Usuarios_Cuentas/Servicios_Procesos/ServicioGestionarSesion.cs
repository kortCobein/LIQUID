// TIPO: Servicio.
// PROPÓSITO: Preparar el futuro inicio y cierre de sesión.
// POO: Composición por constructor e implementación de una interfaz.
// SOLID PRINCIPAL: S - Gestionar sesiones; D - Depender de abstracciones.
// DEPENDENCIAS: InterfazAlmacenarUsuarios e InterfazAlmacenarSesiones.
// PISTA: No recibe HTTP ni construye repositorios con new.
// PENDIENTE: US01 y US02 implementarán la lógica de sesión.

using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Respuestas;
using TiendaPC.Usuarios.Solicitudes;

namespace TiendaPC.Usuarios.Servicios;

public class ServicioGestionarSesion : InterfazGestionarSesion
{
    private readonly InterfazAlmacenarUsuarios _almacenamientoUsuarios;
    private readonly InterfazAlmacenarSesiones _almacenamientoSesiones;

    public ServicioGestionarSesion(
        InterfazAlmacenarUsuarios almacenamientoUsuarios,
        InterfazAlmacenarSesiones almacenamientoSesiones)
    {
        _almacenamientoUsuarios = almacenamientoUsuarios;
        _almacenamientoSesiones = almacenamientoSesiones;
    }

    public RespuestaSesionUsuario IniciarSesion(SolicitudIniciarSesion solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01: validar credenciales, crear sesión y asignar perfil.
        throw new NotImplementedException();
    }

    public void CerrarSesion(SolicitudCerrarSesion solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US02: cerrar la sesión solicitada.
        throw new NotImplementedException();
    }
}
