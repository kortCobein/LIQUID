// TIPO: Modelo.
// PROPÓSITO: Representar un artículo que se almacenará en el repositorio.
// POO: Constructor explícito y propiedades encapsuladas con private set.
// SOLID PRINCIPAL: S - Representación coherente de un producto.
// DEPENDENCIAS: EnumeracionCategoriaProducto.
// PISTA: El constructor recibe sus datos; todavía no aplica reglas del negocio.
// PENDIENTE: Definir validaciones y cambios del producto durante US06 y US07.

namespace TiendaPC.Productos.Modelos;

public class ModeloProducto
{
    public Guid IdProducto { get; private set; }
    public string Nombre { get; private set; }
    public string Marca { get; private set; }
    public string Descripcion { get; private set; }
    public decimal Precio { get; private set; }
    public int CantidadDisponible { get; private set; }
    public EnumeracionCategoriaProducto Categoria { get; private set; }
    public string UrlImagen { get; private set; }

    public ModeloProducto(
        Guid idProducto,
        string nombre,
        string marca,
        string descripcion,
        decimal precio,
        int cantidadDisponible,
        EnumeracionCategoriaProducto categoria,
        string urlImagen)
    {
        IdProducto = idProducto;
        Nombre = nombre;
        Marca = marca;
        Descripcion = descripcion;
        Precio = precio;
        CantidadDisponible = cantidadDisponible;
        Categoria = categoria;
        UrlImagen = urlImagen;
    }
}
