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
