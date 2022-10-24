class Electrodomestico:
    def __comprobarConsumoEnergetico(self, letra):
        if letra != "A" and letra != "B" and letra != "C" and letra != "D" and letra != "E" and letra != "F":
            letra = "F"
            return letra
    
    def __comprobarColor(self, color):
        if color != "blanco" and color != "negro" and color != "rojo" and color != "azul" and color != "gris":
            color = "blanco"
            return color
        
    def __init__(self, preciobase = 100, color = "Blanco", consumo = 'F', peso = 5):
        color = self.__comprobarColor(str.lower(color))
        consumo = self.__comprobarConsumoEnergetico(str.upper(consumo))
        self.__preciobase = preciobase
        self.__color = color
        self.__consumo = consumo
        self.__peso = peso  
    
    @property
    def preciobase(self):
        return self.__preciobase
    
    @property
    def color(self):
        return self.__color
    
    @property
    def consumo(self):
        return self.__consumo
    
    @property
    def peso(self):
        return self.__peso
    
    def precioFinal(self):
        extra = 0
        if self.consumo == "A":
            extra += 100
        elif self.consumo == "B":
            extra += 80
        elif self.consumo == "C":
            extra += 60
        elif self.consumo == "D":
            extra += 50
        elif self.consumo == "E":
            extra += 30
        elif self.consumo == "F":
            extra += 10
        
        if self.peso >= 0 and self.peso <= 19:
            extra += 10
        elif self.peso >= 20 and self.peso >= 49:
            extra += 50
        elif self.peso >= 50 and self.peso <= 79:
            extra += 80
        elif self.peso >= 80:
            extra += 100
            
        precioFinal = self.preciobase + extra
        return precioFinal

class Lavadora(Electrodomestico):
    def __init__(self, preciobase=100, color="Blanco", consumo='F', peso=5, carga = 5):
        super().__init__(preciobase, color, consumo, peso)
        self.__carga = carga
    
    @property
    def carga(self):
        return self.__carga
    
    def precioFinal(self):
        precioFinal = super().precioFinal()
        if self.__carga > 30:
            precioFinal += 50
        return precioFinal
    
class Television(Electrodomestico):
    def __init__(self, preciobase=100, color="Blanco", consumo='F', peso=5, resolucion = 20, fourK = False):
        super().__init__(preciobase, color, consumo, peso)
        self.__resolucion = resolucion
        self.__fourK = fourK
        
    @property
    def fourK(self):
        return self.__fourK
    
    def precioFinal(self):
        precioFinal = super().precioFinal()
        if self.__resolucion > 40:
            precioFinal += (self.__preciobase * 0.3)
        if self.fourK:
            precioFinal += 50
        return precioFinal   

elec1 = Electrodomestico(200, "negro", "B", 8)
elec2 = Electrodomestico(300, "rojo", "A", 10)
elec3 = Lavadora(200, "Blanco", "D", 80, 8)
elec4 = Lavadora (500, "Azul", "F", 5, 5)
elec5 = Television(500, "Negro", "C", 10, 40, True)
elec6 = Television(200, "Blanco", "F", 5, 26, False)
elec7 = Electrodomestico()
elec8 = Electrodomestico(800, "Negro", "A", 70)
elec9 = Electrodomestico(1000, "Rojo", "B", 30)
elec10 = Lavadora(400, "Blanco", "C", 25, 10)

listaElectrodomesticos = [elec1, elec2, elec3, elec4, elec5, elec6, elec7, elec8, elec9, elec10]
precioElectrodomesticos = 0
precioTelevisiones = 0
precioLavadoras = 0
for elec in listaElectrodomesticos:
    precFinal = 0
    if isinstance(elec, Electrodomestico):
        precFinal = elec.precioFinal()     
        precioElectrodomesticos += precFinal
    if isinstance(elec, Lavadora):
        precioLavadoras += precFinal
    elif isinstance(elec, Television):
        precioTelevisiones += precFinal
        
print("El precio total de todos los electrodomésticos es de ",precioElectrodomesticos,"€")
print("El precio total de todas las lavadoras es de", precioLavadoras,"€")
print("El precio total de todas las televisiones es de", precioTelevisiones, "€")



