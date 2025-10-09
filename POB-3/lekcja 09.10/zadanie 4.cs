//4. Ukrywanie metod(new)
//Utwórz klasę Vehicle z metodą Drive().
//Utwórz klasę Car, która ukrywa metodę Drive() za pomocą new.
//Sprawdź, jak zachowa się program, jeśli przypiszesz obiekt Car do zmiennej typu Vehicle.

namespace zadanie4
{

    class Vehicle
    {
        public void Drive() => Console.WriteLine("Jedzie");
    }

    class Car : Vehicle
    {
        public new void Drive() => Console.WriteLine("Auto jedzie");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Drive();
        }
    }
}
