from Ejercicio2Electrodomestico import Electrodomestico

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
        