from random import randint

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

seriesEntregadas = 0
juegosEntregados = 0

serie1 = Serie("Breaking Bad", 5, "Drama", "Vince Gilligan")
serie2 = Serie("Juego de Tronos", 8, "Fantasía/Drama", "George R.R. Martin")
serie3 = Serie("Cyberpunk 2077: Edgerunners", 1, "Animación", "Rafal Jaki")
serie4 = Serie("Steven Universe", 5, "Animación", "Rebecca Sugar")
serie5 = Serie("Sense8", 3, "Drama/Suspense", "Hermanas Wachowski")

juego1 = Videojuego("The Legend of Zelda: Breath of the Wild", 60, "Aventura", "Nintendo")
juego2 = Videojuego("Genshin Impact", 1000, "Aventura/Gacha", "Hoyoverse")
juego3= Videojuego("Mass Effect 2", 30, "RPG", "BioWare")
juego4= Videojuego("Final Fantasy XIV", 4000, "MMORPG", "Squarenix")
juego5= Videojuego("Devil May Cry 5", 12, "Hack 'n' Slash", "Capcom")
 
listaSeries = [serie1,serie2,serie3,serie4,serie5]
listaVideojuegos = [juego1,juego2,juego3,juego4,juego5]

serieMasLarga = listaSeries[0]
juegoMasLargo = listaVideojuegos[0]


for serie in listaSeries:
    ent = randint(0,1)
    if ent == 1:
        serie.entregar()
        seriesEntregadas += 1
    if serie.Temporadas > serieMasLarga.Temporadas:
        serieMasLarga = serie
    print(serie)
    print("\n")

for juego in listaVideojuegos:
    ent = randint(0,1)
    if ent == 1:
        juego.entregar()
        juegosEntregados += 1
    if juego.HorasEstimadas > juegoMasLargo.HorasEstimadas:
        juegoMasLargo = juego
    print(juego)
    print("\n")
    
print("Se han entregado un total de", seriesEntregadas, "series.")
print("La serie con más temporadas es", serieMasLarga.Titulo,"con",serieMasLarga.Temporadas,"temporadas." "\n")
print("Se han entregado un total de", juegosEntregados, "videojuegos.")
print("El videojuego más largo es",juegoMasLargo.Titulo,"con apróximadamente",juegoMasLargo.HorasEstimadas,"horas de duración.")
    
