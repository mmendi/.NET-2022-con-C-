//// ------ Ejemplo de condicional if ------ 

//Console.Write("Ingrese su edad: "); // Le pedimos al usuario que ingrese su edad
//int edad = int.Parse(Console.ReadLine()); // Obtenemos la edad por teclado

//Console.Write("Ingrese su equipo de fútbol: ");
//string equipo = Console.ReadLine();

//Console.WriteLine("La edad ingresada es: " + edad);

///* 
//AND -> && (Y)
//OR -> || (O)
//Igual que -> ==
//Distinto que -> !=
//*/

//bool condicion = edad < 18 && equipo == "River";

//if (condicion) // Evaluamos la edad y el equipo de fútbol
//{
//    // Instrucciones si se cumple la condición evaluada
//    Console.WriteLine("Usted es menor de edad.");
//    Console.WriteLine("Prohibida la entrada");
//}
//else
//{
//    // Instrucciones si no se cumple la condición evaluada
//    Console.WriteLine("Usted es mayor de edad.");
//}

//// ------ Ejemplo if-elseif-else ------

//Console.Write("Ingrese la edad: ");
//int edad = int.Parse(Console.ReadLine());

//if (edad < 0 || edad > 110)
//{
//    Console.WriteLine("La edad no es válida.");
//}
//else if (edad < 12)
//{
//    Console.WriteLine("Va a la primaria");
//}
//else if (edad < 18)
//{
//    Console.WriteLine("Va al secundario");
//}
//else if (edad < 28)
//{
//    Console.WriteLine("Va a la facultad");
//}
//else
//{
//    Console.WriteLine("A trabajar no queda otra.");
//}

// ------  Ejemplo del switch ------ 

Console.WriteLine("Ingrese el primer número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");

Console.WriteLine("Ingrese la operación a realizar");
string operacion = Console.ReadLine();

double resultado = 0;
switch (operacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0:
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingreso una opción no válida");
        break;
}
Console.WriteLine("El resultado es: " + resultado);