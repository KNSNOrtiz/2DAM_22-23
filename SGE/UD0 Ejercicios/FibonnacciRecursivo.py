n = int(input("Introduce un número: "))
def FiboRecurs(n):
    if n == 1:
        return 0
    if n == 2:
        return 1
    return FiboRecurs(n-1) + FiboRecurs(n-2)

#print(str(FiboRecurs(n)))
print("La secuencia de Fibonacci donde n es " + str(n) + " llega hasta: "+ str(FiboRecurs(n)))