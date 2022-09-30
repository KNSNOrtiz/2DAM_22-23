from pickle import TRUE


def Validar(correo):
    arroba = 0
    correoAntesArroba = correo[0:correo.rfind('@')]
    correoDespuesArroba = correo[correo.rfind('@'):len(correo)]
    for i in correoAntesArroba:
        if ord(i) in range(65,90) or ord(i) in range(97,122) or ord(i) in range(48,57) or i == '.' or i=='_':
            pass
        else:
            return False
    for i in correoDespuesArroba:
        if ord(i) in range(65,90) or ord(i) in range(97,122) or ord(i) in range(48,57) or i == '.':
            pass
        else:
            return False
    return True

def emailpropart(email):
    indice = email.index('@')
    emailp = email[:indice]
    
    if len(emailp) == 0:
        return False
    if emailp[0]=='.' or emailp[indice-1]=='.':
        return False
    punto = False
    for i in emailp:
        if i=='.':
            if punto:
                return False
            else:
                punto=True
        else:
            punto=False
    return True
    
email = input("Dame un email: ")
print(Validar(email))
#print(Validar(email))

