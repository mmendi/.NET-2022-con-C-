Console.Clear();

int[] numeros = new int[10];
Console.WriteLine($"El array tiene {numeros.Length} posiciones");

// Pida 10 números al usuario.
Console.WriteLine("Por favor ingrese los 10 números");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Por favor ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

// Obtener la suma de todos los números ingresados y mostrarlo en pantalla.
double suma = 0;
for (int i = 0; i < 10; i++)
{
    suma = suma + numeros[i];
}

Console.WriteLine($"Valor de la suma de todos los números es: {suma}");

// Obtener cual es el mayor de todos los números y mostrarlo en pantalla.
Console.WriteLine($"El mayor de todos los números: {numeros.Max()}");

// Obtener cual es el menor de todos los números y mostrarlo en pantalla.
Console.WriteLine($"El menor de todos los números: {numeros.Min()}");

// Obtener el promedio de todos los números y mostrarlo en pantalla.
double promedio = suma / numeros.Length;

Console.WriteLine($"El promedio de todos los números es: {promedio}");

// Mostrar todos los números ingresados por pantalla.
Console.WriteLine("Los valores son: ");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(numeros[i]);
}