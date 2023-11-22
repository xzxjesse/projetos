from cpf import valida_cpf
from cnpj import valida_cnpj

def menu_principal():
    print("1. Verificar CPF")
    print("2. Verificar CNPJ")
    print("3. Sair")

def main():
    while True:
        menu_principal()
        escolha = input("Escolha uma opção: ")

        if escolha == "1" or "1. Verificar CPF" or "Verificar CPF":
            cpf_usuario = input("Digite o CPF (apenas números): ")
            if valida_cpf(cpf_usuario):
                print(f"{cpf_usuario} é válido.")
            else:
                print(f"{cpf_usuario} é inválido.")

        elif escolha == "2" or "2. Verificar CNPJ" or "Verificar CNPJ":
            cnpj_usuario = input("Digite o CNPJ (apenas números): ")
            if valida_cnpj(cnpj_usuario):
                print(f"{cnpj_usuario} é válido.")
            else:
                print(f"{cnpj_usuario} é inválido.")

        elif escolha == "3" or "3. Sair" or "Sair":
            print("Programa encerrado.")
            break

        else:
            print("Opção inválida. Escolha novamente.")

        print("Deseja voltar ao menu principal?")
        print("1. Sim")
        print("2. Não")
        continuar = input()
        if continuar.lower() not in ['1', 'sim', '1. sim']:
            print("Programa encerrado.")
            break

if __name__ == "__main__":
    main()