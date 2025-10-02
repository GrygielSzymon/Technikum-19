// Stwórz klasę Animal z metodą Speak() oznaczoną jako virtual.
// Utwórz klasy Dog i Cat, które nadpiszą tę metodę.
// W Main przypisz różne zwierzęta do tablicy Animal[] i wywołaj Speak().
namespace _2
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Zwierze wydaj dzwięk.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("hau hau");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("miau miau");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = [new Dog(), new Cat()];

            animals[0].Speak();
            animals[1].Speak();
        }
    }
}
