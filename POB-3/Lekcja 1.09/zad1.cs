using System.Threading.Channels;

public class Pojazd
{
    public void Jedz()
    {
        Console.WriteLine("Auto jedzie");
    }
}

public class Samochod : Pojazd
{
   public void Tankuj()
    {
        Console.WriteLine("Zatankuj Auto");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Samochod samochod = new Samochod();
        samochod.Jedz();
        samochod.Tankuj();
    }
}
