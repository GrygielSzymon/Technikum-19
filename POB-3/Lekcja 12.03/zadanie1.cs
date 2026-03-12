using System;

namespace ConsoleApp1
{
    class Uczen
    {
        public string Imie { get; set; }
        public double Srednia { get; set; }

        public Uczen(string imie, double srednia)
        {
            Imie = imie;
            Srednia = srednia;
        }
        internal class Program
        {
            static void Main(string[] args)
            {

                Uczen[] uczniowie = new Uczen[5];

                uczniowie[0] = new Uczen("olof", 4.5);
                uczniowie[1] = new Uczen("KOlega od ai", 3.8);
                uczniowie[2] = new Uczen("Taksik", 5.0);
                uczniowie[3] = new Uczen("Cyguś", 4.2);
                uczniowie[4] = new Uczen("dudnior", 4.75);


                //zad 1
                Console.WriteLine("Zadanie.1");
                string name = "olof";
                for (int i = 0; i < uczniowie.Length; i++)
                {
                    if (uczniowie[i].Imie == name)
                    {
                        Console.WriteLine("Tak");
                    }
                    else
                    {
                        Console.WriteLine("Nie");
                    }
                }

                //zad 2
                Console.WriteLine("Zadanie.2");
                double maxAvg = uczniowie[0].Srednia;
                for (int i = 0; i < uczniowie.Length; i++)
                {
                    if (uczniowie[i].Srednia > maxAvg)
                    {
                        maxAvg = uczniowie[i].Srednia;
                    }
                }
                Console.WriteLine($"Najwiękasz średnia: {maxAvg}");

                //zad 3
                Console.WriteLine("Zadanie.3");
                double minAvg = uczniowie[0].Srednia;
                for (int i = 0; i < uczniowie.Length; i++)
                {
                    if (uczniowie[i].Srednia < minAvg)
                    {
                        minAvg = uczniowie[i].Srednia;
                    }
                }
                Console.WriteLine($"Najmniejsza średnia: {minAvg}");

                //zad 4
                Console.WriteLine("Zadanie.4");
                int count = 0;
                double sum = 0;
                for (int i = 0; i < uczniowie.Length; i++)
                {
                    sum += uczniowie[i].Srednia;
                    count++;
                }
                Console.WriteLine($"Średnia klasy: {sum / count}");

                //zad 5
                Console.WriteLine("Zadanie.5");

                for (int i = 0; i < uczniowie.Length; i++)
                {
                    for (int j = 0; j < uczniowie.Length - 1; j++)
                    {
                        if (uczniowie[j].Srednia > uczniowie[j + 1].Srednia)
                        {
                            Uczen temp = uczniowie[j];
                            uczniowie[j] = uczniowie[j + 1];
                            uczniowie[j + 1] = temp;
                        }
                    }
                }

                for (int i = 0; i < uczniowie.Length; i++)
                {
                    Console.WriteLine($"{uczniowie[i].Imie} - {uczniowie[i].Srednia}");
                }
            }
        }
    }
}
