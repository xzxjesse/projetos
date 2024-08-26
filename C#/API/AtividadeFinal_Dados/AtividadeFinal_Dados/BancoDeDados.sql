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

-- Adiciona registros ficticios 
INSERT INTO Pessoa (Id, Nome, Telefone) VALUES 
(1, 'João Silva', '11987654321'),
(2, 'Maria Oliveira', '21987654321'),
(3, 'Carlos Souza', '31987654321'),
(4, 'Ana Pereira', '41987654321'),
(5, 'Paulo Costa', '51987654321'),
(6, 'Luciana Santos', '61987654321'),
(7, 'Pedro Almeida', '71987654321'),
(8, 'Mariana Lima', '81987654321'),
(9, 'Fernanda Ferreira', '91987654321'),
(10, 'Ricardo Gomes', '11912345678'),
(11, 'Juliana Rocha', '21912345678'),
(12, 'Rafael Mendes', '31912345678'),
(13, 'Beatriz Araujo', '41912345678'),
(14, 'Fábio Ribeiro', '51912345678'),
(15, 'Renata Martins', '61912345678'),
(16, 'André Carvalho', '71912345678'),
(17, 'Patrícia Silva', '81912345678'),
(18, 'Gustavo Dias', '91912345678'),
(19, 'Camila Nunes', '11998765432'),
(20, 'Rodrigo Teixeira', '21998765432');

-- Verifica a tabela criada
SELECT * FROM Pessoa;
