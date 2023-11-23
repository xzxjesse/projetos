def calcular_nota_prova(total_questoes, corretas, erradas, fator_correcao):
    nota = (corretas / total_questoes) - (erradas * fator_correcao)
    return max(nota, 0)