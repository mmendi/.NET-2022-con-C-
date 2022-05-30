// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

string[] Cars = { "Ford", "Fiat", "VW", "Peugeot" };

Console.WriteLine(Cars);

string[] Frutas = new string[4];

Frutas[0] = "Pera";
Frutas[1] = "Kiwi";
Frutas[2] = "Banana";
Frutas[3] = "Durazno";
//Frutas[4] = "Uva";

Console.WriteLine(Frutas[3]);
Console.WriteLine(Frutas[2]);
Console.WriteLine("");
//Console.WriteLine(Frutas[4]);

int[] numeros = new int[5];
Console.WriteLine($"El array tiene {numeros.Length} posiciones");

Console.WriteLine("Por favor ingrese los 5 números");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Por favor ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < 5; i++)
{
    //suma += numeros[1];
    suma = suma + numeros[i];
}

Console.WriteLine($"Valor de la suma de todos los números es: {suma}");

Console.WriteLine("Los valores son: ");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numeros[i]);
}
