import math


class Punto:
    def __init__(self, x = 0, y = 0):
        self.X = x
        self.Y = y

class Forma:
    def __init__(self, color = "Blanco", punto = Punto(), nombre = ""):
        self.color = color
        self.centro = punto
        self.nombre = nombre
    
    @property
    def Color(self):
        return self.color
    @Color.setter
    def Color(self, value:str):
        self.color = value
        
    def moverCentro(self, value: Punto):
        self.punto = value
        
    def __str__(self) -> str:
        cadena = "Nombre: {0} || Color: {1} || Pos.Central: (X): {2}, (Y): {3}"
        return cadena.format(self.nombre, self.color, self.centro.X, self.centro.Y)
    
class Rectangulo(Forma):
    def __init__(self, color="Blanco", punto=Punto(), nombre="", ladoMenor = 0, ladoMayor = 0):
        super().__init__(color, punto, nombre)
        self.ladoMenor = ladoMenor
        self.ladoMayor = ladoMayor
    
    def calcularArea(self):
        area = self.ladoMayor * self.ladoMenor
        return area
    
    def calcularPerimetro(self):
        perimetro = 2 * self.ladoMayor + 2 * self.ladoMenor
        return perimetro
    
    def cambiarTamano(self, escala:float):
        self.ladoMenor = self.ladoMenor * escala
        self.ladoMayor = self.ladoMayor * escala
    
    def __str__(self) -> str:
        cadena =  super().__str__()
        cadena += " || Forma: Rectángulo || Lado mayor: {0} || Lado menor: {1}"
        return cadena.format(self.ladoMayor,self.ladoMenor);
    
class Elipse(Forma):
    def __init__(self, color="Blanco", punto=Punto(), nombre="", radioMenor = 0, radioMayor = 0):
        super().__init__(color, punto, nombre)
        self.radioMayor = radioMayor
        self.radioMenor = radioMenor
        
    def calcularArea(self):
        area = round(math.pi * (self.radioMenor * self.radioMayor), 2)
        return area
    
    def __str__(self) -> str:
        cadena = super().__str__()
        cadena += "Forma: Elipse || Radio Mayor: {0} || Radio Menor: {1}"
        return cadena.format(self.radioMayor, self.radioMenor)

class Cuadrado(Rectangulo):
    def __init__(self, color="Blanco", punto=Punto(), nombre="", ladoMenor=0, ladoMayor=0):
        super().__init__(color, punto, nombre, ladoMenor, ladoMayor)
        self.ladoMenor = self.ladoMayor
    
    def calcularPerimetro(self):
        perimetro = self.ladoMayor * 4
        return perimetro

class Circulo(Elipse):
    def __init__(self, color="Blanco", punto=Punto(), nombre="", radioMayor=0, radioMenor=0):
        super().__init__(color, punto, nombre, radioMayor, radioMenor)
        self.radioMenor = self.radioMayor
    
    def calcularArea(self):
        area = round(2 * math.pi * self.radioMayor,2)
        return area

forma = Forma("Negro", Punto(10,10), "Forma 1")
rectangulo = Rectangulo("Blanco", Punto(30,30), "Rectángulo 1", 3, 6)
elipse = Elipse("Rojo", Punto(20,20), "Elipse 1", 10, 8)
cuadrado = Cuadrado("Verde", Punto(15,15), "Cuadrado 1", 5, 10)
circulo = Circulo("Azul", Punto(50,50), "Círculo 1", 6, 12)

print(cuadrado)
print(cuadrado.calcularArea())
print(cuadrado.calcularPerimetro())
print(circulo)
print(circulo.calcularArea())

    
        