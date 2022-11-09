import pickle

def creaFicheroLista():
    lista=["a","b","c"]
    fichero_binario=open("fichero","wb")
    pickle.dump(lista,fichero_binario)
    fichero_binario.close()
    del(fichero_binario)

def leerFicheroLista():
    fichero_binario=open("fichero","rb")
    lista=pickle.load(fichero_binario)
    print(lista)
    fichero_binario.close()
    del(fichero_binario)

creaFicheroLista()
leerFicheroLista()