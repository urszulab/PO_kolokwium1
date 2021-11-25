/* Napisac program do wczytywania z klawiatury ciagu liczb zakonczonego zere i wyswietlenia sredniej arytmetycznej 
wszystkich wprowadoznych liczb(bez zera). */

using System;

namespace kolokwium1_zad4
{
    class Program
    {
        public static void Main()
        {
            int suma = 0; //inicjalizujemy zmienna suma wartoscia 0
            int x; //zmienna x, ktora bedzie przechowywac kolejne wyrazy ciagu
            int ilosc = 0;
            do
            {       //wczytujemy zmienna x:
                Console.WriteLine("Podaj wyraz ciagu (ostatni element: 0): ");
                x = Convert.ToInt32(Console.ReadLine());
                suma += x;
                ilosc++;
            }
            while (x != 0);
            double srednia = Convert.ToDouble(suma) / (ilosc-1);
            Console.WriteLine("Srednia wynosi wynosi: {0}", srednia);
            Console.ReadKey();
        }
    }
}
