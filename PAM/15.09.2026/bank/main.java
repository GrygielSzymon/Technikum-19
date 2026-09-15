void main() {

    Konto konto = new Konto(1000);

    Thread wplac = new Thread(new Wplac(konto));
    Thread wyplac = new Thread(new Wyplac(konto));

    wplac.start();
    wyplac.start();
}
