using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_instrukcje_warunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = -5;
            if (x >3)
            {
                Console.WriteLine("prawda");
            }
            else if(x == 5)
            {
                Console.WriteLine("x rowny 5");
            }
            else
            {
                Console.WriteLine("inna");
            }
            */

            Console.Write("Podaj podstawę trójkąta:");
            string podstawa = Console.ReadLine();
            Console.Write("Podaj wysokość trójkąta:");
            string wysokosc = Console.ReadLine();
            //double x1 = double.Parse(x);

            double podstawa1, wysokosc1, pole;

            if (double.TryParse(podstawa, out podstawa1) &&
                double.TryParse(wysokosc, out wysokosc1))
            {
                //obliczenie pola trójkąta
                pole = 0.5 * podstawa1 * wysokosc1;
                //Console.WriteLine("Pole trójkąta wynosi: " + pole);
                Console.WriteLine("\nDługość podstawy: {0}, wysokość: {1}", podstawa1, wysokosc1);
                Console.WriteLine("Pole trójkąta wynosi: {0}", pole);
            }
            else
            {
                Console.WriteLine("Error! Błędne dane!!!");
            }

            Console.ReadKey();

        }
    }
}
