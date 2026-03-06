with open("liczby_przyklad.txt", mode="r") as file:
    numbers = list(map(int, file.read().split()))

print(*numbers)


#konwersja na system binarny i zapis do pliku binarny.txt
with open("binarne.txt", mode="a+") as file:
    for i in numbers:
        file.write(f"{bin(i)[2:]}\n")



