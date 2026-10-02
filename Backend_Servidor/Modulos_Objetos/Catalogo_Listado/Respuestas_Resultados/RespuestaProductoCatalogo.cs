// TIPO: Respuesta.
// PROPÓSITO: Preparar los datos resumidos de un producto en el catálogo.
// POO: Objeto de salida diferente del modelo del repositorio.
// SOLID PRINCIPAL: S - Presentación resumida de un producto.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: Los datos se construirán desde la única fuente de productos.
// PENDIENTE: Producir esta respuesta durante US03 y US04.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Catalogo.Respuestas;

public class RespuestaProductoCatalogo
{
    public Guid IdProducto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public EnumeracionCategoriaProducto Categoria { get; set; }
    public string UrlImagen { get; set; } = string.Empty;
}
