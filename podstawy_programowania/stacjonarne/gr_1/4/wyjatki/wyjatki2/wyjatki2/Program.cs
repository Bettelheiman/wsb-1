﻿using System;
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
                /*
                try
                {
                    string x = Console.ReadLine();
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Pamieć");
                }
                */
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wprawadź liczbę w poprawnym formacie np. 4\n");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczlnym zakresem");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295>\n");
                }
                catch(ArgumentNullException) 
                {
                    Console.WriteLine("Pusta wartość\n");
                }
                Console.WriteLine("Wprowadź poprawnie wartość");
            }
            Console.WriteLine("\nLiczba całkowita: {0}", number);
            Console.ReadKey();
        }
    }
}
