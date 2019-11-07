using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_instrukcje_warunkowe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczanie pola trójkąta\n");
            Console.Write("Podaj długość podstawy:");
            string x1 = Console.ReadLine();
            Console.Write("Podaj wysokość:");
            string x2 = Console.ReadLine();
            int y1, y2;
            double pole;
            //y1 = int.Parse(x1);
            if (int.TryParse(x1, out y1) && int.TryParse(x2, out y2))
            {
                //obliczenia pola trójkąta
                pole = 0.5 * y1 * y2;
                Console.WriteLine("\nDługość podstawy: {0}, wysokość: {1}", x1, x2);
                Console.WriteLine("Pole trójkąta wynosi: {0}", pole);          
            }
            else
            {
                //Error!
                Console.WriteLine("Podałeś błędne dane!");
            }

            Console.ReadKey();
        }
    }
}
