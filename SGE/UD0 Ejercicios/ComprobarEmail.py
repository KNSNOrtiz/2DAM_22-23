def Validar(correo):
    contadorespacios = 0
    contadorarroba =  0
    for i in correo:
        if(i == " "):
            contadorespacios += 1
            
        if(i=="@"):
            contadorarroba += 1
            
        if(i == "+") or (i=="-") or (i=="*") or (i=="?") or (i=="!"):
            listainvalidos.append(correo)
            return
            
            
    if contadorespacios > 0 or contadorarroba > 1:
        listainvalidos.append(correo)
    else:
        listavalidos.append(correo)

email1 = "mar@io@gmail.com"
email2 = "mario@gmail.com"
email3 = "pepehola@outlook.es"
email4="es temailno.stabien.@com"
listacorreos = [email1,email2,email3,email4]
listavalidos = []
listainvalidos = []

for i in range(0,len(listacorreos),+1):
    Validar(listacorreos[i])

print(listavalidos)
print(listainvalidos)

