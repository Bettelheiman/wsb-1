using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WSB");
            Console.WriteLine("Nowa linia");

            Console.Write("Proszę podaj swoje imię: ");

            //typ string
            string name = Console.ReadLine();

            Console.Write("Masz na imię: ");
            Console.WriteLine(name);

            //typ integer
            int age = 20;
            Console.WriteLine(age);

            uint number = 10;

            //typ float
            float z = 14.55F;
            //+ konkatenacja
            Console.WriteLine("Zmienna z wynosi: " + z);

            Console.WriteLine("Program obliczający pole prostokąta");


            Console.Write("Podaj a: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");

            string y = Console.ReadLine();
            float bokB = float.Parse(y);

            //float wynik = x * bokB;
            //Console.WriteLine("Pole wynosi: " + wynik);

            //x *= bokB; // x = x * bokB
            //Console.WriteLine("Pole wynosi: " + x);

            Console.WriteLine("Pole wynosi: " + x * bokB);

            int j, k = 10, l;

            //int zmienna = 10;
            int zmienna = new int();







            Console.ReadKey();

        }
    }
}
