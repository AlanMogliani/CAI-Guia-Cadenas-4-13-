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
        Ejercicio8();
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



}