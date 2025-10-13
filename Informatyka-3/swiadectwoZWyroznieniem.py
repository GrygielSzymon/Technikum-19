for _ in range(3):
    N = int(input())
    grades = list(map(int, input().split()))
    avg = sum(grades) / N
    print("TAK" if avg >= 4.75 else "NIE")
