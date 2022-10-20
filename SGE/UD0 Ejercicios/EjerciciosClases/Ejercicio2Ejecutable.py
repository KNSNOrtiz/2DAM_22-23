from Ejercicio2Electrodomestico import Electrodomestico
from Ejercicio2Subclases import Lavadora, Television

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



