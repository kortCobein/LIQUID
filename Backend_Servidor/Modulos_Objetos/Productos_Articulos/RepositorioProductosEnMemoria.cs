// TIPO: Repositorio.
// PROPÓSITO: Preparar la única colección de productos del sistema.
// POO: Constructor explícito, colección privada y contrato implementado.
// SOLID PRINCIPAL: O - Otro repositorio podrá implementar el mismo contrato.
// DEPENDENCIAS: InterfazAlmacenarProductos y ModeloProducto.
// PISTA: La colección carga datos ficticios; las operaciones siguen pendientes.
// PENDIENTE: Implementar almacenamiento durante las historias de productos y catálogo.

using TiendaPC.Productos.Interfaces;
using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos;

public class RepositorioProductosEnMemoria : InterfazAlmacenarProductos
{
    private readonly List<ModeloProducto> _productos;

    public RepositorioProductosEnMemoria()
    {
        _productos = DatosProductosIniciales.CrearProductos();
    }

    public IReadOnlyList<ModeloProducto> ObtenerProductos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de productos durante US03.
        throw new NotImplementedException();
    }

    public ModeloProducto? ObtenerProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de un producto durante US05.
        throw new NotImplementedException();
    }

    public void GuardarProducto(ModeloProducto producto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el almacenamiento de un producto durante US06.
        throw new NotImplementedException();
    }

    public void ActualizarProducto(ModeloProducto producto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la actualización de un producto durante US07.
        throw new NotImplementedException();
    }

    public void EliminarProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la eliminación de un producto durante US08.
        throw new NotImplementedException();
    }
}
