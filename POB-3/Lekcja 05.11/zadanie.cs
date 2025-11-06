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
        private string Marka {get;set;}
        private string Model {get;set;}
        private double Cena { get;set;}

        public Samochod(string marka, string model, double cena, double predkosc)
        {
            Marka = marka;
            Model = model;
            Cena = cena;
            Predkosc = predkosc;
        }

        public void WyswietlCene()
        {
            if (IsNullOrEmpty(Marka))
            {
                Console.WriteLine("Wprowadż markę.");
            }
            else
            {
                Console.WriteLine($"Cena: {Cena}zł");
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
            Samochod porsche = new Samochod("", "911 gt3 rs", 1900000, 220);
            porsche.NazwaAuta();
            porsche.WyswietlCene();
            porsche.NowaCena();
            porsche.Jedzie();

        }
    }
}
