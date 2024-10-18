

using System; 
using LibrairieConversionNote; 

class Program
{ 
    static void Main(string[] args) 
{
        ConversionAlphabetiqueToNote convertisseur = new ConversionAlphabetiqueToNote();
        Console.WriteLine("Bienvenue dans le convertisseur de notes !");
        Console.WriteLine("Type de conversion : NOTE (alphabétique vers syllabe)");
        while (true) { Console.Write("Entrez une note alphabétique (A-G) ou CTRL + C pour quitter : ");
        string input = Console.ReadLine(); string result = convertisseur.Transformer(input); 
                      Console.WriteLine(result); 
                     } 
    }
} 
