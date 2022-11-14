import tkinter.font
from tkinter import *
from tkinter import messagebox
import os
import pickle

#   ------------------------------------  DEFINICIÓN DE CLASES ------------------------------------
class Videojuego:
    def __init__(self,id,titulo,descripcion):
        self.id = id
        self.titulo = titulo
        self.descripcion = descripcion

    def __str__(self):
        return "{0};{1};{2}".format(self.id, self.titulo, self.descripcion)

class GestionVideojuegos:
    lista=[]
    def mostrarVideojuegos(self):
        for videojuego in self.lista:
            print(videojuego)

    def anadirVideojuego(self, videojuego:Videojuego):
        for i in range(len(self.lista)):
            if  self.lista[i].id == videojuego.id:
                return -1
        self.lista.append(videojuego)
        return 0

    def modificarVideojuego(self, indice, titulo, descripcion):
         self.lista[indice].titulo = titulo
         self.lista[indice].descripcion = descripcion

# ------------------------------------ MANIPULACIÓN DE OBJETOS Y LISTA ------------------------------------

gestion = GestionVideojuegos()
seleccion = -1    #   Índice seleccionado en la lista.
ultSeleccionado = -1     #   Auxiliar que mantendrá el último índice que se seleccionó, será usado para modificar los elementos de la lista.

def refrescarListbox():
    listbox.delete(0, END)  # LIMPIAR LISTBOX
    listbox.insert(END, *gestion.lista)  # VOLCAR LA LISTA EN EL LISTBOX

def anadirItem():
    if  txtId.get() != "" and txtTitulo.get() != "":
        videojuego = Videojuego(id=txtId.get(), titulo=txtTitulo.get(), descripcion=txtDesc.get())
        if videojuego.descripcion == "":
            videojuego.descripcion= "<Sin descripción>"
        if gestion.anadirVideojuego(videojuego) == -1:
            messagebox.showinfo("Error al añadir", "El videojuego ya está en la lista.")
        else:
            refrescarListbox()
    else:
        messagebox.showinfo("Error de entrada", "Los campos ID y Título no pueden estar vacíos.")

def eliminarItem():
        if ultSeleccionado >= 0:
            res = messagebox.askyesno("Eliminar videojuego", "Se eliminará el elemento seleccionado. ¿Estás seguro?")
            if res == True:
                del gestion.lista[seleccion]
                refrescarListbox()
        else:
            messagebox.showinfo(title="Error de borrado", message="Primero debes haber seleccionado un elemento.")

def modificarItem():
        if ultSeleccionado >= 0:
            res = messagebox.askyesno("Modificar videojuego", "Se modificará el elemento seleccionado con los datos de los campos, salvo ID. ¿Estás seguro?")
            if res == True:
                gestion.modificarVideojuego(ultSeleccionado, entry_titulo.get(), entry_desc.get())
                refrescarListbox()
        else:
            messagebox.showinfo(title="Error de modificación", message="Primero debes haber seleccionado un elemento.")

def itemSeleccionado(evt):
    if len(listbox.curselection()) > 0:
        seleccion = listbox.curselection()[0] #   Se obtiene una tupla con los elementos seleccionados, de la que solo extraemos el primer item seleccionado.
        if seleccion >= 0:
            global ultSeleccionado  #   Mediante "global" se especifica que se usará la variable creada más arriba, y no otra local con el mismo nombre.
            ultSeleccionado = seleccion
            entry_id.set(gestion.lista[seleccion].id)
            entry_titulo.set(gestion.lista[seleccion].titulo)
            entry_desc.set(gestion.lista[seleccion].descripcion)

def exportarBinario():
    if len(gestion.lista) > 0:
        fichero = open("listaVideojuegos.bin","wb")
        pickle.dump(gestion.lista,fichero)
        messagebox.showinfo("Lista exportada", "Se ha exportado la lista en la siguiente ruta:\n " + os.path.realpath(fichero.name))
        fichero.close()
        del(fichero)
    else:
        messagebox.showinfo("Error de exportación","No se puede exportar la lista. Debe haber mínimo un elemento primero")

def importarBinario():
    try:
        fichero = open("listaVideojuegos.bin","rb")
        gestion.lista = pickle.load(fichero)
        refrescarListbox()
        messagebox.showinfo("Lista importada","Se ha importado la lista desde la siguiente ruta:\n " + os.path.realpath(fichero.name))
        fichero.close()
        del(fichero)
    except FileNotFoundError as e:
        messagebox.showinfo(parent=window, title="Error de lectura", message="No se ha podido encontrar el fichero binario con la lista. \n Asegúrate de exportar la lista primero.")
        txtId.focus_set()

#   ------------------------------------ ELEMENTOS GUI ------------------------------------
window = Tk()
window.title("Gestión de lista en Python mediante GUI | Mario Ortiz Jibaja")
window.geometry("600x500")
window.resizable(width=False,height=False)
frame = Frame(window)
frame.pack()


label = Label(frame, text="Gestión de lista de videojuegos", foreground="black", font= ("OpenSymbol", 24, "bold"))

entry_id = StringVar()
lblId = Label(frame, text="ID:")
txtId = Entry(frame, textvariable=entry_id)

entry_titulo = StringVar()
lblTitulo = Label(frame, text="Título:")
txtTitulo = Entry(frame,textvariable=entry_titulo)

entry_desc = StringVar()
lblDesc = Label(frame, text="Descripción:")
txtDesc = Entry(frame, textvariable=entry_desc)

listbox = Listbox(frame)
listbox.bind('<<ListboxSelect>>', itemSeleccionado)


btnAnadir = Button(frame, text="Añadir videojuego", command=anadirItem)
btnModificar = Button(frame, text="Modificar videojuego", command=modificarItem)
btnEliminar = Button(frame, text="Eliminar videojuego", command=eliminarItem)
btnExportar = Button(frame, text="Exportar  la lista", command=exportarBinario)
btnImportar = Button(frame, text="Importar la lista", command=importarBinario)

label.grid(row=0,column=0,pady=40, columnspan=4, sticky=E+W)
lblId.grid(row=1, column=0, sticky=E)
txtId.grid(row=1, column=1)
lblTitulo.grid(row=2,column=0, sticky=E)
txtTitulo.grid(row=2,column=1)
lblDesc.grid(row=3,column=0, sticky=E)
txtDesc.grid(row=3,column=1)
listbox.grid(row=4,column=0, columnspan=5,pady=10, sticky=E+W)
btnAnadir.grid(row=5,column=0,padx=5)
btnModificar.grid(row=5,column=1,padx=5)
btnEliminar.grid(row=5,column=2,padx=5)
btnExportar.grid(row=5,column=3,padx=10)
btnImportar.grid(row=5,column=4)

window.mainloop()