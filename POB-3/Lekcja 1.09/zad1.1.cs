public class Instrument
{
    public void Graj()
    {
        Console.WriteLine("Zagraj na gitarze");
    }
}

public class Gitara : Instrument
{
    public void Strojenie()
    {
        Console.WriteLine("Wstrajanie gitary");
    } 
}

public class program
{
    public static void Main(string[] args)
    {
        Gitara gitara = new Gitara();
        gitara.Graj();
        gitara.Strojenie();
    }
}
