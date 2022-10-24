# 1) Clase Persona
from random import randint

class Persona:
    def generaDNI(self):
        numero = randint(10000000,99999999)
        letras = "TRWAGMYFPDXBNJZSQVHLCKE"
        dni = str(numero) + letras[numero%23]
        return dni
    
    def __init__(self, nombre = "", edad = 0, sexo = 'M', peso = 0.0, altura = 0.0):
        self.__nombre = nombre
        self.__edad = edad
        self.__dni = self.generaDNI()
        if (sexo != 'M') and (sexo != 'H'):
            sexo = 'M'
        self.__sexo = sexo
        self.__peso = peso
        self.__altura = altura
    
    @property    
    def nombre(self):
        return self.__nombre
    @nombre.setter
    def nombre(self, value:str):
        self.__nombre = value
        
    @property
    def edad(self):
        return self.__edad
    @edad.setter
    def edad(self, value:int):
        self.__edad = value
    
    @property
    def dni(self):
        return self.__dni

    
    @property
    def sexo(self):
        return self.__sexo
    @sexo.setter
    def sexo(self, value:str):
        if (value != 'M') and (value != 'H'):
            value = 'M'
        self.__sexo = value

    @property
    def peso(self):
        return self.__peso
    @peso.setter
    def peso(self, value:float):
        self.__peso = value
        
    @property
    def altura(self):
        return self.__altura
    @altura.setter
    def altura(self, value:float):
        self.__altura = value
    
    def esMayorDeEdad(self):
        if self.edad >= 18:
            return True
        else:
            return False
            
    def CalcularIMC(self):
        if self.altura == 0 or self.peso == 0:
            print("La persona " + self.nombre + " no tiene altura o peso especificado.")
            return
        imc = self.peso / pow(self.altura,2) 
        if imc >= 18.5 and imc < 25:
            resultado = 0
        if imc < 18.5:
            resultado = -1
        if imc >= 25:
            resultado = 1
        imc = round(imc,2)
        print("El IMC de {0} es de {1}.".format(self.nombre, imc))
        return resultado
    

        
    def __str__(self):  # "Override" del método ToString en Python.
        cadena = "Nombre: {0} || Edad: {1} || DNI: {2} || Sexo: {3} || Peso: {4} kg || Altura: {5} m"
        return cadena.format(self.nombre, self.edad, self.dni, self.sexo, self.peso, self.altura)

nom = input("Introduce un nombre: ")
try:
    ed = int(input("Introduce una edad: "))
    sex = str.upper(input("Introduce el sexo: "))
    pes = float(input("Introduce el peso (kg): "))
    alt = float(input("Introduce la altura (metros): "))
except ValueError:
    print("ERROR: Uno de los valores introducidos no es correcto.")
    exit()

persona1 = Persona(nom, ed, sex, pes, alt)
persona2 = Persona(nom, ed, sex)
persona3 = Persona()

    
persona3.nombre = "Mario Ortiz"
persona3.edad = 19
persona3.sexo = "H"
persona3.peso = 68
persona3.altura = 1.75
personas = [persona1, persona2, persona3]

for persona in personas:
    print("\n")
    if persona.esMayorDeEdad():
        print(persona.nombre + " es mayor de edad.")
    else:
        print(persona.nombre + " es menor de edad.")
    resultado = persona.CalcularIMC()
    if resultado == -1:
        print("Está por debajo de su peso ideal.")
    if resultado == 0:
        print("Está en su peso ideal.")
    if resultado == 1:
        print("Está por encima de su peso ideal.")
    print(persona)
    print("\n")
