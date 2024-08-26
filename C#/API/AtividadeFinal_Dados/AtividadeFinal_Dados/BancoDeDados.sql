-- Cria o banco
CREATE DATABASE AgendaTelefonica;
USE AgendaTelefonica;

-- Cria a tabela pessoa
CREATE TABLE Pessoa (
    IDPessoa INT PRIMARY KEY IDENTITY(1,1), -- incremento automático
    Nome NVARCHAR(100) NOT NULL,
    DataNascimento DATE,
    Email NVARCHAR(255)
);

-- Adiciona registros ficticios 
INSERT INTO Pessoa (Nome, DataNascimento, Email) VALUES
('João Silva', '1985-06-15', 'joao.silva@example.com'),
('Maria Oliveira', '1990-09-23', 'maria.oliveira@example.com'),
('Carlos Pereira', '1988-12-02', 'carlos.pereira@example.com'),
('Ana Santos', '1992-11-05', 'ana.santos@example.com'),
('Paulo Souza', '1975-01-30', 'paulo.souza@example.com'),
('Fernanda Lima', '1983-08-10', 'fernanda.lima@example.com'),
('Rafael Costa', '1995-03-19', 'rafael.costa@example.com'),
('Beatriz Almeida', '2000-07-07', 'beatriz.almeida@example.com'),
('Ricardo Mendes', '1982-02-14', 'ricardo.mendes@example.com'),
('Camila Ferreira', '1998-05-25', 'camila.ferreira@example.com');

-- Verifica a tabela criada
SELECT * FROM Pessoa;

-- Cria a tabela Telefone
CREATE TABLE Telefone (
    IDTelefone INT PRIMARY KEY IDENTITY(1,1), -- incremento automático
    Telefone NVARCHAR(20) NOT NULL,
    TipoTelefone NVARCHAR(50), 
    IDPessoa INT NOT NULL,
    FOREIGN KEY (IDPessoa) REFERENCES Pessoa(IDPessoa) -- chave estrangeira
);

-- Adiciona registros ficticios 
INSERT INTO Telefone (Telefone, TipoTelefone, IDPessoa) VALUES
('1234-5678', 'Residencial', 1),
('9876-5432', 'Celular', 1),
('2345-6789', 'Comercial', 2),
('8765-4321', 'Celular', 2),
('3456-7890', 'Residencial', 3),
('7654-3210', 'Celular', 4),
('4567-8901', 'Comercial', 5),
('6543-2109', 'Residencial', 6),
('5678-9012', 'Celular', 7),
('5432-1098', 'Residencial', 8),
('6789-0123', 'Comercial', 9),
('4321-0987', 'Celular', 10),
('7890-1234', 'Residencial', 1),
('2109-8765', 'Comercial', 3),
('9012-3456', 'Celular', 2);

-- Verifica a tabela criada
SELECT * FROM Telefone;

-- outros
drop database AgendaTelefonica;

SELECT 
    Pessoa.IDPessoa,
    Pessoa.Nome,
    Pessoa.DataNascimento,
    Pessoa.Email,
    Telefone.IDTelefone,
    Telefone.Telefone,
    Telefone.TipoTelefone
FROM 
    Pessoa
INNER JOIN 
    Telefone ON Pessoa.IDPessoa = Telefone.IDPessoa;
