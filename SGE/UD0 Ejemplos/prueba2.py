def nombre_funcion():
    print("Hola soy una función")
    
def nombre_funcion2(arg01,arg02):
    return arg01 + arg02

def nombre_funcion3(arg01,arg02 = 4):   #   En Python es posible asignar valores por defecto                                       
    resultado = arg01 + arg02           #   los parámetros dentro de la propia firma del método.
    return resultado
    
nombre_funcion()
print("El resultado de la función 2 es: " + str(nombre_funcion2(2,2)))
print("El resultado de la función 2 es: " + str(nombre_funcion3(4)))
