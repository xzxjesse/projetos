from cadastro_usuario import cadastrar_usuario
from autenticacao_usuario import autenticar_usuario
from calculo_nota_prova import calcular_nota_prova
from realizar_prova import fazer_prova
from escolher_pesos import escolher_pesos
from escolher_quantidade_provas import escolher_quantidade_provas

def exibir_menu():
    print("1. Cadastrar Usuário")
    print("2. Login")
    print("3. Escolher Pesos e Quantidade de Provas")
    print("4. Realizar Provas")
    print("5. Sair")

def main():
    usuarios = {}
    usuario_autenticado = None
    pesos = []
    quantidade_provas = 0

    while True:
        exibir_menu()
        escolha = input("Escolha uma opção: ")

        if escolha == "1":
            cadastrar_usuario(usuarios)

        elif escolha == "2":
            usuario_autenticado = autenticar_usuario(usuarios)
            if usuario_autenticado:
                print("Usuário autenticado.")

        elif escolha == "3":
            if usuario_autenticado:
                pesos = escolher_pesos()
                quantidade_provas = escolher_quantidade_provas()
            else:
                print("Você precisa fazer login antes de escolher pesos e quantidade de provas.")

        elif escolha == "4":
            if usuario_autenticado and pesos and quantidade_provas:
                for i in range(1, quantidade_provas + 1):
                    quantidade_questoes = int(input(f"Digite a quantidade de questões para a Prova {i}: "))
                    peso_prova = pesos[i - 1]
                    fazer_prova(i, quantidade_questoes, peso_prova)
            else:
                print("Você precisa fazer login e escolher pesos/quantidade de provas antes de realizar as provas.")

        elif escolha == "5":
            print("Programa encerrado.")
            break

if __name__ == "__main__":
    main()