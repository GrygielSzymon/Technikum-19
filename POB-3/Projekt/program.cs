using System;
using System.Collections.Generic;

class KartaGry
{
    public string Figura;
    public int Numer;

    public KartaGry(string figura, int numer)
    {
        Figura = figura;
        Numer = numer;
    }

    public override string ToString()
    {
        if (Numer == 11) return "Walet " + Figura;
        if (Numer == 12) return "Dama " + Figura;
        if (Numer == 13) return "Król " + Figura;
        if (Numer == 14) return "As " + Figura;
        return Numer + " " + Figura;
    }
}

class ZestawKart
{
    public List<KartaGry> ZbiorKart = new List<KartaGry>();

    public ZestawKart()
    {
        string[] figury = { "Pik", "Kier", "Karo", "Trefl" };

        for (int i = 0; i < figury.Length; i++)
            for (int n = 2; n <= 14; n++)
                ZbiorKart.Add(new KartaGry(figury[i], n));
    }

    public void Wymieszaj()
    {
        Random rand = new Random();

        for (int i = 0; i < ZbiorKart.Count; i++)
        {
            int j = rand.Next(ZbiorKart.Count);
            KartaGry pom = ZbiorKart[i];
            ZbiorKart[i] = ZbiorKart[j];
            ZbiorKart[j] = pom;
        }
    }
}

class OperacjeNaKartach
{
    public static void SortujPrzezWybor(List<KartaGry> karty)
    {
        for (int i = 0; i < karty.Count; i++)
        {
            int indeksMin = i;
            for (int j = i + 1; j < karty.Count; j++)
                if (karty[j].Numer < karty[indeksMin].Numer)
                    indeksMin = j;

            KartaGry temp = karty[i];
            karty[i] = karty[indeksMin];
            karty[indeksMin] = temp;
        }
    }

    public static void SortujPrzezWstawianie(List<KartaGry> karty)
    {
        for (int i = 1; i < karty.Count; i++)
        {
            KartaGry klucz = karty[i];
            int j = i - 1;

            while (j >= 0 && karty[j].Numer > klucz.Numer)
            {
                karty[j + 1] = karty[j];
                j--;
            }
            karty[j + 1] = klucz;
        }
    }

    public static void SortujBabelkowo(List<KartaGry> karty)
    {
        for (int i = 0; i < karty.Count; i++)
            for (int j = 0; j < karty.Count - 1; j++)
                if (karty[j].Numer > karty[j + 1].Numer)
                {
                    KartaGry temp = karty[j];
                    karty[j] = karty[j + 1];
                    karty[j + 1] = temp;
                }
    }
    public static List<KartaGry> SortujPrzezScalanie(List<KartaGry> karty)
    {
        if (karty.Count <= 1)
            return karty;


        int srodek = karty.Count / 2;
        List<KartaGry> lewa = karty.GetRange(0, srodek);

        List<KartaGry> prawa = karty.GetRange(srodek, karty.Count - srodek);

        return Scal(lewa, prawa);
    }

    private static List<KartaGry> Scal(List<KartaGry> lewa, List<KartaGry> prawa)
    {
        List<KartaGry> wynik = new List<KartaGry>();
        int i = 0, j = 0;

        while (i < lewa.Count && j < prawa.Count)
        {
            if (lewa[i].Numer <= prawa[j].Numer)
                wynik.Add(lewa[i++]);
            else
                wynik.Add(prawa[j++]);
        }

        while (i < lewa.Count) wynik.Add(lewa[i++]);
        while (j < prawa.Count) wynik.Add(prawa[j++]);

        return wynik;
    }

    public static int SzukajAsaPikLiniowo(List<KartaGry> karty)
    {
        for (int i = 0; i < karty.Count; i++)
            if (karty[i].Numer == 14 && karty[i].Figura == "Pik")
                return i;
        return -1;
    }

    public static int SzukajAsaPikBinarnie(List<KartaGry> karty)
    {
        int lewo = 0, prawo = karty.Count - 1;

        while (lewo <= prawo)
        {
            int srodek = (lewo + prawo) / 2;

            if (karty[srodek].Numer == 14)
            {
                int i = srodek;
                while (i >= 0 && karty[i].Numer == 14)
                {
                    if (karty[i].Figura == "Pik") return i;
                    i--;
                }

                i = srodek + 1;
                while (i < karty.Count && karty[i].Numer == 14)
                {
                    if (karty[i].Figura == "Pik") return i;
                    i++;

                }
                return -1;

            }

            if (karty[srodek].Numer < 14)
                lewo = srodek + 1;
            else
                prawo = srodek - 1;
        }
        return -1;
    }
}

class AnalizaReki
{
    public static string SprawdzUklad(List<KartaGry> reka)
    {
        int licznikPar = 0;

        for (int i = 0; i < reka.Count; i++)
            for (int j = i + 1; j < reka.Count; j++)
                if (reka[i].Numer == reka[j].Numer)
                {
                    licznikPar++;
                    break;
                }

        if (licznikPar == 2) return "Dwie pary";
        if (licznikPar == 1) return "Jedna para";
        return "Brak par";
    }
}

class Program
{

    static void Main()
    {
        ZestawKart talia = new ZestawKart();
        talia.Wymieszaj();

        List<KartaGry> rekaPierwsza = talia.ZbiorKart.GetRange(0, 5);
        List<KartaGry> rekaDruga = talia.ZbiorKart.GetRange(5, 5);

        Console.WriteLine("Ręka pierwsza(nie posortowane): ");
        foreach (var item in rekaPierwsza)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Ręka Druga(nie posortowane): ");
        foreach (var item in rekaDruga)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        OperacjeNaKartach.SortujPrzezWybor(rekaPierwsza);
        OperacjeNaKartach.SortujBabelkowo(rekaDruga);

        Console.WriteLine("Ręka pierwsza: ");
        foreach (var item in rekaPierwsza)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Ręka Druga: ");
        foreach (var item in rekaDruga)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        List<KartaGry> posortowanaTalia =
            OperacjeNaKartach.SortujPrzezScalanie(talia.ZbiorKart);

        int wynikLiniowy =
            OperacjeNaKartach.SzukajAsaPikLiniowo(talia.ZbiorKart);
        int wynikBinarny =
            OperacjeNaKartach.SzukajAsaPikBinarnie(posortowanaTalia);

        Console.WriteLine("As Pik (wyszukiwanie liniowe): " + wynikLiniowy);
        Console.WriteLine("As Pik (wyszukiwanie binarne): " + wynikBinarny);

        Console.WriteLine("Ocena pierwszej ręki: " +
            AnalizaReki.SprawdzUklad(rekaPierwsza));
        Console.WriteLine("Ocena drugiej ręki: " +
            AnalizaReki.SprawdzUklad(rekaDruga));
    }
}
