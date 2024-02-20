def cadastrar_usuario(usuarios):
    print("Cadastro de Usuário")
    nome = input("Digite seu nome: ")
    senha = input("Digite sua senha: ")
    usuarios[nome] = {"senha": senha}
    print(f"Usuário {nome} cadastrado com sucesso.")