var opcionSeleccionada = "S";

while (opcionSeleccionada.ToUpper() == "S")
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
}

if (opcionSeleccionada.ToLower() == "n")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}

