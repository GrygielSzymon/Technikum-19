//Zadanie 2 — „Zwierzęta w zoo”
//Utwórz abstrakcyjną klasę `Zwierze` z właściwościami: `public string Nazwa { get; protected set; }`
//`public int Wiek { get; protected set; }` oraz metodami abstrakcyjnymi: `void WydajDzwiek()` i `void Jedz()`
//Zaimplementuj klasy:
//`Lew`,
//`Slon`,
//`Papuga`.
//Każda z nich ma inne zachowanie metod.
//Napisz metodę `SymulacjaDnia()` w klasie `Program`, która dla listy zwierząt wywołuje ich metody w losowej kolejności.
//Użyj klasy `Random` i prostego algorytmu losowania.
namespace zadanie
{
    public class Pojazd
    {
        protected double Predkosc { get; set; }
        public void Jedzie()
        {
            Console.WriteLine("Samochód jedzie");
        }
    }
    public class Samochod : Pojazd
    {
        private string Marka { get; set; }
        private string Model { get; set; }
        private double Cena { get; set; }

        public Samochod(string marka, string model, double cena, double predkosc)
        {
            Marka = marka;
            Model = model;
            Cena = cena;
            Predkosc = predkosc;
        }

        public void WyswietlCene()
        {
            if (Cena <= 0)
            {
                Console.WriteLine("Zła cena");
            }
            else
            {
                Console.WriteLine($"Cena samochodu: {Cena}zł");
            }
        }
        public void NowaCena() => Console.WriteLine($"Cena po rabacie: {Cena - 100000}zł");
        public void NazwaAuta() => Console.WriteLine($"Samochód: {Marka} {Model}");
        public void Jedzie() => Console.WriteLine($"{Marka} {Model} jedzie {Predkosc}km/h");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod porsche = new Samochod("Porsche", "911 gt3 rs", 1900000, 220);
            porsche.NazwaAuta();
            porsche.WyswietlCene();
            porsche.NowaCena();
            porsche.Jedzie();

        }
    }
}
