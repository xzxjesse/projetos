-- Cria o banco
CREATE DATABASE AgendaTelefonica;
USE AgendaTelefonica;

-- Cria a tabela principal
CREATE TABLE Pessoa (
	--ID INT NOT NULL AUTO_INCREMENT,
    ID INT NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    PRIMARY KEY (ID)
);

-- Verifica a tabela criada
SELECT * FROM Pessoa;
