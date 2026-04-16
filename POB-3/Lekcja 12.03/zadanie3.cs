namespace zadanzide3
{
    internal class Program
    {
        class Samochod
        {
            public string Marka { get; set; }
            public int RokProdukcji { get; set; }
            public int Przebieg { get; set; }

            public Samochod(string marka, int rok, int przebieg)
            {
                Marka = marka;
                RokProdukcji = rok;
                Przebieg = przebieg;
            }
        }
        static void Main(string[] args)
        {
            Samochod[] auta =
            {
                new Samochod("BMW", 2020, 120000),
                new Samochod("Audi", 2021, 234324),
                new Samochod("Porsche", 2026, 0),
                new Samochod("Ford", 1987, 1231431241)
            };

        }
    }
}
