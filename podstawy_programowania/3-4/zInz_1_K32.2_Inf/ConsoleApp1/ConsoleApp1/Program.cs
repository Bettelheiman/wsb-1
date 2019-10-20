using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj liczbę a: ");
            if (!double.TryParse(Console.ReadLine(), out a)) //jeśli błąd parsowanie to komunikat
                Console.WriteLine("Wprowadzono niepoprawną wartość liczby a !");
            else //jeśli parsownie liczby a OK, to wprowadzenie liczby b
            {
                Console.Write("Podaj liczbę b: ");
                if (!double.TryParse(Console.ReadLine(), out b))
                        Console.WriteLine("Wprowadzono niepoprawną wartość liczby b !");
                else //obie liczby poprawne -> obliczenie wyrażenia
                    Console.Write("Podaj liczbę c: ");
                    if (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Wprowadzono niepoprawną wartość liczby c !");
                    else
                    {
                        if (c > 0) Console.WriteLine("Wartość wyrażenia wynosi: " + (a * a + b));
                        else
                            if (c < 0) Console.WriteLine("Wartość wyrażenia wynosi: " + (a - b * b));
                            else
                            if (a == b) Console.WriteLine("Próba dzielenia przez zero ");
                            else Console.WriteLine("Wartość wyrażenia wynosi: " + (1 / (a - b)));                                                    }
                    }
                Console.ReadKey();
            }
        }
    }
}
