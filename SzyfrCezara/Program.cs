using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo do zaszyfrowania");
            string slowo = Console.ReadLine();

            string slowoSzyfr = "";
            const int SHIFT = 3;
            int ascIndex = 0;

            foreach (char letter in slowo)
            {
                ascIndex = (int)letter;

                if (char.IsLower (letter) )
                {
                    ascIndex = (ascIndex < 120) ? ascIndex += SHIFT : ascIndex += SHIFT - 26;
                }
                else if (char.IsUpper(letter))
                {
                    ascIndex = (ascIndex < 88) ? ascIndex += SHIFT : ascIndex += SHIFT - 26;
                }
                Console.WriteLine(ascIndex);
                slowoSzyfr += (char)ascIndex;
            }

            Console.WriteLine(slowoSzyfr);
        }
    }
}
