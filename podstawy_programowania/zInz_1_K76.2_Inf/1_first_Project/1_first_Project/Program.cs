using System;

namespace _1_first_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: "); //wyświetli imię
            Console.WriteLine("Janusz");

            /* Komentarz
             * w wielu
             * liniach
             */

            /*
             *  #
             *  ##
             *  ###
             *  ####
             */

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Kasia";

            // + konkatenacja
            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("Masz na imię: {0}",name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1} lat",name,age);

            sbyte age1 = 20;
            Console.WriteLine("Wiek: {0}", age1);

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("\nPodaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("a = {0}",a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}",result);

            /*
             * oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
             */





            Console.ReadKey();
        }
    }
}
