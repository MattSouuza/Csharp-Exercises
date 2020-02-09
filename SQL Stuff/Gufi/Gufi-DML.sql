USE Gufi_Tarde;

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES ('Administrador'), ('Comum');

INSERT INTO TipoEvento (TituloTipoEvento)
VALUES ('Csharp'), ('React'), ('SQL');

INSERT INTO Instituicao (CNPJ, NomeFantasia, Endereco)
VALUES ('12345678912345', 'Escola SENAI De Informática', 'Alameda Barão de Limeira, 538');

INSERT INTO Instituicao (CNPJ, NomeFantasia, Endereco)
VALUES ('12345678912349', 'Escola IANES De Tecnologia', 'Avenida Duque de Limão, 835');

INSERT INTO Usuario (NomeUsuario, Email, Senha, Genero, DataNascimento, IdTipoUsuario) 
VALUES ('Matheus', 'math@email.com', '12345', 'Masculino', '2002-05-27', 1),
		('Lucas', 'lucasfarofa@email.com', '12345', 'Outro', '1853-03-05', 2),
		('Davyy', 'davy@email.com', '12345', 'Masculino', '1991-07-30', 2)

INSERT INTO Evento (NomeEvento, DataEvento, Descricao, AcessoLivre, IdInstituicao, IdTipoEvento)
VALUES ('Introdução a Csharp', '2020-04-17', 'Conceitos sobre os pilares da programação orientada a objetos', 1, 1, 1),
		('Introdução a SQL', '2020-06-01','Conceitos sobre os pilares d SQL', 0, 1, 3),
		('Palestra Sobre React', '2020-09-08','Conceitos sobre React', 1, 1, 2);

INSERT INTO Presenca (IdEvento, IdUsuario, Situacao)
VALUES ( 2, 3, 'Agendado'),
		( 1, 1, 'Confirmado'),
		( 3, 2, 'Não Compareceu');