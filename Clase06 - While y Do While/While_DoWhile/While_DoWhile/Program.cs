/*
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando 
un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice 
el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

// ------- Alternativa con while -------
//var opcionSeleccionada = "S";

//while (opcionSeleccionada.ToUpper() == "S")
//{
//    // Borra la pantalla
//    Console.Clear();

//    // Pedimos al usuario que introduzca su nombre
//    Console.WriteLine("Ingrese su nombre por favor:");

//    // Leemos el nombre del usuario
//    string nombre = Console.ReadLine();

//    // Mostramos el nombre con el saludo
//    Console.WriteLine($"¡Hola {nombre}!");

//    Console.WriteLine("¿Desea continuar? S/N");
//    opcionSeleccionada = Console.ReadLine();
//}

//if (opcionSeleccionada.ToLower() == "n")
//{
//    Console.WriteLine("Programa finalizado correctamente");
//}
//else
//{
//    Console.WriteLine("Opcion no valida");
//}

// -----------------------------------------------------------

// ------- Alternativa con do-while (hacer-mientras) -------

string opcionSeleccionada;

do
{
    // Borra la pantalla
    Console.Clear();

    // Pedimos al usuario que introduzca su nombre
    Console.WriteLine("Ingrese su nombre por favor:");

    // Leemos el nombre del usuario
    string nombre = Console.ReadLine();

    // Mostramos el nombre con el saludo
    Console.WriteLine($"¡Hola {nombre}!");

    Console.WriteLine("¿Desea continuar? S/N");
    opcionSeleccionada = Console.ReadLine();

    if (opcionSeleccionada.ToLower() == "n")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    else if (opcionSeleccionada.ToUpper() != "S")
    {
        Console.WriteLine("Opcion no valida");
    }

} while (opcionSeleccionada.ToUpper() == "S");


