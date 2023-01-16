using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarsCipher.logic
{
    internal class Encryption
    {
        List<char> possibleCharacters = new List<char> { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        
        // Initiate encryption function
        internal string Init(int shift, string textToEncrypt)
        {
            char[] charTable = TextToCharList(textToEncrypt);
            List<char> encryptedChars = EncryptChar(shift, charTable);
            string final = Connector(encryptedChars);
            return final;
        }

        // Text To chars table
         char[] TextToCharList(string text)
        {
            char[] charArr = text.ToCharArray();
            return charArr;
        }

        // Encrypt char by char
        // To fix
        List<char> EncryptChar(int shift, char[] chars)
        {
            List<char> encryptedChars = new List<char>();
            foreach (var x in chars)
            {
                if (possibleCharacters.Contains(x))
                {
                    int charIndex = possibleCharacters.IndexOf(x);
                    int charShift = (shift % 35) + charIndex;
                    encryptedChars.Add(possibleCharacters.ElementAt(charIndex));
                }
                else
                {
                    encryptedChars.Add(x);
                }
            }
            return encryptedChars;
        }

        // Char connector to string
        string Connector(List<char> chars)
        {
            string final = "";
            foreach (char x in chars)
            {
                final += x;
            }
            return final;
        }
    }
}
