using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
                    //suma = suma + i;
                    suma += i;
                }
            }
            Console.Write("Suma wynosi: {0} \n\n", suma);

            /*
             * Napisz program, który wyświetli duże litery alfabetu
             * od A do Z oraz od Z do A z wykorzystaniem pętli for
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
             * Napisz program, który za pomocą instrukcji while
             * dla danych wartości x zmieniających się w przedziale
             * <0;10> oblicza wartość funkcji y=4x
             */

            int x = 0, y = 0;

            while (x <= 10)
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            }
            Console.WriteLine();

            /*
             * Napisz program, który za pomocą instrukcji while
             * dla danych wartości x zmieniających się w przedziale
             * <1;50> obliczy ich sumę
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
             * Użytkownik opdaje swój wiek z klawiatury z przedziału
             * <1;120>, wykorzystaj instrukcję do...while do prawidłowego
             * podania danych
             */

            int age;

            //wersja 1
            do
            {
                Console.Write("Podaj wiek: ");
                age = int.Parse(Console.ReadLine());
            } while (age < 1 || age > 120);

            Console.WriteLine("\nWiek: {0}", age);

            //wersja 2
            string wiek;
            bool error = false;
            uint age1;
            do
            {
                Console.Write("Podaj swój wiek2:");
                wiek = Console.ReadLine();
                if (uint.TryParse(wiek, out age1) == false)
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
            } while (age1 < 1 || age1 > 120 || error == true);

            Console.WriteLine("Wiek: {0}", age1);

            /*
             * wyświetl tabliczkę mnożenia za pomocą
             * dwóch pętli do...while
             */



            Console.ReadKey();
        }
    }
}
