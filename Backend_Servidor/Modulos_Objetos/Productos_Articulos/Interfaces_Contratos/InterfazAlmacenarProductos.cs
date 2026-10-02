// TIPO: Interfaz de almacenamiento.
// PROPÓSITO: Definir las operaciones de la única fuente de productos.
// POO: Abstracción que permite sustituir repositorios mediante polimorfismo.
// SOLID PRINCIPAL: I - Contrato enfocado. D - Dependencia de abstracciones.
// DEPENDENCIAS: ModeloProducto.
// PISTA: Indica qué se puede almacenar, sin decidir cómo hacerlo.
// PENDIENTE: Implementar el contrato durante las historias de productos y catálogo.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos.Interfaces;

public interface InterfazAlmacenarProductos
{
    IReadOnlyList<ModeloProducto> ObtenerProductos();
    ModeloProducto? ObtenerProducto(Guid idProducto);
    void GuardarProducto(ModeloProducto producto);
    void ActualizarProducto(ModeloProducto producto);
    void EliminarProducto(Guid idProducto);
}
