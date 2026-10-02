// TIPO: Interfaz.
// PROPÓSITO: Preparar el almacenamiento futuro de sesiones.
// POO: Abstracción que permite sustituir el almacén.
// SOLID PRINCIPAL: I - Contrato específico de sesiones.
// DEPENDENCIAS: ModeloSesion.
// PISTA: No obliga a usar JWT, Identity ni una base de datos.
// PENDIENTE: US01 y US02 implementarán el ciclo de sesión.

using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios.Interfaces;

public interface InterfazAlmacenarSesiones
{
    ModeloSesion? ObtenerSesion(Guid idSesion);
    void GuardarSesion(ModeloSesion sesion);
    void EliminarSesion(Guid idSesion);
}
