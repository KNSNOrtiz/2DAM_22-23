n = int(input("Introduce un número: "))
def FiboIter(n):
    secuencia = []
    if n == 1:
        secuencia = [1]
    elif n == 0:
        secuencia = [0]
    else:
        secuencia = [0,1]
        for i in range(1, n-1):
            secuencia.append(secuencia[i-1] + secuencia[i])
    return secuencia
        
print("La secuencia de Fibonacci con orden " + str(n) + " es: " + str(FiboIter(n)))
        