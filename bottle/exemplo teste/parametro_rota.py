from bottle import route, run

@route('/hello/<name>')
def hello(name):
    return f"Olá, {name}!"

if __name__ == '__main__':
    run(host='localhost', port=8080, debug=True)

