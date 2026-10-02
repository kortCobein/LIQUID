// TIPO: Solicitud.
// PROPÓSITO: Preparar el texto que recibirá la búsqueda del catálogo.
// POO: Objeto de entrada para parámetros de consulta HTTP.
// SOLID PRINCIPAL: S - Datos correspondientes a una búsqueda.
// DEPENDENCIAS: Ninguna.
// PISTA: Contener el texto no ejecuta la búsqueda ni consulta el repositorio.
// PENDIENTE: Definir y aplicar la búsqueda durante US03.

namespace TiendaPC.Catalogo.Solicitudes;

public class SolicitudBuscarCatalogo
{
    public string Texto { get; set; } = string.Empty;
}
