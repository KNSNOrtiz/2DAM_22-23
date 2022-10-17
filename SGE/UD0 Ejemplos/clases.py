class Persona:
    def __init__(self, nom="<Sin Nombre>"):     #   El método __init__ es el constructor.
        self.nombre = nom
 #   Siempre los métodos de una clase van a tener el parámetro "self", incluso aún si no lo usamos.
    def __getNombre(self):  #   Con el prefijo "__" hacemos que el método sea privado.
        print(self.nombre)

p1 = Persona()
p2 = Persona("Mario")

