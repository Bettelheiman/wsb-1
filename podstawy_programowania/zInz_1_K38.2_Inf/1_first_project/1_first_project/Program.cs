using System;


namespace _1_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: "); //wyświetli Imię
            Console.WriteLine("Janusz");
            /* komentarz
             * w wielu
             * liniach
             */

            /*
             *   #
             *   ##
             *   ###
             */
            Console.WriteLine("#\n##\n###");

            string name;
            name = "Anna";

            Console.WriteLine(name);
            //+ konkatenacja
            Console.WriteLine("Masz na imię: " + name);
            Console.WriteLine("Masz na imię: {0}",name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1}",name,age);

            sbyte age1 = 20;
            Console.WriteLine("Masz na imię: {0}, wiek1: {1}", name, age1);

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a={0}",a);

            double boka = double.Parse(a);

            //double pole = boka * boka;
            //Console.WriteLine("Pole kwadratu wynosi:{0}",pole);

            //boka = boka * boka;
            boka *= boka;
            Console.WriteLine("Pole kwadratu wynosi:{0}",boka);

            //pole trójkąta
            Console.Clear();
            Console.Write("\nPodaj podstawę trójkąta:");
            string podstawa = Console.ReadLine();

            Console.Write("\nPodaj wysokość trójkąta:");
            string wysokosc = Console.ReadLine();

            double result = 0.5 * double.Parse(podstawa) * double.Parse(wysokosc);

            Console.WriteLine("Pole trójkąta: {0}", result);
            Console.Clear();

            //##############################################

            string str;
            int liczba;

            Console.Write("Podaj liczbę całkowitą:");
            str = Console.ReadLine();

            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby");
            else
                Console.WriteLine("Liczba wynosi:{0}",liczba);

            /*
             * sprwdź czy liczba podana z klawiatury
             * jest całkowita dodatnia 
             * następnie sprawdź czy jest parzysta
             */

            Console.WriteLine("\nPodaj liczbę całkowitą: ");
            string number = Console.ReadLine();
            uint numberUint;

            if (uint.TryParse(number, out numberUint) == true)
            {
                if (numberUint % 2 != 0)
                    Console.WriteLine("Liczba {0} nie jest parzysta",numberUint);
                else
                    Console.WriteLine("Liczba {0} jest parzysta", numberUint);
            }
            else
                Console.WriteLine("Podane dane z klawiatury są błędne!");

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

            age = 18;

            if (age < 18)
                Console.WriteLine("Masz mniej niż 18 lat");
            else if(age == 18)
                Console.WriteLine("Masz 18 lat");
            else
                Console.WriteLine("Masz więcej niż 18 lat");

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
                                Console.WriteLine("Inna wartość liczby:{0}",liczba);
                            break;
                        }

























            /*
            int liczba = 10;
            switch (liczba)
            {
                case 5 :
                    Console.WriteLine("Liczba = 5");
                    break;
                case 10:
                    Console.WriteLine("Liczba = 10");
                    break;
                case 15:
                    Console.WriteLine("Liczba = 15");
                    break;
            }
            */






            Console.ReadKey();
        }
    }
}
