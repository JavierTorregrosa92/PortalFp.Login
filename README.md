# PortalFp.Login

Aplicación de escritorio desarrollada con WPF y .NET 10 como parte del reto de la Unidad 1 de Desarrollo de Interfaces.

## Funcionalidad

La aplicación presenta un formulario de acceso con usuario y contraseña.

* Si algún campo está vacío, se muestra un mensaje de error en rojo.
* Si el usuario es `admin` y la contraseña es `1234`, se muestra un mensaje de bienvenida en verde.
* Para cualquier otra combinación, se muestra un mensaje de credenciales incorrectas en rojo.

## Uso de inteligencia artificial

Durante el desarrollo se utilizó un asistente de IA para resolver dudas sobre la incorporación de una imagen como recurso en un proyecto WPF.

**Prompt utilizado:**

> ¿Cómo puedo añadir una imagen a mi proyecto WPF y utilizarla desde XAML? La imagen aparece en la vista previa de Visual Studio, pero no cuando ejecuto la aplicación.

La IA ayudó a identificar que la imagen debía incluirse como recurso del proyecto y explicó cómo configurarlo en el archivo `.csproj`. Finalmente, se configuró la carpeta `Images` para que sus archivos se incluyan como recursos mediante:

```xml
<ItemGroup>
    <Resource Include="Images\**" />
</ItemGroup>
```

De esta forma, las imágenes de la carpeta `Images` se incorporan automáticamente como recursos del proyecto y pueden utilizarse desde XAML.

Además, se utilizó la IA como apoyo para redactar y estructurar esta documentación.
