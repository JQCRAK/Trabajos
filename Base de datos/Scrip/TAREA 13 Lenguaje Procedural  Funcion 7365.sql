--	     Lenguaje Procedural - Funci�n
--Nombre: Jhostin Quispe 
--Codigo: 7365

USE [Taller 1 ]
GO

-- FUNCION PARA CALCULAR LA TASA DE APROBACION DE UNA MATERIA EN UN PERIODO ESPECIFICO
CREATE FUNCTION dbo.CalcularTasaAprobacionMateria(@cod_materia VARCHAR(10), @cod_periodo VARCHAR(10))
RETURNS DECIMAL(5,2)
AS
BEGIN
    DECLARE @tasa_aprobacion DECIMAL(5,2)
    DECLARE @total_estudiantes INT
    DECLARE @estudiantes_aprobados INT

    SELECT @total_estudiantes = COUNT(DISTINCT cod_estudiante)
    FROM dbo.matricula
    WHERE cod_materia = @cod_materia AND cod_periodo = @cod_periodo

    SELECT @estudiantes_aprobados = COUNT(DISTINCT cod_estudiante)
    FROM dbo.evaluacion
    WHERE cod_materia = @cod_materia AND cod_periodo = @cod_periodo
      AND estado = 'EE1' -- Asumiendo que 'EE1' es el codigo para "Aprobado"

    IF @total_estudiantes > 0
        SET @tasa_aprobacion = (@estudiantes_aprobados * 100.0) / @total_estudiantes
    ELSE
        SET @tasa_aprobacion = 0

    RETURN @tasa_aprobacion
END
GO

-- Para usar la funci�n:
SELECT dbo.CalcularTasaAprobacionMateria('SOFIB01', 'PS20') AS TasaAprobacion

GO

-- PROCEDIMIENTO PARA LISTAR ESTUDIANTES CON RIESGO ACADEMICO
CREATE PROCEDURE dbo.usp_ListarEstudiantesEnRiesgo
    @cod_periodo VARCHAR(10),
    @umbral_reprobacion INT = 2
AS
BEGIN
    SELECT e.cod_estudiante, e.nombre + ' ' + e.apellido AS nombre_completo,
        COUNT(DISTINCT ev.cod_materia) AS materias_reprobadas
    FROM dbo.estudiante e
    INNER JOIN dbo.evaluacion ev ON e.cod_estudiante = ev.cod_estudiante
    WHERE ev.cod_periodo = @cod_periodo
        AND ev.estado IN ('EE2', 'EE3') -- Asumiendo que estos son los codigos para "Desaprobado" y "Suspenso"
    GROUP BY e.cod_estudiante, e.nombre, e.apellido
    HAVING COUNT(DISTINCT ev.cod_materia) >= @umbral_reprobacion
    ORDER BY materias_reprobadas DESC
END
GO

-- Para ejecutar el procedimiento:
EXEC dbo.usp_ListarEstudiantesEnRiesgo @cod_periodo = 'PS20', @umbral_reprobacion = 2