def dec_bin(num_dec):
    binario = []
    
    if num_dec == 0:
        return [0]
    
    while num_dec > 0:
        resto = num_dec % 2
        binario.insert(0, str(resto))
        num_dec = num_dec // 2  #inteiro da divisão
        
    return ''.join(binario) #junta os digitos

def bin_dec(num_bin):
    decimal = 0
    posicao = 0
    
    for digito_binario in reversed(num_bin):
        decimal += int(digito_binario) * (2 ** posicao)
        posicao += 1
        
    return decimal
    

print('------CONVERSOR------')
print('1 - DECIMAL->BINÁRIO')
print('2 - BINÁRIO->DECIMAL')
print('---------------------')

opcao = int(input())

if opcao == 1:
    print('Digite o número decimal: ')
    num_dec = int(input())
    resultado = dec_bin(num_dec)
    print('Conversão em binário:', resultado)
elif opcao == 2:  
    print('Digite o número binário: ')
    num_bin = input()
    resultado = bin_dec(num_bin)
    print('Conversão em decimal:', resultado)
else:
    print('Opção inválida.')
