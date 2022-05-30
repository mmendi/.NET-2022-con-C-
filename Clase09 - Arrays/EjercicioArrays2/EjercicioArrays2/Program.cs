
Console.WriteLine("Ingrese la cantidad de números primos deseados: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] primos = new int[n];

int posicion = 0;
int aux = 0;
int numero = 1;

while (posicion < n)
{
    aux = 0;
    for (var i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            aux++;
        }
    }
    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;      
    }
    numero++;
}
foreach (var i in primos)
{
    Console.WriteLine(i);
}
Console.ReadKey();
