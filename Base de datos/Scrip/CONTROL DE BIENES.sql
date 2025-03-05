Create Table DEPARTAMENTO(
COD_DEPA int PRIMARY KEY,
NOMBRE_DEPA CHAR(80) 
);

create table RESPONSABLES(
ID_RES CHAR(4) PRIMARY KEY,
NOMBRE CHAR(80),
COD_DEPA int,
FOREIGN KEY (COD_DEPA) REFERENCES DEPARTAMENTO(COD_DEPA)
);

CREATE TABLE BIENES (
CODIGO CHAR(4) PRIMARY KEY,
DESCRIPCION CHAR(100),
ID_RES CHAR(4),
ESTADO CHAR(1),
FECHA_ADQ DATE, -- Está bien si solo necesitas la fecha
VALOR DECIMAL(10, 2), -- Mejor para valores monetarios
FOREIGN KEY (ID_RES) REFERENCES RESPONSABLES(ID_RES),
CHECK (ESTADO = 'B' OR ESTADO = 'R' OR ESTADO = 'M')
);
Drop table DEPARTAMENTO;
Drop table BIENES;
Drop table RESPONSABLES;

INSERT INTO DEPARTAMENTO (COD_DEPA, NOMBRE_DEPA) VALUES
(1, 'Recursos Humanos'),
(2, 'Finanzas'),
(3, 'IT'),
(4, 'Marketing'),
(5, 'Ventas');


INSERT INTO RESPONSABLES (ID_RES, NOMBRE, COD_DEPA) VALUES
('R001', 'Juan Pérez', 1),
('R002', 'María López', 2),
('R003', 'Carlos Sánchez', 3),
('R004', 'Ana Martínez', 4),
('R005', 'Luis Gómez', 1),
('R006', 'Sofía Hernández', 2),
('R007', 'Miguel Torres', 3),
('R008', 'Laura Díaz', 1),
('R009', 'Jorge Ramírez', 3),
('R010', 'Elena García', 1);



INSERT INTO BIENES (CODIGO, DESCRIPCION, ID_RES, ESTADO, FECHA_ADQ, VALOR) VALUES
('B001', 'Computadora portátil', 'R001', 'B', '2023-01-15', 1200.00),
('B002', 'Proyector', 'R001', 'R', '2023-02-20', 800.00),
('B003', 'Escritorio', 'R001', 'M', '2022-05-10', 200.00),
('B004', 'Silla de oficina', 'R001', 'B', '2021-11-30', 150.00),
('B005', 'Teléfono', 'R001', 'R', '2023-03-22', 300.00),
('B006', 'Monitor', 'R001', 'B', '2023-04-18', 400.00),
('B007', 'Impresora', 'R001', 'M', '2022-08-25', 600.00),
('B008', 'Teclado', 'R001', 'B', '2023-05-30', 50.00),
('B009', 'Ratón', 'R001', 'R', '2023-06-15', 30.00),
('B010', 'Altavoces', 'R001', 'B', '2022-12-10', 100.00),

('B011', 'Servidor', 'R002', 'B', '2023-01-15', 5000.00),
('B012', 'Router', 'R002', 'R', '2023-02-20', 300.00),
('B013', 'Switch', 'R002', 'M', '2022-05-10', 200.00),
('B014', 'Cableado estructurado', 'R002', 'B', '2021-11-30', 1500.00),
('B015', 'Firewall', 'R002', 'R', '2023-03-22', 1200.00),
('B016', 'UPS', 'R002', 'B', '2023-04-18', 600.00),
('B017', 'Rack de servidores', 'R002', 'M', '2022-08-25', 700.00),
('B018', 'Antivirus', 'R002', 'B', '2023-05-30', 100.00),
('B019', 'Software de gestión', 'R002', 'R', '2023-06-15', 200.00),
('B020', 'Licencias de software', 'R002', 'B', '2022-12-10', 3000.00),

('B021', 'Proyector', 'R003', 'B', '2023-01-15', 800.00),
('B022', 'Pizarra electrónica', 'R003', 'R', '2023-02-20', 500.00),
('B023', 'Mesas de reuniones', 'R003', 'M', '2022-05-10', 400.00),
('B024', 'Sillas de reuniones', 'R003', 'B', '2021-11-30', 300.00),
('B025', 'Televisión', 'R003', 'R', '2023-03-22', 700.00),
('B026', 'Videoconferencia', 'R003', 'B', '2023-04-18', 1500.00),
('B027', 'Whiteboard', 'R003', 'M', '2022-08-25', 250.00),
('B028', 'Cámara web', 'R003', 'B', '2023-05-30', 150.00),
('B029', 'Micrófono', 'R003', 'R', '2023-06-15', 100.00),
('B030', 'Sistema de sonido', 'R003', 'B', '2022-12-10', 1200.00);

SELECT *FROM [dbo].[BIENES];

SELECT CODIGO, DESCRIPCION, ESTADO
FROM BIENES
WHERE ESTADO = 'M'

SELECT ID_RES, NOMBRE
FROM RESPONSABLES
ORDER BY NOMBRE;

SELECT COUNT(*) AS "TOTAL DE REGISTRADOS"
FROM BIENES;

SELECT COUNT(*) AS "TOTAL DE REGISTRADOS"
FROM BIENES
WHERE ESTADO = 'R'
--OTRA OPCION 
SELECT ESTADO, COUNT(*) AS TotalBienes
FROM BIENES
GROUP BY ESTADO;

SELECT CODIGO, DESCRIPCION, FECHA_ADQ
FROM BIENES
WHERE YEAR(FECHA_ADQ) < 2023;

SELECT R.ID_RES, R.NOMBRE
FROM RESPONSABLES R
JOIN DEPARTAMENTO D ON R.COD_DEPA = D.COD_DEPA
WHERE R.NOMBRE LIKE 'B%' AND D.COD_DEPA = 21;


SELECT DISTINCT YEAR(FECHA_ADQ) AS AñoAdquisicion
FROM BIENES;

SELECT YEAR(FECHA_ADQ) AS AñoAdquisicion, COUNT(*) AS TotalBienes
FROM BIENES
GROUP BY YEAR(FECHA_ADQ)
ORDER BY YEAR(FECHA_ADQ);

SELECT ESTADO, COUNT(*) AS TotalBienes
FROM BIENES
GROUP BY ESTADO;

SELECT TOP 10 CODIGO, DESCRIPCION, VALOR
FROM BIENES
ORDER BY VALOR DESC;

SELECT COD_DEPA, COUNT(*) AS TotalResponsables
FROM RESPONSABLES
GROUP BY COD_DEPA
HAVING COUNT(*) > 1;

SELECT D.COD_DEPA, COUNT(R.ID_RES) AS TotalResponsables
FROM DEPARTAMENTO D
JOIN RESPONSABLES R ON D.COD_DEPA = R.COD_DEPA
GROUP BY D.COD_DEPA
HAVING COUNT(R.ID_RES) > 1;






