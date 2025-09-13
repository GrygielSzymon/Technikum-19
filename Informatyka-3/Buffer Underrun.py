N, B = map(int, input().split())
count = 0

for _ in range(N):
    word = input().strip()
    if len(word) > B:
        count += 1
print(count)