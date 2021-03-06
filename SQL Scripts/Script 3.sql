/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.usuario
(
	usr_login      varchar(50) NOT NULL,
	usr_clave      varchar(50) NOT NULL,
	usr_nombre     varchar(100) NULL,
	usr_activo     varchar(1) NOT NULL
)  ON [PRIMARY]
GO
ALTER TABLE dbo.usuario ADD CONSTRAINT
	PK_usuario PRIMARY KEY CLUSTERED 
	(
	usr_login
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


IF OBJECT_ID (N'dbo.usuario') IS NOT NULL
	DROP TABLE dbo.usuario
GO

CREATE TABLE dbo.usuario
	(
	usr_login  VARCHAR (50) NOT NULL,
	usr_clave  VARCHAR (50) NOT NULL,
	usr_nombre VARCHAR (100) NULL,
	usr_activo VARCHAR (1) NOT NULL,
	CONSTRAINT PK_usuario PRIMARY KEY (usr_login)
	)
GO

