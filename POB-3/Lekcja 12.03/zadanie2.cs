namespace zad1
{
    class Produkt
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Produkt(string nazwa, decimal cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Produkt[] produkty = new Produkt[5];

            produkty[0] = new Produkt("kiełbasa", 12.1m);
            produkty[1] = new Produkt("Bochen", 312.21m);
            produkty[2] = new Produkt("Kot", 213.2m);
            produkty[3] = new Produkt("Mieso", 1233.123m);
            produkty[4] = new Produkt("Oliwa", 2313.312m);

            // zadanie 2
            Array.Sort(produkty, (a, b) => a.Nazwa.CompareTo(b.Nazwa));

            Console.WriteLine("Produkty po sortowaniu:");
            foreach (var p in produkty)
            {
                Console.WriteLine(p.Nazwa + " - " + p.Cena);
            }

            Console.WriteLine();

            string szukanaNazwa = "Kot";

            // zadanie 3
            Console.WriteLine("Wyszukiwanie liniowe:");
            bool znaleziono = false;

            foreach (var p in produkty)
            {
                if (p.Nazwa == szukanaNazwa)
                {
                    Console.WriteLine("Znaleziono: " + p.Nazwa + " - " + p.Cena);
                    znaleziono = true;
                    break;
                }
            }

            if (!znaleziono)
                Console.WriteLine("Nie znaleziono produktu");

            Console.WriteLine();

            // zadanie 4
            Console.WriteLine("Wyszukiwanie binarne:");

            int lewy = 0;
            int prawy = produkty.Length - 1;

            while (lewy <= prawy)
            {
                int srodek = (lewy + prawy) / 2;

                int porownanie = string.Compare(produkty[srodek].Nazwa, szukanaNazwa);

                if (porownanie == 0)
                {
                    Console.WriteLine("Znaleziono: " + produkty[srodek].Nazwa + " - " + produkty[srodek].Cena);
                    break;
                }
                else if (porownanie < 0)
                {
                    lewy = srodek + 1;
                }
                else
                {
                    prawy = srodek - 1;
                }
            }
        }
    }
}
