//Console.WriteLine("Ingrese la cantidad de alumnos");

//// Ingresamos el tam´ño del vector
//int cantidadAlumnos = int.Parse(Console.ReadLine());

//// Tipo[] nombre = nwe tipo[tamaño]
//int[] notas = new int[cantidadAlumnos];

//Console.WriteLine("Ingrese las notas de cada alumno");

//// Recorremos el vector para cargar 
//for (int posicion = 0; posicion < notas.Length; posicion++)
//{
//    Console.WriteLine($"Nota del Alumno Nº {posicion + 1}: ");
//    notas[posicion] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine();
//Console.WriteLine("==========================");
//Console.WriteLine();

//for (int posicion = 0; posicion < notas.Length; posicion++)
//{
//    Console.WriteLine($"La Nota del Alumno Nº {posicion + 1}: {notas[posicion]} ");
//}


Console.WriteLine("Ingrese las notas de los exámenes");

Console.WriteLine("Ingrese la cantidad de alumnos");
//Determina las columnas
int cantidadAlumnos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de notas por alumno");
// Determina las filas
int cantidadNotas = int.Parse(Console.ReadLine());

// Tipo[,] nombre = new tipo[tamañoFilas, tamañoColumnas]
int[,] notas = new int[cantidadNotas, cantidadAlumnos];

// Cantidad de Filas
int lengthFilas = notas.GetUpperBound(0) + 1;
// Cantidad de Columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;

// Recorremos columnas (Asignar)
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno/a Nº {columna + 1}: ");

    // Recorremos filas (Asignar)
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Cargue la nota Nº {fila + 1}: ");
        notas[fila, columna] = int.Parse(Console.ReadLine());
    }
}

// Recorremos columnas (Mostrar)
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno/a Nº {columna + 1}: ");

    // Recorremos filas (Mostrar)
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"La nota Nº {fila + 1} es: ");
        Console.WriteLine(notas[fila, columna]);
    }
}


Console.ReadKey();
