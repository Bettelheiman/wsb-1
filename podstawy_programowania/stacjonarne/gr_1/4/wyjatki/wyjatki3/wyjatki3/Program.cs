using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
                Console.Write("Podaj dzień tygodnia(poniedziałek-wtorek):");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }

            //################################################



            switch (x)
            {
                case 1:
                    Console.WriteLine("poniedziałek"); 
                    break;
                case 2:
                    Console.WriteLine("wtorek"); 
                    break;
                case 6:
                    throw new System.Exception("Masz już weekend, błędnie podana wartość"); 
                    break;
                case 7:
                    throw new System.Exception("Niedziela, błędnie podana wartość");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Liczba powinna być z zakresu od 1-5");
                    break;
            }
/*
 * Napisz kalkulator z zabezpieczeniami
 */
            Console.ReadKey();
        }
    }
}
