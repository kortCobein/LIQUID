// TIPO: Interfaz de repositorio.
// PROPÓSITO: Definir el acceso futuro a la fuente única de carritos.
// POO: Abstrae el mecanismo de almacenamiento de los modelos.
// SOLID PRINCIPAL: O - Abierto/Cerrado; D - Inversión de Dependencias.
// DEPENDENCIAS: ModeloCarritoCompra.
// PISTA: Otro repositorio podrá sustituir al almacenamiento en memoria.
// PENDIENTE: Implementar la persistencia durante US09, US10 y US12.

using TiendaPC.Carrito.Modelos;

namespace TiendaPC.Carrito.Interfaces;

public interface InterfazAlmacenarCarritos
{
    IReadOnlyList<ModeloCarritoCompra> ConsultarCarritos();
    IReadOnlyList<ModeloCarritoCompra> ConsultarCarritosPorUsuario(Guid idUsuario);
    ModeloCarritoCompra? ConsultarCarritoPorId(Guid idCarrito);
    ModeloCarritoCompra? ConsultarCarritoPersonal(Guid idUsuario);
    void GuardarCarrito(ModeloCarritoCompra carrito);
    void ActualizarCarrito(ModeloCarritoCompra carrito);
}
