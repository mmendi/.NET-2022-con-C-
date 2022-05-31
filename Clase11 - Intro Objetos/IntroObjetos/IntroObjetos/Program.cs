namespace IntroObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia 1
            Perro firulais = new Perro();
            firulais.Color = "Negro";
            firulais.Edad = 4;
            firulais.Tamanio = "Grande";
            firulais.Raza = "Maztín Napolitano";

            // Instancia 2
            Perro fatiga = new Perro();
            fatiga.Color = "Blanco";
            fatiga.Edad = 2;
            fatiga.Tamanio = "Medio";
            fatiga.Raza = "Maltes";

            // Instancia 3
            Perro cartucho = new Perro();
            cartucho.Color = "Marrón";
            cartucho.Edad = 3;
            cartucho.Tamanio = "Medio";
            cartucho.Raza = "Chow Chow";

            // Lista de perros
            var perritos = new List<Perro>();
            perritos.Add(firulais);
            perritos.Add(fatiga);
            perritos.Add(cartucho);

            Console.WriteLine($"Hay {perritos.Count} perritos en la lista");

            foreach (var item in perritos)
            {
                Console.Write(item.Raza + " -> ");
                item.Ladrar();
            }



        }
    }
}