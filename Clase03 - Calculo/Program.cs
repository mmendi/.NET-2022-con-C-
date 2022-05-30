Console.Clear();

// decimal v= decimal.Parse("222");

// string baseRectanguloTexto = Console.ReadLine();
// double baseRectangulo = double.Parse(baseRectanguloTexto);

Console.WriteLine("Ingrese la base del rectángulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = 
    baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectángulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    Console.WriteLine("La superficie del rectángulo es mayor a 10");
}

Console.WriteLine("Presione una tecla para terminar");
Console.ReadKey();