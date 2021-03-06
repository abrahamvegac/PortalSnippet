
USE db_sqlsnippet 
go
IF OBJECT_ID('dbo.sp_CargaMenu') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.sp_CargaMenu
    IF OBJECT_ID('dbo.sp_CargaMenu') IS NOT NULL
        PRINT '<<< FAILED DROPPING PROCEDURE dbo.sp_CargaMenu >>>'
    ELSE
        PRINT '<<< DROPPED PROCEDURE dbo.sp_CargaMenu >>>'
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE dbo.sp_CargaMenu
(
	@inLoginUsuario	VARCHAR(100)
)
AS

/* ******************************************************
 PROCEDIMIENTO ALMACENADO : 
 AUTOR                    : 
 BASE                     : 
 FECHA DE CREACIÓN        : 
 DESCRIPCION              : 
 ENTRADA                  : 
 SALIDA                   : 
 OBSERVACIONES            : 
 TIPO PROCEDIMIENTO       : 
 INVOCACIÓN               : sp_CargaMenu 'yo'
 ------------------------ MANTENCIONES ----------------------
 -- AUTOR -----|--FECHA---------|-------- OBJETIVO ----------
 --------------|----------------|----------------------------
 ---------------------FIN MANTENCIONES-----------------------
************************************************************ */

SET dateformat dmy
set nocount on	

	-- opciones activas	
	SELECT   mnu_id
 	       , mnu_titulo
	       , mnu_descripcion
	       , mnu_url
	       , mnu_activo	       
	  FROM dbo.menu
	 WHERE lower(mnu_activo) = 'S'
	 
	 

set nocount off
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER OFF
GO

IF OBJECT_ID('dbo.sp_CargaMenu') IS NOT NULL
    PRINT '<<< CREATED PROCEDURE dbo.sp_CargaMenu >>>'
ELSE
    PRINT '<<< FAILED CREATING PROCEDURE dbo.sp_CargaMenu >>>'
go
