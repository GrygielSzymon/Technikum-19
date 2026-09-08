void main(){
    Scanner input = new Scanner(System.in);
    System.out.println("Podaj liczbę: ");
    int amount = input.nextInt();
    Random random = new Random();

    int num = amount / 2;

    ArrayList<Integer> numbers = new ArrayList<Integer>();

    for (int i = 0; i < num; i++) {
        numbers.add(random.nextInt(10));
    }

    System.out.println(numbers);
}