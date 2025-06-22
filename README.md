# MiniCoreComisiones

Sistema web para el cálculo automático de comisiones por ventas según reglas preestablecidas. Desarrollado en **ASP.NET Core MVC** como parte del proyecto académico para la materia **Ingeniería Web – UDLA**.

---

## Funcionalidad principal

El sistema permite seleccionar un vendedor y un rango de fechas para calcular:

- ✅ Total de ventas dentro del período
- ✅ Regla de comisión aplicada (por rangos)
- ✅ Porcentaje y monto de comisión

**Ejemplo:**  
Si un vendedor tiene $350 en ventas y la regla es del 10%, la comisión es $35.

---

## 🗂 Estructura del Proyecto

### Modelo de Datos

- `Vendedor`
- `Venta`
- `ReglaComision`

### Relaciones

- Un **vendedor** tiene muchas **ventas**
- El sistema busca la **regla** aplicable según el total de ventas acumuladas

---

## Extras implementados

- Estilo visual con **Bootstrap 5** (modo oscuro)
- Nombre del vendedor destacado en resultados
- Visualización clara del porcentaje aplicado
- Validación de fechas y selección obligatoria
- Rango de fechas disponible mostrado dinámicamente
- Interfaz responsive para móvil y escritorio

---

## Tecnologías utilizadas

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite (base de datos en memoria para testing)
- Bootstrap 5 + CSS personalizado
- Render (para despliegue en la nube)
- GitHub (control de versiones)

## Cómo ver el proyecto y aprender más

### Enlaces importantes

- **Sitio desplegado en Render (producción):**  
  [https://minicorecomisiones.onrender.com](https://minicorecomisiones.onrender.com)

- **Video explicativo del proyecto (YouTube):**  
  [https://youtu.be/zyll-dYgbPE?si=HlNwypzkWAsHLHM6](https://youtu.be/zyll-dYgbPE?si=HlNwypzkWAsHLHM6)

---

### Recursos adicionales

- [Documentación oficial ASP.NET MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-8.0)  
- [Tutorial oficial de Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)  
- [Guía completa de ASP.NET MVC en YouTube](https://youtu.be/sZVqGIW6Jno?si=ZAFDyRnhNinXSGT-)

---

## Autor

Proyecto desarrollado por **Mateo Ramirez**  
Universidad de las Américas – 2025
mateo.ramirez.lopez@udla.edu.ec

---

## Cómo desplegar en local

1. Clonar el repositorio:

```bash
git clone https://github.com/TU_USUARIO/MiniCoreComisiones.git
cd MiniCoreComisiones
Ejecutar en Visual Studio / VS Code
Asegúrate de tener instalado .NET 8 SDK y restaurar las dependencias.
