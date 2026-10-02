// TIPO: Respuesta.
// PROPÓSITO: Preparar las categorías que se podrán mostrar para filtrar el catálogo.
// POO: Composición de una respuesta con una colección de valores de categoría.
// SOLID PRINCIPAL: S - Presentación de categorías disponibles.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: Esta colección de salida no es otra fuente de productos.
// PENDIENTE: Determinar las categorías disponibles durante US04.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Catalogo.Respuestas;

public class RespuestaCategoriasCatalogo
{
    public IReadOnlyList<EnumeracionCategoriaProducto> Categorias { get; set; } = Array.Empty<EnumeracionCategoriaProducto>();
}
