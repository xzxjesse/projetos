# Sistema de Provas

Este é um sistema simples em desenvolvimento para gerenciar provas e usuários. Ele inclui funcionalidades básicas como cadastrar usuário, fazer login, escolher pesos e quantidade de provas, realizar provas, e sair do sistema.

## Funcionalidades

1. **Cadastrar Usuário**
   - Acesse a página de cadastro de usuário.
   - Insira um nome e uma senha.
   - Clique em "Cadastrar Usuário".
   - Uma mensagem será exibida indicando se o cadastro foi realizado com sucesso ou se falhou.

2. **Login**
   - Acesse a página de login.
   - Insira um nome e uma senha.
   - Clique em "Login".
   - Será exibida uma mensagem indicando se o login foi bem-sucedido.

3. **Escolher Pesos e Quantidade de Provas**
   - Realize o login antes de acessar esta funcionalidade.
   - Escolha os pesos para as provas.
   - Escolha a quantidade de provas.

4. **Realizar Provas**
   - Realize o login e escolha pesos/quantidade de provas antes de acessar esta funcionalidade.
   - Informe a quantidade de questões para cada prova.
   - O sistema calculará a nota da prova com base nas respostas fornecidas.

5. **Sair**
   - Encerra o programa.

## Anotações para Trabalhar

### Estilo
- Formar paleta de cores e incluir imagens.

### Cadastro
- Inserir informações de cadastro em um arquivo/banco.
- Adicionar opção de atualizar senha/recuperar conta.
- Fazer funcionar as mensagens de "cadastro realizado com sucesso" e "cadastro não realizado".
- Só permitir próximas etapas após o cadastro e login.

### Login
- A partir do login, devem aparecer as outras funcionalidades.

### Funções do Sistema
- Escolher quantidade de provas -> Escolher pesos -> Realizar provas.

### Sair
- Deslogar a conta salvando todas as informações de provas.

### Geral
- Avaliar a possibilidade de remover cadastro e armazenamento de dados para facilitar a implementação.

## Como Executar

1. Certifique-se de ter o Python instalado em sua máquina.
2. Instale as dependências usando `pip install -r requirements.txt`.
3. Execute o arquivo `app.py` usando `python app.py`.
4. Abra o navegador e acesse `http://127.0.0.1:5000/` para utilizar o sistema.