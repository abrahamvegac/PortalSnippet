



-- para registrar datos en tabla (basicos
/*
INSERT INTO dbo.Categoria (	cat_nombre,	cat_descripcion	)
                   VALUES (	'SQL-Oracle',	'Codigos para Oracle'	)
go
INSERT INTO dbo.Categoria (	cat_nombre,	cat_descripcion	)
                   VALUES (	'SQL-DB2',	'Cosigos para DB2 '	)
GO
INSERT INTO dbo.Categoria (	cat_nombre,	cat_descripcion	)
                   VALUES (	'SQL-Sybase',	'Codigos para Sybase (ASE)'	)
GO
INSERT INTO dbo.Categoria (	cat_nombre,	cat_descripcion	)
                   VALUES (	'SQL-MSSQL Server',	'Codigos para SQL Server'	)
GO
INSERT INTO dbo.Categoria (	cat_nombre,	cat_descripcion	)
                   VALUES (	'VB',	'Codigos para Visual Basic 6'	)
GO

SELECT * FROM Categoria 
go
*/


-- Para registrar opcion de menu
/*
INSERT INTO dbo.menu	(	mnu_titulo,	mnu_descripcion,	mnu_url,	mnu_activo	)
VALUES 	(	'inicio',	'Neosoft- CodeSnippet Inicio',	'index.aspx',	'S'	)
GO

INSERT INTO dbo.menu	(	mnu_titulo,	mnu_descripcion,	mnu_url,	mnu_activo	)
VALUES 	(	'snippet',	'Neosoft- CodeSnippet Snippet',	'#',	'S'	)
GO

INSERT INTO dbo.menu	(	mnu_titulo,	mnu_descripcion,	mnu_url,	mnu_activo	)
VALUES 	(	'registrar',	'Neosoft- CodeSnippet Registrar',	'#',	'S'	)
GO

INSERT INTO dbo.menu	(	mnu_titulo,	mnu_descripcion,	mnu_url,	mnu_activo	)
VALUES 	(	'administrar',	'Neosoft- CodeSnippet Administrar',	'#',	'S'	)
GO
SELECT * FROM menu 
*/


-- Para Registrar parametria 
/*
INSERT INTO dbo.parametros	(	prm_titulo,	prm_descripcion,	prm_glosa,	prm_fecha,	prm_valor	)
VALUES 	(	'footer',	'Texto para pie de pagina',	'(c) 2012 code Snippet. diseñado por avega(neosoft).',	'19000101',	0	)
go
*/


-- Para registrar usuario
/*
INSERT INTO dbo.usuario	(	usr_login,	usr_clave,	usr_nombre,	usr_activo	)
VALUES 	(	'admin',	'admin01',	'Administrador',	'S'	)
GO 
*/

