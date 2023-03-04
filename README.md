# C-Sharp-Bases

En este repositorio estaré colocando las bases de C#.
Trataré de explicar de la mejor manera que me sea posible y agregare referencias para que se pueda investigar más

## ¿.NET?

Plataforma de desarrollo para crear aplicaciones, creado en el 2002 por Microsoft para aplicaciones de Windows (NET Framework). Microsoft decide liberar el código fuente y reescribir el código de .NET con el nombre de .NET Core.

Esta nueva versión es multiplataforma y se puede correr en Windows, MacOS y/o Linux.

Microsoft dejo de publicar más versiones de .NET Framwork(privativo) y solo decidió darle mantenimiento. Para la versión de Net Core la llamó de esta manera hasta la versión 3, después decidieron quitar el _Core_ y solo dejar .Net pasando a la versión 5.

.Net Framework -> 4.8 mayor versión
.Net Core -> 1, 2, 3
.Net -> 5,6, 7, 8, etc

## ¿Qué es C#?

.Net puede utilizar varios lenguajes como VB, F# y C#. En este repositorio nos concetraremos en C#.

Es un lenguaje orientado a objetos, fuertemente tipado. El lenguaje probablemente más popular de .NET. Se puede utilizar para crear aplicaciones en escritorio (Windows Form), web (MVC, Blazor, API), múltiplataforma (MAUI) y también Unity lo utiliza para poder crear juegos.

Más información sobre C# [aquí](https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/)

## ¿Que herramienta se necesita para programar en C#?

Se puede utilizar el IDE **Visual Studio** o el editor de texto **Visual Studio Code**.

Se recomienda usar el IDE por que nos facilita mucho en el desarrollo de aplicaciones si tenemos como sistema operativo Windows o MacOS.

Si estás trabajando en Linux se puede utilizar Visual Studio Code. (En este caso tienes que instalar el SDK para que pueda funcionar).

### Crear Proyecto en Visual Studio

Abrimos el programa nos aparece una opción para crear un nuevo proyecto.

Seleccionamos el tipo de proyecto en este caso de Consola. Clic en siguiente.
Luego pedirá el nombre del proyecto y la ubicación de este. Click en Siguiente.

Ahora nos pedirá elegir el Framework (lo dejamos por defecto).

## Sintaxis

### Mensaje en consola

    Console.WriteLine("Hola mundo");

Siempre termina el punto y coma. De tener un error en Visual studio nos avisará que el código está mal.

**Console** es una clase del Framework y después de el punto podemos ver los miembros de la clase. En este caso _.WriteLine("")_ con parentesis, indica que es un método de la clase Console. Este método nos sirve para imprimir en pantalla de la consola de windows el texto que se coloca dentro del paréntesis.

### Comentarios

    // Comentario

Si deseas hacer algún comentario en el código solo tienes que colocar doble barra "//" seguído del comentario y el compilador de .Net no lo considera para su ejecución.

Tienes otra opción de comentar varias lineas de código utilizando "/* _comentarios_*/" .

    /* comentario 1
       comentario 2
       comentario 3*/

### Mayusculas y minusculas

En C# es importante respetar las mayusculas y minusculas con las que fueron declarados los miembros de una clase, si no saldrá error.

Válido:

    Console.WriteLine("Hola mundo");

No válido:

    Console.WRITELINE("Hola mundo");

## Variables

Nos permiten guardar información en la memoria RAM del computador.

Existen muchos tipos de varibles que maneja C#. Los principales son int, decimal, double, string, bool, DateTime. Pero existen muchos tipos de variables más.

### Declaración

    int edadPersona;
    string nombrePersona;
    bool mayorDeEdad;

### Asignación de valores a las variables

    edadPersona = 30;
    nombrePersona = "Jhan Karlo";
    mayorDeEdad = true;

### Declaración y asignación de valores a las variables

    int edadPersona = 30;
    string nombrePersona = "Jhan Karlo";
    bool mayorDeEdad = true;

### imprimir el valor de nuestras variables

    Console.WriteLine(edadPersona);
    Console.WriteLine(nombrePersona);
    Console.WriteLine(mayorDeEdad);
