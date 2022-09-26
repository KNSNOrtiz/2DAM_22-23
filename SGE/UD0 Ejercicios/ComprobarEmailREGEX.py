import re
def Validar(correo):
    expresionRegular = "^[a-z0-9]+[\._]?[a-z0-9]+[@]\w+[.]\w{2,3}$"
    valido = re.search(expresionRegular, correo)
    if valido:
        listavalidos.append(correo)
    else:
        listainvalidos.append(correo)
        
email1 = "mar@@@io@gmail.com"
email2 = "mario@gmail.com"
email3 = "pepehola@outlook.es"
email4="es temailno.stabien.@com"
listacorreos = [email1,email2,email3,email4]
listavalidos = []
listainvalidos = []

for i in range(0,len(listacorreos),+1):
    Validar(listacorreos[i])
    
print("Emails válidos: " + str(listavalidos))
print("Emails inválidos: " + str(listainvalidos))

