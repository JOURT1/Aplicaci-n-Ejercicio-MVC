# MiniCoreComisiones

Sistema web para el cálculo automático de comisiones por ventas según reglas preestablecidas. Desarrollado en ASP.NET Core MVC como parte del proyecto académico para la materia ingeniería web web – UDLA.

---

## Funcionalidad principal

El sistema permite seleccionar un vendedor y un rango de fechas para calcular:

- Total de ventas dentro del período
- Regla de comisión aplicada (por rangos)
- Porcentaje y monto de comisión

Ejemplo:  
Si un vendedor tiene $350 en ventas y la regla es del 10%, la comisión es $35.

---

## 🗂Estructura del Proyecto

- **Modelo de Datos:**  
  - `Vendedor`  
  - `Venta`  
  - `ReglaComision`

- **Relaciones:**  
  - Un `Vendedor` tiene muchas `Ventas`  
  - El sistema busca la regla aplicable según el total de ventas acumuladas

---

## Extras implementados

- Estilo visual con Bootstrap 5 (modo oscuro)
- Nombre del vendedor destacado en resultados
- Visualización clara del porcentaje aplicado
- Validación de fechas y selección obligatoria
- Rango de fechas disponible mostrado dinámicamente
- Interfaz responsive para móvil y escritorio

---

## Tecnologías

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite (base de datos en memoria para testing)
- Bootstrap 5 + CSS personalizado
- Render (para despliegue en la nube)
- GitHub (control de versiones)

---

## Cómo desplegar en local

1. Clonar el repositorio:
```bash
git clone https://github.com/TU_USUARIO/MiniCoreComisiones.git
cd MiniCoreComisiones
