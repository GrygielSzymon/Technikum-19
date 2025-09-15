n = int(input())
grades = list(map(int, input().split()))

counts = [0] * 7
for grade in grades:
    counts[grade] += 1

print(counts[1], counts[2], counts[3], counts[4], counts[5], counts[6])
