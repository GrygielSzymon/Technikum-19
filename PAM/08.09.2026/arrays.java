void main() {
    Scanner input = new Scanner(System.in);
    ArrayList<Integer> numbers = new ArrayList<Integer>();
    //1
    System.out.println("1. Tworzenie Listy");
    
    int n = input.nextInt();
    for (int i = 0; i < n; i++) {
        int number = input.nextInt();
        numbers.add(number);
    }
    int sum = 0;
    for (int i = 0; i < numbers.size(); i++) {
        sum += numbers.get(i);
    }
    double avg = sum / numbers.size();

    System.out.println("Lista: " + numbers);
    System.out.println("Średnia: " + avg + ",Suma: " + sum);


    //2

    System.out.println("\n2. Podaj liczbę do usunięcia: ");

    int deleteNum = input.nextInt();
    for (int i = 0; i < numbers.size(); i++) {
        if (numbers.get(i) == deleteNum) {
            numbers.remove(i);
        }
    }
    System.out.println("Lista po usunęciu: " + numbers);


    //3

    int min = numbers.get(0);
    for (int i = 0; i < numbers.size(); i++) {
        if (numbers.get(i) < min){
            min = numbers.get(i);
        }
    }
    int max = numbers.get(0);
    for (int i = 0; i < numbers.size(); i++) {
        if (numbers.get(i) > max){
            max = numbers.get(i);
        }
    }

    System.out.println("\n3. Najmniejsza i największa wartość");
    System.out.println("Najmniejsza wartość: " + min + "\nNajwiększa wartość: " + max);


    //4

    System.out.println("\n4. Sortowanie Listy");
    System.out.println("Lista nieposortowana: " + numbers);
    Collections.sort(numbers);
    System.out.println("Lista posortowana rosnąco: " + numbers);
    Collections.reverse(numbers);
    System.out.println("Lista posortowana malejąco: " + numbers);


    //5

    System.out.println("\n5. Odwracanie Listy: " + numbers);

    for(int i = 0; i < numbers.size()/2; i++){
        int j = numbers.size() - 1 - i;

        int tmp = numbers.get(i);
        numbers.set(i, numbers.get(j));
        numbers.set(j, tmp);
    }
    System.out.println("Odwrócona lista: " + numbers);


    //6

    System.out.println("\n6. Usuwanie duplikatów z listy: " + numbers);

    for (int i = 0; i < numbers.size(); i++) {
        int d = numbers.get(i);
        for (int j = i + 1; j < numbers.size(); j++) {
            if (numbers.get(j) == d){
                numbers.remove(j);
                j--;
            }
        }
    }
    System.out.println(numbers);
}