year = int(input())

if year % 4 == 0:
    if year % 100 == 0 and year % 400 != 0:
        print("NIE")
    else:
        print("TAK")
else:
    print("NIE")
