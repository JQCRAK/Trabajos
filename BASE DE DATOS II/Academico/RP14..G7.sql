--TRABAJO GRUPAL Grupo 07
--Angel Guaño 7337
--Jhostin Quispe 7365
--Franklin Acero 7402
--Jairo Anilema 7241
--Samuel Yambay 7065

--Ejercicio 4 Recuperación de datos


--1. Seleccionar los estudiantes de un sexo dado ordenados por el nombre.
CREATE PROCEDURE sp_EstudiantesPorSexo(@Sexo CHAR(1))
AS
BEGIN
    SELECT *
    FROM Estudiantes
    WHERE txtSexo = @Sexo
    ORDER BY txtNombre;
END;
GO
-- Ejecucion:
EXEC sp_EstudiantesPorSexo 'M'; -- Cambia 'M' por 'F' segun el sexo (Masculino, Femenino)

--2. Seleccionar las evaluaciones con las materias de los estudiantes de un sexo dado.
CREATE PROCEDURE sp_EvaluacionesPorSexo(@Sexo CHAR(1))
AS
BEGIN
    SELECT E.txtCodigo AS Estudiante, M.txtNombre AS Materia, Ev.bytNota, Ev.bytTotal
    FROM Estudiantes E
    JOIN Evaluaciones Ev ON E.txtCodigo = Ev.txtCodEstudiante
    JOIN Materias M ON Ev.txtCodMateria = M.txtCodigo
    WHERE E.txtSexo = @Sexo;
END;
GO
-- Ejecucion:
EXEC sp_EvaluacionesPorSexo 'M';

--3. Seleccionar las evaluaciones de un estudiante dado con los datos de los docentes.
CREATE PROCEDURE sp_evaluaciones_estudiante_docentes
    @codigo_estudiante VARCHAR(10)
AS
BEGIN
    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        ev.txtCodMateria,
        m.txtNombre AS NombreMateria,
        ev.bytNota,
        d.txtCodigo AS CodigoDocente,
        d.txtNombre AS NombreDocente
    FROM Evaluaciones ev
    JOIN Estudiantes e ON ev.txtCodEstudiante = e.txtCodigo
    JOIN Materias m ON ev.txtCodMateria = m.txtCodigo
    JOIN Docentes d ON ev.txtCodDocente = d.txtCodigo
    WHERE e.txtCodigo = @codigo_estudiante
END
GO

--4. Seleccionar el promedio de notas del curso.
CREATE FUNCTION fn_promedio_notas_curso()
RETURNS DECIMAL(5,2)
AS
BEGIN
    RETURN (
        SELECT AVG(CAST(bytNota AS DECIMAL(5,2))) 
        FROM Evaluaciones
    )
END
GO

--5. Seleccionar el promedio de notas de los estudiantes de un sexo dado.
CREATE FUNCTION fn_promedio_notas_por_sexo(@sexo CHAR(1))
RETURNS DECIMAL(5,2)
AS
BEGIN
    RETURN (
        SELECT AVG(CAST(ev.bytNota AS DECIMAL(5,2)))
        FROM Evaluaciones ev
        JOIN Estudiantes e ON ev.txtCodEstudiante = e.txtCodigo
        WHERE e.txtSexo = @sexo
    )
END
GO

--6. Seleccionar el promedio de notas por cada estudiante.
CREATE VIEW vw_promedio_notas_estudiante
AS
SELECT 
    e.txtCodigo AS CodigoEstudiante,
    e.txtNombre AS NombreEstudiante,
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
FROM Estudiantes e
JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
GROUP BY e.txtCodigo, e.txtNombre
GO

--7. Seleccionar la cantidad de evaluaciones por cada estudiante.
CREATE VIEW vw_cantidad_evaluaciones_estudiante
AS
SELECT 
    e.txtCodigo AS CodigoEstudiante,
    e.txtNombre AS NombreEstudiante,
    COUNT(ev.txtCodMateria) AS CantidadEvaluaciones
FROM Estudiantes e
LEFT JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
GROUP BY e.txtCodigo, e.txtNombre
GO

--8. Seleccionar el promedio de notas por cada materia.
CREATE VIEW vw_promedio_notas_materia
AS
SELECT 
    m.txtCodigo AS CodigoMateria,
    m.txtNombre AS NombreMateria,
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
FROM Materias m
JOIN Evaluaciones ev ON m.txtCodigo = ev.txtCodMateria
GROUP BY m.txtCodigo, m.txtNombre
GO

--9. Seleccionar la cantidad de evaluaciones por cada materia.
CREATE VIEW vw_cantidad_evaluaciones_materia
AS
SELECT 
    m.txtCodigo AS CodigoMateria,
    m.txtNombre AS NombreMateria,
    COUNT(ev.txtCodEstudiante) AS CantidadEvaluaciones
FROM Materias m
LEFT JOIN Evaluaciones ev ON m.txtCodigo = ev.txtCodMateria
GROUP BY m.txtCodigo, m.txtNombre
GO

--10. Seleccionar el promedio de notas por cada docente.
CREATE VIEW vw_promedio_notas_docente
AS
SELECT 
    d.txtCodigo AS CodigoDocente,
    d.txtNombre AS NombreDocente,
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
FROM Docentes d
JOIN Evaluaciones ev ON d.txtCodigo = ev.txtCodDocente
GROUP BY d.txtCodigo, d.txtNombre
GO

--11. Seleccionar la cantidad de evaluaciones por cada docente.
CREATE VIEW vw_cantidad_evaluaciones_docente
AS
SELECT 
    d.txtCodigo AS CodigoDocente,
    d.txtNombre AS NombreDocente,
    COUNT(ev.txtCodEstudiante) AS CantidadEvaluaciones
FROM Docentes d
LEFT JOIN Evaluaciones ev ON d.txtCodigo = ev.txtCodDocente
GROUP BY d.txtCodigo, d.txtNombre
GO

--12. Devolver el estudiante, la materia y el docente que tengan el mejor promedio en las evaluaciones.
CREATE FUNCTION fn_mejor_promedio()
RETURNS TABLE
AS
RETURN (
    SELECT TOP 1
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        m.txtCodigo AS CodigoMateria,
        m.txtNombre AS NombreMateria,
        d.txtCodigo AS CodigoDocente,
        d.txtNombre AS NombreDocente,
        AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
    FROM Evaluaciones ev
    JOIN Estudiantes e ON ev.txtCodEstudiante = e.txtCodigo
    JOIN Materias m ON ev.txtCodMateria = m.txtCodigo
    JOIN Docentes d ON ev.txtCodDocente = d.txtCodigo
    GROUP BY 
        e.txtCodigo, e.txtNombre, 
        m.txtCodigo, m.txtNombre,
        d.txtCodigo, d.txtNombre
    ORDER BY PromedioNotas DESC
)
GO

--13. Seleccionar los estudiantes que tengan un promedio mayor o igual al promedio de todos los estudiantes.
CREATE VIEW vw_estudiantes_sobre_promedio
AS
WITH PromedioGeneral AS (
    SELECT AVG(CAST(bytNota AS DECIMAL(5,2))) AS PromGeneral
    FROM Evaluaciones
)
SELECT 
    e.txtCodigo AS CodigoEstudiante,
    e.txtNombre AS NombreEstudiante,
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
FROM Estudiantes e
JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
GROUP BY e.txtCodigo, e.txtNombre
HAVING AVG(CAST(ev.bytNota AS DECIMAL(5,2))) >= (SELECT PromGeneral FROM PromedioGeneral)
GO

--14. Seleccionar los estudiantes de un sexo dado que tengan un promedio mayor o igual al promedio de todos los estudiantes.
CREATE VIEW vw_estudiantes_sexo_sobre_promedio
AS
WITH PromedioGeneral AS (
    SELECT AVG(CAST(bytNota AS DECIMAL(5,2))) AS PromGeneral
    FROM Evaluaciones
)
SELECT 
    e.txtCodigo AS CodigoEstudiante,
    e.txtNombre AS NombreEstudiante,
    e.txtSexo,
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioNotas
FROM Estudiantes e
JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
GROUP BY e.txtCodigo, e.txtNombre, e.txtSexo
HAVING 
    AVG(CAST(ev.bytNota AS DECIMAL(5,2))) >= (SELECT PromGeneral FROM PromedioGeneral)
GO

--15. Seleccionar los estudiantes que tengan un promedio mayor o igual al promedio de los estudiantes de su mismo sexo.
CREATE PROCEDURE sp_EstudiantesSobrePromedioSexo
AS
BEGIN
    -- Calcular promedio por sexo
    WITH PromediosPorSexo AS (
        SELECT 
            e.txtSexo,
            AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioSexo
        FROM Estudiantes e
        JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
        GROUP BY e.txtSexo
    ),
    PromediosEstudiantes AS (
        SELECT 
            e.txtCodigo AS CodigoEstudiante,
            e.txtNombre AS NombreEstudiante,
            e.txtSexo,
            AVG(CAST(ev.bytNota AS DECIMAL(5,2))) AS PromedioEstudiante,
            pps.PromedioSexo
        FROM Estudiantes e
        JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
        JOIN PromediosPorSexo pps ON e.txtSexo = pps.txtSexo
        GROUP BY 
            e.txtCodigo, 
            e.txtNombre, 
            e.txtSexo, 
            pps.PromedioSexo
    )
    SELECT 
        CodigoEstudiante,
        NombreEstudiante,
        txtSexo,
        ROUND(PromedioEstudiante, 2) AS PromedioEstudiante,
        ROUND(PromedioSexo, 2) AS PromedioSexo
    FROM PromediosEstudiantes
    WHERE PromedioEstudiante >= PromedioSexo
    ORDER BY PromedioEstudiante DESC
END
GO
EXEC sp_EstudiantesSobrePromedioSexo;
--16. Seleccionar los estudiantes que tengan un promedio entre X y Y valores.
CREATE PROCEDURE sp_EstudiantesPorRangoPromedio
    @PromedioMinimo DECIMAL(5,2),
    @PromedioMaximo DECIMAL(5,2)
AS
BEGIN
    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        ROUND(AVG(CAST(ev.bytNota AS DECIMAL(5,2))), 2) AS PromedioNotas
    FROM Estudiantes e
    JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
    GROUP BY e.txtCodigo, e.txtNombre
    HAVING 
        AVG(CAST(ev.bytNota AS DECIMAL(5,2))) BETWEEN @PromedioMinimo AND @PromedioMaximo
    ORDER BY PromedioNotas DESC
END
GO
EXEC sp_EstudiantesPorRangoPromedio 7.0, 8.5;

--17. Seleccionar los estudiantes que tengan evaluaciones en todas las materias registradas.
CREATE PROCEDURE sp_EstudiantesEnTodasMaterias
AS
BEGIN
    DECLARE @TotalMaterias INT
    SELECT @TotalMaterias = COUNT(*) FROM Materias

    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        COUNT(DISTINCT ev.txtCodMateria) AS CantidadMaterias
    FROM Estudiantes e
    JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
    GROUP BY e.txtCodigo, e.txtNombre
    HAVING COUNT(DISTINCT ev.txtCodMateria) = @TotalMaterias
END
GO
EXEC sp_EstudiantesEnTodasMaterias;
--18. Seleccionar los estudiantes que tengan evaluación en una materia dada.
CREATE PROCEDURE sp_EstudiantesEnMateria
    @CodigoMateria VARCHAR(10)
AS
BEGIN
    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        m.txtNombre AS NombreMateria,
        ev.bytNota AS Nota
    FROM Estudiantes e
    JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
    JOIN Materias m ON ev.txtCodMateria = m.txtCodigo
    WHERE m.txtCodigo = @CodigoMateria
END
GO
EXEC sp_EstudiantesEnMateria 'SOFI7';

--19. Seleccionar los estudiantes que tengan aprobado todas las materias registradas.
CREATE PROCEDURE sp_EstudiantesAprobados
    @NotaAprobacion INT = 70
AS
BEGIN
    DECLARE @TotalMaterias INT
    SELECT @TotalMaterias = COUNT(*) FROM Materias

    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        ROUND(AVG(CAST(ev.bytNota AS DECIMAL(5,2))), 2) AS PromedioGeneral
    FROM Estudiantes e
    JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
    GROUP BY e.txtCodigo, e.txtNombre
    HAVING 
        COUNT(DISTINCT CASE WHEN ev.bytNota >= @NotaAprobacion THEN ev.txtCodMateria END) = @TotalMaterias
END
GO
EXEC sp_EstudiantesAprobados;
--20. Seleccionar las materias en las que se han evaluado al menos un porciento dado de los estudiantes registrados.
CREATE PROCEDURE sp_MateriasConPorcentajeEstudiantes
    @PorcentajeMinimo DECIMAL(5,2)
AS
BEGIN
    DECLARE @TotalEstudiantes INT
    SELECT @TotalEstudiantes = COUNT(*) FROM Estudiantes

    SELECT 
        m.txtCodigo AS CodigoMateria,
        m.txtNombre AS NombreMateria,
        COUNT(DISTINCT ev.txtCodEstudiante) AS CantidadEstudiantes,
        @TotalEstudiantes AS TotalEstudiantes,
        ROUND(COUNT(DISTINCT ev.txtCodEstudiante) * 100.0 / @TotalEstudiantes, 2) AS PorcentajeEstudiantes
    FROM Materias m
    JOIN Evaluaciones ev ON m.txtCodigo = ev.txtCodMateria
    GROUP BY m.txtCodigo, m.txtNombre
    HAVING 
        COUNT(DISTINCT ev.txtCodEstudiante) * 100.0 / @TotalEstudiantes >= @PorcentajeMinimo
END
GO
EXEC sp_MateriasConPorcentajeEstudiantes 50.0;

--21. Devolver las evaluaciones de un estudiante dado incluyendo: materia, docente, notas, equivalencia y asistencia.
CREATE PROCEDURE sp_EvaluacionesCompletasEstudiante1
    @CodigoEstudiante VARCHAR(10)
AS
BEGIN
    SELECT 
        e.txtCodigo AS CodigoEstudiante,
        e.txtNombre AS NombreEstudiante,
        m.txtNombre AS NombreMateria,
        d.txtNombre AS NombreDocente,
        ev.bytNota AS Nota,
        ev.txtEquivalencia AS Equivalencia,
        ev.bytAsistencia AS Asistencia
    FROM Evaluaciones ev
    JOIN Estudiantes e ON ev.txtCodEstudiante = e.txtCodigo
    JOIN Materias m ON ev.txtCodMateria = m.txtCodigo
    JOIN Docentes d ON ev.txtCodDocente = d.txtCodigo
    WHERE e.txtCodigo = @CodigoEstudiante
END
GO
EXEC sp_EvaluacionesCompletasEstudiante1 '7301';

--22. Insertar estudiantes, materias, docentes y evaluaciones. (un objeto para cada caso)
-- Insertar Estudiante
CREATE PROCEDURE sp_InsertarEstudiante
    @Codigo VARCHAR(10),
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(200),
    @Telefono VARCHAR(20),
    @FechaNacimiento DATE,
    @FechaIngreso DATE,
    @Sexo CHAR(1)
AS
BEGIN
    INSERT INTO Estudiantes (
        txtCodigo, txtCedula, txtNombre, txtDireccion, 
        txtTelefono, dtFecha_Nacimiento, dtFecha_Ingreso, txtSexo
    ) VALUES (
        @Codigo, @Cedula, @Nombre, @Direccion, 
        @Telefono, @FechaNacimiento, @FechaIngreso, @Sexo
    )
END
GO

-- Insertar Materia
CREATE PROCEDURE sp_InsertarMateria
    @Codigo VARCHAR(10),
    @Nombre VARCHAR(100)
AS
BEGIN
    INSERT INTO Materias (txtCodigo, txtNombre)
    VALUES (@Codigo, @Nombre)
END
GO

-- Insertar Docente
CREATE PROCEDURE sp_InsertarDocente
    @Codigo VARCHAR(10),
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(200),
    @Telefono VARCHAR(20),
    @FechaNacimiento DATE,
    @FechaIngreso DATE,
    @Sexo CHAR(1),
    @Categoria VARCHAR(50),
    @Salario DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Docentes (
        txtCodigo, txtCedula, txtNombre, txtDireccion, 
        txtTelefono, dtFecha_Nacimiento, dtFecha_Ingreso, 
        txtSexo, txtCategoria, mnSalario
    ) VALUES (
        @Codigo, @Cedula, @Nombre, @Direccion, 
        @Telefono, @FechaNacimiento, @FechaIngreso, 
        @Sexo, @Categoria, @Salario
    )
END
GO

-- Insertar Evaluación
CREATE PROCEDURE sp_InsertarEvaluacion
    @CodigoEstudiante VARCHAR(10),
    @CodigoMateria VARCHAR(10),
    @CodigoDocente VARCHAR(10),
    @Acumulado TINYINT,
    @Nota TINYINT,
    @Total TINYINT,
    @Asistencia TINYINT,
    @Equivalencia VARCHAR(10)
AS
BEGIN
    INSERT INTO Evaluaciones (
        txtCodEstudiante, txtCodMateria, txtCodDocente,
        bytAcumulado, bytNota, bytTotal, 
        bytAsistencia, txtEquivalencia
    ) VALUES (
        @CodigoEstudiante, @CodigoMateria, @CodigoDocente,
        @Acumulado, @Nota, @Total, 
        @Asistencia, @Equivalencia
    )
END
GO

--23. Eliminar estudiantes, materias, docentes y evaluaciones. (un objeto para cada caso)
-- Eliminar Estudiante
CREATE PROCEDURE sp_EliminarEstudiante
    @Codigo VARCHAR(10)
AS
BEGIN
    DELETE FROM Evaluaciones WHERE txtCodEstudiante = @Codigo
    DELETE FROM Estudiantes WHERE txtCodigo = @Codigo
END
GO

-- Eliminar Materia
CREATE PROCEDURE sp_EliminarMateria
    @Codigo VARCHAR(10)
AS
BEGIN
    DELETE FROM Evaluaciones WHERE txtCodMateria = @Codigo
    DELETE FROM Materias WHERE txtCodigo = @Codigo
END
GO

-- Eliminar Docente
CREATE PROCEDURE sp_EliminarDocente
    @Codigo VARCHAR(10)
AS
BEGIN
    DELETE FROM Evaluaciones WHERE txtCodDocente = @Codigo
    DELETE FROM Docentes WHERE txtCodigo = @Codigo
END
GO

-- Eliminar Evaluación
CREATE PROCEDURE sp_EliminarEvaluacion
    @CodigoEstudiante VARCHAR(10),
    @CodigoMateria VARCHAR(10)
AS
BEGIN
    DELETE FROM Evaluaciones 
    WHERE txtCodEstudiante = @CodigoEstudiante 
    AND txtCodMateria = @CodigoMateria
END
GO

--24. Actualizar estudiantes, materias, docentes y evaluaciones. (un objeto para cada caso)
CREATE PROCEDURE sp_ActualizarEstudiante
    @Codigo VARCHAR(10),
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(200),
    @Telefono VARCHAR(20),
    @FechaNacimiento DATE,
    @FechaIngreso DATE,
    @Sexo CHAR(1)
AS
BEGIN
    UPDATE Estudiantes
    SET 
        txtNombre = @Nombre,
        txtDireccion = @Direccion,
        txtTelefono = @Telefono,
        dtFecha_Nacimiento = @FechaNacimiento,
        dtFecha_Ingreso = @FechaIngreso,
        txtSexo = @Sexo
    WHERE txtCodigo = @Codigo;
END;
GO

CREATE PROCEDURE sp_ActualizarMateria
    @Codigo VARCHAR(10),
    @Nombre VARCHAR(100)
AS
BEGIN
    UPDATE Materias
    SET txtNombre = @Nombre
    WHERE txtCodigo = @Codigo;
END;
GO
CREATE PROCEDURE sp_ActualizarDocente
    @Codigo VARCHAR(10),
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(200),
    @Telefono VARCHAR(20),
    @FechaNacimiento DATE,
    @FechaIngreso DATE,
    @Sexo CHAR(1),
    @Categoria VARCHAR(50),
    @Salario DECIMAL(10,2)
AS
BEGIN
    UPDATE Docentes
    SET 
        txtNombre = @Nombre,
        txtDireccion = @Direccion,
        txtTelefono = @Telefono,
        dtFecha_Nacimiento = @FechaNacimiento,
        dtFecha_Ingreso = @FechaIngreso,
        txtSexo = @Sexo,
        txtCategoria = @Categoria,
        mnSalario = @Salario
    WHERE txtCodigo = @Codigo;
END;
GO
CREATE PROCEDURE sp_ActualizarEvaluacion
    @CodigoEstudiante VARCHAR(10),
    @CodigoMateria VARCHAR(10),
    @Nota TINYINT,
    @Asistencia TINYINT
AS
BEGIN
    UPDATE Evaluaciones
    SET 
        bytNota = @Nota,
        bytAsistencia = @Asistencia
    WHERE txtCodEstudiante = @CodigoEstudiante AND txtCodMateria = @CodigoMateria;
END;
GO
EXEC sp_ActualizarEstudiante '7301', 'Angel Guaño', 'Riobamba Centro', '123456789', '2004-01-01', '2024-09-01', 'M';


--25. Eliminar las evaluaciones correspondientes a los estudiantes de un sexo dado en una materia dada.
CREATE PROCEDURE sp_EliminarEvaluacionesPorSexo
    @Sexo CHAR(1),
    @CodigoMateria VARCHAR(10)
AS
BEGIN
    DELETE FROM Evaluaciones
    WHERE 
        txtCodEstudiante IN (
            SELECT txtCodigo 
            FROM Estudiantes 
            WHERE txtSexo = @Sexo
        )
        AND txtCodMateria = @CodigoMateria;
END;
GO
EXEC sp_EliminarEvaluacionesPorSexo 'M', 'SOFI7';


--26. Eliminar los estudiantes que tengan aprobado todas las materias registradas.
CREATE PROCEDURE sp_EliminarEstudiantesAprobados
    @NotaAprobacion INT = 70
AS
BEGIN
    DELETE FROM Estudiantes
    WHERE txtCodigo IN (
        SELECT e.txtCodigo
        FROM Estudiantes e
        JOIN Evaluaciones ev ON e.txtCodigo = ev.txtCodEstudiante
        GROUP BY e.txtCodigo
        HAVING 
            COUNT(DISTINCT CASE WHEN ev.bytNota >= @NotaAprobacion THEN ev.txtCodMateria END) = 
            (SELECT COUNT(*) FROM Materias)
    );
END;
GO
EXEC sp_EliminarEstudiantesAprobados;

--27. Incrementar en un porcentaje determinado el salario de los docentes de una categoría específica.
CREATE PROCEDURE sp_IncrementarSalarioDocentes
    @Categoria VARCHAR(50),
    @PorcentajeIncremento DECIMAL(5,2)
AS
BEGIN
    UPDATE Docentes
    SET mnSalario = mnSalario * (1 + @PorcentajeIncremento / 100.0)
    WHERE txtCategoria = @Categoria;
END;
GO
EXEC sp_IncrementarSalarioDocentes 'A', 10;


--28. Hacer un traspaso de los estudiantes aptos para ser egresados (estudiantes que tengan aprobado todas las materias registradas) a una tabla de egresados. 
--La tabla Egresados posee la siguiente estructura: Código y Nombre del estudiante, Fecha de egresamiento y Promedio con el que egresa.

CREATE OR ALTER VIEW VistaEstudiantesAprobados AS
SELECT 
    E.txtCodEstudiante,
    S.txtNombre,
    AVG(CAST(E.bytNota AS FLOAT)) AS Promedio
FROM 
    Evaluaciones E
JOIN 
    Estudiantes S ON E.txtCodEstudiante = S.txtCodigo
WHERE 
    E.bytNota >= 6 -- Nota mínima para aprobar
GROUP BY 
    E.txtCodEstudiante, S.txtNombre
HAVING 
    COUNT(E.txtCodMateria) = (SELECT COUNT(*) FROM Materias); -- Evaluaciones para todas las materias
GO


CREATE OR ALTER FUNCTION ObtenerFechaEgreso()
RETURNS DATE
AS
BEGIN
    RETURN CAST(GETDATE() AS DATE); -- Devuelve la fecha actual como DATE
END
GO


CREATE OR ALTER PROCEDURE TraspasarAegresados
AS
BEGIN
    INSERT INTO Egresados (Codigo, Nombre, Fecha_Egreso, Promedio)
    SELECT 
        txtCodEstudiante,
        txtNombre,
        dbo.ObtenerFechaEgreso(),
        Promedio
    FROM 
        VistaEstudiantesAprobados;
END
GO

CREATE TABLE Egresados (
    Codigo NVARCHAR(20) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Fecha_Egreso DATE NOT NULL,
    Promedio FLOAT NOT NULL
);
GO

EXEC TraspasarAegresados;

