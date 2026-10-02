// TIPO: Solicitud HTTP.
// PROPÓSITO: Recibir la nueva cantidad de una línea del carrito.
// POO: Representa la entrada como un objeto con constructor explícito.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: Ninguna dependencia de reglas del carrito.
// PISTA: Usuario y producto llegan por la ruta; la cantidad llega por JSON.
// PENDIENTE: Validar y aplicar la cantidad durante US10.

namespace TiendaPC.Carrito.Solicitudes;

public class SolicitudCambiarCantidadCarrito
{
    public int Cantidad { get; set; }

    public SolicitudCambiarCantidadCarrito()
    {
    }
}
