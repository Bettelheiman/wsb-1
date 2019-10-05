using System;

namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: "); //wyświetli Imię:
            Console.WriteLine("Kasia");

            /* komentarz
             * w wielu
             * liniach
             */

            /*
             *      #
             *      ##
             *      ###
             *      ####
             */

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Janusz";

            // + konkatenacja
            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1}", age, name);

            sbyte age1 = 127;
            Console.WriteLine("Masz na imię: {0}, wiek1: {1}", age1, name);

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a:{0}",a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}",result);

            /*
             * Oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
             */

            Console.ReadKey();
        }
    }
}
