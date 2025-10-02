// Figura geometryczna (abstract)
// Utwórz klasę abstrakcyjną Shape z metodą GetArea().
// Zaimplementuj klasy Circle i Rectangle.
// Utwórz listę Shape i policz pola różnych figur.
namespace _3
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }

        public override double GetArea()
        {
           return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }
        public Rectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }
        public override double GetArea()
        {
            return SideA * SideB;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shape = new List<Shape> {new Circle(2), new Rectangle(2, 5) };

            Console.WriteLine("Pole koła: " + Shape[0].GetArea());
            Console.WriteLine("Pole prostokąta: " + Shape[1].GetArea());
        }
    }
}
