USE Gufi_Tarde;

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES ('Administrador'), ('Comum');

INSERT INTO TipoEvento (TituloTipoEvento)
VALUES ('Csharp'), ('React'), ('SQL');

INSERT INTO Instituicao (CNPJ, NomeFantasia, Endereco)
VALUES ('12345678912345', 'Escola SENAI De Inform�tica', 'Alameda Bar�o de Limeira, 538');

INSERT INTO Usuario (NomeUsuario, Email, Senha, Genero, DataNascimento, IdTipoUsuario) 
VALUES ('Matheus', 'math@email.com', '12345', 'Masculino', '27/03/1998', 1),
		('Lucas', 'lucasfarofa@email.com', '12345', 'Outro', '01/02/1854', 2),
		('Davyy', 'davy@email.com', '12345', 'Masculino', '05/09/1567', 2)

INSERT INTO Evento (NomeEvento, DataEvento, Descricao, AcessoLivre, IdInstituicao, IdTipoEvento)
VALUES ('Introdu��o a Csharp', '21/08/2020', 'Conceitos sobre os pilares da programa��o orientada a objetos', 1, 1, 1),
		('Introdu��o a SQL', '01/03/2021','Conceitos sobre os pilares d SQL', 0, 1, 3),
		('Palestra Sobre React', '17/09/2022','Conceitos sobre React', 1, 1, 2);

INSERT INTO Presenca (IdEvento, IdUsuario, Situacao)
VALUES ( 2, 3, 'Agendado'),
		( 1, 1, 'Confirmado'),
		( 3, 2, 'N�o Compareceu');
