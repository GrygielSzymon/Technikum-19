n = int(input())
for _ in range(n):
    sides = list(map(int, input().split()))
    sides.sort()
    if sides[0] + sides[1] + sides[2] > sides[3]:
        print("TAK")
    else:
        print("NIE")
