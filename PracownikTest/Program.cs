using System;
using PracownikBiblioteka;

namespace PracownikTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kierownik kierownik_top = new("Główny kierownik");
            Kierownik kierownik_1 = new("drugi kierownik");
            Kierownik kierownik_2 = new("trzeci kierownik");
            Pracownik pracownik_1 = new("pracownik1");
            Pracownik pracownik_2 = new("pracownik2");
            Pracownik pracownik_3 = new("pracownik3");
            Pracownik pracownik_4 = new("pracownik4");

            kierownik_top.Add(kierownik_1);
            kierownik_1.Add(pracownik_1);
            kierownik_top.Add(pracownik_2);
            kierownik_1.Add(kierownik_2);
            kierownik_2.Add(pracownik_3);
            kierownik_2.Add(pracownik_4);

            Console.WriteLine("Struktura: " + kierownik_top.WyswietlInformacje());
            Console.WriteLine("Count: " + kierownik_top.Count().ToString());
        }
    }
}
