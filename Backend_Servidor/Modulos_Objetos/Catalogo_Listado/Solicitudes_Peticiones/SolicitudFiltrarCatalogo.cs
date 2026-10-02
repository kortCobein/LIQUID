// TIPO: Solicitud.
// PROPÓSITO: Preparar los criterios que recibirá el filtro de productos.
// POO: Objeto de entrada separado de los modelos almacenados.
// SOLID PRINCIPAL: S - Representa solamente criterios de filtrado.
// DEPENDENCIAS: EnumeracionCategoriaProducto del módulo de productos.
// PISTA: Los criterios opcionales todavía no aplican ninguna selección.
// PENDIENTE: Implementar el filtro de categoría durante US04.

using TiendaPC.Productos.Modelos;

namespace TiendaPC.Catalogo.Solicitudes;

public class SolicitudFiltrarCatalogo
{
    public EnumeracionCategoriaProducto? Categoria { get; set; }
    public string? Marca { get; set; }
    public decimal? PrecioMinimo { get; set; }
    public decimal? PrecioMaximo { get; set; }
}
