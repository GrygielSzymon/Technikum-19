//Napisz klasę Uczen, która zawiera pola:
//imię i nazwisko (String),
//lista ocen (np. tablica lub kolekcja typu List<Integer>).

//Dodaj metody:
//dodajOcene(int ocena) – dodaje ocenę(sprawdź warunkiem, czy ocena mieści się w zakresie 1–6),
//obliczSrednia() – zwraca średnią ocen,
//wypiszOceny() – wypisuje wszystkie oceny.

//Dodatkowo:
//w metodzie obliczSrednia użyj pętli do sumowania ocen,
//w metodzie wypiszOceny iteruj po kolekcji i wyświetl każdą ocenę.

namespace Rejerstr_ocen_ucznia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uczen uczen = new Uczen();
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Dodaj ocenę");
                Console.WriteLine("2. Średnia ocen");
                Console.WriteLine("3. Wypisz wszystkie oceny");
                Console.WriteLine("4. Wyjście");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        uczen.dodajOcene();
                        break;
                    case 2:
                        double srednia = uczen.sredniaOcen();
                        Console.WriteLine("Średnia ocen: " + srednia);
                        break;
                    case 3:
                        uczen.wypiszOceny();
                        break;
                    default:
                        Console.WriteLine("Zły wybór");
                        break;
                }
            }
        }


        public class Uczen
        {
            public string Imie;
            public string Nazwisko;
            public List<int> Oceny = new List<int>();

            public void dodajOcene()
            {
                Console.Write("Podaj ocenę: ");
                int ocena = int.Parse(Console.ReadLine());

                if (ocena >= 1 && ocena <= 6)
                {
                    Oceny.Add(ocena);
                    Console.WriteLine($"Dodano ocenę: {ocena}");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa ocena. Podaj ocenę od 1 do 6.");
                }
            }

            public double sredniaOcen()
            {
                if (Oceny.Count == 0)
                {
                    Console.WriteLine("Brak ocen do obliczenia średniej.");
                    return 0;
                }

                double suma = 0;

                foreach (var ocena in Oceny)
                {
                    suma += ocena;
                }

                return suma / Oceny.Count;

            }

            public void wypiszOceny()
            {
                foreach (var ocena in Oceny)
                {
                    Console.Write(ocena + " ");
                }
            }
        }



    }
}
