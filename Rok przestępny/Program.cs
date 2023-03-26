using System;

namespace Rok_przestępny
{
    internal class Program
    {
        static void Main(string[] args)

            //Zadanie nr 4 tydzień 2
        {
            Console.WriteLine("Podaj rok...");
            
            string liczba = Console.ReadLine();

           int a = int.Parse(liczba);

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            {
                Console.WriteLine(liczba + " jest rokiem przestępnym");
            }
            else Console.WriteLine(liczba + " nie jest rokiem przestępnym");
            




            

            

            

        }
    }
}
