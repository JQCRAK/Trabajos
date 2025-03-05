--TRABAJO GRUPAL Grupo 07
--Angel Guaño 7337
--Jhostin Quispe 7365

--Ejercicio 4 Recuperación de datos.
-- Implementación de base de datos y trabajo en equipo.

--						INSERCION DE DATOS EN LAS TABLAS: 
-- Insertar registros en la tabla Estudiantes
INSERT INTO Estudiantes(txtCodigo, txtCedula, txtNombre, txtDireccion, txtTelefono, dtFecha_Nacimiento, dtFecha_Ingreso, txtSexo)
VALUES
    ('7301', '1234567890', 'Carlos Perez', 'AV. PICHINCHA Y RIO', '0987654321', '2000-02-12', '2020-08-15', 'M'),
    ('7302', '2345678901', 'Ana Maria Ruiz', 'Calle Colon y 10 de Agosto', '0987654322', '2001-03-22', '2020-10-05', 'F'),
    ('7303', '3456789012', 'Luis Alvarez', 'AV. ESPAÑA Y JUAN MONTALVO', '0987654323', '2000-07-13', '2020-09-12', 'M'),
    ('7304', '4567890123', 'Laura Romero', 'CALLE JUAN PABLO II', '0987654324', '2000-11-05', '2020-10-15', 'F'),
    ('7305', '5678901234', 'Pedro Lopez', 'CALLE PRINCIPAL Y 2 DE AGOSTO', '0987654325', '2001-01-20', '2020-09-20', 'M'),
    ('7306', '6789012345', 'Maria Torres', 'Calle 24 de Mayo', '0987654326', '2002-02-10', '2020-05-12', 'F'),
    ('7307', '7890123456', 'Jose Martinez', 'AV. DEL EJIDO', '0987654327', '2003-09-18', '2021-06-08', 'M'),
    ('7308', '8901234567', 'Isabel Jimenez', 'CALLE CORDOVA Y GUAYAS', '0987654328', '2002-06-25', '2021-05-10', 'F'),
    ('7309', '9012345678', 'Fernando Garcia', 'AV. GALO PLAZA LARA', '0987654329', '2003-10-15', '2021-06-17', 'M'),
    ('7310', '0123456789', 'Patricia Gutierrez', 'Calle 10 DE AGOSTO', '0987654330', '2002-11-25', '2020-08-20', 'F');

	Select *
	From Estudiantes

-- Insertar registros en la tabla Docentes
INSERT INTO Docentes (txtCodigo, txtCedula, txtNombre, txtDireccion, txtTelefono, dtFecha_Nacimiento, dtFecha_Ingreso, txtSexo, txtCategoria, mnSalario)
VALUES
    ('0001', '3210987654', 'Alvaro Molina', 'Calle Paris y Versalles', '0991112223', '1980-06-14', '2010-03-10', 'M', 'A', 2650.00),
    ('0002', '6543210987', 'Carmen Vera', 'Av. Real y Republica', '0994445556', '1985-03-20', '2016-01-05', 'F', 'P', 2900.00),
    ('0003', '2345678901', 'Miguel Paredes', 'Calle 7 de Septiembre', '0997778889', '1979-11-12', '2005-06-21', 'M', 'A', 2500.00),
    ('0004', '9876543210', 'Rosa Martinez', 'Av. Colon y Sucre', '0999991111', '1988-09-18', '2018-04-14', 'F', 'A', 2750.00),
    ('0005', '1122334455', 'Luis Gonzalez', 'Calle El Ejido', '0992223334', '1982-04-23', '2002-12-18', 'M', 'P', 2800.00),
    ('0006', '6677889900', 'Maria Lara', 'Av. Universitaria', '0995556667', '1987-02-11', '2014-09-12', 'F', 'G', 3000.00),
    ('0007', '9988776655', 'Pedro Guerrero', 'Calle America', '0998889990', '1976-10-29', '2003-05-09', 'M', 'A', 2600.00),
    ('0008', '3344556677', 'Angela Castro', 'Av. Republica', '0991112223', '1983-12-05', '2018-03-08', 'F', 'A', 2450.00),
    ('0009', '5566778899', 'Juan Becerra', 'Calle Carcelen', '0994445556', '1981-05-19', '2001-10-25', 'M', 'G', 2950.00),
    ('0010', '4433221100', 'Luisa Andrade', 'Av. Los Arupos', '0996667778', '1984-08-09', '2019-07-01', 'F', 'P', 2850.00);

	Select *
	From Docentes
-- Insertar registros en la tabla Materias
INSERT INTO Materias (txtCodigo, txtNombre)
VALUES
    ('SOFI7', 'REDES II'),
    ('SOFI6', 'ENTORNOS VIRTUALES DE APRENDIZAJE'),
    ('SOFI4', 'MATEMÁTICAS DISCRETAS'),
    ('SOFI8', 'TÉCNICAS DE SIMULACIÓN'),
    ('SOFI1', 'FUNDAMENTOS DE PROGRAMACIÓN'),
    ('SOFI5', 'APLICACIONES INFORMÁTICAS'),
    ('SOFI2', 'ÁLGEBRA LINEAL'),
    ('SOFI3', 'CÁLCULO I'),
    ('SOFI9', 'MATEMÁTICAS DISCRETAS I'),
    ('SOFI0', 'SISTEMAS OPERATIVOS');

	-- Insertar registros en la tabla Evaluaciones
	INSERT INTO Evaluaciones (txtCodEstudiante, txtCodMateria, txtCodDocente, bytAcumulado, bytNota, bytTotal, bytAsistencia, txtEquivalencia)
	VALUES
	('7301', 'SOFI7', '0001', 25, 10, 35, 85, 'E'),
    ('7302', 'SOFI6', '0002', 20, 9, 29, 70, 'R'),
    ('7303', 'SOFI4', '0003', 24, 5, 29, 80, 'A'),
    ('7304', 'SOFI8', '0004', 23, 3, 26, 60, 'R'),
    ('7305', 'SOFI1', '0005', 25, 10, 35, 90, 'E'),
    ('7306', 'SOFI5', '0006', 20, 7, 27, 60, 'R'),
    ('7307', 'SOFI2', '0007', 22, 7, 29, 85, 'A'),
    ('7308', 'SOFI3', '0008', 19, 5, 24, 50, 'R'),
    ('7309', 'SOFI9', '0009', 21, 9, 30, 95, 'A'),
	('7303', 'SOFI5', '0006', 23, 6, 29, 80, 'A'),
    ('7310', 'SOFI0', '0010', 25, 10, 35, 100, 'E');


--Realice un script de sql que resuelva los siguientes ejercicios de recuperación de datos de su base de datos Academico. No puede utilizar subconsultas.		
--1.Seleccionar los estudiantes de sexo masculino.
	SELECT *
	FROM Estudiantes 
	where txtSexo = 'M';

--2. Seleccionar los estudiantes de sexo femenino.
	SELECT *
	FROM Estudiantes 
	where txtSexo = 'F';

--3. Seleccionar los estudiantes de sexo masculino ordenados por el nombre.
	SELECT txtCodigo, txtCedula, txtNombre, txtSexo
	FROM Estudiantes 
	where txtSexo = 'M'
	ORDER BY txtNombre

--4. Seleccionar los estudiantes de sexo femenino ordenados por el nombre.
	SELECT txtCodigo, txtCedula, txtNombre, txtSexo
	FROM Estudiantes 
	where txtSexo = 'F'
	ORDER BY txtNombre

--5. Seleccionar las evaluaciones con las materias de los estudiantes de sexo masculino.
	SELECT e.txtCodigo as Codigo, e.txtNombre as Nombre, ma.txtNombre as NombreMateria, bytAcumulado as Acumulado, bytNota as Nota, bytTotal as Total
	FROM Estudiantes e
	JOIN Evaluaciones eva On(e.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	where txtSexo = 'M'

--6. Seleccionar las evaluaciones con las materias de los estudiantes de sexo femenino.
	SELECT es.txtCodigo AS Codigo, es.txtNombre as NombreEstu, ma.txtNombre as NombreMateria, bytAcumulado as Acumulado, bytNota as Nota, bytTotal as Total
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	where txtSexo = 'F'

--7. Similar al 5 ordenado por las materias.
	SELECT es.txtCodigo, es.txtNombre, ma.txtNombre, bytAcumulado, bytNota, bytTotal
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	where txtSexo = 'M'
	Order by ma.txtNombre

--8. Similar al 6 ordenado por las materias.
	SELECT es.txtCodigo, es.txtNombre, ma.txtNombre, bytAcumulado, bytNota, bytTotal
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	where txtSexo = 'F'
	Order by ma.txtNombre

--9. Seleccionar las evaluaciones de un estudiante dado con los datos del docente. 
	SELECT es.txtCodigo as [Codigo Alumno], es.txtNombre, txtCodDocente as [Codigo Docente], doc.txtNombre, eva.txtCodMateria,
			ma.txtNombre,eva.bytAcumulado as Acumulado, eva.bytNota as Nota , eva.bytTotal as TOTAL
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Docentes doc ON(eva.txtCodDocente = doc.txtCodigo)
	JOIN Materias ma ON (ma.txtCodigo = eva.txtCodMateria) 
	where eva.txtCodDocente = '0003'

--10. Similar al 7 con los datos del docente.
	SELECT es.txtCodigo as [Codigo Alumno], es.txtNombre, txtCodDocente as [Codigo Docente], doc.txtNombre,
			ma.txtNombre,eva.bytAcumulado as Acumulado, eva.bytNota as Nota , eva.bytTotal as TOTAL
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	JOIN Docentes doc ON(eva.txtCodDocente = doc.txtCodigo)
	where es.txtSexo = 'M'
	Order by ma.txtNombre

--11. Similar al 8 con los datos del docente.
	SELECT es.txtCodigo as [Codigo Alumno], es.txtNombre, txtCodDocente as [Codigo Docente], doc.txtNombre,
			ma.txtNombre,eva.bytAcumulado as Acumulado, eva.bytNota as Nota , eva.bytTotal as TOTAL
	FROM Estudiantes es
	JOIN Evaluaciones eva On(es.txtCodigo = eva.txtCodEstudiante)
	JOIN Materias ma ON(eva.txtCodMateria = ma.txtCodigo)
	JOIN Docentes doc ON(eva.txtCodDocente = doc.txtCodigo)

	where es.txtSexo = 'F'
	Order by ma.txtNombre

--12. Seleccionar los estudiantes con apellido “perez” que aprobaron una materia determinada.
	SELECT es.*
	FROM Estudiantes es
	JOIN Evaluaciones eva ON es.txtCodigo = eva.txtCodEstudiante
	WHERE eva.txtCodMateria = 'SOFI8' AND eva.txtEquivalencia = 'A' 
	 AND SUBSTRING(es.txtNombre, CHARINDEX(' ', es.txtNombre) + 1, LEN(es.txtNombre)) = 'Perez';

--13. Seleccionar los profesores cuyos nombres inicien con las letras “P” o “M” y que hayan evaluado alguna asignatura.
	SELECT eva.*, txtNombre as Docente
	FROM Docentes doc
	JOIN Evaluaciones eva ON doc.txtCodigo = eva.txtCodDocente
	WHERE LEFT(txtNombre, 1) IN ('P', 'M');

--14. Seleccionar los estudiantes sin teléfono de la ciudad de “Riobamba”.
	SELECT es.*
	FROM Estudiantes es
	WHERE es.txtTelefono is null and es.txtDireccion = 'Riobamba'

--15. Seleccionar los estudiantes que tengan al menos una evaluación aprobada
	SELECT count(eva.txtEquivalencia) [Numero de arobados], eva.txtCodEstudiante, es.txtNombre
	FROM Estudiantes es
	JOIN Evaluaciones eva ON(es.txtCodigo = eva.txtCodEstudiante)
	where eva.txtEquivalencia = 'A'
	Group By eva.txtCodEstudiante, es.txtNombre
	having count(eva.txtEquivalencia)>=1




--Realice un script de sql, donde aplique los métodos para agrupar y resumir datos, y la 
--aplicación de las subconsultas, que resuelva los siguientes ejercicios de recuperación de datos.

--1. Seleccionar el promedio de notas del curso
	SELECT AVG(bytNota) as "Promedio de notas"
	FROM Evaluaciones 

--2. Seleccionar el promedio de notas de los estudiantes evaluados de sexo masculino.
	SELECT AVG(bytNota) as "promedio de notas"
	FROM Evaluaciones eva
	JOIN Estudiantes as es ON eva.txtCodEstudiante = es.txtCodigo
	WHERE es.txtSexo = 'M'


--3. Seleccionar el promedio de notas de los estudiantes evaluados de sexo femenino.
	SELECT AVG(bytNota) as "Promedio de notas"
	FROM Evaluaciones eva
	JOIN Estudiantes as es ON eva.txtCodEstudiante = es.txtCodigo
	WHERE es.txtSexo = 'F'

--4. Seleccionar el promedio de notas por cada estudiante de la base de datos.
	SELECT es.txtCodigo, es.txtNombre, AVG(bytNota) as "Promedio de notas"
	FROM Evaluaciones 
	RIGHT JOIN Estudiantes as es ON (txtCodEstudiante = es.txtCodigo)
	Group BY es.txtCodigo, es.txtNombre


--5. Seleccionar la cantidad de evaluaciones por cada estudiante de la base de datos
	SELECT es.txtCodigo, es.txtNombre, count(eva.txtCodMateria) as "Cantidad de evaluaciones"
	FROM Evaluaciones eva
	RIGHT JOIN Estudiantes as es ON (eva.txtCodEstudiante = es.txtCodigo)
	Group BY es.txtCodigo, es.txtNombre

--6. Seleccionar el promedio de notas por cada materia de la base de datos.
	SELECT eva.txtCodMateria, ma.txtNombre, AVG(eva.bytNota) as "Promedio de notas de la materia"
	FROM Evaluaciones eva
	RIGHT JOIN Materias as ma ON (eva.txtCodMateria = ma.txtCodigo)
	Group BY eva.txtCodMateria, ma.txtNombre

--7. Seleccionar la cantidad de evaluaciones por cada materia de la base de datos.
	SELECT eva.txtCodMateria, ma.txtNombre, count(eva.txtCodEstudiante) as "Cantidad de Evaluaciones"
	FROM Evaluaciones eva
	RIGHT JOIN Materias as ma ON (eva.txtCodMateria = ma.txtCodigo)
	Group BY eva.txtCodMateria, ma.txtNombre

--8. Seleccionar el promedio de notas por cada docente de la base de datos.
	SELECT d.txtCodigo, d.txtNombre, AVG(eva.bytNota) as "Promedio de notas por docente"
	FROM Evaluaciones eva
	RIGHT JOIN Docentes as d ON (eva.txtCodDocente = d.txtCodigo)
	Group BY d.txtCodigo, d.txtNombre

--9. Seleccionar la cantidad de evaluaciones por cada docente de la base de datos.
	SELECT d.txtCodigo, d.txtNombre, Count(eva.txtCodEstudiante) as "Numero de evaluaciones"
	FROM Evaluaciones eva
	RIGHT JOIN Docentes as d ON (eva.txtCodDocente = d.txtCodigo)
	Group BY d.txtCodigo, d.txtNombre


--10. Seleccionar el promedio de notas por cada materia y docente de la base de datos.
	SELECT ma.txtNombre AS "Nombre de la Materia", d.txtNombre AS "Nombre del Docente", AVG(eva.bytNota) AS "Promedio de Notas"
	FROM Evaluaciones eva
	RIGHT JOIN Docentes as d ON (eva.txtCodDocente = d.txtCodigo)
	RIGHT JOIN Materias as ma ON (eva.txtCodMateria = ma.txtCodigo)
	Group BY ma.txtNombre, d.txtNombre


--11. Seleccionar la cantidad de evaluaciones por cada materia y docente de la base de datos.
	SELECT ma.txtNombre AS "Nombre de la Materia", d.txtNombre AS "Nombre del Docente", count(eva.bytNota) AS "Cantidad de Evaluaciones"
	FROM Evaluaciones eva
	RIGHT JOIN Docentes as d ON (eva.txtCodDocente = d.txtCodigo)
	RIGHT JOIN Materias as ma ON (eva.txtCodMateria = ma.txtCodigo)
	Group BY ma.txtNombre, d.txtNombre

--12. Seleccionar los estudiantes que tengan un promedio entre X y Y valores.
	SELECT ma.txtNombre AS "Nombre de la Materia", d.txtNombre AS "Nombre del Docente", AVG(eva.bytNota) AS "Promedio de Notas"
	FROM Evaluaciones eva
	RIGHT JOIN Docentes as d ON (eva.txtCodDocente = d.txtCodigo)
	RIGHT JOIN Materias as ma ON (eva.txtCodMateria = ma.txtCodigo)
	Group BY ma.txtNombre, d.txtNombre

--13. Seleccionar los 10 mejores estudiantes según el promedio de notas.
	SELECT TOP 10 txtCodEstudiante, txtNombre, AVG(bytNota) as "Promedio Notas"
	FROM Evaluaciones eva
	JOIN Estudiantes es On es.txtCodigo = eva.txtCodEstudiante
	Group BY txtCodEstudiante,txtNombre
	Order by AVG(eva.bytNota) Desc

--14. Seleccionar los estudiantes que tengan el mayor promedio del curso.
	SELECT eva.txtCodEstudiante as CodEstudiante, es.txtNombre as Nombre, AVG(eva.bytNota) AS "Promedio Nota"
	FROM Estudiantes es
	INNER JOIN Evaluaciones eva ON es.txtCodigo = eva.txtCodEstudiante
	GROUP BY eva.txtCodEstudiante, es.txtNombre
	HAVING AVG(eva.bytNota) = (
		SELECT MAX(avgNota)
		FROM (
			SELECT AVG(bytNota) AS avgNota
			FROM Evaluaciones
			GROUP BY txtCodEstudiante
		) AS subquery
	);

--15. Seleccionar los estudiantes que tengan el promedio mayor o igual al promedio de todos los estudiantes
	SELECT  txtCodEstudiante as CodEstudiante, txtNombre as Nombre, AVG(bytNota) as Promedio
	FROM Evaluaciones eva
	JOIN Estudiantes es On es.txtCodigo = eva.txtCodEstudiante
	Group BY txtCodEstudiante,txtNombre
	HAVING AVG(bytNota) >= 
		(
			SELECT AVG(AvgNotaEstudiante) AS "Promedio del Promedio"
			FROM (
				SELECT AVG(bytNota) AS AvgNotaEstudiante
				FROM Evaluaciones
				GROUP BY txtCodEstudiante
			) AS SubqueryEstudiantes
		)

--16. Seleccionar por cada estudiante el código, nombre, su promedio, promedio general del curso y diferencia entre 
--el promedio del curso con su promedio.
	SELECT
		txtCodEstudiante as CodEstu, txtNombre as Nombre, AVG(bytNota) AS Promedio,
		PromediodelPromedio.[Promedio del Curso] AS "Promedio del curso",
		AVG(bytNota) - PromediodelPromedio.[Promedio del Curso] AS Diferencia
	FROM
		Evaluaciones eva
	JOIN
		Estudiantes es ON es.txtCodigo = eva.txtCodEstudiante
	CROSS JOIN (
		SELECT AVG(AvgNotaEstudiante) AS [Promedio del Curso]
		FROM (
			SELECT AVG(bytNota) AS AvgNotaEstudiante
			FROM Evaluaciones
			GROUP BY txtCodEstudiante
		) AS SubqueryEstudiantes
	) AS PromediodelPromedio
	GROUP BY txtCodEstudiante, txtNombre,PromediodelPromedio.[Promedio del Curso];

--17. Seleccionar los estudiantes que tengan un promedio mayor o igual al promedio de los estudiantes de su mismo sexo.
	WITH PromedioPorSexo AS (
    SELECT
        txtSexo,
        AVG(bytTotal) AS AvgNotaEstudiante
    FROM
        Evaluaciones
    INNER JOIN Estudiantes es ON es.txtCodigo = txtCodEstudiante
    GROUP BY
        txtSexo
)

SELECT es.txtCodigo AS CodEstu, es.txtNombre AS Nombre, es.txtSexo AS Sexo, eva.bytTotal AS Total
FROM Estudiantes es
INNER JOIN Evaluaciones eva ON es.txtCodigo = eva.txtCodEstudiante
INNER JOIN PromedioPorSexo ps ON es.txtSexo = ps.txtSexo
WHERE eva.bytTotal >= ps.AvgNotaEstudiante;


--18. Seleccionar los estudiantes que se hayan evaluado en una cantidad de materias determinada.
	SELECT txtCodEstudiante as CodEstu, txtNombre as Nombre, count(txtCodMateria) as "Numero de materias"
	FROM Evaluaciones as eva
	JOIN Estudiantes as es ON eva.txtCodEstudiante = es.txtCodigo
	Group by txtCodEstudiante,txtNombre
	Having count(txtCodMateria) >= 2

--19. Seleccionar los estudiantes que se hayan evaluado en todas las materias registradas.
	SELECT eva.txtCodEstudiante AS CodEstu, es.txtNombre AS Nombre
	FROM Evaluaciones eva
	INNER JOIN Estudiantes es ON eva.txtCodEstudiante = es.txtCodigo
	GROUP BY eva.txtCodEstudiante, es.txtNombre
	HAVING 	COUNT(DISTINCT eva.txtCodMateria) = (SELECT COUNT(*) FROM Materias);
			
--20. Seleccionar a todos los estudiantes de la base de datos y por cada uno de ellos mostrar la cantidad de materias aprobadas.
	SELECT txtCodEstudiante as CodEstu, txtNombre as Nombre, count(txtCodMateria) "Cantidad de materias aprobadas"
	FROM Evaluaciones as eva
	RIGHT JOIN Estudiantes as es ON eva.txtCodEstudiante = es.txtCodigo
	Group by txtCodEstudiante,txtNombre,txtEquivalencia
	Having txtEquivalencia = 'A'

--21. Seleccionar los estudiantes que tengan aprobadas todas las materias registradas.
WITH EstudiantesRep AS (
    SELECT txtCodEstudiante
    FROM Evaluaciones
    WHERE txtEquivalencia = 'R'
    GROUP BY txtCodEstudiante
)

SELECT es.txtCodigo AS CodigoEstudiante, es.txtNombre AS NombreEstudiante
FROM Estudiantes es
INNER JOIN Evaluaciones eva on es.txtCodigo = eva.txtCodEstudiante
WHERE es.txtCodigo NOT IN (SELECT txtCodEstudiante FROM EstudiantesRep)
GROUP BY es.txtCodigo, es.txtNombre;

--22. Seleccionar las materias en las que se han evaluado al menos el 50% de los estudiantes.
	SELECT txtCodigo as CodMateria, txtNombre AS "Nombre de la Materia"
	FROM
		Materias as m
		JOIN Evaluaciones as eva ON(m.txtCodigo = eva.txtCodMateria)

	Group By txtCodigo,txtNombre,txtCodEstudiante
	Having count(txtCodEstudiante) >= 
		(SELECT count(txtCodigo)*0.5
		FROM Estudiantes
		) 

--23. Seleccionar por cada materia el mejor estudiante.
	SELECT m.txtNombre AS NombreMateria, ES.txtCodigo AS CodEstu, ES.txtNombre AS NombreEstu, eva.bytTotal AS PuntuacionTotal
	FROM Materias m
	JOIN Evaluaciones eva ON m.txtCodigo = eva.txtCodMateria
	JOIN Estudiantes es ON eva.txtCodEstudiante = ES.txtCodigo
	WHERE eva.bytTotal = (
					SELECT MAX(eva2.bytTotal)
					FROM Evaluaciones eva2
					WHERE eva2.txtCodMateria = m.txtCodigo)

--24. Seleccionar por cada materia la cantidad de estudiantes aprobados y reprobados.
	SELECT 
		M.txtCodigo AS CodMateria,
		M.txtNombre AS NombreMateria,
		SUM(CASE WHEN eva.txtEquivalencia = 'A' OR eva.txtEquivalencia = 'E'  THEN 1 ELSE 0 END) AS Aprobados,
		SUM(CASE WHEN eva.txtEquivalencia = 'R' THEN 1 ELSE 0 END) AS Reprobados
	FROM Evaluaciones eva
	JOIN Materias M ON eva.txtCodMateria = M.txtCodigo
	JOIN Estudiantes E ON eva.txtCodEstudiante = E.txtCodigo
	GROUP BY M.txtCodigo, M.txtNombre;

--25. Seleccionar los docentes que han evaluado en todas las materias.
	SELECT eva.txtCodDocente AS CodDocente, d.txtNombre AS "Nombre del Docente"
	FROM Evaluaciones eva 
	INNER JOIN Docentes d ON eva.txtCodDocente = d.txtCodigo
	GROUP BY eva.txtCodDocente, d.txtNombre
	HAVING COUNT(DISTINCT eva.txtCodMateria) = (SELECT COUNT(*) FROM Materias);

--26. Seleccionar por cada categoría de docente el promedio de notas en las evaluaciones.
	SELECT d.txtCategoria AS CategoriaDocente, AVG(eva.bytNota) AS "Promedio de Notas"
	FROM Docentes d
	JOIN Evaluaciones eva ON d.txtCodigo = eva.txtCodDocente
	GROUP BY d.txtCategoria;

--27. Seleccionar el profesor con mejor promedio por cada categoría.
WITH PromedioPorProfesor AS (
    SELECT 
        d.txtCodigo AS CodProfesor,
        d.txtNombre AS NombreProfesor,
        d.txtCategoria AS Categoria,
        AVG(eva.bytTotal) AS PromedioCalificacion
    FROM 
        Docentes d
    JOIN 
        Evaluaciones eva ON d.txtCodigo = eva.txtCodDocente
    GROUP BY 
        d.txtCodigo, d.txtNombre, d.txtCategoria
)

SELECT Categoria, CodProfesor, NombreProfesor, PromedioCalificacion
FROM PromedioPorProfesor pp1
WHERE PromedioCalificacion = (
        SELECT MAX(pp2.PromedioCalificacion)
        FROM PromedioPorProfesor pp2
        WHERE pp2.Categoria = pp1.Categoria
    );

--28. Devolver los profesores que han evaluado a todos los estudiantes que tienen más de 2 años de antigüedad.
	SELECT txtCodDocente as CodDodcente,txtNombre as Nombre
	FROM Evaluaciones as eva
	JOIN Docentes as d ON(eva.txtCodDocente = d.txtCodigo)
	WHERE (d.dtFecha_Ingreso - GETDATE()) >= 2
	Group by txtCodDocente,txtNombre,txtCodEstudiante
	HAVING count(txtCodEstudiante) = 
				(
					SELECT count(DISTINCT(txtCodEstudiante))
					FROM Evaluaciones
				) 

--29. Utilizando la función “EXISTS” devolver los profesores con registro de calificaciones en una materia determinada.
	SELECT txtCodigo, txtNombre
	FROM Docentes d
	WHERE EXISTS 
				(
					SELECT *
					FROM Evaluaciones eva
					WHERE d.txtCodigo = eva.txtCodDocente and eva.txtCodMateria = 'SOFI1'
				)


--30. Construya un único conjunto de datos que devuelva:
--i. Código de cada estudiante, código de cada materia y la nota total
--correspondiente.
--ii. Por cada estudiante su promedio de notas.
--iii. El promedio general de todas las evaluaciones.
	Select txtCodEstudiante As CodEstu, txtCodMateria as CodMateria, bytTotal as Total, AVG(bytNota)as "Promedio de notas", 
		(SELECT AVG(bytTotal)
		 FROM Evaluaciones 
		)as "Promedio general de las evaluaciones"
	FROM Evaluaciones
	Group by txtCodEstudiante, txtCodMateria, bytTotal;

--31. Construya un único conjunto de datos que devuelva:
--i. Código de cada estudiante, código de cada materia y la nota total correspondiente
--ii. Por cada estudiante su promedio de notas.
	WITH PromNotaPorEstudiante AS (
		SELECT eva.txtCodEstudiante as CodEstu, AVG(eva.bytNota) as Promedio
		FROM Evaluaciones eva
		GROUP BY eva.txtCodEstudiante
	),

--iii. Por cada materia su promedio de notas.
	 PromNotaPorMateria AS (
		SELECT eva.txtCodMateria as CodMateria, AVG(eva.bytNota) as Promedio
		FROM Evaluaciones eva
		GROUP BY eva.txtCodMateria
	),

--iv. El promedio general de todas las evaluaciones.
	PromGeneral AS (
		SELECT AVG(eva.bytNota) as Promedio
		FROM Evaluaciones eva
	)

	SELECT 
		eva.txtCodEstudiante as CodEstu, 
		eva.txtCodMateria as CodMateria, 
		eva.bytTotal as Total,
		p2.Promedio as "Promedio Estudiante",
		p3.Promedio as "Promedio Materia",
		(SELECT Promedio FROM PromGeneral) as "Promedio General"
	FROM Evaluaciones eva
	INNER JOIN PromNotaPorEstudiante p2 
	ON eva.txtCodEstudiante = p2.CodEstu
	INNER JOIN PromNotaPorMateria p3
	ON eva.txtCodMateria = p3.CodMateria;

--32. Similar al 30 agregando las columnas que distingan los valores de detalle y de resumen
	Select txtCodEstudiante as CodEstu,GROUPING(txtCodEstudiante), txtCodMateria as CodMateria, GROUPING(txtCodMateria), bytTotal as Total, AVG(bytNota) as "Promedio de notas", 
		(SELECT AVG(bytTotal)
		 FROM Evaluaciones 
		) as "Promedio general de las evaluaciones"
	FROM Evaluaciones
	Group by txtCodEstudiante, txtCodMateria, bytTotal
	WITH CUBE
	Order by txtCodEstudiante,txtCodMateria,bytTotal


--33. Similar al 31 agregando las columnas que distingan los valores de detalle y de resumen.
With PromGeneral AS (
	SELECT AVG(eva.bytNota) as Promedio
	FROM Evaluaciones eva
)

	SELECT 
		eva.txtCodEstudiante as CodEstudiante, 
		eva.txtCodMateria as CodMateria, 
		eva.bytTotal as Total,
		AVG(eva.bytNota) OVER (PARTITION BY eva.txtCodEstudiante) AS "Promedio Estudiante",
		AVG(eva.bytNota) OVER (PARTITION BY eva.txtCodMateria) as "Promedio Materia",
		(SELECT Promedio FROM PromGeneral)as "Promedio General"
	FROM Evaluaciones eva
	GROUP BY eva.txtCodEstudiante, eva.txtCodMateria, eva.bytTotal, eva.bytNota
	WITH CUBE
	ORDER BY eva.txtCodEstudiante, eva.txtCodMateria

