//5.Polimorfizm przez interfejsy
//Utwórz interfejs IPlayable z metodą Play().
//Zaimplementuj go w klasach Guitar i Piano.
//Utwórz listę IPlayable i odtwórz „koncert” (wywołaj Play() na wszystkich obiektach).

namespace zadanie5
{
    public interface Iplayable
    {
        void Play();
    }

    class Guitar : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("gra gitara");
        }
    }

    class Piano : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("gra pianino");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var instruments = new List<Iplayable>()
            {
                new Guitar(),
                new Piano()
            };

            foreach (var item in instruments)
            {
                item.Play();
            }
        }
    }
}
