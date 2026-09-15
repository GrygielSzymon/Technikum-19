public class Konto {
    int stan;

    public Konto(int stan) {
        this.stan = stan;
    }

    public synchronized void Wplac(int kwota){
        stan += kwota;
    }
    public synchronized void Wyplac(int kwota){
        stan -= kwota;
    }
}
