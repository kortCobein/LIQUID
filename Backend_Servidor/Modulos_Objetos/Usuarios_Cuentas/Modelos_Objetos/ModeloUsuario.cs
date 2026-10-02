// TIPO: Modelo.
// PROPÓSITO: Representar una cuenta ficticia y su perfil.
// POO: Constructor explícito y propiedades encapsuladas.
// SOLID PRINCIPAL: S - Describir una cuenta.
// DEPENDENCIAS: EnumeracionRolUsuario.
// PISTA: Contrasena contiene solamente datos educativos, sin autenticación.
// PENDIENTE: US01 definirá credenciales y permisos; US11 consultará cuentas.

namespace TiendaPC.Usuarios.Modelos;

public class ModeloUsuario
{
    public Guid IdUsuario { get; private set; }
    public string NombreUsuario { get; private set; }
    public string NombreCompleto { get; private set; }
    public string CorreoElectronico { get; private set; }
    public string Contrasena { get; private set; }
    public EnumeracionRolUsuario Rol { get; private set; }

    public ModeloUsuario(
        Guid idUsuario,
        string nombreUsuario,
        string nombreCompleto,
        string correoElectronico,
        string contrasena,
        EnumeracionRolUsuario rol)
    {
        IdUsuario = idUsuario;
        NombreUsuario = nombreUsuario;
        NombreCompleto = nombreCompleto;
        CorreoElectronico = correoElectronico;
        Contrasena = contrasena;
        Rol = rol;
    }
}
