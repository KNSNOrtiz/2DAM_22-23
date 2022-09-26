lista = ["elemento1","elemento2",3]
print(lista)    
print(lista[0:1])    #  Se indica entre [minInclusivo,maxExclusivo] el rango que se quiere ocupar de la lista.
lista.append("añadido")
lista.insert(2,"Añadido en la posición 2")
#lista.remove("elemento1")   #   Elimina toda coincidencia con el valor especificado.
#lista.pop()     #   Borra el elemento del índice indicado, que por defecto va a ser el último.
#lista.clear()   #   Borra la lista entera.
print(lista.count(3))    #   Con count se obtiene el número de veces que ese elemento está en la lista.
print(len(lista))       #   Devuelve la longitud de la lista.

for i in "cadena":  #   Se recorren las listas genéricamente de esta manera
    print(i)
    
#for i in range(9,1,-1):  #   Así se recorre la lista inversamente desde el 9 hasta el 1 (exclusivo) restando -1.
 #   print(i)
    
for i in range(len(lista)-1,-1,-1):
    print(lista[i])