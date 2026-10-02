// TIPO: Repositorio en memoria.
// PROPÓSITO: Conservar la única lista de cuentas durante la ejecución.
// POO: Constructor explícito e implementación de una interfaz.
// SOLID PRINCIPAL: S - Almacenar cuentas; O - Implementación sustituible.
// DEPENDENCIAS: InterfazAlmacenarUsuarios y DatosUsuariosIniciales.
// PISTA: Singleton conserva la lista; reiniciar restablece datos ficticios.
// PENDIENTE: US01 y US11 implementarán las operaciones sobre la lista.

using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Repositorios;

public class RepositorioUsuariosEnMemoria : InterfazAlmacenarUsuarios
{
    private readonly List<ModeloUsuario> _usuarios;

    public RepositorioUsuariosEnMemoria()
    {
        _usuarios = DatosUsuariosIniciales.CrearUsuarios();
    }

    public IReadOnlyList<ModeloUsuario> ObtenerUsuarios()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US11: obtener usuarios del almacén.
        throw new NotImplementedException();
    }

    public ModeloUsuario? ObtenerUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01/US11: localizar usuario por identificador.
        throw new NotImplementedException();
    }

    public ModeloUsuario? ObtenerUsuarioPorNombre(string nombreUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01: localizar la cuenta por nombre.
        throw new NotImplementedException();
    }
}
