public class StaryCzajnik{
    private double celsiusze;

    public StaryCzajnik(double celsiusze) {
        this.celsiusze = celsiusze;
    }
    public double getCelsiusze(){
        return celsiusze;
    }
}


public interface Czajnik{
    double pobierzTempFareny();
}


public class NowyCzajnik implements Czajnik{
    private StaryCzajnik staryCzajnik;
    private double farenheity;

    public NowyCzajnik(StaryCzajnik staryCzajnik) {
        this.staryCzajnik = staryCzajnik;
    }
    public double pobierzTempFareny(){
        return staryCzajnik.getCelsiusze() * 1.8 + 32;
    }
}

void main() {
    StaryCzajnik staryCzajnik = new StaryCzajnik(20);
    Czajnik czajnik = new NowyCzajnik(staryCzajnik);
    System.out.println(czajnik.pobierzTempFareny());
}
