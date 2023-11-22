from calculo_nota_prova import calcular_nota_prova


def fazer_prova(numero_prova, total_questoes, fator_correcao):
    print('A PROVA {} TEVE {} QUESTÕES'.format(numero_prova, total_questoes))
    print('INFORME A QUANTIDADE DE QUESTÕES CORRETAS')
    corretas = int(input())
    print('INFORME A QUANTIDADE DE QUESTÕES ERRADAS')
    erradas = int(input())
    nota = calcular_nota_prova(total_questoes, corretas, erradas, fator_correcao)
    print('NOTA P{} = {:.2f}'.format(numero_prova, nota))
    return nota