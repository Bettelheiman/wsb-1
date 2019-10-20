using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który za pomocą pętli for sumuje
             * liczby nieparzyste z przedziału <1;10>
             */

            int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    //Console.Write("{0} ", i);
                    //suma = suma + i;
                    //Console.Write("{0} ", suma);
                    suma += i;
                }
            }
            Console.Write("Suma wynosi: {0} \n", suma);

            /*
             * Napisz program, któy wyświetli duże litery alfabetu
             * od A do Z oraz od Z do A z wykorzystaniem dwóch pętli for
             * np. A, B, C, ..., Z.
             * np. Z, Y, X, ..., A.
             */


            char znak = 'A';

            for (; znak <= 'Z'; znak++)
            {
                if (znak == 'Z')
                {
                    Console.WriteLine("{0}.", znak);
                }
                else
                {
                    Console.Write("{0}, ", znak);

                }
            }


            for (znak--; znak >= 'A'; znak--)
            {
                if (znak == 'A')
                {
                    Console.WriteLine("{0}.", znak);
                }
                else
                {
                    Console.Write("{0}, ", znak);

                }
            }
            Console.WriteLine();

            /*
             * Napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się
             *w przedziale <0;10> oblicza wartośc funkcji y=4x
             */

            int x = 0, y = 0;

            while (x <= 10)
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            }
            Console.WriteLine("\n");

            /*
             * Napisz program, który za pomocą instrukcji while
             * dla danych wartości x z przedziału <1;50>
             * obliczy ich sumę
             */

            x = 1;
            suma = 0;

            while (x <= 50)
            {
                suma += x;
                x++;
            }

            Console.WriteLine("Suma wynosi: {0}\n", suma);

            /*
             * Użytkownik podaje swój wiek z klawiatury z przedziału <1;120>
             * Wykorzystaj instrukcjędo while do prawidłowego podania danych
             */

            string wiek;
            bool error;
            uint age;
            do
            {
                Console.Write("Podaj swój wiek:");
                wiek = Console.ReadLine();
                if (uint.TryParse(wiek, out age) == false)
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
            } while (age < 1 || age > 120 || error);

            Console.WriteLine("\nWiek: {0}", age);

            /*
             * Wyświetl tabliczkęmnożenia za pomocą dwóch pętli while
             */
            Console.ReadKey();
        }
    }
}
