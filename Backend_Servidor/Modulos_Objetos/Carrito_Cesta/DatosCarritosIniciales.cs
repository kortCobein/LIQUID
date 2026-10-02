// TIPO: Datos iniciales hardcodeados.
// PROPÓSITO: Crear dos carritos históricos ficticios para el trabajo posterior.
// POO: Construye objetos que componen sus propias líneas de productos.
// SOLID PRINCIPAL: S - Responsabilidad Única.
// DEPENDENCIAS: ModeloCarritoCompra y ModeloProductoCarrito.
// PISTA: Solo define valores iniciales; el repositorio conserva la lista en memoria.
// PENDIENTE: Desarrollar la consulta del historial durante US12, fuera de este archivo.

using TiendaPC.Carrito.Modelos;

namespace TiendaPC.Carrito;

public static class DatosCarritosIniciales
{
    public static List<ModeloCarritoCompra> CrearCarritos()
    {
        return new List<ModeloCarritoCompra>
        {
            new ModeloCarritoCompra(
                new Guid("30000000-0000-0000-0000-000000000001"),
                new Guid("20000000-0000-0000-0000-000000000002"),
                new DateTimeOffset(2026, 9, 28, 10, 0, 0, TimeSpan.FromHours(-6)),
                new[]
                {
                    new ModeloProductoCarrito(
                        new Guid("10000000-0000-0000-0000-000000000001"),
                        1,
                        7499m)
                }),
            new ModeloCarritoCompra(
                new Guid("30000000-0000-0000-0000-000000000002"),
                new Guid("20000000-0000-0000-0000-000000000002"),
                new DateTimeOffset(2026, 9, 29, 16, 30, 0, TimeSpan.FromHours(-6)),
                new[]
                {
                    new ModeloProductoCarrito(
                        new Guid("10000000-0000-0000-0000-000000000003"),
                        2,
                        8999m)
                })
        };
    }
}
