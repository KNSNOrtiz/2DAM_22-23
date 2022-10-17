from clases import Persona

class Alumno(Persona):
    def __init__(self, nom="<Sin Nombre>"):
        #self.nombre = nom
        super().__init__(nom)
        
    def imprimir(self):
        print(f"{self.nombre}")
    
    def quienSoy(self):
        print("Soy un Alumno")
        
class Profesor(Persona):
    def __init__(self, nom="<Sin Nombre>"):
        super().__init__(nom)
        
    def imprimir(self):
        print(f"{self.nombre}")
        
    def quienSoy(self):
        print("Soy un profesor")
        
        
def polimorfismo(objeto):
    objeto.quienSoy()
    
al1 = Alumno("Mario Ortiz")
pf1 = Profesor("Pepe")
al1.imprimir()
#al1.quienSoy()
pf1.imprimir()
#pf1.quienSoy()

polimorfismo(al1)
polimorfismo(pf1)
