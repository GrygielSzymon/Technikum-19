def selection_sort(t):
    n = len(t)
    for i in range(n-1):
        p = i
        for j in range (i+1, n):
            if t[j] < t[p]:
                p = j
        t[p], t[i] = t[i], t[p]

    return t

t = [5, 4, 5, 5, 1, 7]
print(selection_sort(t))