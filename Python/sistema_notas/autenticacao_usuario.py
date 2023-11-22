def autenticar_usuario(usuarios):
    print("Login")
    nome = input("Digite seu nome: ")
    senha = input("Digite sua senha: ")

    if nome in usuarios and usuarios[nome]["senha"] == senha:
        print(f"Bem-vindo, {nome}!")
        return True
    else:
        print("Login falhou. Verifique seu nome e senha.")
        return False