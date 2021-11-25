/*  W funkcji main po wyswietleniu odpowiedniego komunikatu wczytac z klawiatury dwie liczby calkowite M i N oraz przekazac do drugiej funkcji, 
w ktorej nalezy wymienic miedzy soba wartosci tych zmiennych. W funkcji main wyswietlic wartosci zmiennych przed zamiana i po zamianie. */

using System;

namespace Zad_2
{
    class Program
    {   
        static void Zamiana(int a, int ref b)
        {
            int x = a;    
            a = b;
            b = x;
            return Console.WriteLine(Zamiana(a, b));
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Przed zmiana: M = {0}, N = {1}", m, n);
            Zamiana(m, ref n);
        }
    }
}
