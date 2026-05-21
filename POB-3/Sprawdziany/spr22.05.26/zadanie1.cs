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
            int sumacyfr = 0;
            for (int l = 0; l < 9; l++)
            {
                for (int i = 0; i < index; i++)
                {
                    if (Kod[i].ToString().Contains(l.ToString()))
                    {
                        sumacyfr++;
                    }
                }
            }

            return sumacyfr;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "ab12cd7x";
            KodDostepu kodDostepu = new KodDostepu(word);
            int len = word.GetNormalizedLength();
            Console.WriteLine("Dane:");
            Console.WriteLine();
            Console.WriteLine($"Kod: {word}");
            Console.WriteLine();
            Console.WriteLine("Wynik: ");
            Console.WriteLine();
            Console.WriteLine($"Liczba cyfr w kodzie: {kodDostepu.LiczCyfry(len)}");

            
        }
    }
}
