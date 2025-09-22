text = '''Szukajcie prawdy jasnego plomienia,
Szukajcie nowych, nieodkrytych drog!'''

# a = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'
#
# for i in a:
#     print(i, text.count(i))


t = [0] * 123

for i in text:
    t[ord(i)] += 1

for i in range(65, len(t)):
    if t[i]:
        print(chr(i), t[i])