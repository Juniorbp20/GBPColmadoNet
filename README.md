# GBPColmadoNet
Sistema de Gestión Integral para Colmados y Pequeños Negocios.

Este sistema ha sido diseñado para centralizar la operación de ventas, inventario y gestión de créditos (fíaos) en negocios de venta al detalle. Utiliza una arquitectura desacoplada para garantizar que la lógica de negocio sea independiente de la interfaz de usuario.

# Arquitectura del Software
La estructura del proyecto sigue un patrón de Arquitectura Multinivel (N-Tier), facilitando el mantenimiento y la escalabilidad del sistema:

# **Estructura de la Solución**
```Plaintext
GBPColmadoNet/
├── GBPColmadoNet.Data/           (Acceso a Datos / Entidades)
│   ├── Context/                  <-- Configuración de EF Core
│   ├── Migrations/              <-- Historial de Migraciones
│   └── Models/                   <-- Entidades del Dominio
├── GBPColmadoNet.UI/             (Capa de Presentación - WinForms)
│   ├── Services/                 <-- Lógica de Reglas de Negocio
│   ├── Forms/                    (Módulos Administrativos)
│   │   ├── LoginForm/            <-- Autenticación de Usuarios
│   │   ├── Clientes/             
│   │   │   ├── Cliente/          <-- Gestión de Perfiles
│   │   │   └── CuentasPorCobrar/ <-- Control de Créditos y Fíaos
│   │   ├── Configuracion/        <-- Usuarios, Roles y Ajustes
│   │   ├── Historial/            
│   │   │   ├── HClienteList/     <-- Auditoría de Clientes
│   │   │   ├── HProveedorList/   <-- Auditoría de Proveedores
│   │   │   └── HVentasList/      <-- Registro Histórico de Ventas
│   │   ├── Inventario/           
│   │   │   ├── FormsInventario/  <-- Productos y Categorías
│   │   │   └── Devoluciones/     <-- Gestión de Mercancía Devuelta
│   │   ├── Proveedor/            <-- Registro de Suplidores
│   │   ├── Ventas/               <-- Facturación, Apertura y Cuadre de Caja
│   │   └── MainForm.cs           <-- Panel Principal Categorizado
│   └── Program.cs                <-- Inyección de Dependencias
└── GBPColmadoNet.Tests/          (Capa de Pruebas Unitarias)
    └── *.cs                     <-- Pruebas de Servicios
```

# Tecnologías y Herramientas
**Lenguaje:** C# (.NET 8.0)

**Interfaz:** Windows Forms para una experiencia de escritorio ágil.

**Persistencia:** Entity Framework Core con SQL Server Express.

**Pruebas:** xUnit para pruebas unitarias de todos los servicios.

# Funcionalidades Clave
**Gestión de Autenticación:** Sistema de login con control de usuarios y roles (Administrador, Empleado).

**Gestión de Inventario:** Control total sobre entradas y salidas de productos con soporte para códigos de barras, categorías y unidades de medida.

**Módulo de Ventas:** Interfaz optimizada para el despacho rápido de clientes con gestión de carrito de compras.

**Control de Caja:** Apertura y cuadre de caja diaria con generación de reportes de cierre.

**Control de Créditos (Fíaos):** Seguimiento automatizado de saldos pendientes por cliente con alertas de límite excedido y sistema de abonos.

**Gestión de Proveedores:** Registro y seguimiento de proveedores con historial de compras.

**Devoluciones:** Control de mercancía devuelta por clientes o proveedores.

**Bitácora:** Registro de auditoría de todas las operaciones del sistema.

**Configuración:** Ajustes globales del negocio incluyendo límites de crédito, moneda y datos de la empresa.