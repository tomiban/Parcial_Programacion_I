# Ejecutar Aplicaciones de Consola en .NET

## Requisitos Previos

Tener instalado Homebrew

## Descarga y ejecucion

1. **Instalar el NET SDK Y Runtime (versión 8)**:

   ```bash
   brew install --cask dotnet-sdk
   brew install dotnet-runtime
   ```

2. **Ejecutar la Aplicación**:

   Para ejecutar un proyecto específico

   ```bash
   cd Parcial/EjercicioX
   dotnet run
   ```

## Aclaraciones de sintaxis de C#
En los ejercicios 2 y 3 se emplean propiedades automaticas para encapsular campos sin necesidad de definir manualmente un campo privado y los métodos `get` y `set`. Con esto, el compilador genera automáticamente un campo privado y gestiona los accesos.

```csharp
//Esto
public class Estudiante
{
    public string Nombre { get; set; }
}

// Es equivalente a esto
private string _nombre;

public string Nombre
{
    get { return _nombre; }
    set { _nombre = value; }
}
```
