listaArticulos = []

def Alta(cod: int, nom: str, desc: str, prec: float):
    if len(cod) == 0 or len(nom) == 0 or len(desc) == 0 or len(prec) == 0:
        print("*******************Ningún campo puede estar vacío.*******************\n")
        return -1
    else:
        articulo = {
        "Cod_Articulo" : cod,
        "Nombre" : nom,
        "Descripción" : desc,
        "Precio" : prec
        }
        return articulo
    
def Baja(cod):
    for i in range(len(listaArticulos)):
        if listaArticulos[i]["Cod_Articulo"] == cod:
            del listaArticulos[i]
            print("\nArtículo borrado de la lista con éxito.\n")
            break
        else:
            print("El artículo con código " + str(cod) + " no existe en la lista.\n")
            break

def Buscar(cod):
    for i in range(len(listaArticulos)):
        if listaArticulos[i]["Cod_Articulo"] == cod:
            print("Artículo encontrado:\n")
            print(listaArticulos[i])
            return i
        else:
            print("El artículo con código " + str(cod) + " no existe en la lista.\n")
            return -1      
               
def Modificar(i: int, nom: str, desc: str, prec: float):
    listaArticulos[i]["Nombre"] = nom
    listaArticulos[i]["Descripción"] = desc
    listaArticulos[i]["Precio"] = prec
    print("\nEl artículo con código " + str(cod) + " ha sido modificado.\n")
         
def Listar():
        contador = 0
        print("\nArtículos de la lista:\n ")
        for articulo in listaArticulos:
            contador += 1
            print("Artículo " + str(contador))
            print(articulo)
            print ("\n")
while True:
    opcion = "0"
    print("Bienvenido. Elija una opción:\n 1.Alta\n 2.Baja\n 3.Modificar\n 4.Buscar\n 5.Listar\n 0.Salir")
    opcion = input("Opción: ")
    if opcion == "1":
        try:
            cod = input("Número de artículo: ")
            nom = input("Nombre: ")
            desc = input("Descripción: ")
            prec = input("Precio: ")
        except:
            print("Los datos no son válidos.")
            continue
        articulo = Alta(cod, nom, desc, prec)
        if articulo != -1:
         listaArticulos.append(articulo)
    elif opcion == "2":
        if len(listaArticulos) == 0:
            print("La lista está vacía.\n")
            continue
        cod = input("Introduzca el código del artículo a borrar: ")
        Baja(cod)
    elif opcion == "3":
        if len(listaArticulos) == 0:
            print("La lista está vacía.\n")
            continue
        try:
            cod = input("Introduzca el código del artículo a modificar: ")
            indiceLista = Buscar(cod)
            if (indiceLista != -1):
                nom = input("Nombre: ")
                desc = input("Descripción: ")
                prec = input("Precio: ")
                Modificar(indiceLista, nom, desc, prec) 
        except:
            print("Los datos no son válidos.")
            continue                
    elif opcion == "4":
        if len(listaArticulos) == 0:
            print("La lista está vacía.\n")
            continue
        cod = input("Introduzca el código del artículo a buscar: ")
        Buscar(cod)        
    elif opcion == "5":
        Listar()
    elif opcion == "0":
        print("Adiós!")
        break
