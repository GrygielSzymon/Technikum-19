public class Wyplac implements Runnable {
    private Konto konto;

    public Wyplac(Konto konto) {
        this.konto = konto;
    }

    public void run() {
        for (int i = 0; i < 100; i++)
            konto.Wyplac(1);
        System.out.println(konto.stan);
    }
}
