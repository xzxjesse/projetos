valores=0
pares=0
impares=0
positivos=0
negativos=0

while (valores<5):
    valor = int(input())
    if valor%2==0:
        pares=pares+1
    else:
        impares=impares+1

    if valor>0:
        positivos=positivos+1
    if valor<0:
        negativos=negativos+1
        
valores +=1

print('{} valor(es) par(es)'.format (pares))
print('{} valor(es) impar(es)'.format (impares))
print('{} valor(es) positivo(s)'.format (positivos))
print('{} valor(es) negativo(s)'.format (negativos))