// TIPO: Repositorio en memoria.
// PROPÓSITO: Preparar la fuente única de almacenamiento de carritos.
// POO: Implementa una interfaz y compone una colección privada.
// SOLID PRINCIPAL: O - Abierto/Cerrado; L - Sustitución de Liskov.
// DEPENDENCIAS: InterfazAlmacenarCarritos, ModeloCarritoCompra y DatosCarritosIniciales.
// PISTA: Su instancia Singleton conservará la colección durante la ejecución.
// PENDIENTE: Implementar el almacenamiento durante US09, US10 y US12.

using TiendaPC.Carrito.Interfaces;
using TiendaPC.Carrito.Modelos;

namespace TiendaPC.Carrito;

public class RepositorioCarritosEnMemoria : InterfazAlmacenarCarritos
{
    private readonly List<ModeloCarritoCompra> _carritos;

    public RepositorioCarritosEnMemoria()
    {
        _carritos = DatosCarritosIniciales.CrearCarritos();
    }

    public IReadOnlyList<ModeloCarritoCompra> ConsultarCarritos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public IReadOnlyList<ModeloCarritoCompra> ConsultarCarritosPorUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public ModeloCarritoCompra? ConsultarCarritoPorId(Guid idCarrito)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public ModeloCarritoCompra? ConsultarCarritoPersonal(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public void GuardarCarrito(ModeloCarritoCompra carrito)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public void ActualizarCarrito(ModeloCarritoCompra carrito)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }
}
