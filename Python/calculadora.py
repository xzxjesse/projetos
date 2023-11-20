print('-----------------------CALCULADORA-------------------------')
print('                      soma: x + y')
print('                    subtração: x - y')
print('                  multiplicação: x * y')
print('                     divisão: x / y')
print('-----------------------------------------------------------')
print('')

numero1, operacao, numero2 = input('').split()

if operacao == '+':
    resultado = int(numero1) + int(numero2)
elif operacao == '-':
    resultado = int(numero1) - int(numero2)
elif operacao == '*':
    resultado = int(numero1) * int(numero2)
elif operacao == '/':
    resultado = int(numero1) / int(numero2)
else:
    print('INVÁLIDO')

print('={}'.format (resultado))