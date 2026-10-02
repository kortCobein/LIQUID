// TIPO: Interfaz.
// PROPÓSITO: Definir consultas futuras de cuentas.
// POO: Abstracción independiente del repositorio concreto.
// SOLID PRINCIPAL: I - Consultas en un contrato específico.
// DEPENDENCIAS: RespuestaInformacionUsuario.
// PISTA: Separa la consulta pública del almacenamiento interno.
// PENDIENTE: US11 implementará estas consultas.

using TiendaPC.Usuarios.Respuestas;

namespace TiendaPC.Usuarios.Interfaces;

public interface InterfazConsultarUsuarios
{
    IReadOnlyList<RespuestaInformacionUsuario> ConsultarUsuarios();
    RespuestaInformacionUsuario? ConsultarUsuario(Guid idUsuario);
}
