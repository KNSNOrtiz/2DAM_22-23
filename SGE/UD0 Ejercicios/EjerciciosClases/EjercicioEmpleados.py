class Coche:
    def __init__(self, matricula="",marca="",modelo="") -> None:
        self.matricula = matricula
        self.marca = marca
        self.modelo = modelo
    def __str__(self) -> str:
        cadena = "[Matrícula: {0}, Marca: {1}, Modelo: {2}]"
        return cadena.format(self.matricula,self.marca,self.modelo)

class Empleado:        
    def __init__(self, nombre="", apellidos="", dni="", direccion="", antiguedad=0, telefono="", salario=0.0) -> None:
        self.nombre = nombre
        self.apellidos = apellidos
        self.dni = dni
        self.direccion = direccion
        self.antiguedad = antiguedad
        self.telefono = telefono
        self.incremento = 0.0
        self.salario = salario
        self.salario = self.incrementarSalario()
        self.supervisor = None
        
    def incrementarSalario(self):
        salario = self.salario + self.salario * (self.antiguedad * self.incremento)
        return salario
        
    def asignarSupervisor(self, supervisor):
        self.supervisor = supervisor
            


    def __str__(self) -> str:
        cadena = "Nombre: {0} || Apellidos: {1} || DNI: {2} || Dirección: {3} || Antigüedad: {4} años || Teléfono: {5} || Salario: {6} €"
        if self.supervisor != None:
            cadena += " || Supervisor:",self.supervisor
            
        return cadena.format(self.nombre, self.apellidos, self.dni, self.direccion, self.antiguedad, self.telefono, self.salario)
    
class Secretario(Empleado):
    def __init__(self, nombre="", apellidos="", dni="", direccion="", antiguedad=0, telefono="", salario=0, despacho="", fax="") -> None:
        super().__init__(nombre, apellidos, dni, direccion, antiguedad, telefono, salario)
        self.despacho = despacho
        self.fax = fax
        self.incremento = 0.05
        self.salario = self.incrementarSalario()
        
    def __str__(self) -> str:
        cadena = super().__str__()
        cadena += " || Despacho: {0} || Fax: {1} || Puesto: Secretario/a"
        return cadena.format(self.despacho, self.fax)

class Vendedor(Empleado):
    def __init__(self, nombre="", apellidos="", dni="", direccion="", antiguedad=0, telefono="", salario=0, coche:Coche = Coche(), movil= "", areaventa="", listaclientes:list = [], comisiones= 0) -> None:
        super().__init__(nombre, apellidos, dni, direccion, antiguedad, telefono, salario)
        self.coche = coche
        self.movil = movil
        self.areaventa = areaventa
        self.listaclientes = listaclientes
        self.comisiones = comisiones
        self.incremento = 0.10
        self.salario = self.incrementarSalario()
    def __str__(self) -> str:
        cadena = super().__str__()
        cadena += " || Coche de empresa: {0} || Telf. Móvil: {1} || Área Venta: {2} || Clientes: {3} || Comisión: {4} % || Puesto: Vendedor/a "
        return cadena.format(self.coche, self.movil, self.areaventa, self.listaclientes, self.comisiones)    
    
    def AltaCliente(self, cliente:str):
        if self.listaclientes.count(cliente) > 0:
            print("El cliente",cliente,"ya se encuentra asignado al vendedor",self.nombre,self.apellidos)
        else:
            self.listaclientes.append(cliente)
            print("Se ha añadido el cliente", cliente, "al vendedor",self.nombre, self.apellidos, "con éxito.")
        
    def BajaCliente(self, cliente:str):
        if self.listaclientes.count(cliente) > 0:
            self.listaclientes.remove(cliente)
            print("Se ha eliminado al cliente",cliente,"del vendedor",self.nombre,self.apellidos)
        else:
            print("El vendedor", self.nombre,self.apellidos,"no tiene tal cliente.")
    
    def CambiarCoche(self, coche:Coche):
        self.coche = coche
        print("Se ha cambiado el coche del vendedor", self.nombre, self.apellidos)
        
class JefeZona(Empleado):
    def __init__(self, nombre="", apellidos="", dni="", direccion="", antiguedad=0, telefono="", salario=0, despacho ="", secretario:Secretario = Secretario(), listaVendedores:list = [], coche:Coche = Coche() ) -> None:
        super().__init__(nombre, apellidos, dni, direccion, antiguedad, telefono, salario)
        self.despacho = despacho
        self.secretario = secretario
        self.listaVendedores = listaVendedores
        self.coche = coche
        self.incremento = 0.20
        self.salario = self.incrementarSalario()
        
    def CambiarSecretario(self, secretario:Secretario):
        self.secretario = secretario
        print("Se ha asignado el/la secretario/a",secretario.nombre,secretario.apellidos,"al jefe de zona",self.nombre,self.apellidos)

    def CambiarCoche(self, coche:Coche):
        self.coche = coche
        print("Se ha cambiado el coche del jefe/a", self.nombre, self.apellidos)
        
    def AltaVendedor(self, vendedor:Vendedor):
        if self.listaVendedores.count(vendedor) > 0:
            print("El/la vendedor/a",vendedor.nombre,vendedor.apellidos,"ya se encuentra asignado/a al jefe/a",self.nombre,self.apellidos)
        else:
            self.listaVendedores.append(vendedor)
            print("Se ha añadido el/la vendedor/a", vendedor.nombre,vendedor.apellidos, "al jefe/a",self.nombre, self.apellidos, "con éxito.")
        
    def BajaVendedor(self, vendedor:Vendedor):
        if self.listaVendedores.count(vendedor) > 0:
            self.listaVendedores.remove(vendedor)
            print("Se ha eliminado al vendedor/a",vendedor.nombre,vendedor.apellidos,"a cargo de",self.nombre,self.apellidos)
        else:
            print("El/la jefe/a de zona", self.nombre,self.apellidos,"no tiene tal vendedor/a a su cargo.")
        
    def __str__(self) -> str:
        cadena = super().__str__()
        cadena += " || Puesto: Jefe/a|| Despacho. {0} || Secretario/a: [{1}] || Vendedores: {2} || Coche: {3}"
        return cadena.format(self.despacho,self.secretario,self.listaVendedores,self.coche)
    
    
#   DEMOSTRACIÓN DEL FUNCIONAMIENTO DE LAS CLASES    
            
empleado1 = Empleado("Mario", "Ortiz", "78113824M", "Calle 1", 5, "629649784", 20000)
secretario1 = Secretario("Mario", "Ortiz", "78113824M", "Calle 1", 5, "629649784", 20000, "Despacho 10", "123456789")
secretario2 = Secretario("Marina", "Rey", "98765432B", "Calle 4", 2, "4238482324", 26000, "Despacho grande", "472384243")
vendedor1 = Vendedor("Mario", "Ortiz", "78113824M", "Calle 1", 5, "629649784", 20000,Coche("12345ABC","Citroen","C4"), "123456890","Cartuja", ["Cliente1", "Cliente2"], 10)
vendedor2 = Vendedor("Lidia", "Sepúlveda", "12345678Z", "Calle 2", 3, "1234567890", 30000,Coche("857474G","Nissan","Micra"), "2345678901","Mondragones", ["Cliente3", "Cliente4"], 10)
jefezona1 = JefeZona("Mario", "Ortiz", "78113824M", "Calle 1", 10, "629649784", 20000, "Despacho del jefazo", secretario1, [vendedor1,vendedor2], Coche("987654F","Nissan","Micra"))

#   INFORMACIÓN DE CADA OBJETO
print(empleado1)
print("\n")
print(secretario1)
print("\n")
print(vendedor1)
print("\n")
print(jefezona1)
print("\n")

#   MÉTODOS DE VENDEDOR
vendedor1.AltaCliente("Pepe")
print(vendedor1.listaclientes)
print("\n")
vendedor1.BajaCliente("Pepe")
print(vendedor1.listaclientes)
print("\n")
vendedor1.CambiarCoche(Coche("67890DEF","Renault","Kangoo"))
print(vendedor1)
print("\n")

#   MÉTODOS DE JEFE DE ZONA
jefezona1.AltaVendedor(vendedor2)
jefezona1.BajaVendedor(vendedor2)
for vendedor in jefezona1.listaVendedores:
    print(vendedor)
    print("\n")
jefezona1.CambiarCoche(Coche("43284GF", "Seat", "Ibiza"))
jefezona1.CambiarSecretario(secretario2)
print(jefezona1)


        