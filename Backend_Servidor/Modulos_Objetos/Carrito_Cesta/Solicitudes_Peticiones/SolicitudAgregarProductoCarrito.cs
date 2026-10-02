// TIPO: Solicitud HTTP.
// PROPÓSITO: Recibir los datos necesarios para agregar un producto al carrito.
// POO: Agrupa propiedades de entrada en un objeto con constructor explícito.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: Ninguna dependencia del almacenamiento.
// PISTA: El usuario se identifica mediante la ruta; el cuerpo describe la línea.
// PENDIENTE: Validar y procesar estos datos durante US09.

namespace TiendaPC.Carrito.Solicitudes;

public class SolicitudAgregarProductoCarrito
{
    public Guid IdProducto { get; set; }
    public int Cantidad { get; set; }

    public SolicitudAgregarProductoCarrito()
    {
    }
}
