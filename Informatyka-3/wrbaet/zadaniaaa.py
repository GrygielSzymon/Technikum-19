with open("liczba.txt", "r") as file:
    #numbers = [int(i) for i in file.readline().split("")]
    numbers = list(map(int, file.read().split()))

#1
for liczba in liczby:
    if liczba % 2 == 0:
        print(liczba)

#2
suma = sum(liczby)
print("Suma:", suma)

#3
print("Największa:", max(liczby))
print("Najmniejsza:", min(liczby))

#4
licznik = 0

for liczba in liczby:
    if liczba % 3 == 0 and liczba % 5 == 0:
        licznik += 1

print("Ilość:", licznik)

#5
with open("binarne.txt", "w") as zapis:
    for liczba in liczby:
        b = bin(liczba)[2:]
        zapis.write(b + "\n")

#6
licznik = 0

for liczba in liczby:
    b = bin(liczba)[2:]
    if b.count("1") == 5:
        licznik += 1

print("Ilość:", licznik)

#7palindromy = []

for liczba in liczby:
    b = bin(liczba)[2:]
    if b == b[::-1]:
        palindromy.append(liczba)

print(palindromy)

#8
max_dl = 0

for liczba in liczby:
    b = bin(liczba)[2:]
    if len(b) > max_dl:
        max_dl = len(b)

print("Max długość:", max_dl)

#9counter = 0
for n in numbers:
    if n[:3] == "111":
        counter += 1
print(counter)

#10
counter = 0
for n in numbers:
    if n[-3:] == "111":
        counter += 1
print(counter)

#11
licznik = 0

for liczba in liczby:
    b = bin(liczba)[2:]
    if b.count("1") > b.count("0"):
        licznik += 1

print("Ilość:", licznik)
