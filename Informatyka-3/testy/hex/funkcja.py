def czyhex(liczba):
    hex_number = hex(liczba)[2:]
    for char in hex_number:
        if char.isalpha():
            return "tak"
    return "nie"
