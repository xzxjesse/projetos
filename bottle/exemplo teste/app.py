from bottle import route, run

@route('/')
def index():
    return "Bem-vindo ao meu exemplo Bottle!"

if __name__ == '__main__':
    run(host='localhost', port=8080, debug=True)