






SELECT * 
  FROM Snippet
 
 ORDER BY snp_fecha_creacion DESC 
  
  
SELECT * 
  FROM Snippet 
 WHERE cat_id = 1
   ORDER BY snp_fecha_creacion DESC 


SELECT * 
  FROM Snippet
 WHERE upper(snp_titulo)      LIKE upper('%tabla%efdfsdfsadfas%')
    or upper(snp_descripcion) LIKE upper('%tabla%efdfsdfsadfas%')
    OR upper(snp_codigo)      LIKE upper('%tabla%efdfsdfsadfas%')
  
ORDER BY  snp_fecha_creacion DESC  


