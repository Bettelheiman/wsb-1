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
                Console.Write("Wprowadź liczbę całkowitą: ");
                string x = Console.ReadLine();

                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    //Console.WriteLine("Error");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine("Podałeś błędne dane: {0}\n", x);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane: {0}", number);
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
