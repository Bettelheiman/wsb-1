using System;


namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: "); //your name
            Console.WriteLine("Janusz");
            /*komentarz
             * w wielu
             * liniach
             */

            string name = "Anna";
            Console.WriteLine(name);
            //+ konkatenacja
            Console.WriteLine("Masz na imię: " + name);
            Console.Write("Masz na imię: ");
            Console.WriteLine(name);

            Console.WriteLine("Masz na imię: {0}",name);

            int age = 20;
            sbyte age1 = 20;

            Console.WriteLine("Wiek: {0}, imię: {1}", age, name);
            Console.WriteLine("Wiek1: {0}, imię: {1}", age1, name);


            Console.ReadKey();
        }
    }
}
