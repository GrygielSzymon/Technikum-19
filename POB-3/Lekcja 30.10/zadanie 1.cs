//1.Utwórz interfejsy ILatajace i IPlywajace z odpowiednimi metodami.
//2.Utwórz klasę Kaczka, która implementuje oba interfejsy.
//3.W Main sprawdź, jak zachowuje się obiekt klasy Kaczka wywoływany przez różne interfejsy.    
namespace zadanie4
{

    public interface IFlyable
    {
        void Fly();
    }
    public interface ISwimable
    {
        void Swims();
    }

    public class Duck : IFlyable, ISwimable
    {
        public void Fly()
        {
            Console.WriteLine("Kaczka lata");
        }
        public void Swims()
        {
            Console.WriteLine("Kaczka pływa");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable kaczka1 = new Duck();
            kaczka1.Fly();
            ISwimable kaczka2 = new Duck();
            kaczka2.Swims();
        }
    }
}
