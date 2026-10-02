# LIQUID

Base de trabajo para el Sprint de una tienda de hardware, componentes y periféricos para PC.

## Estado actual

Este repositorio está en fase de **cimentación**. La arquitectura queda preparada para que el equipo implemente posteriormente las historias de usuario. En esta etapa no se pretende resolver las US01–US12.

## Arquitectura acordada

La solución se dividirá en:

```text
LIQUID/
├── Backend_Servidor/
│   └── Modulos_Objetos/
│       ├── Productos_Articulos/
│       ├── Catalogo_Listado/
│       ├── Carrito_Cesta/
│       └── Usuarios_Cuentas/
├── Frontend_Interfaz/
├── README.md
└── .gitignore
```

Cada módulo puede contener componentes como:

- `Controladores_Manejadores`
- `Servicios_Procesos`
- `Interfaces_Contratos`
- `Modelos_Objetos`
- `Solicitudes_Peticiones`
- `Respuestas_Resultados`
- `Repositorios_Almacenes`

### Regla de carpetas

La organización es intencionalmente explícita:

- 0 archivos de un tipo: no se crea carpeta.
- 1 archivo de un tipo: el archivo queda en la raíz lógica del módulo.
- 2 o más archivos relacionados: se crea la carpeta correspondiente.
- No se divide código artificialmente para justificar una carpeta.

### Regla de nombres

Los nombres de carpetas, archivos, clases, métodos, variables y propiedades propios del proyecto se escribirán en español siempre que el framework no exija otra cosa.

Las carpetas usan nombres dobles para facilitar la lectura, por ejemplo:

- `Productos_Articulos`
- `Carrito_Cesta`
- `Interfaces_Contratos`
- `Servicios_Procesos`

Los archivos profundos deben indicar explícitamente su tipo, por ejemplo:

- `ServicioAdministrarCarrito.cs`
- `InterfazAlmacenarProductos.cs`
- `RepositorioProductosEnMemoria.cs`
- `ModeloCarritoCompra.cs`

En este proyecto las interfaces propias usarán la palabra completa `Interfaz` en lugar del prefijo `I`, por decisión pedagógica.

## Backend

Tecnología prevista:

- C#
- .NET 10
- ASP.NET Core Web API
- REST / JSON
- POO
- SOLID
- Dependency Injection

El almacenamiento será educativo y temporal. Los datos iniciales estarán hardcodeados en archivos como:

- `DatosProductosIniciales.cs`
- `DatosUsuariosIniciales.cs`
- `DatosCarritosIniciales.cs`

Los repositorios cargarán esos datos a colecciones `List<T>` y los cambios existirán únicamente mientras el backend siga encendido.

## Frontend

Angular + TypeScript. Durante la cimentación solo se preparará lo mínimo indispensable para comprobar comunicación con el backend mediante un endpoint técnico como `GET /api/estado`.

## Mapeo de historias

| Módulo | Historias |
|---|---|
| Usuarios_Cuentas | US01, US02, US11 |
| Catalogo_Listado | US03, US04, US05 |
| Productos_Articulos | US06, US07, US08 |
| Carrito_Cesta | US09, US10, US12 |

Todas permanecen pendientes hasta que el equipo las implemente.

## Principios de trabajo

- Controladores: entrada HTTP.
- Servicios: reglas y procesos.
- Interfaces: contratos.
- Repositorios: acceso a datos en memoria.
- Modelos: objetos del dominio.
- Solicitudes: datos que entran.
- Respuestas: datos que salen.
- Los servicios dependen de interfaces, no de implementaciones concretas.
- Las dependencias se reciben mediante constructores explícitos.

## Ramas de trabajo

Las ramas principales del Sprint se separan por área, no por subcarpeta interna:

- `backend-servidor`
- `frontend-interfaz`
- `modulo-productos-articulos`
- `modulo-catalogo-listado`
- `modulo-carrito-cesta`
- `modulo-usuarios-cuentas`

## Estado de las US

US01–US12: **PENDIENTES**.
