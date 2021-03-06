


IF OBJECT_ID (N'dbo.sp_CargaTextoPaginaInicio') IS NOT NULL
	DROP PROCEDURE dbo.sp_CargaTextoPaginaInicio
GO

CREATE   PROCEDURE dbo.sp_CargaTextoPaginaInicio

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
 INVOCACIÓN               : sp_CargaTextoPaginaInicio 
 ------------------------ MANTENCIONES ----------------------
 -- AUTOR -----|--FECHA---------|-------- OBJETIVO ----------
 --------------|----------------|----------------------------
 ---------------------FIN MANTENCIONES-----------------------
************************************************************ */

SET dateformat dmy
set nocount on	

	SELECT   prm_titulo
	       , prm_descripcion
	       , prm_glosa
	       , prm_valor 
	  FROM parametros 
	 WHERE prm_titulo = 'pgInicio'
	 ORDER BY prm_valor 

set nocount off

GO


