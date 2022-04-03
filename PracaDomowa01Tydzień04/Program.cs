using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp0401
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Proszę podaj dowolną liczbę całkowitą:");
                var number = int.Parse(Console.ReadLine());

                var number2 = number % 2;

                if (number2 == 0)
                {
                    Console.WriteLine("Wpisana przez Ciebie liczba to liczba parzysta.");
                }
                else
                    Console.WriteLine("Wpisana przez Ciebie liczba to liczba nieparzysta.");
            }
            catch (Exception)
            {
                Console.WriteLine("Podałeś niepoprawne dane.");
            }


        }
    }
}
