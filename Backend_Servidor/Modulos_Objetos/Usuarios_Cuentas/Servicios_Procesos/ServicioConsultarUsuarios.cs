// TIPO: Servicio.
// PROPÓSITO: Preparar la consulta de información pública de usuarios.
// POO: Constructor explícito con dependencia abstracta.
// SOLID PRINCIPAL: S - Consultar cuentas; D - Inversión de dependencias.
// DEPENDENCIAS: InterfazAlmacenarUsuarios.
// PISTA: Transformar modelos a respuestas quedará aquí, sin exponer contraseñas.
// PENDIENTE: US11 implementará la consulta de usuarios.

using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Respuestas;

namespace TiendaPC.Usuarios.Servicios;

public class ServicioConsultarUsuarios : InterfazConsultarUsuarios
{
    private readonly InterfazAlmacenarUsuarios _almacenamientoUsuarios;

    public ServicioConsultarUsuarios(InterfazAlmacenarUsuarios almacenamientoUsuarios)
    {
        _almacenamientoUsuarios = almacenamientoUsuarios;
    }

    public IReadOnlyList<RespuestaInformacionUsuario> ConsultarUsuarios()
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US11: consultar usuarios y preparar respuestas públicas.
        throw new NotImplementedException();
    }

    public RespuestaInformacionUsuario? ConsultarUsuario(Guid idUsuario)
    {
        // TODO: Implementar durante la historia de usuario correspondiente. US11: consultar la información de un usuario.
        throw new NotImplementedException();
    }
}
