using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int liczba;

            Console.Write("Podaj liczbę całkowitą:");
            str = Console.ReadLine();

            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Zły format liczby!");
            }
            else
            {
                Console.WriteLine("Liczba wynosi: {0}", liczba);
            }

            /*
             * sprawdź czy dane podane z klawiatury są
             * liczbą całkowitą dodatnią
             * nastęnie sprawdź czy liczba jest nieparzysta
             */
            Console.Clear();
            string number;
            uint numberUint;

            Console.Write("Podaj liczbę całkowitą dodatnią:");
            number = Console.ReadLine();

            if (uint.TryParse(number, out numberUint) == true)
            {
                if (numberUint % 2 != 0)
                    Console.WriteLine("Liczba {0} jest nieparzysta", numberUint);
                else
                    Console.WriteLine("Liczba {0} jest parzysta", numberUint);
            }
            else
            {
                Console.WriteLine("Zły format liczby!");
            }

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

            byte age = 18;
            if (age == 18)
            {
                Console.WriteLine("Masz 18 lat");
            }else if(age < 18){
                Console.WriteLine("Masz mniej niż 18 lat\n");
            }
            else
            {
                Console.WriteLine("Masz powyżej 18 lat\n");
            }

            //switch

            liczba = 11;
            switch (liczba)
            {
                case 5:
                    Console.WriteLine("Liczba = 5");
                    break;
                case 10:
                    Console.WriteLine("Liczba = 10");
                    break;
                case 15:
                    Console.WriteLine("Liczba = 15");
                    break;
                default:
                    Console.WriteLine("Liczba ma wartość: {0}",liczba);
                    break;
            }

            /*
             * Użytkownik podaje z klawiatury swoją narodowość
             * wykorzystaj instrukcję switch do wyświetlenia pochodzenia
             * Do wyboru użytkownik ma 3 kraje: Polska, USA, Hiszpania
             * Uważaj na wielkość liter podanych przez użytkownika
             */
            Console.Clear();
            Console.Write("Podaj swoją narodowość:");
            string country;
            country = Console.ReadLine();

            switch (country.ToLower())
            {
                case "polska":
                    Console.Write("Narodowość: {0}", country);
                    Console.WriteLine(", mówisz w języku polskim");
                    break;

                case "usa":
                    Console.Write("Narodowość: {0}", country);
                    Console.WriteLine(", mówisz w języku angielkim");

                    break;
                case "hiszpania":
                    Console.Write("Narodowość: {0}", country);
                    Console.WriteLine(", mówisz w języku hiszpańskim");

                    break;
                default:
                    Console.WriteLine("Jesteś z {0}", country);
                    break;
            }

            //pętle

            //wypisz liczby od <1;10>
            int i;

            for(i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            /*
             * Napisz program, który wypisuje ulubione kolory
             * Kolory przypisz do zmiennej colors
             * Użytkownik z klawiatury podaje ilość ulubionych kolorów
             * wykorzystaj pętlę for do przypisania kolorów do zmiennej
             */

            Console.Write("Podaj ilość ulubionych kolorów:");
            string color = "",x;
            string count = Console.ReadLine();
            byte count1;
            //while(byte.TryParse(count, out count1) == false)
            {
                for (i=0; i<=count1; i++)
                {
                    //Console.Write("Podaj kolor:");
                    //x = Console.ReadLine();
                    //color += x;
                }
            }

            Console.WriteLine("Kolory: {0}", color);


            Console.ReadKey();
        }
    }
}
