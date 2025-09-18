//Napisz klasę KontoBankowe, która posiada pola:
//numer konta(String/int),
//właściciel(String),
//saldo(double).

//Dodaj metody:
//wplata(double kwota) – zwiększa saldo,
//wyplata(double kwota) – zmniejsza saldo, jeśli kwota nie przekracza dostępnych środków,
//sprawdzSaldo() – wypisuje aktualny stan konta.

//Dodatkowo:
//przy wypłacie sprawdź warunkiem, czy saldo ≥ kwota,
//zbuduj prostą pętlę menu (switch-case lub if-else), w której użytkownik może dokonywać wpłat, wypłat i sprawdzać saldo.
namespace Symulator_konta_bankowego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kontobankowe kontobankowe = new Kontobankowe(37381367,"Szymon Grygiel", 0.0);

            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Wpłać środki");
                Console.WriteLine("2. Wypłać środki");
                Console.WriteLine("3. Sprawdź saldo");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        kontobankowe.wplata();
                    break;

                    case 2:
                        kontobankowe.wyplata();
                    break;

                    case 3:
                        kontobankowe.sprawdzSaldo();
                    break; 
                        
                    default:
                        Console.WriteLine("Zły wybór.");
                        break;
                }
            }


        }
        public class Kontobankowe
        {
            public string NumerKonta;
            public string Wlasciciel;
            public double Saldo;

            public void wplata()
            {
                Console.Write("Podaj kwotę o jaką chcesz zasilić swoje konto: ");
                double wplata = double.Parse(Console.ReadLine());

                if (wplata > 0 )
                {
                    Saldo += wplata;
                }
                else
                {
                    Console.WriteLine("Podaj poprawną kwotę");
                }
            }

            public void wyplata()
            {
                Console.Write("Podaj kwotę jaką chcesz wypłacić z swojego konta: ");
                double wyplata = double.Parse(Console.ReadLine());

                if (wyplata <= Saldo)
                {
                    Saldo -= wyplata;
                }
                else
                {
                    Console.WriteLine("Brak wystarczających środków.");
                }
            }
            
            public void sprawdzSaldo()
            {
                Console.Write($"Twoje saldo wynosi: {Saldo}");
            }

        }
    }
}
