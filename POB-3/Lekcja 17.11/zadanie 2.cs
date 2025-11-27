//Zadanie 2 — Zarządzanie flotą pojazdów
//Wykorzystane elementy: interfejsy, klasy pochodne, algorytm filtrowania i sortowania.

//Opis
//Utwórz interfejs IPojazd:
//interface IPojazd
//{
//    double PobierzSpalanie();  // l/100km
//    string GetInfo();
//}
//Utwórz klasy:
//Samochod(moc, spalanie, marka)
//Motocykl(pojemność, spalanie)
//Autobus(liczba miejsc, spalanie)

//W Main():
//Dodaj różne pojazdy do listy.
//Znajdź pojazdy o spalaniu poniżej wartości podanej przez użytkownika.
//Posortuj wyniki rosnąco po spalaniu.
//Wypisz je w formacie z metody ToString().

namespace ConsoleApp3
{
    interface IPojazd
    {
        double PobierzSpalanie();  // l/100km
        string GetInfo();
    }
    public class Samochod : IPojazd
    {
        public double Moc { get; set; }
        public double Spalanie { get; set; }
        public string Marka { get; set; }
        public Samochod(int moc, double spalanie, string marka)
        {
            Moc = moc;
            Spalanie = spalanie;
            Marka = marka;
        }
        public double PobierzSpalanie() => Spalanie;
        public string GetInfo() => $"Moc: {Moc}, Marka: {Marka}, Spalanie: {Spalanie}";
        public override string ToString() => GetInfo();
    }
    public class Motocykl : IPojazd
    {
        public double Pojemnosc { get; set; }
        public double Spalanie { get; set; }
        public Motocykl(double pojemnosc, double spalanie)
        {
            Pojemnosc = pojemnosc;
            Spalanie = spalanie;
        }
        public double PobierzSpalanie() => Spalanie;
        public string GetInfo() => $"Pojemnosc: {Pojemnosc}, Spalanie: {Spalanie}";
        public override string ToString() => GetInfo();
    }
    public class Autobus : IPojazd
    {
        public int LiczbaMiejsc { get; set; }
        public double Spalanie { get; set; }
        public Autobus(int liczbaMiejsc, double spalanie)
        {
            LiczbaMiejsc = liczbaMiejsc;
            Spalanie = spalanie;
        }
        public double PobierzSpalanie() => Spalanie;
        public string GetInfo() => $"Liczba Miejsc: {LiczbaMiejsc}, Spalanie: {Spalanie}";
        public override string ToString() => GetInfo();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPojazd> list = new List<IPojazd>()
            {
                new Samochod(356, 10, "Porsche"),
                new Samochod(220, 12, "BMW"),
                new Motocykl(1000, 5),
                new Motocykl(150, 3),
                new Autobus(50, 25),
                new Autobus(100, 40)
            };

            Console.Write("Podaj maksymalne spalanie(l/100km): ");
            double limit = double.Parse(Console.ReadLine());

            List<IPojazd> wynik = new List<IPojazd>();

            foreach (var p in list)
            {
                if (p.PobierzSpalanie() < limit)
                {
                    wynik.Add(p);
                }
            }

            BubbleSort(wynik);

            foreach (var p in wynik)
                Console.WriteLine(p);


        }
        static void BubbleSort(List<IPojazd> lista)
        {
            for (int j = 0; j < lista.Count - 1; j++)
            {
                for (int i = 0; i < lista.Count - 1 - j; i++)
                {
                    if (lista[i].PobierzSpalanie() > lista[i + 1].PobierzSpalanie())
                    {
                        IPojazd temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                    }
                }
            }
        }
    }
}
