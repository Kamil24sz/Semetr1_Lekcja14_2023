using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Semetr1_Lekcja14_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1
            Console.WriteLine("Zadanie 1");
            //Stworzenie 5 zmiennych typu string, int, float, double, char. Nadanie im
            //wartości i wyświetlenie na konsoli za pomocą Console.WriteLine();

            int wiek = 20;
            string imie = "Kamil";
            float waga = 80.4f;
            double temperatura = 36.6;
            char znak = '$';

            Console.WriteLine($"imię: {imie} \n wiek: {wiek} \n waga: {waga} \n temp.:{temperatura} \n znak:{znak}");

            //Zadanie2
            Console.WriteLine("\nZadanie 2");
            //Utworzenie pętli for, która wyświetli na ekranie 5 potęg liczby 4. 
            //for skałada się z 3 elementów 
            //1. deklaracja zmiennej startowej
            //2. warunek - liczba końcowa
            //3. o ile ma się zwiększać zmienna startowa
            for(int x = 1; x <= 5; x++)
            {
                Console.WriteLine($"4 do potęgi {x} = {Math.Pow(4,x)}");
            }
            //Math.Pow(4,1)
            //Math.Pow(4,2)
            //Math.Pow(4,3)
            //Math.Pow(4,4)
            //Math.Pow(4,5)


            //Zadanie 3
            Console.WriteLine("\nZadanie 3");
            //Napisanie programu, który będzie pobierać z konsoli wiek i ilość pieniędzy
            //użytkownika a następnie przy pomocy instrukcji if sprawdzać, czy może wejść
            //do kina na film „Piła”. Warunki wejścia na seans to: cena biletu: 20, wiek: 16
            //lat.Sprawdzenie, czy można wejść ma być realizowane w oddzielnej
            //metodzie, która nic nie zwraca i przyjmuje 2 argumenty typu int -wiek oraz
            //ilość pieniędzy.

            //pobieranie danych od usera
            //1.wiek -> int
            //2.budżet -> decimal
            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Budżet: ");
            decimal budżet = decimal.Parse(Console.ReadLine());

            if (age >= 16 && budżet >= 20)
            {
                Console.WriteLine("Zapraszamy na seans");
            }
            if(age < 16)
            {
                Console.WriteLine("Jesteś za młody żeby wejść");
            }
            if(budżet < 20)
            {
                Console.WriteLine("Masz za mało pieniędzy żeby wejść");
            }


            //Zadanie 4
            Console.WriteLine("\nZadanie 4");
            //Stwórz tablicę o nazwie liczby do której dodasz 10 dowolnych liczb
            //całkowitych.Następnie wykonaj poniższe polecenia bazując na tej tablicy.
            //a.wyświetl wszystkie elementy z tablicy na konsoli.Wykorzystaj do tego
            //pętle for.
            //b.znajdź i wyświetl największą liczbę, która jest w tablicy
            //c.znajdź i wyświetl najmniejszą liczbę, która jest w tablicy
            //d.oblicz średnią arytmetyczną z podanych liczb w tablicy a następnie wyświetl wynik

            int[] liczby = {3, 5, 7, 8, 9, 124, 2, -12, 12, 43};
            int min = liczby[0];
            int max = liczby[0];
            int suma = 0;

            // a - wyświetlanie
            Console.WriteLine("\na)wypisywanie");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(liczby[x]);

                //c - najmniejsza
                if(min > liczby[x])
                {
                    min = liczby[x];
                }

                //b - największa
                if(max < liczby[x])
                {
                    max = liczby[x];
                }

                //d - średnia
                suma = suma + liczby[x];
            }
            Console.WriteLine("\nb)maksymalna liczba");
            Console.WriteLine($"max: {max}");
            Console.WriteLine("\nc)minimalna liczba");
            Console.WriteLine($"min: {max}");
            Console.WriteLine("\nd)średnia");
            Console.WriteLine($"avg: {(double)suma/10}");  //241 / 10 = 24.1
            // liczby[0]
            // liczby[1]
            // ...
            // liczby[9]
            Console.ReadLine();
        }
    }
}
