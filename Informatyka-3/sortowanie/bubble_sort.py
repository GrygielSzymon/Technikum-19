import random


def bubble_sort(t):
    n = len(t)
    for i in range(n-1):
        is_sorted = True
        for j in range(n-i-1):
            if t[j] > t[j+1]:
                t[j], t[j+1] = t[j+1], t[j]
                is_sorted = False
        if is_sorted:
            break
        print(t)
    return t

n = 10
t = []
for i in range(n):
    t.append(random.randint(1, 100))

print(bubble_sort(t))