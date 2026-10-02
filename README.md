# Tienda PC

Base estructural y técnica de una tienda educativa de hardware, componentes y periféricos para PC. El equipo de estudiantes desarrollará después las funcionalidades.

**La arquitectura está preparada. Las US01–US12 todavía NO están implementadas.**

El backend es la prioridad. El frontend únicamente comprueba la comunicación con `GET /api/estado`: no presenta catálogo, inicio de sesión, carrito ni administración.

## Tecnologías y requisitos

| Parte | Tecnología utilizada |
| --- | --- |
| Backend | C#, .NET 10, ASP.NET Core Web API, controladores REST y JSON |
| Documentación HTTP | Swashbuckle.AspNetCore 10.2.3, OpenAPI y Swagger UI |
| Frontend | Angular 22.2.1, TypeScript 6.0.3, HTML y CSS |
| Almacenamiento | Cuatro repositorios en memoria con `List<T>` |
| Entorno verificado | SDK .NET 10.0.401, Node.js 24.21.0 y npm 11.19.0 |

Instalar un SDK .NET 10 y una versión de Node compatible con Angular 22. La [tabla oficial de compatibilidad de Angular](https://angular.dev/reference/versions) describe los requisitos del framework. `package-lock.json` conserva las versiones resueltas del frontend; se incluye en el proyecto.

No se utiliza base de datos, Entity Framework, servicios externos ni API de productos de internet. Las dependencias de desarrollo se descargan de NuGet y npm al restaurar; los datos del dominio proceden exclusivamente de nuestros archivos C#.

## Arquitectura y módulos

Una solución `TiendaPC.sln` agrupa el backend `Backend_Servidor/TiendaPC.csproj`. `Frontend_Interfaz` contiene una aplicación Angular independiente dentro de la misma raíz general. No se crearon repositorios Git interiores; `.gitignore` está únicamente en la raíz. La conexión con [kortCobein/LIQUID](https://github.com/kortCobein/LIQUID) se añadió por solicitud posterior del usuario para publicar la cimentación en `main`, conservando el historial existente.

El repositorio de destino ya incluía `LICENSE.md` y `.github/workflows/validar-base.yml`; ambos se conservaron sin modificaciones. No se creó infraestructura de CI/CD nueva durante la cimentación.

| Módulo | Responsabilidad futura | Historias |
| --- | --- | --- |
| `Productos_Articulos` | Representar y administrar productos; ofrecer la fuente única de productos | US06, US07, US08 |
| `Catalogo_Listado` | Consultar, buscar, filtrar y presentar productos del almacén de productos | US03, US04, US05 |
| `Carrito_Cesta` | Administrar carritos personales y consultar carritos históricos | US09, US10, US12 |
| `Usuarios_Cuentas` | Preparar cuentas, perfiles, permisos y sesiones | US01, US02, US11 |

La categoría es una propiedad de `ModeloProducto` del tipo `EnumeracionCategoriaProducto`. Los roles Administrador, Cliente y Auditor están en `EnumeracionRolUsuario`. Ninguno de estos conceptos necesita un módulo adicional en esta etapa.

## Nombres y ubicación de archivos

Los nombres propios se escriben en español, incluidas clases, métodos, propiedades, variables y parámetros. Las carpetas personalizadas combinan dos palabras para enseñar el concepto desde dos formas de nombrarlo: `Interfaces_Contratos`, `Servicios_Procesos`, `Modelos_Objetos`, etc.

Los archivos indican explícitamente su tipo, por ejemplo `ServicioAdministrarProductos.cs` y `SolicitudAgregarProductoCarrito.cs`. Esta redundancia permite reconocer la responsabilidad sin abrir todos los archivos. El nombre del tipo coincide con el nombre del archivo.

Nuestras interfaces comienzan con **`Interfaz`**, no con el prefijo convencional `I`: `InterfazAlmacenarProductos` muestra directamente al estudiante qué está leyendo. Las interfaces propias de .NET o Angular conservan sus nombres estándar, como `IActionResult`, `IReadOnlyList` y `OnInit`.

La regla de agrupación por tipo es:

- Cero archivos: no crear carpeta.
- Un archivo: colocarlo en la raíz lógica del módulo.
- Dos o más archivos realmente relacionados: crear la carpeta correspondiente.

No se divide una clase artificialmente para justificar una carpeta. Un módulo puede tener un archivo directamente en su raíz y varias subcarpetas con más archivos: no es una carpeta creada para alojar exclusivamente ese único archivo.

Carpetas que se dejaron sin crear por esa regla:

| Ubicación | Carpetas omitidas |
| --- | --- |
| `Productos_Articulos` | `Controladores_Manejadores`, `Servicios_Procesos`, `Repositorios_Almacenes`, `Respuestas_Resultados`, `Datos_Iniciales` |
| `Catalogo_Listado` | `Controladores_Manejadores`, `Servicios_Procesos`, `Interfaces_Contratos` |
| `Carrito_Cesta` | `Repositorios_Almacenes`, `Datos_Iniciales` |
| `Usuarios_Cuentas` | `Datos_Iniciales` |
| Raíz backend | Carpeta exclusiva para `ControladorEstadoSistema.cs` |
| Frontend | `Servicios_Procesos` para el único `ServicioEstadoBackend` |

Catálogo tampoco contiene repositorio ni archivo de datos: allí hay **cero** fuentes independientes. Los nombres estándar `Properties`, `src` y `app`, así como `Program.cs`, `appsettings.json`, `launchSettings.json`, `package.json`, `angular.json`, `tsconfig.json` y `main.ts`, se mantienen por las convenciones de las herramientas. `bin`, `obj`, `node_modules`, `dist` y `.angular` son salidas generadas e ignoradas.

Los namespaces son cortos y españoles: `TiendaPC.Productos`, `TiendaPC.Carrito.Interfaces`, `TiendaPC.Usuarios.Modelos`, etc. No necesitan repetir cada palabra del árbol físico.

## Qué representa cada tipo

| Tipo | Papel en esta base |
| --- | --- |
| Controlador | Recibe una petición HTTP, identifica su ruta y prepara la respuesta HTTP. Los controladores de negocio reciben interfaces por constructor y por ahora responden 501. |
| Servicio | Contendrá las reglas de negocio y coordinará almacenes. Sus operaciones pendientes arrojan `NotImplementedException`. |
| Interfaz | Declara qué operaciones ofrece una dependencia, sin determinar cómo se realizan. |
| Repositorio | Conserva la lista del módulo durante la ejecución. Sus consultas y modificaciones todavía están pendientes. |
| Modelo | Representa un objeto del dominio, como producto, usuario o carrito. Sus propiedades están encapsuladas y sus constructores son explícitos. |
| Solicitud | Describe los datos de entrada de una futura petición. No ejecuta reglas. |
| Respuesta | Describe los datos de salida previstos. Separa la representación HTTP del almacenamiento; la respuesta de usuario no incluye contraseña. |
| Datos iniciales | Define únicamente objetos ficticios de arranque. No busca, filtra, autentica ni modifica información. |

Todos los archivos C# propios comienzan con una pista educativa breve que identifica tipo, propósito, POO, principio SOLID, dependencias y pendientes.

## POO, SOLID y constructores

Una **clase** define una estructura; un **objeto** es una instancia de ella. Un **constructor** asigna sus datos iniciales o recibe sus colaboradores. Los modelos utilizan `private set` donde corresponde para explicar el **encapsulamiento**: las propiedades internas no se modifican desde cualquier parte.

`ModeloCarritoCompra` muestra **composición** mediante líneas `ModeloProductoCarrito`. Cada línea guarda solamente identificador de producto, cantidad y precio unitario; no copia el producto completo. La colección se expone como lectura. Los constructores únicamente preparan estructura y datos: no calculan totales ni verifican existencias.

Las interfaces muestran **abstracción** y preparan **polimorfismo**: un servicio podrá trabajar con otra implementación compatible del almacén sin conocer su clase concreta. No se utilizan primary constructors; la recepción y asignación de cada dependencia se puede leer explícitamente.

| Principio SOLID | Preparación concreta |
| --- | --- |
| S — Responsabilidad única | HTTP en controladores, reglas futuras en servicios, almacenamiento en repositorios y datos ficticios en archivos iniciales. |
| O — Abierto/cerrado | En el futuro puede añadirse otro almacén que implemente la misma interfaz sin reescribir el servicio consumidor. |
| L — Sustitución de Liskov | Las implementaciones futuras deberán respetar el contrato para poder sustituirse. Los cuerpos actuales son pendientes explícitos, todavía no implementaciones funcionales. |
| I — Segregación de interfaces | Cada interfaz se enfoca en productos, catálogo, carrito, historial, sesión, usuarios, permisos o un almacén específico. |
| D — Inversión de dependencias | Los servicios reciben interfaces de almacenamiento por constructor; los controladores reciben interfaces de servicios. |

La estructura prepara estos principios; completar los contratos y sus comportamientos forma parte del trabajo del equipo.

## Dependency Injection y duración de objetos

**Dependency Injection (DI)** significa que ASP.NET Core construye y proporciona los colaboradores. Los servicios no hacen `new Repositorio...` y los controladores no hacen `new Servicio...`. `Program.cs` muestra directamente los once registros, sin ocultarlos detrás de extensiones propias.

| Interfaz | Implementación | Duración |
| --- | --- | --- |
| `InterfazAlmacenarProductos` | `RepositorioProductosEnMemoria` | Singleton |
| `InterfazAlmacenarCarritos` | `RepositorioCarritosEnMemoria` | Singleton |
| `InterfazAlmacenarUsuarios` | `RepositorioUsuariosEnMemoria` | Singleton |
| `InterfazAlmacenarSesiones` | `RepositorioSesionesEnMemoria` | Singleton |
| `InterfazAdministrarProductos` | `ServicioAdministrarProductos` | Scoped |
| `InterfazConsultarCatalogo` | `ServicioConsultarCatalogo` | Scoped |
| `InterfazAdministrarCarrito` | `ServicioAdministrarCarrito` | Scoped |
| `InterfazConsultarHistorialCarritos` | `ServicioConsultarHistorialCarritos` | Scoped |
| `InterfazGestionarSesion` | `ServicioGestionarSesion` | Scoped |
| `InterfazConsultarUsuarios` | `ServicioConsultarUsuarios` | Scoped |
| `InterfazValidarPermisos` | `ServicioValidarPermisos` | Scoped |

**Singleton** crea una instancia compartida durante la vida del servidor. Así las futuras modificaciones de las listas podrán conservarse entre peticiones. `Program.cs` resuelve los cuatro almacenes al arrancar para cargar sus datos iniciales. **Scoped** crea una instancia de servicio dentro del ámbito de cada petición HTTP. Los datos iniciales son proveedores estáticos sencillos y no necesitan DI.

Cuando el equipo implemente las modificaciones deberá considerar que las listas Singleton son compartidas entre peticiones; la cimentación no añade todavía reglas de concurrencia ni otra infraestructura.

Los controladores con nombres `Controlador...` llevan `[Controller]` y `[ApiController]` para que MVC los descubra sin exigir el sufijo inglés `Controller`. Sus rutas son explícitas.

## Almacenamiento simulado y datos iniciales

No existe persistencia permanente. Los archivos iniciales definen **con qué datos arranca el sistema**; los repositorios mantienen **esos datos durante la ejecución** dentro de `List<T>`.

| Archivo de origen | Almacén único | Información inicial |
| --- | --- | --- |
| `DatosProductosIniciales.cs` | `RepositorioProductosEnMemoria` | 12 productos ficticios |
| `DatosUsuariosIniciales.cs` | `RepositorioUsuariosEnMemoria` | 3 usuarios ficticios, uno por rol |
| `DatosCarritosIniciales.cs` | `RepositorioCarritosEnMemoria` | 2 carritos históricos ficticios del Cliente |
| Lista vacía en el constructor | `RepositorioSesionesEnMemoria` | 0 sesiones; no existe `DatosSesionesIniciales.cs` |

```text
DatosProductosIniciales.CrearProductos()
    → RepositorioProductosEnMemoria → List<ModeloProducto>
DatosUsuariosIniciales.CrearUsuarios()
    → RepositorioUsuariosEnMemoria → List<ModeloUsuario>
DatosCarritosIniciales.CrearCarritos()
    → RepositorioCarritosEnMemoria → List<ModeloCarritoCompra>
Lista vacía
    → RepositorioSesionesEnMemoria → List<ModeloSesion>
```

Solo cada repositorio conserva la colección correspondiente. El catálogo depende de `InterfazAlmacenarProductos` y no tiene lista, repositorio ni datos propios. Los archivos iniciales producen una lista nueva al construir el almacén; no conservan otra colección global.

Los identificadores son `Guid` fijos para relacionar la información. Productos utilizan `10000000-0000-0000-0000-000000000001` a `...000012`; usuarios utilizan el prefijo `20000000` y terminaciones `001`, `002`, `003`; carritos utilizan `30000000` y terminaciones `001`, `002`. El Cliente es el usuario `...000002`; sus carritos referencian los productos `...000001` y `...000003`. Las fechas de demostración son fijas, del 28 y 29 de septiembre de 2026.

Los usuarios `administrador`, `cliente` y `auditor` tienen la contraseña ficticia `1234` solamente para la actividad educativa. No hay validación de credenciales, sesiones creadas ni autorización. Los precios son inventados para la demostración. `UrlImagen` contiene cadenas de rutas locales propuestas; no se incluyen ni se descargan imágenes en esta fase.

**Cuando se implementen las modificaciones, los cambios existirán solamente mientras el backend esté encendido. Al reiniciar, los datos regresarán al estado hardcodeado original.** Por ahora los métodos que leerán o modificarán las listas continúan pendientes.

## Flujo HTTP y flujos futuros

El flujo técnico que funciona ahora es:

```text
ComponenteAplicacion → ServicioEstadoBackend → HttpClient
    → GET http://localhost:5080/api/estado
    → ControladorEstadoSistema
    → JSON { "estado": "Backend funcionando" }
    → Estado visible en Angular
```

En una futura petición de negocio, el controlador recibirá la solicitud, usará su interfaz de servicio, el servicio aplicará reglas y consultará su interfaz de almacenamiento; después se construirá una respuesta JSON. **Actualmente el controlador se detiene en una respuesta 501 y no invoca el servicio pendiente.** Los siguientes flujos muestran las dependencias preparadas, no funcionalidad implementada.

Catálogo:

```text
Frontend
    ↓
ControladorConsultarCatalogo
    ↓
InterfazConsultarCatalogo
    ↓
ServicioConsultarCatalogo
    ↓
InterfazAlmacenarProductos
    ↓
RepositorioProductosEnMemoria
```

Productos:

```text
ControladorAdministrarProductos
    ↓
InterfazAdministrarProductos
    ↓
ServicioAdministrarProductos
    ↓
InterfazAlmacenarProductos
    ↓
RepositorioProductosEnMemoria
```

Carrito:

```text
ControladorCarritoPersonal
    ↓
InterfazAdministrarCarrito
    ↓
ServicioAdministrarCarrito
    ↓
InterfazAlmacenarCarritos → RepositorioCarritosEnMemoria
InterfazAlmacenarProductos → RepositorioProductosEnMemoria
```

Sesión de usuario:

```text
ControladorSesionUsuario
    ↓
InterfazGestionarSesion
    ↓
ServicioGestionarSesion
    ↓
InterfazAlmacenarUsuarios → RepositorioUsuariosEnMemoria
InterfazAlmacenarSesiones → RepositorioSesionesEnMemoria
```

Historial utiliza `ControladorHistorialCarritos → InterfazConsultarHistorialCarritos → ServicioConsultarHistorialCarritos → InterfazAlmacenarCarritos`. La consulta de cuentas utiliza `ControladorConsultaUsuarios → InterfazConsultarUsuarios → ServicioConsultarUsuarios → InterfazAlmacenarUsuarios`. El servicio de permisos está registrado y preparado, pero no aplica reglas de acceso todavía.

## Estado de las historias

| Historia | Trabajo futuro | Módulo | Estado |
| --- | --- | --- | --- |
| US01 | Inicio de sesión, perfil y permisos | Usuarios_Cuentas | PENDIENTE |
| US02 | Cierre de sesión | Usuarios_Cuentas | PENDIENTE |
| US03 | Catálogo y búsqueda | Catalogo_Listado | PENDIENTE |
| US04 | Filtrado por categoría | Catalogo_Listado | PENDIENTE |
| US05 | Detalle de producto | Catalogo_Listado | PENDIENTE |
| US06 | Registro de producto | Productos_Articulos | PENDIENTE |
| US07 | Modificación de producto | Productos_Articulos | PENDIENTE |
| US08 | Eliminación de producto | Productos_Articulos | PENDIENTE |
| US09 | Agregar artículos al carrito | Carrito_Cesta | PENDIENTE |
| US10 | Consulta, modificación y eliminación de artículos del carrito | Carrito_Cesta | PENDIENTE |
| US11 | Consulta de usuarios registrados | Usuarios_Cuentas | PENDIENTE |
| US12 | Consulta del historial de carritos | Carrito_Cesta | PENDIENTE |

Están implementados la estructura, los modelos, las solicitudes, las respuestas, las interfaces, los constructores, los datos ficticios de arranque, DI, CORS, Swagger y la comunicación técnica de estado. Hay 44 cuerpos de operaciones de servicios/repositorios con `throw new NotImplementedException()` y 22 acciones HTTP de negocio preparadas con respuesta 501. Ninguna historia está resuelta por cargar datos de demostración.

## Rutas preparadas

| Método | Ruta | Historia pendiente |
| --- | --- | --- |
| POST / DELETE | `/api/usuarios/sesion` | US01 / US02 |
| GET | `/api/usuarios` y `/api/usuarios/{idUsuario}` | US11 |
| GET | `/api/catalogo` y `/api/catalogo/buscar` | US03 |
| GET | `/api/catalogo/categorias` y `/api/catalogo/filtrar` | US04 |
| GET | `/api/catalogo/{idProducto}` | US05 |
| POST | `/api/productos` | US06 |
| PUT | `/api/productos/{idProducto}` | US07 |
| DELETE | `/api/productos/{idProducto}` | US08 |
| GET | `/api/productos` y `/api/productos/{idProducto}` | Consulta administrativa futura de productos |
| POST | `/api/carrito/{idUsuario}` | US09 |
| GET / DELETE | `/api/carrito/{idUsuario}` | US10: consultar / vaciar |
| PUT / DELETE | `/api/carrito/{idUsuario}/productos/{idProducto}` | US10: cantidad / quitar |
| GET | `/api/carritos/historial` | US12 |
| GET | `/api/carritos/historial/usuarios/{idUsuario}` | US12 |
| GET | `/api/carritos/historial/{idCarrito}` | US12 |

Las acciones anteriores están preparadas para responder **501 Not Implemented** cuando la petición pasa el enlace y validación de parámetros del framework. Los identificadores de ruta utilizan la restricción `:guid`. No se verifican como historias funcionales en esta fase.

## Arrancar el backend

Desde la raíz `TiendaPC`:

```powershell
dotnet restore
dotnet build
dotnet run --project Backend_Servidor/TiendaPC.csproj --launch-profile ServidorDesarrollo
```

El perfil `ServidorDesarrollo` fija HTTP en el puerto 5080 y el entorno `Development`. Swagger está disponible en ese entorno. Detener el proceso con `Ctrl+C`.

- Backend: [http://localhost:5080](http://localhost:5080).
- Endpoint técnico: [http://localhost:5080/api/estado](http://localhost:5080/api/estado).
- Swagger UI: [http://localhost:5080/swagger](http://localhost:5080/swagger).
- Documento OpenAPI: [http://localhost:5080/swagger/v1/swagger.json](http://localhost:5080/swagger/v1/swagger.json).

Comprobar solamente el estado técnico:

```powershell
Invoke-RestMethod -Uri http://localhost:5080/api/estado
```

Respuesta HTTP 200 esperada:

```json
{"estado":"Backend funcionando"}
```

## Arrancar el frontend

En otra terminal:

```powershell
Set-Location Frontend_Interfaz
npm install
npm run build
npm start -- --host localhost --port 4200
```

Para instalaciones reproducibles posteriores puede utilizarse `npm ci` con el archivo de bloqueo existente. La compilación escribe en `dist/tienda-pc`. Detener el servidor con `Ctrl+C`.

Frontend: [http://localhost:4200](http://localhost:4200).

`servicio-estado-backend.ts` fija `http://localhost:5080`; CORS en `Program.cs` permite `http://localhost:4200`. Mantener sincronizadas ambas URLs y este README si el equipo cambia puertos.

`configuracion-aplicacion.ts` habilita `provideHttpClient()`. El componente consulta una vez el estado al iniciar, muestra «Comprobando conexión...» y después «Backend funcionando» o «Backend no disponible». No existen rutas consumidas de historias de usuario.

## Validación realizada el 2 de octubre de 2026

| Verificación real | Resultado |
| --- | --- |
| `dotnet restore` desde la raíz | Correcto, código de salida 0 |
| `dotnet build` desde la raíz | Correcto, código de salida 0, cero advertencias y cero errores |
| `npm install` | Correcto, código de salida 0; dependencias instaladas y archivo de bloqueo incluido |
| `npm run build` | Correcto, código de salida 0; bundle inicial de 123.57 kB |
| Inicio temporal del backend | Correcto en `http://localhost:5080`, entorno Development |
| `GET /api/estado` | HTTP 200, JSON `{"estado":"Backend funcionando"}` |
| CORS en `/api/estado` con origen Angular | `Access-Control-Allow-Origin: http://localhost:4200` |
| Swagger y documento OpenAPI | HTTP 200; controladores reconocidos y respuestas 501 documentadas para las 22 acciones de negocio |
| Inicio temporal de Angular y apertura en navegador | El navegador mostró «Estado del servidor: Backend funcionando» |
| Revisión estructural | 57 C# propios con cabeceras educativas, 11 interfaces backend `Interfaz...`, sin carpetas propias creadas para un único archivo |

Se comprobó la integración real del frontend con `/api/estado`. No se crearon tests automatizados ni se ejecutaron historias como funcionalidades completas.

## Posibles evoluciones futuras

El siguiente paso del equipo es implementar US01–US12 en las operaciones señaladas y conectar cada controlador con su servicio. Los modelos podrán recibir métodos explícitos para modificar su estado respetando encapsulamiento; los repositorios podrán implementar consultas y cambios sobre sus listas, y los servicios las reglas y transformación de respuestas.

La infraestructura futura podrá sustituir un repositorio a través de su interfaz cuando el equipo lo decida. En esta base no se adelantan base de datos, autenticación real, JWT, Identity, OAuth, pagos, pedidos, facturación, proveedores, favoritos, Docker, CI/CD, microservicios ni caché distribuida.

## Árbol real y archivos creados

```text
TiendaPC/
├── .github/
│   └── workflows/
│       └── validar-base.yml
├── Backend_Servidor/
│   ├── Modulos_Objetos/
│   │   ├── Carrito_Cesta/
│   │   │   ├── Controladores_Manejadores/
│   │   │   │   ├── ControladorCarritoPersonal.cs
│   │   │   │   └── ControladorHistorialCarritos.cs
│   │   │   ├── Interfaces_Contratos/
│   │   │   │   ├── InterfazAdministrarCarrito.cs
│   │   │   │   ├── InterfazAlmacenarCarritos.cs
│   │   │   │   └── InterfazConsultarHistorialCarritos.cs
│   │   │   ├── Modelos_Objetos/
│   │   │   │   ├── ModeloCarritoCompra.cs
│   │   │   │   └── ModeloProductoCarrito.cs
│   │   │   ├── Respuestas_Resultados/
│   │   │   │   ├── RespuestaDetalleCarrito.cs
│   │   │   │   ├── RespuestaHistorialCarrito.cs
│   │   │   │   └── RespuestaResumenCarrito.cs
│   │   │   ├── Servicios_Procesos/
│   │   │   │   ├── ServicioAdministrarCarrito.cs
│   │   │   │   └── ServicioConsultarHistorialCarritos.cs
│   │   │   ├── Solicitudes_Peticiones/
│   │   │   │   ├── SolicitudAgregarProductoCarrito.cs
│   │   │   │   └── SolicitudCambiarCantidadCarrito.cs
│   │   │   ├── DatosCarritosIniciales.cs
│   │   │   └── RepositorioCarritosEnMemoria.cs
│   │   ├── Catalogo_Listado/
│   │   │   ├── Respuestas_Resultados/
│   │   │   │   ├── RespuestaCategoriasCatalogo.cs
│   │   │   │   ├── RespuestaDetalleProducto.cs
│   │   │   │   └── RespuestaProductoCatalogo.cs
│   │   │   ├── Solicitudes_Peticiones/
│   │   │   │   ├── SolicitudBuscarCatalogo.cs
│   │   │   │   └── SolicitudFiltrarCatalogo.cs
│   │   │   ├── ControladorConsultarCatalogo.cs
│   │   │   ├── InterfazConsultarCatalogo.cs
│   │   │   └── ServicioConsultarCatalogo.cs
│   │   ├── Productos_Articulos/
│   │   │   ├── Interfaces_Contratos/
│   │   │   │   ├── InterfazAdministrarProductos.cs
│   │   │   │   └── InterfazAlmacenarProductos.cs
│   │   │   ├── Modelos_Objetos/
│   │   │   │   ├── EnumeracionCategoriaProducto.cs
│   │   │   │   └── ModeloProducto.cs
│   │   │   ├── Solicitudes_Peticiones/
│   │   │   │   ├── SolicitudModificarProducto.cs
│   │   │   │   └── SolicitudRegistrarProducto.cs
│   │   │   ├── ControladorAdministrarProductos.cs
│   │   │   ├── DatosProductosIniciales.cs
│   │   │   ├── RepositorioProductosEnMemoria.cs
│   │   │   ├── RespuestaInformacionProducto.cs
│   │   │   └── ServicioAdministrarProductos.cs
│   │   └── Usuarios_Cuentas/
│   │       ├── Controladores_Manejadores/
│   │       │   ├── ControladorConsultaUsuarios.cs
│   │       │   └── ControladorSesionUsuario.cs
│   │       ├── Interfaces_Contratos/
│   │       │   ├── InterfazAlmacenarSesiones.cs
│   │       │   ├── InterfazAlmacenarUsuarios.cs
│   │       │   ├── InterfazConsultarUsuarios.cs
│   │       │   ├── InterfazGestionarSesion.cs
│   │       │   └── InterfazValidarPermisos.cs
│   │       ├── Modelos_Objetos/
│   │       │   ├── EnumeracionRolUsuario.cs
│   │       │   ├── ModeloSesion.cs
│   │       │   └── ModeloUsuario.cs
│   │       ├── Repositorios_Almacenes/
│   │       │   ├── RepositorioSesionesEnMemoria.cs
│   │       │   └── RepositorioUsuariosEnMemoria.cs
│   │       ├── Respuestas_Resultados/
│   │       │   ├── RespuestaInformacionUsuario.cs
│   │       │   └── RespuestaSesionUsuario.cs
│   │       ├── Servicios_Procesos/
│   │       │   ├── ServicioConsultarUsuarios.cs
│   │       │   ├── ServicioGestionarSesion.cs
│   │       │   └── ServicioValidarPermisos.cs
│   │       ├── Solicitudes_Peticiones/
│   │       │   ├── SolicitudCerrarSesion.cs
│   │       │   └── SolicitudIniciarSesion.cs
│   │       └── DatosUsuariosIniciales.cs
│   ├── Properties/
│   │   └── launchSettings.json
│   ├── appsettings.json
│   ├── ControladorEstadoSistema.cs
│   ├── Program.cs
│   └── TiendaPC.csproj
├── Frontend_Interfaz/
│   ├── src/
│   │   ├── app/
│   │   │   ├── componente-aplicacion.html
│   │   │   ├── componente-aplicacion.ts
│   │   │   ├── configuracion-aplicacion.ts
│   │   │   └── servicio-estado-backend.ts
│   │   ├── estilos.css
│   │   ├── index.html
│   │   └── main.ts
│   ├── angular.json
│   ├── package-lock.json
│   ├── package.json
│   ├── tsconfig.app.json
│   └── tsconfig.json
├── .gitignore
├── LICENSE.md
├── README.md
└── TiendaPC.sln
```

El árbol lista todos los archivos de código, configuración y documentación, incluida la licencia y el flujo de validación preexistentes conservados del repositorio. Se omiten los metadatos internos de Git y los archivos generados dentro de `bin`, `obj`, `node_modules`, `dist` y `.angular`, que permanecen en disco como resultados de restauración y compilación y están ignorados. No hay archivos de tests.

## Inventario exacto de TODO del equipo

Cada entrada corresponde a un comentario real del código e identifica archivo, método, línea y texto literal. Las interfaces declaran contratos y no necesitan cuerpos ni TODO adicionales. Las pistas `PENDIENTE` de las cabeceras explican la historia relacionada; las 66 entradas siguientes señalan las operaciones concretas.

### Backend_Servidor/Modulos_Objetos/Carrito_Cesta/Controladores_Manejadores/ControladorCarritoPersonal.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 31 | `ConsultarCarritoPersonal` | TODO: Implementar durante la historia de usuario correspondiente. |
| 38 | `AgregarProductoCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 45 | `CambiarCantidadCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 52 | `QuitarProductoCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 59 | `VaciarCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |

### Backend_Servidor/Modulos_Objetos/Carrito_Cesta/Controladores_Manejadores/ControladorHistorialCarritos.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 30 | `ConsultarHistorialCarritos` | TODO: Implementar durante la historia de usuario correspondiente. |
| 37 | `ConsultarHistorialCarritosPorUsuario` | TODO: Implementar durante la historia de usuario correspondiente. |
| 44 | `ConsultarDetalleCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |

### Backend_Servidor/Modulos_Objetos/Carrito_Cesta/RepositorioCarritosEnMemoria.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ConsultarCarritos` | TODO: Implementar durante la historia de usuario correspondiente. |
| 31 | `ConsultarCarritosPorUsuario` | TODO: Implementar durante la historia de usuario correspondiente. |
| 37 | `ConsultarCarritoPorId` | TODO: Implementar durante la historia de usuario correspondiente. |
| 43 | `ConsultarCarritoPersonal` | TODO: Implementar durante la historia de usuario correspondiente. |
| 49 | `GuardarCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 55 | `ActualizarCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |

### Backend_Servidor/Modulos_Objetos/Carrito_Cesta/Servicios_Procesos/ServicioAdministrarCarrito.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 31 | `ConsultarCarritoPersonal` | TODO: Implementar durante la historia de usuario correspondiente. |
| 37 | `AgregarProductoCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 43 | `CambiarCantidadCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 49 | `QuitarProductoCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 55 | `VaciarCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 61 | `CalcularSubtotalProducto` | TODO: Implementar durante la historia de usuario correspondiente. |
| 67 | `CalcularTotalCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |
| 73 | `VerificarProducto` | TODO: Implementar durante la historia de usuario correspondiente. |
| 79 | `VerificarCantidad` | TODO: Implementar durante la historia de usuario correspondiente. |

### Backend_Servidor/Modulos_Objetos/Carrito_Cesta/Servicios_Procesos/ServicioConsultarHistorialCarritos.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ConsultarHistorialCarritos` | TODO: Implementar durante la historia de usuario correspondiente. |
| 31 | `ConsultarHistorialCarritosPorUsuario` | TODO: Implementar durante la historia de usuario correspondiente. |
| 37 | `ConsultarDetalleCarrito` | TODO: Implementar durante la historia de usuario correspondiente. |

### Backend_Servidor/Modulos_Objetos/Catalogo_Listado/ControladorConsultarCatalogo.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 30 | `ObtenerCatalogo` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de catálogo durante US03. |
| 37 | `ConsultarDetalleProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de detalle durante US05. |
| 44 | `ObtenerCategoriasDisponibles` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de categorías durante US04. |
| 51 | `BuscarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de búsqueda durante US03. |
| 58 | `FiltrarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de filtrado durante US04. |

### Backend_Servidor/Modulos_Objetos/Catalogo_Listado/ServicioConsultarCatalogo.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 26 | `ObtenerCatalogo` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta del catálogo durante US03. |
| 32 | `BuscarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la búsqueda de productos durante US03. |
| 38 | `FiltrarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el filtrado por categoría durante US04. |
| 44 | `ObtenerCategoriasDisponibles` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de categorías disponibles durante US04. |
| 50 | `ConsultarDetalleProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el detalle de un producto durante US05. |

### Backend_Servidor/Modulos_Objetos/Productos_Articulos/ControladorAdministrarProductos.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 31 | `RegistrarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de registro durante US06. |
| 38 | `ModificarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de modificación durante US07. |
| 45 | `EliminarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la ruta de eliminación durante US08. |
| 52 | `ConsultarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta administrativa durante las historias de productos. |
| 59 | `ConsultarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el listado administrativo durante las historias de productos. |

### Backend_Servidor/Modulos_Objetos/Productos_Articulos/RepositorioProductosEnMemoria.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ObtenerProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de productos durante US03. |
| 31 | `ObtenerProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta de un producto durante US05. |
| 37 | `GuardarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el almacenamiento de un producto durante US06. |
| 43 | `ActualizarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la actualización de un producto durante US07. |
| 49 | `EliminarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la eliminación de un producto durante US08. |

### Backend_Servidor/Modulos_Objetos/Productos_Articulos/ServicioAdministrarProductos.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `RegistrarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el registro de productos durante US06. |
| 31 | `ModificarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la modificación de productos durante US07. |
| 37 | `EliminarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la eliminación de productos durante US08. |
| 43 | `ConsultarProducto` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: la consulta administrativa durante las historias de productos. |
| 49 | `ConsultarProductos` | TODO: Implementar durante la historia de usuario correspondiente. Alcance: el listado administrativo durante las historias de productos. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Controladores_Manejadores/ControladorConsultaUsuarios.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 30 | `ConsultarUsuarios` | TODO: Implementar durante la historia de usuario correspondiente. US11: conectar la consulta de usuarios con su servicio. |
| 38 | `ConsultarUsuario` | TODO: Implementar durante la historia de usuario correspondiente. US11: conectar la consulta de un usuario con su servicio. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Controladores_Manejadores/ControladorSesionUsuario.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 31 | `IniciarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US01: conectar la ruta con el servicio de inicio. |
| 39 | `CerrarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US02: conectar la ruta con el servicio de cierre. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Repositorios_Almacenes/RepositorioSesionesEnMemoria.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ObtenerSesion` | TODO: Implementar durante la historia de usuario correspondiente. US01/US02: localizar una sesión. |
| 31 | `GuardarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US01: almacenar una sesión. |
| 37 | `EliminarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US02: retirar una sesión. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Repositorios_Almacenes/RepositorioUsuariosEnMemoria.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ObtenerUsuarios` | TODO: Implementar durante la historia de usuario correspondiente. US11: obtener usuarios del almacén. |
| 31 | `ObtenerUsuario` | TODO: Implementar durante la historia de usuario correspondiente. US01/US11: localizar usuario por identificador. |
| 37 | `ObtenerUsuarioPorNombre` | TODO: Implementar durante la historia de usuario correspondiente. US01: localizar la cuenta por nombre. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Servicios_Procesos/ServicioConsultarUsuarios.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 25 | `ConsultarUsuarios` | TODO: Implementar durante la historia de usuario correspondiente. US11: consultar usuarios y preparar respuestas públicas. |
| 31 | `ConsultarUsuario` | TODO: Implementar durante la historia de usuario correspondiente. US11: consultar la información de un usuario. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Servicios_Procesos/ServicioGestionarSesion.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 30 | `IniciarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US01: validar credenciales, crear sesión y asignar perfil. |
| 36 | `CerrarSesion` | TODO: Implementar durante la historia de usuario correspondiente. US02: cerrar la sesión solicitada. |

### Backend_Servidor/Modulos_Objetos/Usuarios_Cuentas/Servicios_Procesos/ServicioValidarPermisos.cs

| Línea | Método pendiente | TODO literal |
| --- | --- | --- |
| 29 | `TienePermiso` | TODO: Implementar durante la historia de usuario correspondiente. US01: comprobar sesión y permisos del perfil. |
