// TIPO: Interfaz.
// PROPÓSITO: Preparar el acceso a la única fuente de usuarios.
// POO: Abstracción del almacenamiento de cuentas.
// SOLID PRINCIPAL: O - Almacén sustituible; D - Contrato para servicios.
// DEPENDENCIAS: ModeloUsuario.
// PISTA: Todavía no recorre la lista ni compara credenciales.
// PENDIENTE: US01 y US11 implementarán el acceso a cuentas.

using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Interfaces;

public interface InterfazAlmacenarUsuarios
{
    IReadOnlyList<ModeloUsuario> ObtenerUsuarios();
    ModeloUsuario? ObtenerUsuario(Guid idUsuario);
    ModeloUsuario? ObtenerUsuarioPorNombre(string nombreUsuario);
}
