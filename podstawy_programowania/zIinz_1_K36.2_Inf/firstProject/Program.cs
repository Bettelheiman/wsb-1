using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a:{0}",a);

            double boka = double.Parse(a);
            boka *= boka; //boka = boka * boka

            Console.WriteLine("Pole kwadratu wynosi: {0}",boka);

            //Pole trójkąta

            Console.Write("\nPodaj podstawę trójkąta:");
            string podstawa = Console.ReadLine();

            Console.Write("\nPodaj wysokość trójkąta:");
            string wysokosc = Console.ReadLine();

            double result = 0.5 * double.Parse(podstawa) * double.Parse(wysokosc);

            Console.WriteLine("Pole trójkąta: {0}", result);

            //##################################################

            string str;
            int liczba;

            Console.Write("Podaj liczbę całowitą:");
            str = Console.ReadLine();

            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby");
            else
                Console.WriteLine("Liczba wynosi:{0}", liczba);

            //sprawdź czy liczba całkowita podana z klawiatury
            //jest parzysta

            Console.Write("Podaj x:");
            string x = Console.ReadLine();
            uint x1 = uint.Parse(x);
            if (x1 % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta",x1);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest parzysta", x1);
            }

            //sprawdź czy liczba podana z klawiatury
            //jest prawidłowa
            //następnie sprawdź czy jest nieparzysta

            Console.Write("\nPodaj liczbę całkowitą:" );
            string number = Console.ReadLine();
            uint numberUint;
            if (uint.TryParse(number, out numberUint) == true)
            {
                if (numberUint % 2 != 0)
                {
                    Console.WriteLine("Liczba {0} nie jest parzysta", x1);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest parzysta", x1);
                }
            }
            else
                Console.WriteLine("Dane podane z klawiatury są błędne!");

            /*
             * Użytkownik podaje z klawiatury dane dwóch boków
             * Oblicz pole prostokąta i obwód
             * 
             * Wyświetl w formacie:
             * Pole prostokąta wynosi: ...
             * Obwód prostokąta wynosi: ...
             * 
             * Sprawdź czy dane z klawiatury są poprawne
             * W przypadku błędnych danych wyświetl na ekranie komunikat:
             * "Podałeś błędne dane"
             */

            Console.ReadKey();
        }
    }
}
