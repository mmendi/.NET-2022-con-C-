//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

//1) Pedir al usuario la longitud de un vector
//2) Crear el vector del tamaño ingresado.
//3) Llenar el mismo con datos aleatorios
//4) Mostrar el vector por pantalla
//5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
//el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector 
//es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar 
//así: 50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. 
//Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
//6) Mostrar el vector nuevamente.


Console.WriteLine("Ingrese la longitud de un vector");

// Tipo[] nombre = new tipo[]
int[] vector = new int[100];

// Generar aleatorio
//int[] vector = new Random(DateTime.Now.Millisecond).Next(1, 100);
Random rand = new Random();

Console.WriteLine("==================");
Console.WriteLine($"Los números aleatorios antes de invertir son: ");
Console.WriteLine("==================");

// Recorremos el vector

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(1, 100);
}
foreach (var i in vector)
{
    Console.WriteLine(i);
}

/*foreach (var elemento in vector)
{
    vector[elemento] = rand.Next(0, 100);
    Console.WriteLine(vector[elemento]);
}
for (int indiceIzquierdo = 0; indiceIzquierdo < vector.Length / 2; indiceIzquierdo++)
{
    int indiceDerecho = vector.Length - indiceIzquierdo - 1;
    int auxiliar = vector[indiceDerecho];
    vector[indiceDerecho] = vector[indiceIzquierdo];
    vector[indiceIzquierdo] = auxiliar;
    
}
Console.WriteLine("==================");
Console.WriteLine($"Los números aleatorios después de invertir son: ");
Console.WriteLine("==================");
foreach (var elemento in vector)
{
    Console.WriteLine(elemento);
}
*/

Console.ReadKey();
