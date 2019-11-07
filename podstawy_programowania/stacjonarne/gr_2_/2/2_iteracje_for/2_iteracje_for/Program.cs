using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_iteracje_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //wyświetl liczby z przedziału <1;3>
            for (int i = 1; i <= 3; i++)
            {
                //Console.Write("Zmienna i wynosi" + i + " ");
                Console.Write("{0} ",i);
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
             *
             */

            Console.ReadKey();
        }
    }
}
