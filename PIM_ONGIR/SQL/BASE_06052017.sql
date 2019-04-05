
USE [MASTER]
GO



IF EXISTS(SELECT * FROM SYS.DATABASES WHERE NAME = 'PIM_CPIR')
	DROP DATABASE [PIM_CPIR]
GO

--Cria��o da base de dados: 
CREATE DATABASE [PIM_CPIR]
GO

USE [PIM_CPIR]
GO

--################################
--########## TABELAS #############
--################################

--Cria��o da tabela de Usu�rios:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'USUARIOS')
	DROP TABLE USUARIOS
GO

CREATE TABLE USUARIOS(
	codUSU INT NOT NULL IDENTITY,
	loginUSU VARCHAR(20) NOT NULL,
	senhaUSU CHAR(7) NOT NULL,
	perfilUSU VARCHAR(20) NOT NULL, 
	idUSU VARCHAR(2)
	CONSTRAINT pk_codUSU PRIMARY KEY  (codUSU) 

);
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'ASSOCIADOS')
	DROP TABLE ASSOCIADOS
GO


CREATE TABLE ASSOCIADOS(
	codASS INT NOT NULL IDENTITY,
	nomeASS NVARCHAR(50) NOT NULL,
	nomerespASS NVARCHAR(50) NOT NULL,
	cepASS NVARCHAR(20) NULL,
	enderASS NVARCHAR(250) NOT NULL,
	cidadeASS NVARCHAR(100) NOT NULL,
	estadoASS CHAR(2) NOT NULL,
	bairroASS NVARCHAR(100) NOT NULL,
	numcasaASS INT NULL,
	rgASS VARCHAR(20) NOT NULL,
	cpfASS VARCHAR(20) NOT NULL,
	datanascASS DATETIME NOT NULL,
	telefonefixoASS VARCHAR(20) NULL,
	telefonecelularASS VARCHAR(20) NULL,
	datacadastroASS DATETIME DEFAULT GETDATE(),
	senhaASS VARCHAR(50) NOT NULL DEFAULT(0),
	imgASS NVARCHAR(200) NULL ,
	CONSTRAINT pk_codASS PRIMARY KEY  (codASS) 

);

IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'SERVICOS')
	DROP TABLE SERVICOS
GO

	/*

	Os tipos s�o: 
		AD - Assist�ncia Jur�dica (Advogado)
		AS - Assist�ncia Social
		PS - Psicologia
		AM - Administrador

	*/


CREATE TABLE SERVICOS (
	
	codSER INT IDENTITY,
	tipoSER VARCHAR(5),
	infoSER VARCHAR(400)
	CONSTRAINT pk_cdSER  PRIMARY KEY  (codSER) 
	
	
);
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'AGENDAMENTOS')
	DROP TABLE AGENDAMENTOS
GO

CREATE TABLE AGENDAMENTOS(
	
	codAGE INT IDENTITY,
	assAGE INT,
	serAGE CHAR(2),
	datahoraAGE DATETIME,
	concluidoAGE BIT DEFAULT (0),
	CONSTRAINT pk_codAGE  PRIMARY KEY  (codAGE),
	FOREIGN KEY (assAGE) REFERENCES ASSOCIADOS(codASS)
	
);




--################################
--########## CARGAS ###############
--################################

GO
INSERT INTO USUARIOS
VALUES('admin',123,'admin','AM')
GO
INSERT INTO USUARIOS
VALUES('Denise Carla',123,'Atendente','AT')
GO
INSERT INTO USUARIOS
VALUES('LucasS',123,'Advogado','AD')
GO
INSERT INTO USUARIOS
VALUES('Luiza Alc�ntara',123,'Psic�loga','PS')
GO
INSERT INTO USUARIOS
VALUES('Beatriz',123,'Assistente Social','AS')
GO

--################################
--########## VIEWS ###############
--################################


IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'CarregarCLI')
	DROP VIEW CarregarASS
GO

CREATE VIEW CarregarASS
AS

	SELECT *
	FROM ASSOCIADOS

GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaASS')
	DROP VIEW ConsultaASS
GO

CREATE VIEW ConsultaASS
AS


	SELECT codASS AS CODIGO, nomeASS AS NOME,rgASS AS RG,
	cpfASS AS CPF,enderASS AS LOGRADOURO,
	cidadeASS AS CIDADE,estadoASS AS ESTADO,
	CASE WHEN telefonefixoASS = '(  )      -' THEN telefonecelularASS ELSE telefonefixoASS END CONTATO ,
	datacadastroASS AS [DATA CADASTRO]
	FROM ASSOCIADOS


GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaAgendamentos')
	DROP VIEW ConsultaAgendamentos
GO

CREATE VIEW ConsultaAgendamentos
AS

	SELECT nomeASS AS NOME,
	CASE WHEN serAGE = 'PS' THEN 'Psicologia' 
				WHEN serAGE = 'AD' THEN 'Assist�ncia Jur�dica'
				ELSE 'Assist�ncia Social' END AS [SERVICO]
				,datahoraAGE AS DATA ,concluidoAGE AS [STATUS]
	FROM AGENDAMENTOS
	INNER JOIN ASSOCIADOS ON assAGE = codASS

GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaAgendamentosAsso')
	DROP VIEW ConsultaAgendamentosAsso
GO

CREATE VIEW ConsultaAgendamentosAsso
AS
		SELECT 
			nomeASS AS NOME	,
			cpfASS AS CPF,
			CONVERT(NVARCHAR,datanascASS,103) AS [DATA NASCI],
			CASE WHEN serAGE = 'PS' THEN 'Psicologia' 
			WHEN serAGE = 'AD' THEN 'Assist�ncia Jur�dica'
			ELSE 'Assist�ncia Social' END AS [SERVICO]
			,concluidoAGE AS CONCLUIDO,
			CONVERT(NVARCHAR,datahoraAGE,103) + ':' +  FORMAT(datahoraAGE,'HH:mm tt') AS [DATA DO AGENDAMENTO]
		
		FROM AGENDAMENTOS 
		INNER JOIN ASSOCIADOS ON codASS = assAGE 
		WHERE concluidoAGE = 0


GO
	