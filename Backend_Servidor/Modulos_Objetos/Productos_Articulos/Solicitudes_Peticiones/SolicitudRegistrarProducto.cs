// TIPO: Solicitud.
// PROPÓSITO: Describir los datos que recibirá el registro de un producto.
// POO: Objeto de entrada con propiedades para deserializar JSON.
// SOLID PRINCIPAL: S - Agrupa solamente datos del registro.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: Recibir estos datos no equivale a registrar un producto.
// PENDIENTE: Validar y procesar la solicitud durante US06.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos.Solicitudes;

public class SolicitudRegistrarProducto
{
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int CantidadDisponible { get; set; }
    public EnumeracionCategoriaProducto Categoria { get; set; }
    public string UrlImagen { get; set; } = string.Empty;
}
