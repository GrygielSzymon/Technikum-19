void main() {
    Thread watek1 = new Thread(new zadWatek1());
    Thread watek2 = new Thread(new zadWatek2());

    watek1.start();
    watek2.start();
}