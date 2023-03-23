using System;
using System.Configuration;

namespace Bijuterii
{
    class Program
    {
        static void Main()
        {
            int x, b;
            long buget;
            Bijuterie[] obiect = new Bijuterie[4];
            Bijuterie inel = new Bijuterie("inel", "GoldShop", "aur", 8000, 10);
            Bijuterie medalion = new Bijuterie("medalion", "Pandora", "argint", 800, 20);
            Bijuterie pandantiv = new Bijuterie("pandantiv", "Pandora", "argint", 550, 6);
            Bijuterie bratara = new Bijuterie("bratara", "Tiffany", "aliaj", 750, 1);
            obiect[0] = inel;
            obiect[1] = medalion;
            obiect[2] = pandantiv;
            obiect[3] = bratara;

            do
            {
                Console.Clear();
                Console.WriteLine("a: Afisati bijuteriile disponibile");
                Console.WriteLine("b: Afisare optiuni in functie de buget");
                Console.WriteLine("x: Iesire ");
                x = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (x)
                {
                    case 'a':
                        Console.WriteLine("Optiuni disponibile: ");
                        Console.WriteLine();
                        for (int j = 0; j < 4; j++)
                        {
                            string c = obiect[j].afisare();
                            Console.Write(c);
                        }
                        Console.ReadKey();
                        break;
                    case 'b':
                        Console.WriteLine("Introduceti bugetul de care dispuneti: ");
                        long bug = Convert.ToInt64(Console.ReadLine());
                        b = 0;
                        for (int t = 0; t < 4; t++)
                        {
                            b = 0;
                            b = obiect[t].verifPret(bug);
                            if (b == 1)
                                Console.WriteLine(obiect[t].afisare());
                        }
                        if (b == 0)
                            Console.WriteLine("Nu aveti suficienti bani pentru cadou");
                        Console.ReadKey();
                        break;
                    case 'x':
                        Environment.Exit(1);
                        break;
                }
            } while (1 != 0);
            Console.ReadKey();
        }
    }
}