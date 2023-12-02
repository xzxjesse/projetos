from bottle import route, run, template

@route('/hello/<name>')
def hello(name):
    return template('hello_template', name=name)

if __name__ == '__main__':
    run(host='localhost', port=8080, debug=True)
