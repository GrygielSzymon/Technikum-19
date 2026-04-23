using System.Diagnostics.CodeAnalysis;

namespace Sprawdzian
{
    public class Kursant
    {
        public string Nazwisko { get; set; }
        public int Punkty { get; set; }
        public int Zadania { get; set; }

        public Kursant(string nazwisko, int punkty, int zadania) 
        {
            Nazwisko = nazwisko;
            Punkty = punkty;
            Zadania = zadania;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Kursant[] kursanci =
            {
                new Kursant("Dudzik", 6, 1),
                new Kursant("Taksik", 7, 2),
                new Kursant("Cygan", 5, 3),
                new Kursant("Szefc", 1, 4)
            };

            foreach (var item in kursanci)
            {
                Console.WriteLine($"Kursant: {item.Nazwisko}, Punkty: {item.Punkty}, Zadania: {item.Zadania}");
            }
            Console.WriteLine();

            //2
            double sum = 0;
            for (int i = 0; i < kursanci.Length; i++)
            {
                sum += kursanci[i].Punkty;
            }
            double srednia = sum / kursanci.Length;
            Console.WriteLine($"Średnia punktów kursantów: {srednia}");
            Console.WriteLine();

            //3
            int maxP = kursanci[0].Punkty;
            for (int i = 0; i < kursanci.Length; i++)
            {
                if (maxP < kursanci[i].Punkty)
                {
                    maxP = kursanci[i].Punkty;
                }
            }
            Console.WriteLine($"Najlepszy kursant ma {maxP} punktów");
            Console.WriteLine();

            //4
            double skutecznosc;
            for (int i = 0; i < kursanci.Length; i++)
            {
                skutecznosc = kursanci[i].Punkty / kursanci[i].Zadania;
                Console.WriteLine($"Skuteczność kursanta o indexie {i} wynosi {skutecznosc}");
            }
            Console.WriteLine();

            //6
            string nazwiskoSzukanego = "Taksik";
            for (int i = 0; i < kursanci.Length; i++)
            {
                if (kursanci[i].Nazwisko == nazwiskoSzukanego)
                {
                    Console.WriteLine($"Znaleziono kursanta o nazwisku: {nazwiskoSzukanego} na indexie: {i}");
                }
            }
        
        }
    }
}
