// TIPO: Solicitud.
// PROPÓSITO: Preparar los datos que podrá modificar la administración.
// POO: Objeto de entrada independiente del modelo encapsulado.
// SOLID PRINCIPAL: S - Datos correspondientes a la modificación de productos.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: El identificador del producto llegará por la ruta HTTP.
// PENDIENTE: Validar y aplicar modificaciones durante US07.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos.Solicitudes;

public class SolicitudModificarProducto
{
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int CantidadDisponible { get; set; }
    public EnumeracionCategoriaProducto Categoria { get; set; }
    public string UrlImagen { get; set; } = string.Empty;
}
