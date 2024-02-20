from flask import Flask, render_template, request, jsonify

app = Flask(__name__)

usuarios = {}

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/cadastrar_usuario', methods=['POST'])
def cadastrar_usuario():
    nome = request.form['nome']
    senha = request.form['senha']
    
    if nome in usuarios:
        return jsonify({"mensagem": "Usuário já cadastrado. Escolha outro nome."})
    
    usuarios[nome] = {"senha": senha}
    return jsonify({"mensagem": f'Cadastro realizado com sucesso para o usuário {nome}.'})

if __name__ == '__main__':
    app.run(debug=True)