// TIPO: Enumeración.
// PROPÓSITO: Nombrar los tres perfiles previstos del sistema.
// POO: Tipo compartido por modelos y contratos.
// SOLID PRINCIPAL: S - Representar únicamente el rol.
// DEPENDENCIAS: Ninguna.
// PISTA: Un rol describe el perfil; no implementa permisos.
// PENDIENTE: Las reglas de autorización pertenecen a US01.

namespace TiendaPC.Usuarios.Modelos;

public enum EnumeracionRolUsuario
{
    Administrador,
    Cliente,
    Auditor
}
