// TIPO: Servicio.
// PROPÓSITO: Preparar las operaciones de administración de productos.
// POO: Composición y constructor explícito para recibir el repositorio abstracto.
// SOLID PRINCIPAL: S - Administración de productos. D - Depende de una interfaz.
// DEPENDENCIAS: InterfazAlmacenarProductos, solicitudes y respuesta de productos.
// PISTA: Aquí vivirán las reglas; no recibe HTTP ni crea repositorios.
// PENDIENTE: Implementar las operaciones de US06, US07 y US08.

using TiendaPC.Productos.Interfaces;
using TiendaPC.Productos.Solicitudes;

namespace TiendaPC.Productos;

public class ServicioAdministrarProductos : InterfazAdministrarProductos
{
    private readonly InterfazAlmacenarProductos _almacenamientoProductos;

    public ServicioAdministrarProductos(InterfazAlmacenarProductos almacenamientoProductos)
    {
        _almacenamientoProductos = almacenamientoProductos;
    }

    public RespuestaInformacionProducto RegistrarProducto(SolicitudRegistrarProducto solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el registro de productos durante US06.
        throw new NotImplementedException();
    }

    public RespuestaInformacionProducto ModificarProducto(Guid idProducto, SolicitudModificarProducto solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la modificación de productos durante US07.
        throw new NotImplementedException();
    }

    public void EliminarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la eliminación de productos durante US08.
        throw new NotImplementedException();
    }

    public RespuestaInformacionProducto? ConsultarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta administrativa durante las historias de productos.
        throw new NotImplementedException();
    }

    public IReadOnlyList<RespuestaInformacionProducto> ConsultarProductos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el listado administrativo durante las historias de productos.
        throw new NotImplementedException();
    }
}
