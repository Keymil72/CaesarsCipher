using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaesarsCipher.logic
{
    internal class Validation
    {
        // Checking if the string is an integer
        internal int UserInputAsInt(string key)
        {
            if (int.TryParse(key, out int x))
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
    }
}
