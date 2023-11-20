def imprimir_piramide(tamanho):
    j = tamanho - 1
    for i in range(2, tamanho + 1, 2):
        print(' ' * j + i * '*')
        j = j - 1

tamanho_piramide = int(input("Digite o tamanho da pirâmide: "))

imprimir_piramide(tamanho_piramide)