// Kalkulator przeciążony
// Utwórz klasę Calculator i zaimplementuj metodę Add w trzech wersjach:
// dodającą dwa int,
// dodającą dwa double,
// dodającą trzy int.
// Przetestuj działanie.

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 3));
            Console.WriteLine(calculator.Add(1.2, 3));
            Console.WriteLine(calculator.Add(1, 3, 4));


        }
    }
}
