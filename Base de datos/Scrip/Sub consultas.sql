--INNER
--Conocer los estudiantes que estan matriculados
select cod_estudiante, cedula, nombre, apellido 
from estudiante
where cod_estudiante in (
		select	distinct m.cod_estudiante
		from matricula as m)

--Conocer que estudiantes no sean matriculados
select cod_estudiante, cedula, nombre, apellido 
from estudiante
where cod_estudiante not in (
		select	distinct m.cod_estudiante
		from matricula as m)

--EXISTS
--Conocer los estudiantes que estan matriculados	
SELECT cod_estudiante, cedula, nombre, apellido
FROM estudiante AS e
WHERE EXISTS (
    SELECT distinct m.cod_estudiante
    FROM matricula AS m
    WHERE m.cod_estudiante = e.cod_estudiante
);

--Conocer los estudiantes que no estan matriculas

SELECT cod_estudiante, cedula, nombre, apellido
FROM estudiante AS e
WHERE NOT EXISTS (
    SELECT distinct m.cod_estudiante
    FROM matricula AS m
    WHERE m.cod_estudiante = e.cod_estudiante
);

--conocer todos los estudianres dos matriculas en la misma materia "Que estan haciendo segunda matricula"

SELECT cod_estudiante, cedula, nombre, apellido
FROM estudiante AS e
WHERE EXISTS (
    SELECT distinct mt.cod_estudiante, cod_materia
    FROM matricula AS mt
	where mt.cod_estudiante = e.cod_estudiante 
	AND EXISTS (
			SELECT m.cod_materia, m.nombre
			FROM materia AS m
			WHERE m.cod_materia = mt.cod_materia AND cod_materia= 'SOFIB01'))

SELECT  e.apellido, e.nombre, e.cod_estudiante
FROM estudiante AS e
WHERE exists(
	SELECT count(m.cod_materia)
	FROM matricula as m
	WHERE e.cod_estudiante = m.cod_estudiante and m.cod_materia = 'SOFIB01'
	GROUP BY m.cod_materia
	HAVING COUNT(m.cod_materia) = 2
);

SELECT DISTINCT e.apellido, e.nombre, e.cod_estudiante, m.cod_materia, COUNT(m.cod_materia) AS numero_matriculas
FROM estudiante AS e
JOIN matricula AS m ON e.cod_estudiante = m.cod_estudiante
WHERE EXISTS(
	SELECT count(m.cod_materia)
	FROM matricula as m
	WHERE e.cod_estudiante = m.cod_estudiante
	GROUP BY m.cod_estudiante, m.cod_materia
	HAVING COUNT(m.cod_materia) = 2)
GROUP BY e.apellido, e.nombre, e.cod_estudiante, m.cod_materia
HAVING COUNT(m.cod_materia) = 2

Select * from evaluacion

SELECT  e.apellido, e.nombre, e.cod_estudiante
FROM estudiante AS e
WHERE exists(
	SELECT cod_materia, cod_estudiante, count(m.cod_materia) as "Numero de Matriculas"
	FROM matricula as m
	WHERE e.cod_estudiante = m.cod_estudiante
	GROUP BY m.cod_materia, m.cod_estudiante
	HAVING COUNT(m.cod_materia) > 1
);

--Subconsulta en From
SELECT  e.apellido, e.nombre, e.cod_estudiante,mt.nombre,sb.[Numero de Matriculas]
FROM estudiante AS e
inner join (
	SELECT distinct cod_materia, cod_estudiante, count(m.cod_materia) as "Numero de Matriculas"
	FROM matricula as m
	GROUP BY m.cod_materia, m.cod_estudiante
	HAVING COUNT(m.cod_materia) > 1
) as sb on e.cod_estudiante = sb.cod_estudiante
inner join materia as mt on mt.cod_materia =sb.cod_materia

--JOIN
SELECT  e.apellido, e.nombre, e.cod_estudiante,mt.nombre,count(m.cod_materia) as "Numero de Matriculas"
FROM estudiante AS e
inner join matricula as m on e.cod_estudiante = m.cod_estudiante
inner join materia as mt on mt.cod_materia =m.cod_materia
GROUP BY e.apellido, e.nombre, e.cod_estudiante,mt.nombre
HAVING COUNT(m.cod_materia) > 1

--Conocer los estudiantes cuya nota final sea inferior a al promedio del curso de una materia especifica
--con periodo 

Select *
From estudiante as e
where exists(
Select avg(notafinal)
From evaluacion as eva
where eva.cod_estudiante=e.cod_estudiante
Group By cod_periodo, cod_materia);

--Conocer los estudiantes cuya nota final sea inferior a al promedio del curso de una materia especifica
--con periodo 

Select e.nombre, e.apellido, v.notaFinal, v.cod_materia
From estudiante as e
inner join evaluacion v on e.cod_estudiante=v.cod_estudiante 
where v.cod_materia = 'SOFIB01' and v.cod_periodo = 'PA21'and v.notaFinal < any (
Select avg(notafinal)
From evaluacion as eva
where eva.cod_materia = 'SOFIB01' and eva.cod_periodo = 'PA21'	`
) 

SELECT * FROM evaluacion