// See https://aka.ms/new-console-template for more information


using csharp_oop_shop;

/*Console.WriteLine("Inserisci il nome del nuovo prodotto: ");
string name = Console.ReadLine();

Console.WriteLine("Inserisci una descrizione per il nuovo prodotto: ");
string description = Console.ReadLine();

Console.WriteLine("Inserisci il prezzo del nuovo prodotto: ");
double price = decimal.Parse(Console.ReadLine());*/


Prodotto first = new Prodotto("rastrello", "funziona bene", 1.99);
Console.WriteLine("nome: " + first.GetName());
Console.WriteLine("descrizione: " + first.GetDescription());
Console.WriteLine("prezzo: " + first.GetPrice());
Console.WriteLine("codice prodotto: " + first.GetCode());


