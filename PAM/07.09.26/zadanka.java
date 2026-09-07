import  java.util.Scanner;
void main() {
    Scanner input = new Scanner(System.in);
    //1
    System.out.println("1.");
    int a = input.nextInt();
    int b = input.nextInt();

    System.out.println(a+b);
    System.out.println(a-b);
    System.out.println(a*b);
    System.out.println(a/b);

    //2
    int bokA = input.nextInt();
    int bokB = input.nextInt();
    System.out.println("2.");
    System.out.println(bokA * bokB);
    System.out.println((2*bokA)+(2*bokB));

    //3
    int temp = input.nextInt();
    System.out.println((temp * 1.8) + 32);

    //4
    int nwdA = input.nextInt();
    int nwdB = input.nextInt();

    while (nwdA != nwdB) {
        if (nwdA > nwdB){
            nwdA = nwdA - nwdB;
        }
        else {
            nwdB = nwdB - nwdA;
        }
    }
    System.out.println(nwdA);

}
