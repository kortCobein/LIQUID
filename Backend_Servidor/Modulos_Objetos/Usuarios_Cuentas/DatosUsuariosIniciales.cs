// TIPO: Datos iniciales hardcodeados.
// PROPÓSITO: Crear tres cuentas completamente ficticias al iniciar el almacén.
// POO: Construye objetos ModeloUsuario mediante sus constructores explícitos.
// SOLID PRINCIPAL: S - Definir exclusivamente información inicial.
// DEPENDENCIAS: ModeloUsuario y EnumeracionRolUsuario.
// PISTA: Cada llamada crea datos nuevos; el repositorio conserva la lista.
// PENDIENTE: La autenticación y la consulta pertenecen a US01 y US11.

using TiendaPC.Usuarios.Modelos;

namespace TiendaPC.Usuarios;

public static class DatosUsuariosIniciales
{
    public static List<ModeloUsuario> CrearUsuarios()
    {
        return new List<ModeloUsuario>
        {
            new ModeloUsuario(
                Guid.Parse("20000000-0000-0000-0000-000000000001"),
                "administrador", "Administradora de demostración",
                "administrador@example.invalid", "1234", EnumeracionRolUsuario.Administrador),
            new ModeloUsuario(
                Guid.Parse("20000000-0000-0000-0000-000000000002"),
                "cliente", "Cliente de demostración",
                "cliente@example.invalid", "1234", EnumeracionRolUsuario.Cliente),
            new ModeloUsuario(
                Guid.Parse("20000000-0000-0000-0000-000000000003"),
                "auditor", "Auditor de demostración",
                "auditor@example.invalid", "1234", EnumeracionRolUsuario.Auditor)
        };
    }
}
