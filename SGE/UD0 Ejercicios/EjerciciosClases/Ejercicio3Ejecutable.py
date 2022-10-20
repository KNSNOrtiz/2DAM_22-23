from random import randint
from Ejercicio3Clases import Serie, Videojuego

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
    
