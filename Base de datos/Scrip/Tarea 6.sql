CREATE TABLE PACIENTE (
  CI CHAR(10) PRIMARY KEY,
  NombrePac VARCHAR(50) NOT NULL,
  DireccionP VARCHAR(200),
  TelefonoP CHAR(10)
);

CREATE TABLE MEDICO (
  Codigo CHAR(8) PRIMARY KEY,
  NombreMedt VARCHAR(50) NOT NULL,
  DireccionM VARCHAR(200),
  TelefonoM CHAR(10) NOT NULL
);

CREATE TABLE P_EXTERNA (
  CI CHAR(10) PRIMARY KEY NOT NULL,
  FechaAtencion DATE NOT NULL,
  FOREIGN KEY (CI) REFERENCES PACIENTE(CI)
);

CREATE TABLE AREA (
  IdArea CHAR(1) PRIMARY KEY ,
  DescripcionA VARCHAR(100) NOT NULL
);
 
CREATE TABLE CAMA(
IdCama TINYINT PRIMARY KEY,
DescripcionC VARCHAR(200) ,
IdArea CHAR(1)
FOREIGN KEY (IdArea) REFERENCES AREA(IdArea),
);

CREATE TABLE P_HOSPITALIZACION (
  CI CHAR(10) PRIMARY KEY,
  IdCama TINYINT NOT NULL,
  FechaHospital DATE NOT NULL,
  FOREIGN KEY (CI) REFERENCES PACIENTE(CI),
  FOREIGN KEY (IdCama) REFERENCES CAMA(IdCama)
);

CREATE TABLE ATIENDE (
  CI CHAR(10) NOT NULL,
  Codigo CHAR(8) NOT NULL,
  PRIMARY KEY (CI, Codigo),  -- Clave primaria compuesta
  FOREIGN KEY (CI) REFERENCES PACIENTE(CI),
  FOREIGN KEY (Codigo) REFERENCES MEDICO(Codigo),
);

drop table [dbo].[ATIENDE]
CREATE TABLE ESPECIALIZACION (
  Id_Espe CHAR(1) PRIMARY KEY ,
  DescripcionE VARCHAR(100) NOT NULL
);


CREATE TABLE MEDICO_ESP(
Codigo CHAR(8) NOT NULL,
Id_Espe CHAR(1),
FOREIGN KEY (Codigo) REFERENCES MEDICO(Codigo),
FOREIGN KEY (Id_Espe) REFERENCES ESPECIALIZACION(Id_Espe),
CONSTRAINT ME_ESPECI UNIQUE (Codigo,Id_Espe)  -- Unique constraint on both columns
);

DROP TABLE ESPECIALIZACION;

-- Insert data into PACIENTE
INSERT INTO PACIENTE (CI, NombrePac, DireccionP, TelefonoP) VALUES
('0000000001', 'John Doe', '123 Elm St', '5550000001'),
('0000000002', 'Jane Smith', '456 Oak St', '5550000002'),
('0000000003', 'Jim Brown', '789 Pine St', '5550000003'),
('0000000004', 'Jake White', '101 Maple St', '5550000004'),
('0000000005', 'Jill Black', '202 Cedar St', '5550000005'),
('0000000006', 'Jack Green', '303 Birch St', '5550000006'),
('0000000007', 'Jen Blue', '404 Ash St', '5550000007'),
('0000000008', 'Joe Yellow', '505 Cherry St', '5550000008'),
('0000000009', 'Judy Purple', '606 Walnut St', '5550000009'),
('0000000010', 'Jeff Red', '707 Spruce St', '5550000010');

INSERT INTO PACIENTE (CI, NombrePac, DireccionP, TelefonoP) VALUES
('0000000013', 'John Doe', '123 Elm St', '5550000001');
-- Insert data into MEDICO
INSERT INTO MEDICO (Codigo, NombreMedt, DireccionM, TelefonoM) VALUES
('MD000001', 'Dr. Alice', '111 Doctor St', '5551000001'),
('MD000002', 'Dr. Bob', '222 Doctor St', '5551000002'),
('MD000003', 'Dr. Charlie', '333 Doctor St', '5551000003'),
('MD000004', 'Dr. David', '444 Doctor St', '5551000004'),
('MD000005', 'Dr. Eve', '555 Doctor St', '5551000005'),
('MD000006', 'Dr. Frank', '666 Doctor St', '5551000006'),
('MD000007', 'Dr. Grace', '777 Doctor St', '5551000007'),
('MD000008', 'Dr. Heidi', '888 Doctor St', '5551000008'),
('MD000009', 'Dr. Ivan', '999 Doctor St', '5551000009'),
('MD000010', 'Dr. Judy', '1010 Doctor St', '5551000010');

-- Insert data into P_EXTERNA
INSERT INTO P_EXTERNA (CI, FechaAtencion) VALUES
('0000000001', '2024-01-01'),
('0000000002', '2024-01-02'),
('0000000003', '2024-01-03'),
('0000000004', '2024-01-04'),
('0000000005', '2024-01-05'),
('0000000006', '2024-01-06'),
('0000000007', '2024-01-07'),
('0000000008', '2024-01-08'),
('0000000009', '2024-01-09'),
('0000000010', '2024-01-10');
INSERT INTO P_EXTERNA (CI, FechaAtencion) VALUES
('0000000013', '2024-04-05');
-- Insert data into AREA
INSERT INTO AREA (IdArea, DescripcionA) VALUES
('1', 'Urgencias'),
('2', 'Cuidados Intensivos'),
('3', 'Anestesiología'),
('4', 'Cardiología');

-- Insert data into CAMA
INSERT INTO CAMA (IdCama, DescripcionC, IdArea) VALUES
(1, 'Room 101, Bed 1', '1'),
(2, 'Room 101, Bed 2', '1'),
(3, 'Room 102, Bed 1', '2'),
(4, 'Room 102, Bed 2', '2'),
(5, 'Room 201, Bed 1', '3'),
(6, 'Room 201, Bed 2', '3'),
(7, 'Room 202, Bed 1', '4'),
(8, 'Room 202, Bed 2', '4'),
(9, 'Room 301, Bed 1', '1'),
(10, 'Room 301, Bed 2', '2');


INSERT INTO CAMA (IdCama, DescripcionC, IdArea) VALUES
(11, 'Room 501, Bed 25', '1'),
(12, 'Room 701, Bed 30', '1');

-- Insert data into P_HOSPITALIZACION
INSERT INTO P_HOSPITALIZACION (CI, IdCama, FechaHospital) VALUES
('0000000001', 1, '2024-02-01'),
('0000000002', 2, '2024-02-02'),
('0000000003', 3, '2024-02-03'),
('0000000004', 4, '2024-02-04'),
('0000000005', 5, '2024-02-05'),
('0000000006', 6, '2024-02-06'),
('0000000007', 7, '2024-02-07'),
('0000000008', 8, '2024-02-08'),
('0000000009', 9, '2024-02-09'),
('0000000010', 10, '2024-02-10');

INSERT INTO P_HOSPITALIZACION (CI, IdCama, FechaHospital) VALUES
(null, 1, '2021-12-12'),
(null, 2, '2021-12-12');

-- Insert data into ATIENDE
INSERT INTO ATIENDE (CI, Codigo) VALUES
('0000000001', 'MD000001'),
('0000000002', 'MD000002'),
('0000000003', 'MD000003'),
('0000000004', 'MD000004'),
('0000000005', 'MD000005'),
('0000000006', 'MD000006'),
('0000000007', 'MD000007'),
('0000000008', 'MD000008'),
('0000000009', 'MD000009'),
('0000000010', 'MD000010');

-- Insert data into ESPECIALIZACION
INSERT INTO ESPECIALIZACION (Id_Espe, DescripcionE) VALUES
('1', 'Cirujano Cardiovascular'),
('2', 'Pediatra'),
('3', 'Endocrinólogo'),
('4', 'General-Familiar');

-- Insert data into MEDICO_ESP
INSERT INTO MEDICO_ESP (Codigo, Id_Espe) VALUES
('MD000001', '1'),
('MD000002', '2'),
('MD000003', '3'),
('MD000004', '4'),
('MD000005', '1'),
('MD000006', '2'),
('MD000007', '3'),
('MD000008', '1'),
('MD000009', '1'),
('MD000010', '2');

-- Insert data into ATIENDE (datos ajustados para evitar duplicados)
INSERT INTO ATIENDE (CI, Codigo) VALUES
('0000000001', 'MD000001'),
('0000000002', 'MD000002'),
('0000000003', 'MD000003'),
('0000000001', 'MD000004'),
('0000000005', 'MD000005'),
('0000000001', 'MD000006'),
('0000000007', 'MD000007'),
('0000000008', 'MD000008'),
('0000000001', 'MD000009'),
('0000000010', 'MD000010');

INSERT INTO ATIENDE (CI, Codigo) VALUES
('0000000001', 'MD000001'),
('0000000001', 'MD000001');

DELETE FROM ATIENDE;



--1
SELECT P.NombrePac as "Numero Paciente", P.CI as "Cedula", C.DescripcionC as "Descripcion"
FROM PACIENTE AS P
INNER JOIN P_HOSPITALIZACION AS PH ON P.CI = PH.CI
INNER JOIN CAMA AS C ON PH.IdCama = C.IdCama
Group by P.NombrePac, P.CI, C.DescripcionC
ORDER BY P.NombrePac ASC;
--2
SELECT TOP 3 ME.DescripcionE AS "Especialidad", COUNT(A.CI) AS "Numero Pacientes"
FROM ATIENDE AS A
INNER JOIN MEDICO_ESP AS ME ON A.Id_Espe = ME.Id_Espe
INNER JOIN MEDICO AS M ON ME.Codigo = M.Codigo
GROUP BY ME.DescripcionE
ORDER BY "Numero Pacientes" DESC;

--3
SELECT M.NombreMedt AS Medico, P.NombrePac AS Paciente, COUNT(A.CI) AS NumeroDeAtenciones
FROM ATIENDE AS A
JOIN MEDICO AS M ON M.Codigo = A.Codigo
JOIN PACIENTE AS P ON A.CI = P.CI
GROUP BY M.NombreMedt, P.NombrePac
HAVING COUNT(A.CI) >2;

--4
SELECT PE.CI, P.NombrePac as "Paciente", PH.CI AS Cedula
FROM P_EXTERNA AS PE
INNER JOIN PACIENTE AS P ON P.CI = PE.CI
LEFT JOIN P_HOSPITALIZACION AS PH ON PE.CI = PH.CI
WHERE PH.CI IS NULL;


--5
SELECT year(FechaHospital) as "Año", day(FechaHospital) as Dia, COUNT(day(FechaHospital)) AS "Pacientes Atendidos"
FROM P_HOSPITALIZACION
WHERE YEAR(FechaHospital) = 2023
GROUP BY YEAR(FechaHospital), day(FechaHospital)
HAVING COUNT(day(FechaHospital)) > 10

--6

SELECT COUNT(C.IdCama) AS "Camas Disponibles", A.DescripcionA AS "Area"
FROM AREA AS A
INNER JOIN CAMA AS C ON A.IdArea = C.IdArea
LEFT JOIN P_HOSPITALIZACION AS PH ON C.IdCama = PH.IdCama AND MONTH(PH.FechaHospital) = 12 AND YEAR(PH.FechaHospital) = 2021
GROUP BY A.IdArea, A.DescripcionA
HAVING COUNT(PH.IdCama) = 0;

--7
SELECT M.NombreMedt as Medico, count(ME.Especialidad) as "Numero Especialidad"
FROM MEDICO AS M
INNER JOIN MEDICO_ESP AS ME ON M.Codigo = ME.Codigo
GROUP BY M.NombreMedt
HAVING COUNT(ME.Especialidad) > 2;

--8
-- Listado de pacientes de consulta externa
SELECT P.NombrePac AS "Paciente", P.CI AS "Cedula"
FROM PACIENTE as p
INNER JOIN P_EXTERNA as PE ON p.CI = PE.CI
UNION
-- Listado de pacientes de hospitalización
SELECT P.NombrePac, P.CI
FROM PACIENTE AS P
INNER JOIN P_HOSPITALIZACION AS PH ON P.CI = PH.CI

ORDER BY NombrePac;



