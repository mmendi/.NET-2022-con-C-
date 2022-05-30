/*
Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.WriteLine("Ingrese la cantidad de filas");
// Determina las filas
int cantFilas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de columnas");
//Determina las columnas
int cantColumnas = int.Parse(Console.ReadLine());

// Tipo[,] nombre = new tipo[tamañoFilas, tamañoColumnas]
int[,] numeros = new int[cantFilas, cantColumnas];

// Cantidad de Filas
int lengthFilas = numeros.GetUpperBound(0) + 1;
// Cantidad de Columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

// Recorremos columnas (Asignar)
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Columna Nº {columna + 1}: ");

    // Recorremos filas (Asignar)
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Cargue el valor en la fila Nº {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

// Recorremos columnas (Mostrar)
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine();
    Console.WriteLine($"Valores de la Columna Nº {columna + 1}: ");

    // Recorremos filas (Mostrar)
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Fila Nº {fila + 1} es: ");
        Console.WriteLine(numeros[fila, columna]);
    }
}

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine();

// Obtener la suma de todos los números ingresados y mostrarlo en pantalla.
double sumaCol = 0;
double promedio = 0;

for (int columna = 0; columna < lengthColumnas; columna++)
{
    sumaCol = 0;
    promedio = 0;
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        sumaCol = sumaCol + numeros[fila, columna];
        promedio = sumaCol / lengthFilas;
    }
    
    Console.WriteLine($"La suma de la Columna Nº: {columna + 1} es: {sumaCol} ");
    Console.WriteLine();
    Console.WriteLine($"El promedio de la Columna Nº: {columna + 1} es: {promedio} ");
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine();

}

Console.ReadKey();