using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true) { 
            Console.Write("Wprowadź liczbę całkowitą:");
            string x = Console.ReadLine();
            try
            {
                number = uint.Parse(x);
                break;
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
                Console.WriteLine("Podaj jeszcze raz liczbę całkowitą\n\n");
            }

            Console.WriteLine("Liczba całkowita wynosi: {0}", number);

            Console.ReadKey();
        }
    }
}
