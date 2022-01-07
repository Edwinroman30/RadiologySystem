SELECT *
FROM Tbl_Pacientes



CREATE VIEW viewGridViewPasientes
as (
SELECT cedula,nombre,prim_apellido,seg_apellido,email,telefono,Tbl_Seguros.concepto as seguros
FROM Tbl_Pacientes
INNER JOIN 
	Tbl_Seguros ON 
		Tbl_Seguros.id_seguro = Tbl_Pacientes.id_seguro
)
GO

SELECT *
FROM viewGridViewPasientes

SELECT *
FROM viewGridViewPasientes
WHERE [cedula] LIKE '%402-584%'

Select id_pais,nombre_pais,nacionalidad
From Tbl_Pais

Select id_pais,nombre_pais,nacionalidad
From Tbl_Pais
Where id_pais =


Select id_seguro, concepto
From Tbl_Seguros

Select  id_sangre,descripcion
From Tbl_Tipo_sangre


Select id_sexo,descripcion
from Tbl_Sexo


Select SectorID, localidad
from Tbl_Sectores