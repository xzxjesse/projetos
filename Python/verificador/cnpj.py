def valida_cnpj(cnpj):
    # Remova caracteres não numéricos do CNPJ
    cnpj = ''.join(filter(str.isdigit, cnpj))

    # Verifique se o CNPJ tem 14 dígitos
    if len(cnpj) != 14:
        return False

    # Calcula o primeiro dígito verificador
    soma = 0
    peso = 5
    for i in range(12):
        soma += int(cnpj[i]) * peso
        peso -= 1
        if peso == 1:
            peso = 9

    resto = soma % 11
    digito1 = 0 if resto < 2 else 11 - resto

    # Calcula o segundo dígito verificador
    soma = 0
    peso = 6
    for i in range(13):
        soma += int(cnpj[i]) * peso
        peso -= 1
        if peso == 1:
            peso = 9

    resto = soma % 11
    digito2 = 0 if resto < 2 else 11 - resto

    # Verifica se os dígitos verificadores calculados são iguais aos dígitos reais
    if int(cnpj[12]) == digito1 and int(cnpj[13]) == digito2:
        return True
    else:
        return False