using System;

namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Podaj x:");
            string x = Console.ReadLine();
            uint x1;
            //uint x1 = uint.Parse(x);

            if (uint.TryParse(x, out x1) == false)
            {
                Console.WriteLine("Błędne dane!");
            }
            else
            {
                if (x1 % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta", x1);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta", x1);
                }
            }

            //switch

            string kraj;
            Console.Write("Podaj kraj pochodzenia:");
            kraj = Console.ReadLine();
            switch (kraj.ToLower())
            {
                case "polska":
                    Console.WriteLine("\nKraj pochodzenia: Polska");
                    break;
                case "hiszpania":
                    Console.WriteLine("\nKraj pochodzenia: Hiszpania");
                    break;
                default:
                    Console.WriteLine("\nKraj pochodzenia: inny");
                    break;
            }
            Console.WriteLine();

            //pętle
            //program który sumuje całkowite liczby nieparzyste z przedziału <1;10>

            int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma wynosi: {0}\n", suma);

            //A - Z

            char znak = 'A';
            for (; znak <= 'Z' ;znak++ )
            {
                if (znak == 'Z')
                    Console.Write("{0}.",znak);
                else
                    Console.Write("{0}, ",znak);

            }
            Console.WriteLine();

            znak--;
            for (; znak >= 'A'; znak--)
            {
                if (znak == 'A')
                    Console.Write("{0}.", znak);
                else
                    Console.Write("{0}, ", znak);

            }
            Console.WriteLine("\n");

            /*
             *Napisz program, który za pomocą instrukcji while dla danych wartości x 
             * zmieniających się w przedziale od 0 do 10 oblicza wartość funkcji y = 3x
            */

            int x2 = 0, y = 0;

            while (x2 <= 10)
            {
                y = 3 * x2;
                Console.WriteLine("x = {0}\ty = {1}", x2, y);
                x2++;
            }

            /*
             * Napisz program, któy za pomocą instrukcji while
             * dla danych wartości x zmieniających się w przedziale od 1 do 50
             * obliczy ich sumę
             */

            x2 = 1;
            suma = 0;

            while (x2 <= 50)
            {
                suma += x2;
                x2++;
            }

            Console.WriteLine("\nSuma wynosi: {0}\n", suma);

            /*
             * Użytkownik podaje z klawiatury swój wiek z przedziału od 1 do 120
             * wykorzystaj instrukcję do...while do prawidłowego podania danych
            */

            int age;

            do
            {
                Console.Write("Podaj swój wiek:");
                age = int.Parse(Console.ReadLine());
            } 
            while (age < 1 || age > 120);

            Console.WriteLine("\nWiek wynosi {0}\n", age);

            Console.ReadKey();
        }
    }
}
