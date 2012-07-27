/*
Created: 21/06/2012
Modified: 21/06/2012
Project: SQLsnippet
Model: Microsoft SQL Server 2005
Database: MS SQL Server 2005
*/

-- Create tables section -------------------------------------------------

-- Table Categoria

CREATE TABLE [Categoria]
(
 [cat_id] Numeric(18,0) IDENTITY(1,1) NOT NULL,
 [cat_nombre] Varchar(100) NOT NULL,
 [cat_descripcion] Nvarchar(3000) NULL
)
go

-- Add keys for table Categoria

ALTER TABLE [Categoria] ADD CONSTRAINT [Key1] PRIMARY KEY ([cat_id])
go

ALTER TABLE [Categoria] ADD CONSTRAINT [cat_id] UNIQUE CLUSTERED ([cat_id])
go

-- Table Snippet

CREATE TABLE [Snippet]
(
 [snp_id] Numeric(18,0) IDENTITY(1,1) NOT NULL,
 [snp_titulo] Varchar(300) NULL,
 [snp_descripcion] Varchar(4000) NULL,
 [snp_codigo] Varchar(max) NULL,
 [snp_fecha_creacion] Datetime NULL,
 [snp_fecha_modificacion] Datetime NULL,
 [snp_posteado] Varchar(100) NULL,
 [cat_id] Numeric(18,0) NOT NULL
)
go

-- Add keys for table Snippet

ALTER TABLE [Snippet] ADD CONSTRAINT [Key2] PRIMARY KEY ([cat_id],[snp_id])
go

ALTER TABLE [Snippet] ADD CONSTRAINT [snp_id] UNIQUE CLUSTERED ([snp_id])
go

-- Create relationships section ------------------------------------------------- 

ALTER TABLE [Snippet] ADD CONSTRAINT [publicacion] FOREIGN KEY ([cat_id]) REFERENCES [Categoria] ([cat_id])
go




