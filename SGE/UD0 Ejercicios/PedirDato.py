#   MÉTODOS
def Operar():       #   Esta función pide dos parámetros numéricos y la operación que se quiere realizar.
    a = input("Introduce un número por favor: ")
    b = input("Introduce otro: ")
    if not str.isdigit(a) or not str.isdigit(b):
        print("Entrada no válida.")
        return
        
    op = input("Operación que quieres realizar (S,R,M,D): ")
    op = op.upper()
    if op == "S":
        res = int(a) + int(b)
    elif op == "R":
        res = int(a) - int(b)
    elif op == "M":
        res = int(a) * int(b)
    elif op == "D":
        res = int(a) / int(b)
    else:
        print("No existe esa operación")
        return     
        
    print("El resultado es: " + str(res))

def Suma(a,b):
    return a + b

def Resta(a,b):
    return a - b

def Multiplica(a,b):
    return a * b

def Divide(a,b):
    return a / b

#Operar()

a = int(input("Dato 1: "))
b = int(input("Dato 2: "))
print("La suma es: " + str(Suma(a,b)))
print("La resta es: " + str(Resta(a,b)))
print("La multiplicación es: " + str(Multiplica(a,b)))
print("La división es: " + str(Divide(a,b)))