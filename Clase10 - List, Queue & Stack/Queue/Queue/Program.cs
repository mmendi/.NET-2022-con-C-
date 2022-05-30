// Queue - Cola

var miCola = new Queue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());