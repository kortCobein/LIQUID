// TIPO: Repositorio en memoria.
// PROPÓSITO: Preparar la única lista de sesiones, inicialmente vacía.
// POO: Constructor explícito y contrato de almacenamiento.
// SOLID PRINCIPAL: S - Almacenar sesiones; O - Implementación sustituible.
// DEPENDENCIAS: InterfazAlmacenarSesiones y ModeloSesion.
// PISTA: No hay sesiones hardcodeadas ni persistencia permanente.
// PENDIENTE: US01 y US02 implementarán las operaciones sobre la lista.

using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Repositorios;

public class RepositorioSesionesEnMemoria : InterfazAlmacenarSesiones
{
    private readonly List<ModeloSesion> _sesiones;

    public RepositorioSesionesEnMemoria()
    {
        _sesiones = new List<ModeloSesion>();
    }

    public ModeloSesion? ObtenerSesion(Guid idSesion)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01/US02: localizar una sesión.
        throw new NotImplementedException();
    }

    public void GuardarSesion(ModeloSesion sesion)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US01: almacenar una sesión.
        throw new NotImplementedException();
    }

    public void EliminarSesion(Guid idSesion)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US02: retirar una sesión.
        throw new NotImplementedException();
    }
}
