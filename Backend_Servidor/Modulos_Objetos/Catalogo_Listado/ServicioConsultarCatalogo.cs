// TIPO: Servicio.
// PROPÓSITO: Preparar las consultas y la presentación de productos del catálogo.
// POO: Composición e inyección mediante un constructor explícito.
// SOLID PRINCIPAL: S - Consulta del catálogo. D - Depende del almacén abstracto.
// DEPENDENCIAS: InterfazAlmacenarProductos, solicitudes y respuestas del catálogo.
// PISTA: Reutiliza la fuente de productos y no mantiene otra lista propia.
// PENDIENTE: Implementar la lógica durante US03, US04 y US05.

using TiendaPC.Catalogo.Respuestas;
using TiendaPC.Catalogo.Solicitudes;
using TiendaPC.Productos.Interfaces;

namespace TiendaPC.Catalogo;

public class ServicioConsultarCatalogo : InterfazConsultarCatalogo
{
    private readonly InterfazAlmacenarProductos _almacenamientoProductos;

    public ServicioConsultarCatalogo(InterfazAlmacenarProductos almacenamientoProductos)
    {
        _almacenamientoProductos = almacenamientoProductos;
    }

    public IReadOnlyList<RespuestaProductoCatalogo> ObtenerCatalogo()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta del catálogo durante US03.
        throw new NotImplementedException();
    }

    public IReadOnlyList<RespuestaProductoCatalogo> BuscarProductos(SolicitudBuscarCatalogo solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la búsqueda de productos durante US03.
        throw new NotImplementedException();
    }

    public IReadOnlyList<RespuestaProductoCatalogo> FiltrarProductos(SolicitudFiltrarCatalogo solicitud)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el filtrado por categoría durante US04.
        throw new NotImplementedException();
    }

    public RespuestaCategoriasCatalogo ObtenerCategoriasDisponibles()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de categorías disponibles durante US04.
        throw new NotImplementedException();
    }

    public RespuestaDetalleProducto? ConsultarDetalleProducto(Guid idProducto)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. Alcance: el detalle de un producto durante US05.
        throw new NotImplementedException();
    }
}
