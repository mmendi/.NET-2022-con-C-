Console.WriteLine("Desea continuar? (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "S") // Convierte el texto a mayúsculas
{
    Console.WriteLine("Usted ingreso que SI");
}
else if (texto.ToUpper() == "N")
{
    Console.WriteLine("Usted ingreso que NO");
}
else
{
    Console.WriteLine("Usted no entendió nada");
}
