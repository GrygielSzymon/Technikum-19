void main() {
    Thread t1 = new Thread(
            () -> {
                System.out.println("dziala watek0");
            }
    );
    t1.start();

    Thread t2 = new Thread(new Watek1());
    t2.start();

    Thread t3 = new Thread(new Watek2());
    t3.start();
}
