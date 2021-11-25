/* 1.delta dla a*x^2 +2*x + 3*c=0 */

using System;

namespace kolokwium1_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liczby typu double to z przecinkiem, nie z kropka np. 2,5   nie 2.5
            double a, b, c, x, x1, x2;
            Console.WriteLine("Podaj wspolczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            c = double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a *3* c;
            double dzielnik = 2 * a;
            if (delta > 0 && dzielnik != 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / dzielnik;
                x2 = (-b + Math.Sqrt(delta)) / dzielnik;
                Console.WriteLine("x1={0}, y={1}", x1, x2);
                Console.ReadKey();
            }
            else if (delta < 0 || dzielnik == 0)
            {
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazania");
                    Console.ReadKey();
                }
                else Console.WriteLine("Zakaz dzielenia przez 0");
                Console.ReadKey();
            }
            else
            {
                x = -b / dzielnik;
                Console.WriteLine(" x={0}", x);
                Console.ReadKey();
            }
        }
    }
}
