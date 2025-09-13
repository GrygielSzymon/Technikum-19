using System.Threading.Channels;

public class osoba
{
    public void Przedstawsie()
    {
        Console.WriteLine("Maksim Dudzik");
    }
}

public class Pracownik : osoba
{
    public void Pracuj()
    {
        Console.WriteLine("Pracuj");
    }
}

public class Programista : Pracownik
{
    public void Koduj()
    {
        Console.WriteLine("Pracownik koduje");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Programista programista = new Programista();
        programista.Przedstawsie();
        programista.Pracuj();
        programista.Koduj();
    }
}
