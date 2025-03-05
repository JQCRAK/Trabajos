--ejemplo de union digamos que tengo unabbases de datos distribuidas por cada carrerra 
--quiero armar una sola tabla de los estudiantes de la espoch pero hay tablas indivdicuales 
--por cada carrera hay que generalizar las tablas datos personales comunes que son difernectes 
--nombre, apellido, cedula si son diferentes son comunes de todas las tablas dispersar y hacer una 
--en este caso se puede unir todas ;as tablas que se llame estudiante espoch 

--Ejemplo de interseccion 
--Conocer los etudiantes que ya sean matricula check

Select cod_estudiante
from estudiante

intersect

Select cod_estudiante
from matricula
--desventajas solo se puede ver codigos 


--Los estudiantes que no sean matriculados check

select cod_estudiante
from estudiante

except

select cod_estudiante
from matricula

--estudiantes que no estan matriculados en una materia especifica y en un periodod especifico 
select cod_estudiante
from estudiante

except

select cod_estudiante
from matricula
where cod_materia = 'SOFIB01'
--inner join tiene la estrcutura similar con conjuntos

select *from [dbo].[matricula]

--conocer las matriculas que ya tiene notas
select cod_estudiante, cod_materia, cod_periodo
from matricula
intersect
select cod_estudiante, cod_materia, cod_periodo
from evaluacion

--conocer las matriculas que no tiene notas
select cod_estudiante, cod_materia, cod_periodo
from matricula
except
select cod_estudiante, cod_materia, cod_periodo
from evaluacion
where notaFinal is null

--conocer las matriculas que tiene nota 2
select cod_estudiante, cod_materia, cod_periodo
from matricula
intersect
select cod_estudiante, cod_materia, cod_periodo
from evaluacion
where nota2  is not null

--conocer 