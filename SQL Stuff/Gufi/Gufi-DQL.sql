USE Gufi_Tarde;

SELECT 
	NomeUsuario,
	Email,
	TipoUsuario.TituloTipoUsuario,
	DataNascimento,
	Genero
	FROM Usuario
	INNER JOIN TipoUsuario ON TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario;

SELECT 
	CNPJ,
	NomeFantasia,
	Endereco
	FROM Instituicao;

SELECT TituloTipoEvento FROM TipoEvento;

SELECT 
	Evento.NomeEvento,
	TipoEvento.TituloTipoEvento,
	Evento.DataEvento,
	CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
	Evento.Descricao,
	Instituicao.CNPJ,
	Instituicao.NomeFantasia,
	Instituicao.Endereco
	FROM Evento
	INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
	INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao

SELECT 
	Evento.NomeEvento,
	TipoEvento.TituloTipoEvento,
	Evento.DataEvento,
	CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
	Evento.Descricao,
	Instituicao.CNPJ,
	Instituicao.NomeFantasia,
	Instituicao.Endereco
	FROM Evento
	INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
	INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao
	WHERE Evento.AcessoLivre = 1;

SELECT 
	Evento.IdEvento,
	Evento.NomeEvento,
	Evento.DataEvento,
	CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
	Evento.Descricao,
	TipoEvento.TituloTipoEvento,
	Instituicao.CNPJ,
	Instituicao.NomeFantasia,
	Instituicao.Endereco,
	Usuario.NomeUsuario,
	Usuario.Email,
	Usuario.DataNascimento,
	Usuario.Genero,
	TipoUsuario.TituloTipoUsuario
	FROM Presenca
	INNER JOIN Usuario ON Presenca.IdUsuario = Usuario.IdUsuario
	INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario
	INNER JOIN Evento ON Presenca.IdEvento = Evento.IdEvento
	INNER JOIN TipoEvento ON Evento.IdTipoEvento = TipoEvento.IdTipoEvento
	INNER JOIN Instituicao ON Evento.IdInstituicao = Instituicao.IdInstituicao
	WHERE Presenca.IdUsuario = 2

SELECT
	Presenca.IdPresenca,
	Usuario.NomeUsuario,
	Evento.NomeEvento
	FROM Presenca
	INNER JOIN Usuario ON Presenca.IdUsuario = Usuario.IdUsuario
	INNER JOIN Evento ON Presenca.IdEvento = Evento.IdEvento

--Estudar as funções abaixo
SELECT Usuario.NomeUsuario
      ,Usuario.Email
	  ,Usuario.Genero
	  ,TipoUsuario.TituloTipoUsuario 
	  ,DATEDIFF(YY, Usuario.DataNascimento, GETDATE()) -
		CASE
			WHEN DATEADD(YY, DATEDIFF(YY,Usuario.DataNascimento,GETDATE()),Usuario.DataNascimento) 
			> GETDATE() THEN 1
			ELSE 0
		END AS Idade
FROM
Usuario
INNER JOIN
TipoUsuario
ON TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario

SELECT * FROM Usuario;
SELECT * FROM Presenca;
SELECT * FROM Evento;



