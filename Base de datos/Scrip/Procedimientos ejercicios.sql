--conocer un listado de estudiante matriculasdos en una materia 

create procedure sp_estudiantes_matriculados
@cod_materia varchar(50) 
as
Select et.cod_estudiante, et.apellido, et.nombre
from matricula mt
inner join estudiante et on mt.cod_estudiante = et.cod_estudiante
where @cod_materia =  mt.cod_estudiante
order by 3,2

exec sp_estudiantes_matriculados 'SOFIP22'



select * 
from 
