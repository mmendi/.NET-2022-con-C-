/*
Estructuras de datos:
1) Arrays
2) Listas
3) Colas
4) Pilas
5) Diccionarios
etc...
 */

//// Inicialización de Array
//var miArray = new int[10];

//// Recorro un Array
//for (int i = 0; i < miArray.Length; i++)
//{
//    Console.WriteLine(miArray[i]);
//}

//foreach (var item in miArray)
//{
//    Console.WriteLine(item);
//}

//var personas = new List<string>();

//personas.Add("Manuela");
//personas.Add("Pilar");
//personas.Add("Pedro");

//foreach (var persona in personas)
//{
//    Console.WriteLine(persona);
//}

var listaNombres = new List<string>();

Console.WriteLine("Bienvenido a la Lista.");
Console.WriteLine("Seleccione una de las siguiente opciones: ");
Console.WriteLine("1: Agregar un elemento");
Console.WriteLine("2: Quitar un elemento");
Console.WriteLine("3: Ubicar un elemento");
Console.WriteLine("4: Invertir una lista");
Console.WriteLine("5: Ver contenido de la lista");

var entradaUsuario = Console.ReadLine();

switch (entradaUsuario)
{
    case "1":
        // Agregar un elemento
        Console.WriteLine("Ingrese el elemento: ");
        var nuevoElemento = Console.ReadLine();

        Console.WriteLine("Donde desea agregar el elemento? ");
        Console.WriteLine("1: Al final ");
        Console.WriteLine("2: En una posición determinada ");

        var opcionParaIngresar = Console.ReadLine();
        switch (opcionParaIngresar)
        {
            case "1":
                // Al final
                listaNombres.Add(nuevoElemento);
                break;

            case "2":
                //Insertar un elemnteo en una posición
                Console.WriteLine("Ingrese la posición: ");
                var posicion = int.Parse(Console.ReadLine());

                listaNombres.Insert(posicion, nuevoElemento);
                break;
        }
        break;
    
        case "2":
        // Quitar un elemento
            Console.WriteLine("Ingrese el elemento que desea quitar: ");
            var elementoParaQuitar = Console.ReadLine();

            listaNombres.Remove(elementoParaQuitar);
        break;

        case "3":
        // Ubicar un elemento
        Console.WriteLine("Ingrese el elemento que desea ubicar: ");
        var elementoParaUbicar = Console.ReadLine();
        var posicionElemento = listaNombres.IndexOf(elementoParaUbicar);
        if (posicionElemento > -1)
        {
            Console.WriteLine("El elemento se encuentra en la posición " + )
        }


}
