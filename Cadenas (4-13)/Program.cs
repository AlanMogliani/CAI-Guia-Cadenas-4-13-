// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        //Ejercicio4();
        //Ejercicio5();
        //Ejercicio6();
        //Ejercicio7();
        //Ejercicio8();
        //Ejercicio9();
        //Ejercicio10();
        Ejercicio12B();
    }

    static void Ejercicio4()
    {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }

    static void Ejercicio5()
    {
        string phrase;
        bool phraseHas;
        Console.Write("Please write a phrase: ");
        phrase = Console.ReadLine();
        phraseHas = phrase.Contains("fin");
        if (phraseHas) { Console.WriteLine("Phrase contains the word 'fin'"); }
        ;
    }

    static void Ejercicio6()
    {
        string input;
        Console.Write("Enter a text in lower caps: ");
        input = Console.ReadLine();
        Console.WriteLine("Here's the text in upper caps: " + input.ToUpper());
    }

    static void Ejercicio7()
    {
        string input;
        Console.Write("Enter a text in upper caps: ");
        input = Console.ReadLine();
        Console.WriteLine("Here's the text in lower caps: " + input.ToLower());
    }

    static void Ejercicio8()
    {
        string input;
        string newString = null;
        input = Console.ReadLine();
        foreach (char c in input)
        {
            string newChar = c.ToString();
            if (newChar == "á")
            {
                newChar = "a";
                newString += newChar;

            }
            else if (newChar == "é")
            {
                newChar = "e";
                newString += newChar;

            }
            else if (newChar == "í")
            {
                newChar = "i";
                newString += newChar;

            }
            else if (newChar == "ó")
            {
                newChar = "o";
                newString += newChar;

            }
            else if (newChar == "ú")
            {
                newChar = "u";
                newString += newChar;

            }
            else {
                newString += newChar;
            };
        }
        Console.WriteLine(newString);
    }

    static void Ejercicio9()
    {
        string phrase1;
        string phrase2;
        bool comparison;

        Console.Write("Enter phrase number 1: ");
        phrase1 = Console.ReadLine();
        Console.Write("Enter phrase number 2: ");
        phrase2 = Console.ReadLine();

        comparison = Equals(phrase1, phrase2);
        if (comparison)
        { 
            Console.WriteLine("The phrases are identical"); 
        }

        else
        {
            Console.WriteLine("The phrases don't match");
        };

    }

    static void Ejercicio10()
    {
        string phrase1;
        string phrase2;
        bool comparison;

        Console.Write("Enter phrase number 1: ");
        phrase1 = Console.ReadLine();
        Console.Write("Enter phrase number 2: ");
        phrase2 = Console.ReadLine();

        comparison = Equals(phrase1.Length, phrase2.Length);
        if (comparison)
        {
            Console.WriteLine("The phrases are identical");
        }

        else
        {
            Console.WriteLine("The phrases don't match");
        }
        ;
    }

    static void Ejercicio12()
    {
        string phrase;
        int counter = 0;

        Console.Write("Enter a phrase: ");
        phrase = Console.ReadLine();

        foreach (char c in phrase)
        {
            string Char = c.ToString();
            if (Char == ",") ;
            else if (Char == ";") ;
            else if (Char == ".") ;
            else { counter++; };

                
        }

        Console.WriteLine(counter);

    }

    static void Ejercicio12B()
    {
        {
            // 1. Ask the user for a phrase
            Console.Write("Enter a phrase: ");
            string input = Console.ReadLine();

            // 2. Remove punctuation (basic ones)
            string cleaned = "";
            foreach (char c in input)
            {
                if (!char.IsPunctuation(c))
                {
                    cleaned += c;
                }
            }

            // 3. Split the phrase by spaces
            string[] words = cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // 4. Count the words
            int wordCount = words.Length;

            // 5. Show the result
            Console.WriteLine("Number of words: " + wordCount);
        }
    }
}