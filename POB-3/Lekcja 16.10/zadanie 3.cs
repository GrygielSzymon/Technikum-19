//Zadanie 3. „Pracownicy firmy”
//Utwórz klasę abstrakcyjną Pracownik z:
//właściwościami Imie, Stanowisko,
//metodą abstrakcyjną ObliczPensje().
//Napisz klasy pochodne:
//Programista(np.ma stawkę godzinową),
//Kierownik(ma stałą pensję + premię).
//Wyświetl miesięczne wynagrodzenie różnych pracowników.

namespace ConsoleApp3
{

    public abstract class Pracownik
    {
        public string Imie {get; set;}
        public string Stanowisko { get; set; }

        public abstract void ObliczPensje();

    }
    public class Programista : Pracownik
    {
        public Programista(string imie, string stanowisko)
        {
            Imie = imie;
            Stanowisko = stanowisko;
        }
        public override void ObliczPensje()
        {
            Console.WriteLine("Programista zarabia 15000zł");
        }

    }

    public class Kierownik : Pracownik
    {
        public Kierownik(string imie, string stanowisko)
        {
            Imie = imie;
            Stanowisko = stanowisko;
        }
        public override void ObliczPensje()
        {
            Console.WriteLine("kierownik zarabia 20000zł + 5000zł premii");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik programista = new Programista("Maciek", "Programista");
            Console.WriteLine($"Imię: {programista.Imie}, stanowisko: {programista.Stanowisko}");
            programista.ObliczPensje();

            Pracownik kierownik = new Kierownik("Bublik", "Kierownik");
            Console.WriteLine($"Imię: {kierownik.Imie}, stanowisko: {kierownik.Stanowisko}");
            kierownik.ObliczPensje();
        }
    }
}
