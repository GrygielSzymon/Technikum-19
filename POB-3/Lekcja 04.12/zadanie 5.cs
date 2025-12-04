//Zadanie 5 — System zarządzania kontami w banku
//Wykorzystane elementy: interfejsy, klasy pochodne, algorytmy operacji na listach.

//Opis
//Utwórz interfejs:
//interface IOperacjeBankowe
//{
//    void Wplata(double kwota);
//    bool Wyplata(double kwota);
//}
//Utwórz klasy:
//abstrakcyjna Konto
//— posiada saldo, numer konta
//KontoOsobiste
//KontoFirmowe (prowizja za wypłatę 2%)
//KontoPremium (oprocentowanie, bonus za duże wpłaty)

//W Main():
//Stwórz listę kont o różnych typach.
//Wykonaj serię operacji.
//Znajdź konta z saldem poniżej 0.
//Znajdź konta z saldem największym lub w top 3.
//Posortuj konta po saldzie malejąco.

namespace zadanie_5
{
    interface IOperacjeBankowe
    {
        void Wplata(double kwota);
        bool Wyplata(double kwota);
    }
    public abstract class Konto
    {
        public double Saldo { get; set; }
        public int NumerKonta { get; set; }
    }
    public class KontoOsobiste : Konto, IOperacjeBankowe
    {
        public double Kwota { get; set; }
        public KontoOsobiste(double kwota, double saldo, int numerKonta)
        {
            Kwota = kwota;
            Saldo = saldo;
            NumerKonta = numerKonta;
        }
        public void Wplata(double kwota) => Console.WriteLine($"Kwota wplaty: {Kwota}");
        public bool Wyplata(double kwota) => true;
    }
    public class KontoFirmowe : Konto, IOperacjeBankowe
    {
        public double Kwota { get; set; }
        public KontoFirmowe(double kwota, double saldo, int numerKonta)
        {
            Kwota = kwota;
            Saldo = saldo;
            NumerKonta = numerKonta;
        }
        public void Wplata(double kwota) => Console.WriteLine($"Kwota wplaty: {Kwota * 102}");
        public bool Wyplata(double kwota) => true;
    }
    public class KontoPremium : Konto, IOperacjeBankowe
    {
        public double Kwota { get; set; }
        public KontoPremium(double kwota, double saldo, int numerKonta)
        {
            Kwota = kwota;
            Saldo = saldo;
            NumerKonta = numerKonta;
        }
        public void Wplata(double kwota)
        {
            if (kwota > 100000)
            {
                kwota *= 150;
                Console.WriteLine($"Gratulacje dostałeś bonus do wpłaty. Kwota wpłacona na konto: {kwota}");
            }
            else
            {
                Console.WriteLine($"Kwota wpłacona: {kwota}");
            }
        }
        public bool Wyplata(double kwota) => true;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Konto> list = new List<Konto>()
            {
                new KontoOsobiste(150000,2123,01),
                new KontoOsobiste(150000,2123,01),
                new KontoFirmowe(132,13243,1324),
                new KontoFirmowe(1231,34421,2434),
                new KontoPremium(213,134,33),
                new KontoPremium(2133212233,21111,32112)
            };

            foreach (var item in list)
            {
                if (item.Saldo < 0)
                {
                    Console.WriteLine($"Numer konta: {item.NumerKonta}. Biedny jesteś. Masz saldo poniżej 0");
                }
            }

            Console.WriteLine(list.Max(x => x.Saldo));
            Console.WriteLine(list.OrderByDescending(x => x.saldo).take(3));
        }
    }
}
