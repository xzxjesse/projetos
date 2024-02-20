print('A PROVA 1 TEVE 10 QUESTÕES')
print('INFORME A QUANTIDADE DE QUESTÕES CORRETAS')
corretas_p1=int(input())
print('INFORME A QUANTIDADE DE QUESTÕES ERRADAS')
fator_p1=int(input())
nota_p1=(corretas_p1)-(fator_p1*0.5)
print('NOTA P1 = {:.2f}'.format(nota_p1))

print('A PROVA 2 TEVE 16 QUESTÕES')
print('INFORME A QUANTIDADE DE QUESTÕES CORRETAS')
corretas_p2=int(input())
print('INFORME A QUANTIDADE DE QUESTÕES ERRADAS')
fator_p2=int(input())
nota_p2=(corretas_p2*0.625)-(fator_p2*0.3125)
print('NOTA P2 = {:.2f}'.format(nota_p2))

print('A PROVA 3 TEVE 20 QUESTÕES')
print('INFORME A QUANTIDADE DE QUESTÕES CORRETAS')
corretas_p3=int(input())
print('INFORME A QUANTIDADE DE QUESTÕES ERRADAS')
fator_p3=int(input())
nota_p3=(corretas_p3*0.5)-(fator_p3*0.25)
print('NOTA P3 = {:.2f}'.format(nota_p3))

media_sem_recuperacao = ((3.5*nota_p1)+(4.5*nota_p2)+(5*nota_p3))/13
print('MÉDIA FINAL = {:.2f}'.format(media_sem_recuperacao))

if media_sem_recuperacao>=5:
    print('APROVADO')
else:
    print('JÁ FEZ A PROVA DE RECUPERAÇÃO?')
    print('1-SIM   2-NÃO')
    resposta=int(input())
    if resposta==1:
        print('A PROVA DE RECUPERAÇÃO TEVE 30 QUESTÕES')
        print('INFORME A QUANTIDADE DE QUESTÕES CORRETAS')
        corretas_rec=int(input())

        print('INFORME A QUANTIDADE DE QUESTÕES ERRADAS')
        fator_rec=int(input())

        nota_rec=(corretas_rec*0.166666667)-(fator_rec*0.0833333335)
        print('NOTA PROVA DE RECUPERAÇÃO = {:.2f}'.format(nota_rec))

        media_com_recuperacao = (media_sem_recuperacao + nota_rec)
        print('NOVA MÉDIA FINAL = {:.2f}'.format(media_com_recuperacao))

        if media_com_recuperacao>=5:
            print('APROVADO')
        else:
            print('REPROVADO')    
    if resposta==2:
        print('AGENDE SUA PROVA DE RECUPERAÇÃO COM O PROFESSOR RESPONSÁVEL')

#colocar validadores/limites nos dados informados
#colocar sistema de identificação de usuarios
#armazenar dados em documentos
#tornar viavel a escolha dos pesos, quantidade de provas, quantidade de questões...