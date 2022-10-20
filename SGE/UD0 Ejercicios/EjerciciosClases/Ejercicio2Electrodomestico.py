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
            
        