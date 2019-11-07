using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_iteracja_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //wyświetl liczby całkowite z przedziału <1;10>
            for (int i=1; i <= 10 ; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //wyświetl liczby parzyste z przedziału <5;20> w porządku malejącym

            for (int i = 20; i >= 5; i--)
            {
                if (i % 2 == 0)
                {
                Console.Write("{0} ", i);
                }
            }

            /*
             * Wyświetl na ekranie:
             * 
             *  *
             *  **
             *  ***
             *  ****
             *  *****
             *  
             *  Wysokość choinki użytkownik podaje z klawiatury
             */

            Console.Write("\n\nPodaj wysokość choinki:");
            string x = Console.ReadLine();
            int x1;
            Console.WriteLine();
            if (int.TryParse(x, out x1) == true)
            {
                for (int i = 1; i <= x1; i++)
                {
                    //Console.WriteLine("{0} ", i);
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Błędne dane!");
            }
            
            Console.ReadKey();
        }
    }
}
