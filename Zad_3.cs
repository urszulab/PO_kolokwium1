/* napisz program z uzyciem Random(), ktory wczyta z klawiatury do zmiennej n liczbe calkowita (1<=<= 150) , 
wygnereuje losow n poczatowych elementow tablicy o wartosciach calkowitych -1109 do 1109 wlacznie , 
a nastepnie znajdzie w tablicy element najwiekszy i obliczy ile razy wystepuje. */

using System;

namespace kolokwium1_zad3
{
    class Program
    {
        static void Maks(int[] tab)
        {
            int max = tab[0];
            int pozycja_max = 0;
            for (int j = 0; j < tab.Length - 1; j++)
            {
                if (tab[j + 1] > max)
                {
                    max = tab[j + 1];
                    pozycja_max = j + 1;
                }
            }
            int licznik = 0;
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] == max) licznik++;
            }
            Console.WriteLine("Najwieksza wartosc to {0}, ktora wystapila {1} razy", max, licznik);
        }
        public static void Main()
        {
            Console.WriteLine("Podaj n jako rozmiar tablicy(l.calkowita): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            Random liczba = new Random();
            for (int m = 0; m < n; m++)
            {
                tab[m] = liczba.Next(-1109, 1100);  // PRZYPISANIE KAZDEJ NOWO WYLOSOWANEJ LICZBY Z PRZEDZIALU 1-1000 DO DANEGO MIEJSCA W TABLICY
            }
            for (int k=0; k<tab.Length; k++)
            {
                Console.Write(tab[k] + " ");
            }
            Maks(tab);  
        }
    }
}
