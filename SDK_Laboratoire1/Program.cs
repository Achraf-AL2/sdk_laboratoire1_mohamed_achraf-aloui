using System;
using LibrairieConversionNote;

class Program
{
    static void Main(string[] args)
    {
        var converter = new ConversionAlphabetiqueToNote();
        string input;

        Console.WriteLine("Enter 'NOTE' to convert alphabetic note to syllable.");
        while (true)
        {
            Console.Write("Enter the alphabetic note (A-G) or CTRL+C to exit: ");
            input = Console.ReadLine();
            if (input == null) continue;

            string result = converter.Transformer(input);
            Console.WriteLine($"The syllabic note is: {result}");
        }
    }
}

