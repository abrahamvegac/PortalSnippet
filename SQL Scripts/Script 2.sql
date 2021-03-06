



-- Para la tabla menu

CREATE TABLE dbo.menu
(
	  mnu_id           NUMERIC(18) IDENTITY NOT NULL
	, mnu_titulo       VARCHAR(200) NOT NULL
	, mnu_descripcion  VARCHAR(255)
	, mnu_url          VARCHAR(1000)
	, mnu_activo       VARCHAR(1)   NOT NULL	
	CONSTRAINT pk_menu PRIMARY KEY (mnu_id)
)
GO 



CREATE TABLE dbo.parametros
(
	  prm_id           NUMERIC(18)  IDENTITY NOT NULL 
	, prm_titulo       VARCHAR(100) NOT NULL   
	, prm_descripcion  VARCHAR(500) 
	, prm_glosa        VARCHAR(max) 
	, prm_fecha        DATETIME 
	, prm_valor        NUMERIC(18,2)
    CONSTRAINT pk_parametros PRIMARY KEY (prm_id)
)
GO 




/*
IF OBJECT_ID (N'dbo.Categoria') IS NOT NULL
	DROP TABLE dbo.Categoria
GO

CREATE TABLE dbo.Categoria
	(
	cat_id          NUMERIC (18) IDENTITY NOT NULL,
	cat_nombre      VARCHAR (100) NOT NULL,
	cat_descripcion NVARCHAR (3000) NULL,
	CONSTRAINT Key1 PRIMARY KEY (cat_id)
	)
GO
*/





