namespace zadanie2
{
    public class Product
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Product(string nazwa, double cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }

    public class Magazyn
    {
        public static int LiczDrozsze(Product[] produkty, int index, double cenaMin)
        {
            // przypadek bazowy
            if (index >= produkty.Length)
                return 0;

            // krok rekurencyjny
            if (produkty[index].Cena > cenaMin)
                return 1 + LiczDrozsze(produkty, index + 1, cenaMin);

            return LiczDrozsze(produkty, index + 1, cenaMin);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] produkty =
            {
                new Product("Klawiatura",120),
                new Product("Mysz",45),
                new Product("Monitor",750),
                new Product("Pendrive",30)
            };

            double cenaMin = 100;

            Console.WriteLine($"Cena minimalna: {cenaMin}");

            Console.WriteLine();
            Console.WriteLine("Wynik:");
            Console.WriteLine();

            Console.WriteLine(
                $"Liczba produktów droższych niż {cenaMin} zł: " +
                $"{Magazyn.LiczDrozsze(produkty,0,cenaMin)}"
            );
        }
    }
}
