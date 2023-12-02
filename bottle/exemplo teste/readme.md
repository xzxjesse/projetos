# Aprendizado com Bottle

Este repositório contém exemplos simples para começar a usar o framework Bottle em Python. A seguir estão algumas informações úteis para começar.

## Instalação do Bottle

Para utilizar o Bottle, você precisará instalá-lo. Você pode fazer isso utilizando o seguinte comando:

```bash
pip install bottle
```

## Comandos Simples

### Executando um Aplicativo Básico

Para executar um aplicativo Bottle simples, utilize o seguinte comando:

```bash
python app.py
```

Este comando iniciará o servidor em `http://localhost:8080/`.

### Executando um Aplicativo com Rotas

Para executar um aplicativo Bottle com rotas, utilize o seguinte comando:

```bash
python parametro_rota.py
```

Este comando iniciará o servidor em `http://localhost:8080/hello/nome`, onde "nome" pode ser substituído pelo seu próprio nome.

## Utilizando Templates

Para usar templates com Bottle, você precisará instalar o pacote Jinja2. Faça isso com o comando:

```bash
pip install jinja2
```

### Executando um Aplicativo com Templates

Para executar um aplicativo Bottle que utiliza templates, utilize o seguinte comando:

```bash
python app_template.tpl
```

Este comando iniciará o servidor em `http://localhost:8080/hello/nome`, onde "nome" pode ser substituído pelo seu próprio nome.

---

Para mais informações, consulte a documentação oficial do [Bottle](https://bottlepy.org/docs/stable/).