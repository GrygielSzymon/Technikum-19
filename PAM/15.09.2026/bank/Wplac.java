public class Wplac implements Runnable {
    private Konto konto;

    public Wplac(Konto konto) {
        this.konto = konto;
    }

    public void run() {
        for (int i = 0; i < 100; i++)
            konto.Wplac(2);
        System.out.println(konto.stan);
    }
}
