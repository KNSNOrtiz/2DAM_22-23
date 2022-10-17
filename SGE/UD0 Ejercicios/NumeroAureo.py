def fibGenerador():
    a = 0
    b = 1
    while True:
        a, b = b, a + b
        yield b / a

numeroAureo = fibGenerador()

for i in range(40):         #   En la 40º iteración el número aúreo es exacto y por tanto ya no varía en las siguientes.
    print(next(numeroAureo))