//Console.WriteLine("Cuantas vueltas quiere dar?");

//var totalDeVUeltas = int.Parse(Console.ReadLine());

//var contador = 0;

//while (contador < totalDeVUeltas)
//{
//    contador++; // contador = contador + 1
//    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);
//}


Console.WriteLine("Cuantas vueltas quiere dar?");

var respuesta = "S";
var contador = 0;

while (respuesta.ToUpper() != "N")
{
    contador++; // contador = contador + 1
    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);

    Console.WriteLine("Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}


//for (var cantCaramelos = 0; cantCaramelos <= 12; cantCaramelos+=2) // (declaración, condición; paso)
//{
//    // Console.WriteLine("Mi bolsita tiene " + cantCaramelos + " caramelos");
//    // RECORDAR!!! el paso lo hace al finalizar la ejecución

//    // Interpolación de strings es incrustar en una cadena de texto el contenido una variable.
//    Console.WriteLine($"Mi bolsita tiene {cantCaramelos} caramelos");

//}

