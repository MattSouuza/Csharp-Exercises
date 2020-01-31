A--Cria Banco De Dados
CREATE DATABASE Biblioteca_Tarde;

--Os comandos são excutados individualmente manualmente
--Comando pra começar a usar o banco de dados especificado
USE Biblioteca_Tarde;

CREATE TABLE Autores (
	IDAutor		INT PRIMARY KEY IDENTITY,
	NomeAutor	VARCHAR(200) NOT NULL
);

CREATE TABLE Generos (
	IDGenero	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(200) NOT NULL
);

CREATE TABLE Livro (
	IDLivro		INT PRIMARY KEY IDENTITY,
	Titulo		VARCHAR(255) NOT NULL,
	IDAutor		INT FOREIGN KEY REFERENCES Autores (IDAutor),
	IDGenero	INT FOREIGN KEY REFERENCES Generos (IDGenero)
);

SELECT * FROM Generos;
SELECT * FROM Autores;
SELECT * FROM Livro;

--ADD um coluna novo
ALTER TABLE Generos ADD Descricao VARCHAR(255);

--Mudar o tipo de um coluna
ALTER TABLE Generos ALTER COLUMN Descricao CHAR(100);

--Exclui uma coluna
ALTER TABLE Generos DROP COLUMN Descricao;

--Exclui tabela
DROP TABLE Generos;

DROP DATABASE Biblioteca_Tarde;

-- Resolução do Exercício

INSERT INTO Autores(NomeAutor)
VALUES ('Robson'), ('Jailson'), ('Mario')

INSERT INTO Generos(Nome)
VALUES ('Filosofia'), ('Aventura'), ('Romance')

INSERT INTO Livro(Titulo, IDGenero, IDAutor)
VALUES ('Das Kapital v.4', 1, 1), ('Deutsch', 2, 3), ('La Habana', 2, 3)

SELECT NomeAutor FROM Autores;

SELECT Nome FROM Generos;

SELECT Titulo FROM Livro;

SELECT Titulo, IDAutor FROM Livro;

SELECT Titulo, IDGenero FROM LIVRO;

SELECT Titulo, IDAutor, IDGenero FROM Livro;

SELECT L.Titulo, A.NomeAutor FROM Livro AS L JOIN Autores AS A ON A.IDAutor = L.IDAutor;

SELECT L.Titulo, G.Nome FROM Livro AS L 
JOIN Generos AS G ON L.IDGenero = G.IDGenero;

SELECT L.Titulo, G.Nome, A.NomeAutor FROM Livro AS L 
JOIN Generos AS G ON L.IDGenero = G.IDGenero
JOIN Autores AS A ON L.IDAutor = A.IDAutor;