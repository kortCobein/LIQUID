// TIPO: Interfaz.
// PROPÓSITO: Preparar una futura comprobación de acceso por rol.
// POO: Abstracción de la política de permisos.
// SOLID PRINCIPAL: I - Contrato pequeño y enfocado.
// DEPENDENCIAS: EnumeracionRolUsuario e identificador de sesión.
// PISTA: La cimentación no concede ni deniega permisos.
// PENDIENTE: US01 definirá y aplicará las reglas de acceso.

using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Interfaces;

public interface InterfazValidarPermisos
{
    bool TienePermiso(Guid idSesion, EnumeracionRolUsuario rolRequerido);
}
