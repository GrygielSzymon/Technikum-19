namespace zad1
{
    internal class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }



        static void Main(string[] args)
        {

            //1
            Product[] products =
            {
                new Product("MacBook", 1500.00m),
                new Product("Iphone", 800.00m),
                new Product("AirPods", 200.00m),
                new Product("IMac", 300.00m)
            };

            Console.WriteLine("Produkty: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, cena: {product.Price} ");
            }
            Console.WriteLine();

            Console.WriteLine("Produkty posortowane po nazwie");
            SortProductsByName(products);
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, cena: {product.Price} ");
            }
            Console.WriteLine();

            Console.WriteLine("Wyszukiwanie liniowe(Iphone): ");
            LinearSearch(products, "Iphone");
            Console.WriteLine();

            Console.WriteLine("Wyszukiwanie binarne(IMac): ");
            BinarySearch(products, "IMac");
            Console.WriteLine();

            Console.WriteLine("Największa, najmniejsza, średnia cena");
            MaxMinAvg(products);
            Console.WriteLine();

            Console.WriteLine("Po usunięciu");
            DeleteProduct(products, "AirPods");
        }
        // 2
        public static void SortProductsByName(Product[] products)
        {
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (string.Compare(products[j].Name, products[j + 1].Name) > 0)
                    {
                        var temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }

        // 3.1
        public static void LinearSearch(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    Console.WriteLine("Indeks: " + i);
                    return;
                }
            }
        }

        // 3.2
        public static void BinarySearch(Product[] products, string name)
        {
            int left = 0;
            int rigth = products.Length - 1;

            while (left <= rigth)
            {
                int mid = (left + rigth) / 2;
                int resultCompare = string.Compare(products[mid].Name, name);

                if (resultCompare == 0)
                {
                    Console.WriteLine("Indeks: " + mid);
                    return;
                }
                else if (resultCompare < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    rigth = mid - 1;
                }
            }
        }

        // 4
        public static void MaxMinAvg(Product[] products)
        {
            if (products.Length == 0) return;
            decimal maxPrice = products[0].Price;
            decimal minPrice = products[0].Price;
            decimal sumPrice = 0;
            foreach (var product in products)
            {
                if (product.Price > maxPrice) maxPrice = product.Price;
                if (product.Price < minPrice) minPrice = product.Price;
                sumPrice += product.Price;
            }
            decimal avgPrice = sumPrice / products.Length;
            Console.WriteLine($"Max: {maxPrice}, Min: {minPrice}, Avg: {avgPrice}");
        }

        // 5
        public static void DeleteProduct(Product[] products, string nameDelete)
        {
            int count = 0;
            foreach (var product in products)
            {
                if (product.Name != nameDelete) count++;
            }

            Product[] newProducts = new Product[count];
            int sum = 0;

            foreach (var product in products)
            {
                if (product.Name != nameDelete)
                {
                    newProducts[sum] = product;
                    sum++;
                }
            }
            foreach (var product in newProducts)
            {
                Console.WriteLine($"{product.Name}, cena: {product.Price} ");
            }
        }
    }
}
