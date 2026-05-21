namespace zadanie2
{
    public class Product
    {
        public string Nazwa {  get; set; }
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
            int liczbaDrozsze = 0;
            for (int i = 0; i < produkty.Length; i++)
            {
                if (produkty[i].Cena >= cenaMin)
                {
                    liczbaDrozsze++;
                }
            }
            return liczbaDrozsze;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Product[] produkty =
            {
                new Product("Klawiatura", 120),
                new Product("Mysz", 45),
                new Product("Monitor", 750),
                new Product("Pendrive", 30)
            };

            double cenaMin = 100;
            
            Console.WriteLine($"Cena Minimalna: {cenaMin}");
            Console.WriteLine();
            Console.WriteLine("Wynik:");
            Console.WriteLine();
            Console.WriteLine($"Liczba produktów droższych niż {cenaMin} zł: {Magazyn.LiczDrozsze(produkty, 1, cenaMin)}");


        }
    }
}
