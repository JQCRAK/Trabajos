--Consultas

--1. Listar las materias (cod_materia y nombre) de las carreras de la FIE con más de 40 estudiantes
-- Primero, obtenemos los códigos de las carreras de la facultad FIE
SELECT DISTINCT m.cod_materia as "Codigo de materia", m.nombre as Materia
FROM materia m
INNER JOIN carrera c ON m.cod_carrera = c.cod_carrera
INNER JOIN facultad f ON c.cod_facultad = f.cod_facultad
INNER JOIN matricula ma ON m.cod_materia = ma.cod_materia
WHERE f.cod_facultad = 'FI01'
GROUP BY m.cod_materia, m.nombre
HAVING COUNT(DISTINCT ma.cod_estudiante) >40;

--2. Listar las estudiantes (cod_estudiante, nombre) matriculados a BD1 
--que se encuentran con segunda matrícula.
SELECT e.cod_estudiante, e.nombre, e.apellido, COUNT(m.cod_materia) as "Numero de Materias"
FROM estudiante e
INNER JOIN matricula m ON e.cod_estudiante = m.cod_estudiante
WHERE m.cod_materia = 'SOFIP25'
GROUP BY e.cod_estudiante, e.nombre, e.apellido
HAVING COUNT(m.cod_materia) = 2
ORDER BY 3;

--2.Listar las estudiantes (cod_estudiante, nombre) matriculados a 
--BD1 que se encuentran con segunda matrícula
SELECT  e.cod_estudiante, e.nombre, e.apellido
FROM estudiante e
WHERE e.sexo = 'F' and exists(
	SELECT cod_materia,cod_estudiante, count(m.cod_materia) as "Numeros de Matricula"
	FROM matricula m
	WHERE e.cod_estudiante = m.cod_estudiante and m.cod_materia = 'SOFIP25'
	Group by m.cod_materia, m.cod_estudiante
	HAVING COUNT(m.cod_materia) > 1
);

--3. Conocer las materias (cod_materia y nombre) de la carrera de software cuyo promedio 
--de nota (parcial1) es inferior al 75%
SELECT m.cod_materia, m.nombre,AVG(e.nota1) as Promedio
FROM materia m
INNER JOIN carrera c ON m.cod_carrera = c.cod_carrera
INNER JOIN evaluacion e ON m.cod_materia = e.cod_materia
WHERE c.cod_carrera = 'CS01'
GROUP BY m.cod_materia, m.nombre
HAVING AVG(e.nota1) < 7.5;

--4.Conocer las materias de la carrera de software con el mayor número 
--de estudiantes con mayor igual a segunda  matriculas
SELECT ma.cod_materia as Codigo, ma.nombre as Materia, COUNT(DISTINCT M.cod_estudiante) AS "Numero de Estudiantes"
FROM matricula AS M
INNER JOIN materia AS ma ON M.cod_materia = ma.cod_materia
INNER JOIN carrera AS c ON ma.cod_carrera = c.cod_carrera
WHERE c.cod_carrera = 'CS01'
  AND EXISTS (
    SELECT m2.cod_estudiante
    FROM matricula m2
    WHERE m2.cod_estudiante = M.cod_estudiante AND m2.cod_materia = M.cod_materia
    GROUP BY m2.cod_estudiante, m2.cod_materia
    HAVING COUNT(m2.cod_estudiante) >= 2
)
GROUP BY ma.cod_materia, ma.nombre
ORDER BY COUNT(DISTINCT M.cod_estudiante) DESC;


--4. Conocer las materias de la carrera de software con el mayor número de estudiantes con mayor igual a segunda  matriculas.

SELECT m.cod_materia, m.nombre, COUNT(ma.cod_estudiante) AS num_estudiantes
FROM materia m
JOIN carrera c ON m.cod_carrera = c.cod_carrera
JOIN matricula ma ON m.cod_materia = ma.cod_materia
WHERE c.cod_carrera = 'CS01'
GROUP BY m.cod_materia, m.nombre
HAVING COUNT(ma.cod_estudiante) >= 2
ORDER BY num_estudiantes DESC;

--5. Conocer las materias cuya nota promedio (nota1) sea inferior al promedio 
--general de la carrera de software
SELECT m.cod_materia, m.nombre, AVG(e.nota1) AS "Promedio de la Nota 1"
FROM materia m
INNER JOIN evaluacion e ON m.cod_materia = e.cod_materia
INNER JOIN carrera c ON m.cod_carrera = c.cod_carrera
WHERE c.cod_carrera = 'CS01'
GROUP BY m.cod_materia, m.nombre
HAVING AVG(e.nota1) <  (SELECT AVG(e1.nota1) 
						FROM evaluacion e1 
						INNER JOIN materia m1 ON e1.cod_materia = m1.cod_materia 
						WHERE m1.cod_carrera = 'CS01');

--5.Conocer las materias cuya nota promedio (nota1) sea inferior 
--al promedio general de la carrera de software
SELECT c.cod_materia, c.nombre, AVG(e.nota1) AS promedio_nota1
FROM evaluacion AS e
INNER JOIN materia AS c ON e.cod_materia = c.cod_materia
WHERE c.cod_carrera = 'CS01'
GROUP BY c.cod_materia, c.nombre
HAVING AVG(e.nota1) < (
    SELECT CAST(AVG(e2.nota1) AS DECIMAL(4,2))
    FROM evaluacion AS e2
    INNER JOIN materia AS m2 ON e2.cod_materia = m2.cod_materia
    WHERE m2.cod_carrera = 'CS01'
)
ORDER BY c.cod_materia;

--6. Conocer las materias según el periodo académico con menos estudiantes de 25 estudiantes
SELECT m.cod_materia, m.nombre, p.descripcion AS "Periodo Academico", 
COUNT(ma.cod_estudiante) AS "Total Estudiantes"
FROM materia m
INNER JOIN matricula ma ON m.cod_materia = ma.cod_materia
INNER JOIN periodo p ON ma.cod_periodo = p.cod_periodo
GROUP BY m.cod_materia, m.nombre, p.descripcion
HAVING COUNT(ma.cod_estudiante) < 25
ORDER BY COUNT(ma.cod_estudiante), p.descripcion ASC;




--6.Conocer las materias según el periodo académico con menos estudiantes de 25 estudiantes
select MT.cod_materia, M.nombre, count(MT.cod_estudiante) N_estudiantes 
from Matricula MT 
inner join Materia M on MT.cod_materia=M.cod_materia 
inner join Periodo as P on MT.cod_periodo= P.cod_periodo 
group by MT.cod_materia, M.nombre 
having count(MT.cod_estudiante) < 25
--7. Conocer la tasa de repitencia por materia (Número de estudiantes matriculados en la materia / número de 
--estudiantes que han reprobado dicha materia) de la carrera de software en un periodo académico específico.

SELECT m.cod_materia, 
       m.nombre AS Nombre_Materia, 
       p.descripcion AS Periodo_Academico, 
       COUNT(DISTINCT ma.cod_estudiante) AS Total_Matriculados, 
       COUNT(CASE WHEN e.estado = 'Desaprobado' THEN ma.cod_estudiante END) AS Reprobados, 
       CAST(COUNT(CASE WHEN e.estado = 'Desaprobado' THEN ma.cod_estudiante END) AS FLOAT) / COUNT(DISTINCT ma.cod_estudiante) AS Tasa_Repitencia
FROM materia m
INNER JOIN matricula ma ON m.cod_materia = ma.cod_materia
INNER JOIN periodo p ON ma.cod_periodo = p.cod_periodo
LEFT JOIN evaluacion e ON ma.cod_estudiante = e.cod_estudiante AND m.cod_materia = e.cod_materia AND ma.cod_periodo = e.cod_periodo
INNER JOIN carrera c ON m.cod_carrera = c.cod_carrera
WHERE c.cod_carrera = 'CS01' -- Código de la carrera de Software
  AND p.cod_periodo = 'PA24' -- Código del periodo académico específico
GROUP BY m.cod_materia, m.nombre, p.descripcion;




--7.Conocer la tasa de repitencia por materia (Número de estudiantes matriculados en la materia/ 
--número de estudiantes que han reprobado dicha materia) de la carrera de software en un periodo 
--académico específico
SELECT m.cod_materia, m.nombre AS nombre_materia,
    COUNT(DISTINCT mat.cod_estudiante) AS Num_Matriculados,
    COUNT(DISTINCT CASE WHEN e.estado = 'EE2' THEN e.cod_estudiante END) AS Num_Reprobados,
    CAST(COUNT(DISTINCT CASE WHEN e.estado = 'EE2' THEN e.cod_estudiante END) AS DECIMAL(10,2)) /
    CAST(COUNT(DISTINCT mat.cod_estudiante) AS DECIMAL(10,2)) AS Tasa_Repitencia
FROM matricula mat
INNER JOIN materia m ON mat.cod_materia = m.cod_materia
INNER JOIN carrera c ON m.cod_carrera = c.cod_carrera
INNER JOIN evaluacion e ON mat.cod_estudiante = e.cod_estudiante 
AND mat.cod_materia = e.cod_materia AND mat.cod_periodo = e.cod_periodo
WHERE c.cod_carrera = 'CS01'AND mat.cod_periodo = 'PA21'
GROUP BY m.cod_materia, m.nombre
ORDER BY m.cod_materia;

	