// TIPO: Interfaz de consulta.
// PROPÓSITO: Definir las futuras consultas públicas del catálogo.
// POO: Abstracción para sustituir el servicio mediante polimorfismo.
// SOLID PRINCIPAL: I - Contrato específico para consultar productos existentes.
// DEPENDENCIAS: Solicitudes y respuestas del catálogo.
// PISTA: El catálogo presenta productos; no define otra fuente de almacenamiento.
// PENDIENTE: Implementar las consultas durante US03, US04 y US05.

using TiendaPC.Catalogo.Respuestas;
using TiendaPC.Catalogo.Solicitudes;

namespace TiendaPC.Catalogo;

public interface InterfazConsultarCatalogo
{
    IReadOnlyList<RespuestaProductoCatalogo> ObtenerCatalogo();
    IReadOnlyList<RespuestaProductoCatalogo> BuscarProductos(SolicitudBuscarCatalogo solicitud);
    IReadOnlyList<RespuestaProductoCatalogo> FiltrarProductos(SolicitudFiltrarCatalogo solicitud);
    RespuestaCategoriasCatalogo ObtenerCategoriasDisponibles();
    RespuestaDetalleProducto? ConsultarDetalleProducto(Guid idProducto);
}
