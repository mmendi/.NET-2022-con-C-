// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Constantes
const string constanteTexto = "Esto es una constante";

// Datos numéricos
byte numero_byte = 0;
int numero_integer = 4567;
long numero_long = 27824362;
double numero_double = 300.123;
decimal numero_decimal = 0.1453M;
float numero_float = 400.0f;

// Datos lógicos
bool datoBoolFalso = false; // 0 - apagado
bool datoBoolVerdadero = true; // 1 - prendido

// Datos de texto
string dato_string = "Bienvenido al Curso .NET 6.0";

// Instrucción de salida - output
Console.WriteLine(dato_string);
// acá modifico el texto sin declarar porque ya está declarado
dato_string = "Texto Modificado"; 
Console.WriteLine(dato_string);

Console.WriteLine("Ingrese un valor: ");
// Instrucción de entrada - input
Console.ReadLine();

Console.WriteLine(numero_integer);

Console.WriteLine(datoBoolVerdadero);