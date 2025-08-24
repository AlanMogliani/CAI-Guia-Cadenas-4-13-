// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Program
{
    static void Main()
    {
        //Ejercicio1();
        Ejercicio2();
    }

    static void Ejercicio1()
    {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }

    static void Ejercicio2()
    {
        string phrase;
        bool phraseHas;
        Console.Write("Please write a phrase: ");
        phrase = Console.ReadLine();
        phraseHas = phrase.Contains("fin");
        if (phraseHas) { Console.WriteLine("Phrase contains the word 'fin'"); }
        ;



    }
}