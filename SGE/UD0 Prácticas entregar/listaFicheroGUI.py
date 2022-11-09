from tkinter import *
from tkinter import messagebox

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


    def eliminarVideojuego(self, id):
        for i in range(len(self.lista)):
            if  self.lista[i].id == id:
                del self.lista[i]






# ------------------------------------ MANIPULACIÓN DE OBJETOS Y LISTA ------------------------------------



gestion = GestionVideojuegos()

def refrescarListbox():
    if  txtId.get() != "" and txtTitulo.get() != "":
        videojuego = Videojuego(id=txtId.get(), titulo=txtTitulo.get(), descripcion=txtDesc.get())
        if gestion.anadirVideojuego(videojuego) == -1:
            messagebox.showinfo("Error al añadir", "El videojuego ya está en la lista.")
        else:
            listbox.delete(0, END)  # LIMPIAR LISTBOX
            listbox.insert(END, *gestion.lista)  # VOLCAR LA LISTA EN EL LISTBOX
    else:
        messagebox.showinfo("Error de entrada", "Los campos ID y Título no pueden estar vacíos.")

#   ------------------------------------ ELEMENTOS GUI ------------------------------------
window = Tk()
window.title("Gestión de lista en Python mediante GUI | Mario Ortiz Jibaja")
window.geometry("500x500")

label = Label(text="Gestión de lista de videojuegos", foreground="black")

lblId = Label(text="ID:")
txtId = Entry()

lblTitulo = Label(text="Título:")
txtTitulo = Entry()

lblDesc = Label(text="Descripción:")
txtDesc = Entry()

listbox = Listbox()

btnAnadir = Button(text="Añadir videojuego", command=refrescarListbox)

label.pack()
lblId.pack()
txtId.pack()
lblTitulo.pack()
txtTitulo.pack()
lblDesc.pack()
txtDesc.pack()
listbox.pack()
btnAnadir.pack()
window.mainloop()