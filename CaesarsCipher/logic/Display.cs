using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarsCipher.logic
{
    internal class Display
    {
        // Startup screen
        internal void StartScreen()
        {
            Console.WriteLine("Witam w programie z kodowaniem i dekodowanie poprzez *** szyfr Cezara ***");
            Console.WriteLine("Wciśnij dowolny klawisz aby rozpocząć");
            Console.ReadKey();
            SelectModeScreen();
        }

        // Select mode screen
        internal void SelectModeScreen()
        {
            Console.Clear();
            Console.WriteLine("Wybierz tryb pracy wpisując odpowiedni numer znajdujący się przed nazwją: ");
            Console.WriteLine("1. Kodowanie");
            Console.WriteLine("2. Dekodowanie");
            string userInput = Console.ReadLine();

            // Using Validation class
            Validation valid = new Validation();
            int selected = valid.UserInputAsInt(userInput);
            if (selected == 1)
            {
                GetTextScreen();
            }
            else if (selected == 2)
            {
                Console.WriteLine("Coming soon");
            }
            else
            {
                SelectModeScreen();
            }
        }

        // Get text to encrypt screen
        internal void GetTextScreen()
        {
            Console.Clear();
            Console.WriteLine("Podaj tekst do zakodowania i zatwierdź go enterem");
            string userInput = Console.ReadLine();
            if (userInput != "" && userInput.Length >= 1)
            {
                GetShift(userInput);
            }
        }

        // Get shift value
        internal void GetShift(string textToEncrypt)
        {
            Console.Clear();
            Console.WriteLine("Podaj wartość przesunięcia znaków (liczby dodatnie całkowite)");
            string userInput = Console.ReadLine();
            Validation valid = new Validation();
            int shift = valid.UserInputAsInt(userInput);
            if (shift != 0)
            {
                Encryption encryption = new Encryption();
                string final = encryption.Init(shift, textToEncrypt);
                FinalEncryptionScreen(textToEncrypt, shift, final);
            }

            GetShift(textToEncrypt);
        }

        // Final encryption screen
        internal void FinalEncryptionScreen(string textToEncrypt, int shift, string encryptedText)
        {
            Console.Clear();
            Console.WriteLine("Tekst: " + textToEncrypt);
            Console.WriteLine("Po przesunięciu o " + shift + " znaków");
            Console.WriteLine("Zakodowany tekst: " + encryptedText);
            Console.WriteLine("Tekst został skopiowany do twojego schowka ;)");
            Console.WriteLine("Kliknij enter by zacząć od nowa");
            Console.ReadLine();
            StartScreen();
        }



    }
}
