with open("binarne.txt", mode="r") as file:
    numbers = file.read().split()

#max dlugosc
max_len = len(numbers[0])
for n in numbers:
    if len(n) > max_len:
        max_len = len(n)

print(max_len)

with open("dlugosc.txt", mode="w") as file:
    file.write(f"maksymalna dlugosc wynosi {max_len}")


#ile liczb z 111 na początku
max_len = len(numbers[0])
counter = 0
for n in numbers:
    if len(n) > max_len:
        max_len = len(n)
    if n[:3] == "111":
        counter += 1
print(max_len, counter)


#ile takich liczb gdzie jest więcej jedynek
max_len = len(numbers[0])
counter = 0
for n in numbers:
    ones = n.count("1")
    zeros = n.count("0")

    if ones > zeros:
        counter += 1
print(counter)

#przekonwertuj adres na dziesiętny
#A4-BB-6D-B1-85-94
adres = "A4-BB-6D-B1-85-94"
adresC = adres.split("-")
dec = int(adresC, 16)
print(dec)