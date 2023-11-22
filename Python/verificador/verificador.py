def verificador_cpf():
    # Solicita o CPF
    cpf = input("CPF: ")

    # Transforma os números do CPF em int para a verificação da validade
    numeros = [int(digito) for digito in cpf if digito.isdigit()]

    # Realiza os cálculos para obter os dígitos verificadores
    somatorio_a = sum((num * peso) for num, peso in zip(numeros[:9], range(10, 1, -1)))
    resto_a = somatorio_a % 11
    digito_a = 0 if resto_a <= 1 else 11 - resto_a

    somatorio_b = sum((num * peso) for num, peso in zip(numeros[:9], range(11, 1, -1))) + (digito_a * 2)
    resto_b = somatorio_b % 11
    digito_b = 0 if resto_b <= 1 else 11 - resto_b

    # Compara os dígitos obtidos com os dígitos informados para validar o CPF
    if digito_a == numeros[9] and digito_b == numeros[10]:
        print("CPF VÁLIDO")
    else:
        print("CPF INVÁLIDO")

def verificador_cnpj():
    # Solicita o CNPJ
    cnpj = input("CNPJ: ")

    # Transforma os números do CNPJ em int para a verificação da validade
    numeros = [int(digito) for digito in cnpj if digito.isdigit()]

    # Realiza os cálculos para obter os dígitos verificadores
    somatorio_a = sum((num * peso) for num, peso in zip(numeros[:12], range(5, 0, -1)))
    resto_a = somatorio_a % 11
    digito_a = 0 if resto_a <= 1 else 11 - resto_a

    somatorio_b = sum((num * peso) for num, peso in zip(numeros[:13], range(6, 0, -1))) + (digito_a * 2)
    resto_b = somatorio_b % 11
    digito_b = 0 if resto_b <= 1 else 11 - resto_b

    # Compara os dígitos obtidos com os dígitos informados para validar o CNPJ
    if digito_a == numeros[12] and digito_b == numeros[13]:
        print("CNPJ VÁLIDO")
    else:
        print("CNPJ INVÁLIDO")

if __name__ == "__main__":
    print("SELECIONE A OPÇÃO DESEJADA")
    print("1-CPF")
    print("2-CNPJ")
    opcao = input()


    if opcao == "1":
        verificador_cpf()
    elif opcao == "2":
        verificador_cnpj()
    else:
        print("OPÇÃO INVÁLIDA")

#CPF funciona sem inserção de pontuações
#CNPJ não está verificando corretamente