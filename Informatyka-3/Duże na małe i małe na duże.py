N = int(input())
list = ""
for _ in range(N):
    word = input().strip()
    list += word.swapcase() + "\n"

print(list)