// Borra la pantalla
Console.Clear();

// Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, por favor ingresa tu nombre: ");

// Leemos el nombre del usuario
string nombre = Console.ReadLine();

// Pedimos al usuario que introduzca su apellido
Console.WriteLine("Ahora ingrese su apellido: ");

// Leemos el apellido del usuario
string apellido = Console.ReadLine();

// Mostramos el nombre y apellido
Console.Write("Hola " + nombre + " " + apellido);
Console.WriteLine(", este es mi segundo programa.");

Console.WriteLine("Pulse una tecla para finalizar.");
Console.ReadKey();