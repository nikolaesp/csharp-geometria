// See https://aka.ms/new-console-template for more information
using csharp_geometria;
using System.ComponentModel;

Console.WriteLine("Inserisci base di rettangolo:");
    int basere = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci altezza di rettangolo:");
    int altere = int.Parse(Console.ReadLine());


Rettangolo miorettangolo = new();
Rettangolo brayantangollo = new();
Rettangolo emanuelleangolo = new();
brayantangollo.recbase = 4;
brayantangollo.recheight = 6;
emanuelleangolo.recbase = 5;
emanuelleangolo.recheight = 3;
miorettangolo.recbase = basere;
miorettangolo.recheight= altere;

miorettangolo.PrintRectangle();

miorettangolo.recbase += 2;
Console.WriteLine("Mio rectangolo cambiato: ");
miorettangolo.PrintRectangle();
Console.WriteLine("Brayan rectangolo: ");
brayantangollo.PrintRectangle();
brayantangollo.recheight = 16;
Console.WriteLine("Brayan rectangolo cambiato: ");
brayantangollo.PrintRectangle();

Console.WriteLine("Emanuelle rectangolo: ");
emanuelleangolo.PrintRectangle(); 
