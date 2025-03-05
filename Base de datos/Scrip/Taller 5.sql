--Tarea 5
--ejercicio 1
--Conocer los estudiantes (nombreApellido) de sexo femenino que han aprobado 
--las asignaturas de un periodo específico

select estu.nombre+' '+ estu.apellido as Nombres, eva.notaFinal
from estudiante estu 
inner join evaluacion eva on estu.cod_estudiante = eva.cod_estudiante
where eva.cod_periodo = 'PS20' AND estu.sexo = 'F'  and eva.estado = 'EE1' 


-- ejercicio 2
--Conocer las materias (nombre) con menos de 3 estudiantes
select mt.nombre as "Nombre de la Materia", count(ma.cod_estudiante) as "Estudiantes Matriculados"
from matricula as ma
inner join materia as mt on ma.cod_materia = mt.cod_materia
group by mt.nombre
having count(ma.cod_estudiante) < 5

select * from materia

--ejercicio 3
--La nota (nota2) promedio de cada materia
SELECT MA.nombre as "Nombre de la materia", avg(e.nota2) as "Promedio Nota 2"
FROM materia as MA
inner join matricula as M on M.cod_materia = MA.cod_materia
inner join evaluacion as E on E.cod_materia = M.cod_materia
GROUP BY MA.cod_materia, MA.nombre 

Select * from evaluacion
--Ejercicio 4
--Conocer el año con mayor número de estudiantes que aprobaron una asignatura específica en un periodo específico
SELECT  TOP 1 YEAR(M.fecha_matricula) AS "Año de Inicio", COUNT(DISTINCT E.cod_estudiante) AS "Numero de Estudiantes", 
MR.nombre AS "NOMBRE DE LA MATERIA", P.descripcion AS "PERIODO"
FROM evaluacion AS E
INNER JOIN matricula AS M ON E.cod_estudiante = M.cod_estudiante
INNER JOIN materia AS MR ON MR.cod_materia = M.cod_materia
INNER JOIN periodo AS P ON M.cod_periodo = P.cod_periodo
WHERE E.estado = 'EE1' And E.cod_materia = 'SOFIB01' AND P.cod_periodo = 'PS20'
GROUP BY YEAR(M.fecha_matricula), MR.nombre, P.descripcion
ORDER BY COUNT(E.cod_estudiante) DESC;

Select cod_materia,estado from evaluacion

Select cod_materia, COUNT(cod_estudiante)
From evaluacion
where estado = 'EE1'
GROUP BY cod_materia

--Ejercicio 5
--Conocer la máxima y mínima nota por cada materia de un periodo específico. 
SELECT E.cod_materia, MR.nombre AS "NOMBRE DE LA MATERIA", MAX(E.notaFinal) AS "NOTA MAXIMA", 
MIN(E.notaFinal) AS "NOTA MINIMA"
FROM materia AS MR
INNER JOIN matricula AS M ON MR.cod_materia = M.cod_materia
INNER JOIN evaluacion AS E ON E.cod_estudiante = M.cod_estudiante AND E.cod_materia = M.cod_materia AND E.cod_periodo = M.cod_periodo
INNER JOIN periodo AS P ON P.cod_periodo = M.cod_periodo
WHERE P.cod_periodo = 'PS20'
GROUP BY E.cod_materia, MR.nombre
ORDER BY 1;

--Select cod_materia, max(notaFinal), min(notaFinal)
--from evaluacion
--where cod_periodo = 'PS20'
--GROUP BY cod_materia

--Ejercicio 6
--Listado de asignaturas por carrera y facultad que no tienen estudiantes matriculados en un periodo específico
SELECT C.nombre AS "Nombre de Carrera", F.nombre AS "Nombre de Facultad", MR.nombre AS "Nombre de Materia"
FROM materia AS MR
INNER JOIN area AS A ON A.cod_area = MR.cod_area
INNER JOIN carrera AS C ON C.cod_carrera = MR.cod_carrera
INNER JOIN facultad AS F ON F.cod_facultad = C.cod_facultad
LEFT JOIN matricula AS M ON MR.cod_materia = M.cod_materia
LEFT JOIN estudiante AS E ON M.cod_estudiante = E.cod_estudiante
INNER JOIN periodo AS P ON P.cod_periodo = M.cod_periodo
WHERE P.cod_periodo = 'PJ22' AND M.cod_estudiante is not null
GROUP BY C.nombre, F.nombre, MR.nombre;

Select * From matricula
Select D.nombre as Facultad, A.nombre as Carrera,B.cod_materia, B.nombre as Materia, C.cod_periodo
from carrera as A
inner join materia B on A.cod_carrera = B.cod_carrera
inner join matricula C on B.cod_materia = C.cod_materia
inner join facultad D on D.cod_facultad = A.cod_facultad 
where C.estado = 'EM2' and C.cod_periodo = 'PJ22'
group by D.nombre, A.nombre, B.cod_materia, B.nombre, C.cod_periodo


--EJERCICIO 7
--Listado de las materias que no tienen estudiantes matriculados en un periodo específico
SELECT MR.nombre AS "Nombre de Materia"
FROM matricula as M
inner join materia as MR ON MR.cod_materia = M.cod_materia
inner join periodo as P ON P.cod_periodo = M.cod_periodo
WHERE P.cod_periodo = 'PN21' AND M.cod_estudiante is not null
GROUP BY MR.nombre

--Conocer los estudiantes (nombreApellido) de sexo femenino que han aprobado las asignaturas de un período específico:
SELECT estu.nombre + ' ' + estu.apellido as Nombres, eva.notaFinal
FROM estudiante estu 
INNER JOIN evaluacion eva ON estu.cod_estudiante = eva.cod_estudiante
WHERE eva.cod_periodo = 'PS20' 
AND estu.sexo = 'F'  
AND eva.estado = 'EE1'
AND estu.cod_estudiante IN (
    SELECT cod_estudiante
    FROM evaluacion
    WHERE estado = 'EE1' AND cod_periodo = 'PS20'
);



--La nota (nota2) promedio de cada materia:
SELECT MA.nombre as "Nombre de la materia", avg(e.nota2) as "Promedio Nota 2"
FROM materia as MA
INNER JOIN matricula as M on M.cod_materia = MA.cod_materia
INNER JOIN evaluacion as E on E.cod_materia = M.cod_materia
WHERE EXISTS (
    SELECT 1
    FROM evaluacion as subE
    WHERE subE.cod_materia = MA.cod_materia
)
GROUP BY MA.cod_materia, MA.nombre;


SELECT columnas
FROM tabla
WHERE columna IN (a, b, ..., N);

SELECT columnas
FROM tabla1
WHERE EXISTS (SELECT columnas FROM tabla2 WHERE condicion);

SELECT *
FROM productos
WHERE id_producto IN (SELECT id_producto FROM ventas);

SELECT *
FROM productos p
WHERE EXISTS (
    SELECT 1
    FROM ventas v
    WHERE v.id_producto = p.id_producto
);
