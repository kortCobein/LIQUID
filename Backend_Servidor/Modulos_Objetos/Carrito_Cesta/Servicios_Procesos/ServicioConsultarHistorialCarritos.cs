// TIPO: Servicio de consulta.
// PROPÓSITO: Preparar la consulta futura de carritos y sus detalles.
// POO: Compone una dependencia recibida por constructor explícito.
// SOLID PRINCIPAL: S - Responsabilidad Única; D - Inversión de Dependencias.
// DEPENDENCIAS: InterfazAlmacenarCarritos.
// PISTA: Consulta la misma fuente que utiliza el carrito personal.
// PENDIENTE: Implementar el historial durante US12.

using TiendaPC.Carrito.Interfaces;
using TiendaPC.Carrito.Respuestas;

namespace TiendaPC.Carrito.Servicios;

public class ServicioConsultarHistorialCarritos : InterfazConsultarHistorialCarritos
{
    private readonly InterfazAlmacenarCarritos _almacenamientoCarritos;

    public ServicioConsultarHistorialCarritos(InterfazAlmacenarCarritos almacenamientoCarritos)
    {
        _almacenamientoCarritos = almacenamientoCarritos;
    }

    public IReadOnlyList<RespuestaHistorialCarrito> ConsultarHistorialCarritos()
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public IReadOnlyList<RespuestaHistorialCarrito> ConsultarHistorialCarritosPorUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }

    public RespuestaDetalleCarrito? ConsultarDetalleCarrito(Guid idCarrito)
    {
        // TODO: Implementar durante la historia de usuario correspondiente.
        throw new NotImplementedException();
    }
}
