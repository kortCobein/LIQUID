// TIPO: Modelo.
// PROPÓSITO: Describir los datos de una futura sesión educativa.
// POO: Constructor explícito y encapsulamiento.
// SOLID PRINCIPAL: S - Representar una sesión.
// DEPENDENCIAS: Identificador de usuario.
// PISTA: Construir el objeto no inicia ni valida una sesión.
// PENDIENTE: US01 creará sesiones y US02 las cerrará.

namespace TiendaPC.Usuarios.Modelos;

public class ModeloSesion
{
    public Guid IdSesion { get; private set; }
    public Guid IdUsuario { get; private set; }
    public DateTimeOffset FechaInicio { get; private set; }

    public ModeloSesion(Guid idSesion, Guid idUsuario, DateTimeOffset fechaInicio)
    {
        IdSesion = idSesion;
        IdUsuario = idUsuario;
        FechaInicio = fechaInicio;
    }
}
