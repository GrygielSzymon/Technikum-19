namespace zadanie1
{
    public class KodDostepu
    {
        public string Kod { get; set; }

        public KodDostepu(string kod)
        {
            Kod = kod;
        }

        public int LiczCyfry(int index)
        {
            if (index == 0)
                return 0;

            if (char.IsDigit(Kod[index - 1]))
                return 1 + LiczCyfry(index - 1);

            return LiczCyfry(index - 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "ab12cd7x";

            KodDostepu kodDostepu = new KodDostepu(word);

            Console.WriteLine("Dane:");
            Console.WriteLine();
            Console.WriteLine($"Kod: {word}");

            Console.WriteLine();
            Console.WriteLine("Wynik:");
            Console.WriteLine();

            Console.WriteLine(
                $"Liczba cyfr w kodzie: {kodDostepu.LiczCyfry(word.Length)}"
            );
        }
    }
}
