// TIPO: Punto de entrada y composición de la aplicación.
// PROPÓSITO: Configurar HTTP y mostrar cada relación de Dependency Injection.
// POO: Compone controladores, servicios y repositorios mediante interfaces.
// SOLID PRINCIPAL: D - Inversión de dependencias visible en los registros.
// DEPENDENCIAS: ASP.NET Core, Swagger y los cuatro módulos.
// PISTA: Singleton conserva almacenes; Scoped crea servicios por petición.
// PENDIENTE: Las US01-US12 viven en sus servicios y continúan sin implementar.

using TiendaPC.Carrito;
using TiendaPC.Carrito.Interfaces;
using TiendaPC.Carrito.Servicios;
using TiendaPC.Catalogo;
using TiendaPC.Productos;
using TiendaPC.Productos.Interfaces;
using TiendaPC.Usuarios.Interfaces;
using TiendaPC.Usuarios.Repositorios;
using TiendaPC.Usuarios.Servicios;

var constructorAplicacion = WebApplication.CreateBuilder(args);

constructorAplicacion.Services.AddControllers();
constructorAplicacion.Services.AddEndpointsApiExplorer();
constructorAplicacion.Services.AddSwaggerGen(configuracion =>
{
    configuracion.SwaggerDoc("v1", new()
    {
        Title = "Tienda PC - cimentación educativa",
        Version = "v1",
        Description = "Solo GET /api/estado es funcional. Las US01-US12 están pendientes y sus rutas responden 501."
    });
});

constructorAplicacion.Services.AddCors(configuracion =>
{
    configuracion.AddPolicy("InterfazDesarrollo", politica =>
    {
        politica.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Una instancia de cada almacén conserva sus datos durante la ejecución.
constructorAplicacion.Services.AddSingleton<InterfazAlmacenarProductos, RepositorioProductosEnMemoria>();
constructorAplicacion.Services.AddSingleton<InterfazAlmacenarCarritos, RepositorioCarritosEnMemoria>();
constructorAplicacion.Services.AddSingleton<InterfazAlmacenarUsuarios, RepositorioUsuariosEnMemoria>();
constructorAplicacion.Services.AddSingleton<InterfazAlmacenarSesiones, RepositorioSesionesEnMemoria>();

// Una instancia de cada servicio por petición HTTP, con dependencias por constructor.
constructorAplicacion.Services.AddScoped<InterfazAdministrarProductos, ServicioAdministrarProductos>();
constructorAplicacion.Services.AddScoped<InterfazConsultarCatalogo, ServicioConsultarCatalogo>();
constructorAplicacion.Services.AddScoped<InterfazAdministrarCarrito, ServicioAdministrarCarrito>();
constructorAplicacion.Services.AddScoped<InterfazConsultarHistorialCarritos, ServicioConsultarHistorialCarritos>();
constructorAplicacion.Services.AddScoped<InterfazGestionarSesion, ServicioGestionarSesion>();
constructorAplicacion.Services.AddScoped<InterfazConsultarUsuarios, ServicioConsultarUsuarios>();
constructorAplicacion.Services.AddScoped<InterfazValidarPermisos, ServicioValidarPermisos>();

var aplicacion = constructorAplicacion.Build();

// Construir los Singleton carga los datos iniciales al arrancar, sin ejecutar operaciones de negocio.
aplicacion.Services.GetRequiredService<InterfazAlmacenarProductos>();
aplicacion.Services.GetRequiredService<InterfazAlmacenarCarritos>();
aplicacion.Services.GetRequiredService<InterfazAlmacenarUsuarios>();
aplicacion.Services.GetRequiredService<InterfazAlmacenarSesiones>();

if (aplicacion.Environment.IsDevelopment())
{
    aplicacion.UseSwagger();
    aplicacion.UseSwaggerUI();
}

aplicacion.UseCors("InterfazDesarrollo");
aplicacion.MapControllers();
aplicacion.Run();
