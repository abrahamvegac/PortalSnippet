
IF OBJECT_ID (N'dbo.sp_CargaFooter') IS NOT NULL
	DROP PROCEDURE dbo.sp_CargaFooter
GO

CREATE   PROCEDURE dbo.sp_CargaFooter
(
	@v_prm_titulo    VARCHAR(100)
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
 INVOCACIÓN               : sp_CargaFooter 'footer' 
 ------------------------ MANTENCIONES ----------------------
 -- AUTOR -----|--FECHA---------|-------- OBJETIVO ----------
 --------------|----------------|----------------------------
 ---------------------FIN MANTENCIONES-----------------------
************************************************************ */

SET dateformat dmy
set nocount on	

	SELECT  prm_id
	      , prm_titulo
	      , prm_descripcion
	      , prm_glosa
	      , prm_fecha
	      , prm_valor
	  FROM  parametros
	 WHERE  prm_titulo      = @v_prm_titulo 

set nocount off

GO

