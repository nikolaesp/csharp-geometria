// See https://aka.ms/new-console-template for more information
using csharp_geometria;
 
Console.WriteLine("Inserisci base di rettangolo:");
    int basere = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci altezza di rettangolo:");
    int altere = int.Parse(Console.ReadLine());


Rettangolo miorettangolo = new Rettangolo();

miorettangolo.recbase = basere;
miorettangolo.recheight= altere;

miorettangolo.PrintRectangle();

miorettangolo.recbase += 2;

miorettangolo.PrintRectangle();