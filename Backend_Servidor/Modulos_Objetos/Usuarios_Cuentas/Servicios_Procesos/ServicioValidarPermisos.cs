// TIPO: Servicio.
// PROPÓSITO: Preparar la futura comprobación de permisos por perfil.
// POO: Constructor explícito y composición con dos almacenes abstractos.
// SOLID PRINCIPAL: S - Validar permisos; D - Depender de interfaces.
// DEPENDENCIAS: InterfazAlmacenarUsuarios e InterfazAlmacenarSesiones.
// PISTA: El rol requerido es una entrada; todavía no existe una política.
// PENDIENTE: US01 definirá y aplicará los permisos de cada perfil.

using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Servicios;

public class ServicioValidarPermisos : InterfazValidarPermisos
{
    private readonly InterfazAlmacenarUsuarios _almacenamientoUsuarios;
    private readonly InterfazAlmacenarSesiones _almacenamientoSesiones;

    public ServicioValidarPermisos(
        InterfazAlmacenarUsuarios almacenamientoUsuarios,
        InterfazAlmacenarSesiones almacenamientoSesiones)
    {
        _almacenamientoUsuarios = almacenamientoUsuarios;
        _almacenamientoSesiones = almacenamientoSesiones;
    }

    public bool TienePermiso(Guid idSesion, EnumeracionRolUsuario rolRequerido)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01: comprobar sesión y permisos del perfil.
        throw new NotImplementedException();
    }
}
