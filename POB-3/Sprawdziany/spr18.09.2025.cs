//zadanie 1
namespace SprawdzianPojazdy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            samochod.Marka = "Porshe";
            samochod.Predkosc = 150;
            samochod.IloscDrzwi = 2;
            samochod.PokazDane();
            samochod.Jazda();

            if (samochod.Predkosc >120)
            {
                Console.WriteLine("Samochód jedzie za szybko.");
            }
            else
            {
                Console.WriteLine("Prędkośc bezpieczna.");
            }

        }
    }

    public class Pojazd
    {
        public string Marka;
        public int Predkosc;

        public void PokazDane()
        {
            Console.WriteLine($"Marka: {Marka}, Prędkośc: {Predkosc}");
        }
    }

    public class Samochod : Pojazd
    {
        public int IloscDrzwi;

        public void Jazda()
        {
            Console.WriteLine("Samochód jedzie.");
        }
    }
}
//zadanie 2
namespace SprawdzianSklep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklep sklep = new Sklep();
            sklep.Nazwa = "chleb";
            sklep.Cena = 15;
            sklep.Ilosc = [1, 2, 3, 4];
            sklep.PokazProdukt();
            sklep.PokazIlosc();
            sklep.SumaIlosci();
        }
    }

    public class Produkt
    {
        public string Nazwa;
        public double Cena;
    }

    public class Sklep : Produkt
    {
        public int[] Ilosc;

        public void PokazProdukt()
        {
            Console.WriteLine($"Produkt: {Nazwa}, Cena: {Cena}");
        }

        public void PokazIlosc()
        {
            foreach (var ilosc in Ilosc)
            {
                Console.WriteLine($"Ilość: {ilosc}");
            }
        }

        public void SumaIlosci()
        {
            int sum = 0;
            for (int i = 0; i < Ilosc.Length; i++)
            {
                sum += Ilosc[i];
            }
            Console.WriteLine($"Suma: {sum}");
        }
    }
}
