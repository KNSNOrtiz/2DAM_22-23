from email.utils import parsedate_to_datetime


def pares():
    lista=[]
    for i in range (2,20,2):
        lista.append(i)
    return lista

def GenerarPares():
    num = 2
    while True:
        yield num   # Yield: Devuelve el valor pero sin acabar la función.
        num += 2
   

numerosPares = GenerarPares()   #   Se asigna el generador a la variable.
for i in range(5):
    print(next(numerosPares))   #   Con Next hacemos que avance una iteración el generador.
    
    
    #ToDo: Hacer un programa que genere un 