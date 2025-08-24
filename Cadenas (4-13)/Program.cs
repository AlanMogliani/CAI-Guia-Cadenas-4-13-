// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Program
{
    static void Main()
    {
        //Ejercicio1();
        //Ejercicio2();
        Ejercicio3();
        Ejercicio4();
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

    static void Ejercicio3()
    {
        string input;
        Console.Write("Enter a text in lower caps: ");
        input = Console.ReadLine();
        Console.WriteLine("Here's the text in upper caps: " + input.ToUpper());
    }

    static void Ejercicio4()
    {
        string input;
        Console.Write("Enter a text in upper caps: ");
        input = Console.ReadLine();
        Console.WriteLine("Here's the text in upper caps: " + input.ToLower());
    }


}