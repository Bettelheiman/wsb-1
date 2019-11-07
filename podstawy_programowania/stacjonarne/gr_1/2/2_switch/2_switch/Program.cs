using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - pole kwadratu\n2 - pole koła");
            Console.Write("\nWybierz wartość:");
            string x, a;
            double a1, pole;
            x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Pole kwadratu\n");
                    Console.Write("Podaj bok kwadratu:");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out a1) == true)
                    {
                        pole = a1 * a1;
                        Console.WriteLine("Pole kwadratu o boku: {0} wynosi: {1:##.##}", a1, pole);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś błędne dane!");
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Pole koła\n");
                    Console.Write("Podaj promień koła:");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out a1) == true)
                    {
                        pole = Math.PI * a1 * a1;
                        Console.WriteLine("Pole koła o promieniu: {0} wynosi: {1:##.##}", a1, pole);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś błędne dane!");
                    }
                    break;
                default:
                    Console.WriteLine("Podałeś błędne dane!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
