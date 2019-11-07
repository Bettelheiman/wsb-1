using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {
                Console.Write("Wprowadź liczbę całkowitą: ");
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295>\n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartość nie może być pusta\n");
                }
                Console.WriteLine("Wprowadź poprawnie wartość");
            }

            Console.WriteLine("\nLiczba całkowita: {0}", number);
            Console.ReadKey();
        }
    }
}
