using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c;
            Console.Write("Podaj liczbę a: ");
            if (!double.TryParse(Console.ReadLine(), out a)) //jeśli błąd parsowania to komunikat
                Console.WriteLine("Wprowadzono niepoprawną wartość liczby a !!!");
            else //jesli parsowanie liczby a OK, to wprowadzenie liczby b
            {
                Console.Write("Podaj liczbę b: ");
                if (!double.TryParse(Console.ReadLine(), out b)) //jeśli błąd parsowania liczby b to komunikat
                    Console.WriteLine("Wprowadzono niepoprawną wartość liczby b !!!");
                else
                {
                    Console.Write("Podaj liczbę c: ");
                    if (!double.TryParse(Console.ReadLine(), out c)) //jeśli błąd parsowania liczby c to komunikat
                        Console.WriteLine("Wprowadzono niepoprawną wartość liczby c !!!");
                    else //parsowanie liczb: a, b i c jest OK
                    {
                        if (c > 0) Console.WriteLine("Wartość wyrażenia wynosi: " + (a * a + b));
                            else if (c < 0) Console.WriteLine("Wartość wyrażenia wynosi: " + (a - b * b));
                                else if (a == b) Console.WriteLine("Próba dzielenia przez zero");
                             //jeśli c=0 i a<> b to obliczany wyrażenie
                                    else Console.WriteLine("Wartość wyrażenia wynosi: " + (1/(a-b)));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
