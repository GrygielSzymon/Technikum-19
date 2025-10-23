//Cel: utrwalenie klas abstrakcyjnych, dziedziczenia i polimorfizmu.
//1. Utwórz klasę abstrakcyjną Figura z metodami:
//- public abstract double Pole();
//- public abstract double Obwod();
//2.Utwórz klasy pochodne: Kolo, Prostokat, Trojkat.
//3. Każda z klas powinna posiadać odpowiednie pola i konstruktory.
//4. W metodzie Main utwórz listę List<Figura> i dodaj kilka różnych figur.
//5. Za pomocą pętli wyświetl pola i obwody wszystkich figur (polimorfizm w akcji).
//Rozszerzenie: Dodaj metodę Opis() oraz przesłoń ToString().

using System;
using System.Formats.Asn1;
namespace zadanie1
{
    public abstract class Figura
    {
        public abstract double Pole();
        public abstract double Obwod();
    }
    public class Kolo : Figura
    {
        public double Promien { get; set; }
        public Kolo(double promien)
        {
            Promien = promien;
        }
        public override double Pole()
        {
            return Math.PI * Math.Pow(Promien, 2);
        }
        public override double Obwod()
        {
            return 2 * Math.PI * Promien;
        }
    }
    public class Prostokat : Figura
    {
        public double BokA { get; set; }
        public double BokB { get; set; }
        public Prostokat(double bokA, double bokB)
        {
            BokA = bokA;
            BokB = bokB;
        }
        public override double Pole()
        {
            return BokA * BokB;
        }
        public override double Obwod()
        {
            return 2 * BokA + 2 * BokB;
        }
    }
    public class Trojkat : Figura
    {
        public double BokA { get; set; }
        public double BokB { get; set; }
        public double BokC { get; set; }
        public double Wyskoksc { get; set; }
        public Trojkat(double bokA, double bokB, double bokC, double wysokosc)
        {
            BokA = bokA;
            BokB = bokB;
            BokC = bokC;
            Wyskoksc = wysokosc;
        }
        public override double Pole()
        {
            return (BokA * Wyskoksc) / 2;
        }
        public override double Obwod()
        {
            return BokA + BokB + BokC;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figura = new List<Figura>
            {
                new Kolo(10),
                new Prostokat(10, 20),
                new Trojkat(10 , 5, 5, 10)
            };
        }
    }
}
