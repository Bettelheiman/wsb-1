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

            Console.ReadKey();
        }
    }
}
