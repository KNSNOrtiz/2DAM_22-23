class Serie:
    def __init__(self, titulo = "", temporadas = 3, genero = "", creador=""): 
        self.__titulo = titulo
        self.__temporadas = temporadas
        self.__entregado = False
        self.__genero = genero
        self.__creador = creador
    
    @property
    def Titulo(self):
        return self.__titulo
    @Titulo.setter
    def Titulo(self, value):
        self.__titulo = value
    
    @property
    def Temporadas(self):
        return self.__temporadas
    @Temporadas.setter
    def Temporadas(self, value):
        self.__temporadas = value
    
    
    @property
    def Genero(self):
        return self.__genero
    @Genero.setter
    def Genero(self, value):
        self.__genero = value
    
    @property
    def Creador(self):
        return self.__creador
    @Creador.setter
    def Creador(self, value):
        self.__creador = value
        
    def entregar(self):
        self.__entregado = True
        
    def __str__(self) -> str:
        cadena = "Título: {0} || Temporadas: {1} || Entregado: {2} || Género: {3} || Creador: {4}"
        return cadena.format(self.Titulo, self.Temporadas , self.__entregado, self.Genero, self.Creador)
    
class Videojuego:
    def __init__(self, titulo = "", horas=10, genero="", compania=""):
        self.__titulo = titulo
        self.__horas = horas
        self.__entregado = False
        self.__genero = genero
        self.__compania = compania
        
    @property
    def Titulo(self):
        return self.__titulo
    @Titulo.setter
    def Titulo(self, value):
        self.__titulo = value
    
    @property
    def HorasEstimadas(self):
        return self.__horas
    @HorasEstimadas.setter
    def HorasEstimadas(self, value):
        self.__horas = value
    
    @property
    def Genero(self):
        return self.__genero
    @Genero.setter
    def Genero(self, value):
        self.__genero = value
    
    @property
    def Compania(self):
        return self.__compania
    @Compania.setter
    def Compania(self, value):
        self.__compania = value
        
    def entregar(self):
        self.__entregado = True
        
    def __str__(self) -> str:
        cadena = "Título: {0} || Horas estimadas: {1} || Entregado: {2} || Género: {3} || Compañía: {4}"
        return cadena.format(self.Titulo, self.HorasEstimadas , self.__entregado, self.Genero, self.Compania)
    