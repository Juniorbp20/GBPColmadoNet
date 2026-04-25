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
│   ├── InitialData/              <-- Scripts SQL y Datos Semilla
│   └── Models/                   <-- Entidades Scaffolding
├── GBPColmadoNet.UI/             (Capa de Presentación - WinForms)
│   ├── Services/                 <-- Lógica de Reglas de Negocio
│   ├── Forms/                    (Módulos Administrativos)
│   │   ├── Clientes/             
│   │   │   ├── Cliente/          <-- Gestión de Perfiles
│   │   │   └── CuentasPorCobrar/ <-- Control de Créditos y Fíaos
│   │   ├── Configuracion/        <-- Ajustes Globales y Roles
│   │   ├── Historial/            
│   │   │   ├── HClienteList/     <-- Auditoría de Clientes
│   │   │   ├── HProveedorList/   <-- Auditoría de Proveedores
│   │   │   └── HVentasList/      <-- Registro Histórico de Ventas
│   │   ├── Inventario/           
│   │   │   ├── Devoluciones/     <-- Gestión de Mercancía Devuelta
│   │   │   └── ESForm/           <-- Entradas y Salidas de Almacén
│   │   ├── Proveedor/            <-- Registro de Suplidores
│   │   ├── Ventas/               <-- Facturación y Cuadre de Caja
│   │   └── MainForm.cs           <-- Panel Principal Categorizado
│   └── Program.cs                <-- Inyección de Dependencias
└── GBPColmadoNet.Tests/          (Capa de Pruebas Unitarias)
    └── VentaServiceTests.cs      <-- Pruebas de Integridad de Negocio
```

# Tecnologías y Herramientas
**Lenguaje:** C# (.NET 8.0)

**Interfaz:** Windows Forms para una experiencia de escritorio ágil.

**Persistencia:** Entity Framework Core con SQL Server Express.

**Pruebas:** xUnit para asegurar que los cálculos de facturación sean precisos.

# Funcionalidades Clave
**Gestión de Inventario:** Control total sobre entradas y salidas de productos con soporte para códigos de barras.

**Módulo de Ventas:** Interfaz optimizada para el despacho rápido de clientes.

**Control de Créditos (Fíaos):** Seguimiento automatizado de saldos pendientes por cliente con alertas de límite excedido.

**Reportes de Cierre:** Generación de resúmenes diarios de efectivo y ventas a crédito.