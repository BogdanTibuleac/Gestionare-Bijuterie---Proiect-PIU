using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] tablouScara = new string[26][];
            char[] index = new char[26];
            int[] sizeIndex = new int[26];
            int i;
            char c = 'A';
            for (i = 0; i < 26; i++)
            {
                index[i] = c++;
                sizeIndex[i] = 0;
            }

            if (args.Length == 0)
            {

                Console.Write("Linia de comanda nu contine argumente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                foreach (string param in args)
                    for (i = 0; i < 26; i++)
                        if (param[0] == index[i] || param[0] == index[i] + 32)
                            sizeIndex[i]++;
                for (i = 0; i < 26; i++)
                {
                    tablouScara[i] = new string[sizeIndex[i]];
                    sizeIndex[i] = 0; 
                }

                foreach (string param in args)
                    for (i = 0; i < 26; i++)
                        if (param[0] == index[i] || param[0] == index[i] + 32)
                            tablouScara[i][sizeIndex[i]++] += param;

                for (i = 0; i < 26; i++)
                {
                    Console.Write("Cuvinte cu " + (char)(index[i] + 32) + "/" + index[i] + ":");
                    for (int j = 0; j < sizeIndex[i]; j++)
                        Console.Write(tablouScara[i][j] + " ");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }

        }
    }
}