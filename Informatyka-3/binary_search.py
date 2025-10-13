from random import randint, seed

def binary_search(t, e):
    p = 0
    k = len(t)
    while p <= k:
        sr = (p + k) // 2
        if t[sr] == e:
            return sr
        if t[sr] < e:
            p = sr + 1
        else:
            k = sr- 1
    return - 1

seed(3)
t = [randint(1, 10) for i in range(10)]
t.sort()
p = binary_search(t, 9)
print(t)
print(p)
