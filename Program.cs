using System;
using System.Collections.Generic;

namespace Interfejss
{
    class Program 
    {
        
    public static  osoba uzupelnianie()
        {
            Console.WriteLine("Podaj imię");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string nazwisko = Console.ReadLine();
            osoba test = new osoba(imie, nazwisko);
            Console.Clear();

            return test;
        }
        static void Main(string[] args)
        {
            List<osoba> lista = new List<osoba>();


            for (int i = 0; i < 2; i++)
            {
                lista.Add(uzupelnianie());   
            }
            lista.Sort();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Nazywam się {lista[i].Imie} {lista[i].Nazwisko}" );
            }
        }
    }
}
