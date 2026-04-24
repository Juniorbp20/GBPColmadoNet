# GBPColmadoNet
Sistema de Gestión Integral para Colmados y Pequeños Negocios.

Este sistema ha sido diseñado para centralizar la operación de ventas, inventario y gestión de créditos (fíaos) en negocios de venta al detalle. Utiliza una arquitectura desacoplada para garantizar que la lógica de negocio sea independiente de la interfaz de usuario.

# Arquitectura del Software
La estructura del proyecto sigue un patrón de Arquitectura Multinivel (N-Tier), facilitando el mantenimiento y la escalabilidad del sistema:

# **Estructura de la Solución**
```Plaintext
GBPColmadoNet/
├── GBPColmadoNet.Data/           (Biblioteca de Clases)
│   ├── Entities/                 (Modelos de Datos)
│   │   ├── Producto.cs           <-- Definición de stock y precios
│   │   ├── Cliente.cs            <-- Información y límite de crédito
│   │   └── Venta.cs              <-- Cabecera y detalle de transacciones
│   └── ColmadoContext.cs         <-- Configuración de EF Core / SQL Server
├── GBPColmadoNet.UI/             (Proyecto WinForms)
│   ├── Services/                 (Lógica de Interfaz y Reglas)
│   │   ├── IVentaService.cs      <-- Contrato para operaciones de venta
│   │   └── VentaService.cs       <-- Validación de stock y cálculos
│   ├── Forms/                    (Vistas del Usuario)
│   │   ├── MainForm.cs           <-- Panel principal
│   │   └── InventarioForm.cs     <-- Gestión de mercancía
│   └── Program.cs                <-- Punto de entrada e Inyección de Dependencias
└── GBPColmadoNet.Tests/          (Proyecto xUnit)
    └── VentaServiceTests.cs      <-- Pruebas de validación de negocio
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