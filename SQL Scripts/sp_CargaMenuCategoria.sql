IF OBJECT_ID (N'dbo.sp_CargaMenuCategoria') IS NOT NULL
	DROP PROCEDURE dbo.sp_CargaMenuCategoria
GO

CREATE   PROCEDURE dbo.sp_CargaMenuCategoria

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
 INVOCACIÓN               : sp_CargaMenuCategoria 
 ------------------------ MANTENCIONES ----------------------
 -- AUTOR -----|--FECHA---------|-------- OBJETIVO ----------
 --------------|----------------|----------------------------
 ---------------------FIN MANTENCIONES-----------------------
************************************************************ */

SET dateformat dmy
set nocount on	

	SELECT a.cat_nombre , count(b.cat_id ) totalCategoria 
	  FROM Categoria          a
	       LEFT outer JOIN Snippet b ON a.cat_id = b.cat_id        
	 GROUP BY a.cat_nombre
	 ORDER BY a.cat_nombre
	 
	 

set nocount off

GO

