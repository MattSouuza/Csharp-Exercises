CREATE DATABASE ECommerce;

USE ECommerce;

CREATE TABLE Lojas (
	IDLoja				INT PRIMARY KEY IDENTITY,
	NomeLoja			VARCHAR(50) NOT NULL
);

CREATE TABLE Categorias (
	IDCategoria			INT PRIMARY KEY IDENTITY,
	NomeCategoria		VARCHAR(50) NOT NULL,
	IDLoja				INT FOREIGN KEY REFERENCES Lojas (IDLoja)
);

CREATE TABLE Subcategorias (
	IDSubcategoria		INT PRIMARY KEY IDENTITY,
	NomeSubcategoria	VARCHAR(50) NOT NULL,
	IDCategoria			INT FOREIGN KEY REFERENCES Categorias (IDCategoria)
);

CREATE TABLE Produtos (
	IDProduto			INT PRIMARY KEY IDENTITY,
	NomeProduto			VARCHAR(50) NOT NULL,
	Valor				INT NOT NULL,
	IDSubcategoria		INT FOREIGN KEY REFERENCES Subcategorias (IDSubcategoria)
);

CREATE TABLE Clientes (
	IDCliente			INT PRIMARY KEY IDENTITY,
	NomeCliente			VARCHAR(50)
);

CREATE TABLE Pedidos (
	IDPedido			INT PRIMARY KEY IDENTITY,
	NrPedido			INT NOT NULL,
	DataPedido			DATE,
	StatusPedido		VARCHAR(20) NOT NULL,
	IDCliente			INT FOREIGN KEY REFERENCES Clientes (IDCliente)
);

CREATE TABLE PedidosProdutos (
	IDPedido			INT FOREIGN KEY REFERENCES Pedidos (IDPedido),
	IDProduto			INT FOREIGN KEY REFERENCES Produtos (IDProduto)
);