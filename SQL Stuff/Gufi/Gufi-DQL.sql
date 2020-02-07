USE Gufi_Tarde;

SELECT TituloTipoEvento FROM TipoEvento;

SELECT Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,
CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
Evento.Descricao, Instituicao.CNPJ, Instituicao.NomeFantasia, Instituicao.Endereco
FROM Evento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
INNER JOIN Instituicao ON Instituicao.IdInstituicao =Evento.IdInstituicao


SELECT Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,
CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
Evento.Descricao, Instituicao.CNPJ, Instituicao.NomeFantasia, Instituicao.Endereco
FROM Evento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao
WHERE Evento.AcessoLivre = 1;

SELECT Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,
CASE WHEN Evento.AcessoLivre = 1 THEN 'Público' ELSE 'Privado' END AS TituloAcesso,
Evento.Descricao, Instituicao.CNPJ, Instituicao.NomeFantasia, Instituicao.Endereco
FROM Presenca
INNER JOIN Evento ON Evento.IdEvento = Presenca.IdEvento
INNER JOIN Usuario ON Usuario.IdUsuario = Presenca.IdUsuario
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Presenca.IdEvento
INNER JOIN Instituicao On Instituicao.IdInstituicao = Presenca.IdEvento



