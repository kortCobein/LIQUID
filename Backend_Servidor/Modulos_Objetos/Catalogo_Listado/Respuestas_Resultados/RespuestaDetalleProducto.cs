// TIPO: Respuesta.
// PROPÓSITO: Preparar la información completa del detalle público de un producto.
// POO: Objeto de salida con propiedades para serializar JSON.
// SOLID PRINCIPAL: S - Presentación del detalle de un producto existente.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: No guarda un producto adicional ni realiza consultas por sí mismo.
// PENDIENTE: Construir el detalle durante US05.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Catalogo.Respuestas;

public class RespuestaDetalleProducto
{
    public Guid IdProducto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int CantidadDisponible { get; set; }
    public EnumeracionCategoriaProducto Categoria { get; set; }
    public string UrlImagen { get; set; } = string.Empty;
}
