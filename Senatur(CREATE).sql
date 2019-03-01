CREATE DATABASE Senai_Senatur_Manha

USE Senai_Senatur_Manha

CREATE TABLE PACOTES (
	PacoteId INT IDENTITY PRIMARY KEY,
	NomePacote VARCHAR(250) NOT NULL,
	Descricao VARCHAR(250) NOT NULL,
	DataIda DATETIME NOT NULL,
	DataVolta DATETIME NOT NULL,
	Valor DECIMAL NOT NULL,
	Ativo BIT NOT NULL,
	Nome_Cidade VARCHAR(250) NOT NULL)

INSERT INTO PACOTES VALUES ('SALVADOR - 5 DIAS / 4 DI�RIAS', 'O que n�o falta em Salvador s�o atra��es. Prova disso s�o as praias, os museus e as constru��es seculares que d�o um charme mais que especial � regi�o. A cidade, sin�nimo de alegria, tamb�m � conhecida pela efervesc�ncia cultural que a credenciou como um dos destinos mais procurados por turistas brasileiros e estrangeiros. O Pelourinho e o Elevador s�o alguns dos principais pontos de visita��o.', 
'06/08/19', '10/08/19', 854.00,  0, 'Salvador')

CREATE TABLE TIPO_USUARIOS (
	TipoId INT IDENTITY PRIMARY KEY,
	Tipo_Usuario VARCHAR(250) NOT NULL UNIQUE)

CREATE TABLE USUARIOS (
	UsuarioId INT IDENTITY PRIMARY KEY,
	Email VARCHAR(230) NOT NULL UNIQUE,
	Senha VARCHAR(250) NOT NULL,
	TipoUsuarioId INT NOT NULL FOREIGN KEY REFERENCES TIPO_USUARIOS(TipoId))


SELECT * FROM USUARIOS

---------------------Insert-----------------------
INSERT INTO TIPO_USUARIOS VALUES('Admin'), ('Comum')

INSERT INTO USUARIOS VALUES('admin@admin.com', 'admin', 1), ('cliente@cliente.com', 'cliente', 2)


