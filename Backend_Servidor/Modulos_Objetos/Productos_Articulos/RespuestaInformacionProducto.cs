// TIPO: Respuesta.
// PROPÓSITO: Preparar la información que devolverá la administración de productos.
// POO: Objeto de salida separado del modelo almacenado.
// SOLID PRINCIPAL: S - Presentación de datos de un producto administrado.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: Los servicios construirán esta respuesta cuando se desarrollen las historias.
// PENDIENTE: Preparar las respuestas funcionales de US06 y US07.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Productos;

public class RespuestaInformacionProducto
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
