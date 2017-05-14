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
            string word = Console.ReadLine();

            string wordCipher = "";
            const int SHIFT = 3;
            int ascIndex = 0;

            foreach (char letter in word)
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
                wordCipher += (char)ascIndex;
            }

            Console.WriteLine(wordCipher);
        }
    }
}
