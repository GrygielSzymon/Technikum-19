void main(){
    Scanner input = new Scanner(System.in);
    //    14. Napisz program sortujący mapę HashMap<String, Integer> po wartościach malejąco.


    //12. Napisz program wczytujący imiona i wieki osób do HashMap<String, Integer> i wypisujący osobę o najwyższym wieku.

    HashMap<String, Integer> people = new HashMap<>();
    System.out.println("Ile chcesz dodać osób?");
    int ilosc = input.nextInt();

    for (int i = 0; i < ilosc; i++) {
        System.out.println("Podaj imię: ");
        String name = input.next();
        System.out.println("Podaj wiek: ");
        int age = input.nextInt();
        people.put(name, age);
    }

    String oldest = "";
    int maxAge = 0;

    for (String name : people.keySet()){
        int age = people.get(name);

        if (age > maxAge){
            maxAge = age;
            oldest = name;
        }
    }

    System.out.println(people);

    System.out.println("Najstarsza osoba: " + oldest + " ma: " + maxAge + " lat");

    //13. Napisz program zliczający częstość występowania każdego słowa w podanym tekście za pomocą HashMap.

    String tekst = "Ala ma kota Ala ma psa Kot ma mleko";
    tekst = tekst.toLowerCase();

    String[] words = tekst.split(" ");

    HashMap<String, Integer>  map = new HashMap<>();

    for (String word : words){
        if (map.containsKey(word)){
            map.put(word, map.get(word) + 1);
        }
        else{
            map.put(word, 1);
        }
    }

    System.out.println(map);
}
