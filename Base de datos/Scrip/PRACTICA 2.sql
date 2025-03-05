--Practica 2
--Tablas Caso: ORDEN DE COMPRA
CREATE TABLE PROVINCIA(
  idProvincia CHAR(5) PRIMARY KEY,
  nombre varchar(85) NOT NULL
);

CREATE TABLE CIUDAD(
idCiudad char(8) PRIMARY KEY,
nombre varchar(80) NOT NULL,
idProvincia char(5) NOT NULL,
FOREIGN KEY (idProvincia) REFERENCES PROVINCIA(idProvincia)
);

CREATE TABLE TIPOCLI(
idTipo Char(1) PRIMARY KEY,
descripcion varchar(70) NOT NULL,
CONSTRAINT CK_idTipo CHECK (idTipo IN ('0', '1','2')),
CONSTRAINT ck_descripcion CHECK (descripcion IN ('consumidor final', 'natural con cédula', 'jurídica con RUC'))
);

CREATE TABLE CLIENTE(
idCli int PRIMARY KEY,
apellidoCli varchar(70) NOT NULL,
nombreCli varchar(70) NOT NULL,
sexo char(1) not null,
ciudadResidencia char(8) NOT NULL,
tipoCli char(1) NOT NULL,
constraint ck_sexo check (sexo in ('H', 'M')),
FOREIGN KEY (ciudadResidencia) REFERENCES CIUDAD(idCiudad),
FOREIGN KEY (tipoCli) REFERENCES TIPOCLI(idTipo)
);

CREATE TABLE ESTADO_COMPRA(
idEstadoOC CHAR(1) PRIMARY KEY,
descripcion varchar(70) NOT NULL,
CONSTRAINT ck_idEstadoOc CHECK (idEstadoOc IN ('0','1','2','3')),
CONSTRAINT ck_descricpion CHECK (descripcion IN ('pedido de compra', 'pago realizado', 'pendiente de entrega', 'realizada la entrega'))
);

CREATE TABLE VENDEDOR(
idVen char(8) PRIMARY KEY,
nombreVen varchar(70) NOT NULL,
sexo char(1) NOT NULL CHECK (sexo IN ('H','M')), 
salario decimal(8,2) NOT NULL,
fechaIngreso date NOT NULL,
vigencia date NOT NULL,
);

CREATE TABLE ORDEN_COMPRA(
numOC int IDENTITY(1,1) PRIMARY KEY,
idVen char(8) NOT NULL,
idCli int NOT NULL,
fecha date NOT NULL,
idEstadoOC char(1) NOT NULL,
valorTotal decimal(8,2) NOT NULL,
FOREIGN KEY (idVen) REFERENCES VENDEDOR(idVen),
FOREIGN KEY (idCli) REFERENCES CLIENTE(idCli),
FOREIGN KEY (idEstadoOc) REFERENCES ESTADO_COMPRA(idEstadoOc)
);

CREATE TABLE PRODUCTO(
idProducto char(8) PRIMARY KEY,
nombre varchar(100) NOT NULL,
precioUnitario decimal(8,2) NOT NULL,
stock tinyint
);

CREATE TABLE DETALLE_COMPRA(
numOC int NOT NULL,
idProducto char(8) NOT NULL,
cantidad int not null,
subTotal decimal(8,2) NOT NULL,
PRIMARY KEY (numOC, idProducto),
FOREIGN KEY (numOC) REFERENCES ORDEN_COMPRA(numOC),
FOREIGN KEY (idProducto) REFERENCES PRODUCTO(idProducto)
);

--Ingresar datos 
-- Insertar datos en la tabla PROVINCIA
INSERT INTO PROVINCIA (idProvincia, nombre) VALUES
('P001', 'Pichincha'),
('P002', 'Guayas'),
('P003', 'Azuay'),
('P004', 'Manabí'),
('P005', 'El Oro'),
('P006', 'Loja'),
('P007', 'Esmeraldas'),
('P008', 'Tungurahua'),
('P009', 'Imbabura'),
('P010', 'Chimborazo');

-- Insertar datos en la tabla CIUDAD
INSERT INTO CIUDAD (idCiudad, nombre, idProvincia) VALUES
('C0001', 'Quito', 'P001'),
('C0002', 'Guayaquil', 'P002'),
('C0003', 'Cuenca', 'P003'),
('C0004','Portoviejo', 'P004'),
('C0005', 'Machala', 'P005'),
('C0006', 'Loja', 'P006'),
('C0007', 'Esmeraldas', 'P007'),
('C0008', 'Ambato', 'P008'),
('C0009', 'Ibarra', 'P009'),
('C0010', 'Riobamba', 'P010'),
('C0011', 'Sangolquí', 'P001'),
('C0012', 'Daule', 'P002'),
('C0013', 'Azogues', 'P003'),
('C0014', 'Manta', 'P004'),
('C0015', 'Santa Rosa', 'P005'),
('C0016', 'Catamayo', 'P006'),
('C0017', 'Atacames', 'P007'),
('C0018', 'Baños', 'P008'),
('C0019', 'Otavalo', 'P009'),
('C0020', 'Guamote', 'P010');

-- Insertar datos en la tabla TIPOCLI
INSERT INTO TIPOCLI (idTipo, descripcion) VALUES
('0', 'consumidor final'),
('1', 'natural con cédula'),
('2', 'jurídica con RUC');

-- Insertar datos en la tabla CLIENTE
INSERT INTO CLIENTE (idCli, apellidoCli, nombreCli, sexo, ciudadResidencia, tipoCli) VALUES
(1, 'Gomez', 'Juan', 'H', 'C0001', '0'),
(2, 'Perez', 'Maria', 'M', 'C0002', '1'),
(3, 'Martinez', 'Carlos', 'H', 'C0003', '2'),
(4, 'Garcia', 'Ana', 'M', 'C0004', '0'),
(5, 'Lopez', 'Luis', 'H', 'C0005', '1'),
(6, 'Sanchez', 'Lucia', 'M', 'C0006', '2'),
(7, 'Ramirez', 'Miguel', 'H', 'C0007', '0'),
(8, 'Flores', 'Sofia', 'M', 'C0008', '1'),
(9, 'Gonzalez', 'Jose', 'H', 'C0009', '2'),
(10, 'Vargas', 'Laura', 'M', 'C0010', '0'),
(11, 'Castro', 'Pedro', 'H', 'C0011', '1'),
(12, 'Mendoza', 'Carla', 'M', 'C0012', '2'),
(13, 'Silva', 'David', 'H', 'C0013', '0'),
(14, 'Ortega', 'Elena', 'M', 'C0014', '1'),
(15, 'Rojas', 'Fernando', 'H', 'C0015', '2'),
(16, 'Morales', 'Daniela', 'M', 'C0016', '0'),
(17, 'Herrera', 'Ricardo', 'H', 'C0017', '1'),
(18, 'Paredes', 'Monica', 'M', 'C0018', '2'),
(19, 'Alvarez', 'Javier', 'H', 'C0019', '0'),
(20, 'Campos', 'Patricia', 'M', 'C0020', '1'),
(21, 'Vera', 'Esteban', 'H', 'C0001', '2'),
(22, 'Cabrera', 'Gabriela', 'M', 'C0002', '0'),
(23, 'Montenegro', 'Sebastian', 'H', 'C0003', '1'),
(24, 'Benitez', 'Alicia', 'M', 'C0004', '2'),
(25, 'Cruz', 'Raul', 'H', 'C0005', '0'),
(26, 'Navarro', 'Andrea', 'M', 'C0006', '1'),
(27, 'Torres', 'Ivan', 'H', 'C0007', '2'),
(28, 'Reyes', 'Paola', 'M', 'C0008', '0'),
(29, 'Salazar', 'Jorge', 'H', 'C0009', '1'),
(30, 'Guerrero', 'Luis', 'H', 'C0010', '2'),
(31, 'Fernandez', 'Carolina', 'M', 'C0011', '0'),
(32, 'Castillo', 'Sergio', 'H', 'C0012', '1'),
(33, 'Mejia', 'Valeria', 'M', 'C0013', '2'),
(34, 'Ramos', 'Hugo', 'H', 'C0014', '0'),
(35, 'Palacios', 'Marcela', 'M', 'C0015', '1');


-- Insertar datos en la tabla ESTADO_COMPRA
INSERT INTO ESTADO_COMPRA (idEstadoOC, descripcion) VALUES
('0', 'pedido de compra'),
('1', 'pago realizado'),
('2', 'pendiente de entrega'),
('3', 'realizada la entrega');

-- Insertar datos en la tabla VENDEDOR
INSERT INTO VENDEDOR (idVen, nombreVen, sexo, salario, fechaIngreso, vigencia) VALUES
('VA001', 'Pedro', 'H', 1500.00, '2020-01-01', '2024-12-31'),
('VB002', 'Laura', 'M', 1600.00, '2019-02-01', '2024-12-31'),
('VC003', 'Jose', 'H', 1400.00, '2018-03-01', '2024-12-31'),
('VD004', 'Marta', 'M', 1700.00, '2021-04-01', '2024-12-31'),
('VE005', 'Luis', 'H', 1550.00, '2022-05-01', '2024-12-31'),
('VF006', 'Ana', 'M', 1500.00, '2020-06-01', '2024-12-31'),
('VG007', 'Carlos', 'H', 1450.00, '2019-07-01', '2024-12-31'),
('VH008', 'Elena', 'M', 1650.00, '2021-08-01', '2024-12-31'),
('VI009', 'Jorge', 'H', 1350.00, '2018-09-01', '2024-12-31'),
('VJ010', 'Lucia', 'M', 1750.00, '2022-10-15', '2024-12-31'),
('VK011', 'Miguel', 'H', 1500.00, '2020-11-01', '2024-12-31'),
('VL012', 'Sofia', 'M', 1600.00, '2019-12-01', '2024-12-31'),
('VM013', 'Raul', 'H', 1400.00, '2018-01-01', '2024-12-31'),
('VN014', 'Patricia', 'M', 1700.00, '2021-02-01', '2024-12-31'),
('VO015', 'Fernando', 'H', 1550.00, '2022-11-10', '2024-12-31'),
('VP016', 'Gabriela', 'M', 1500.00, '2020-04-01', '2024-12-31'),
('VQ017', 'Ricardo', 'H', 1450.00, '2019-05-01', '2024-12-31'),
('VR018', 'Monica', 'M', 1650.00, '2021-06-01', '2024-12-31'),
('VS019', 'Javier', 'H', 1350.00, '2018-07-01', '2024-12-31'),
('VT020', 'Daniela', 'M', 1750.00, '2022-12-05', '2024-12-31');

Select * from VENDEDOR

-- Insertar datos en la tabla ORDEN_COMPRA
-- Insertar datos en la tabla ORDEN_COMPRA
INSERT INTO ORDEN_COMPRA (idVen, idCli, fecha, idEstadoOC, valorTotal) VALUES
('VA001', 1, '2023-01-15', '0', 250.50),
('VB002', 2, '2023-02-10', '1', 150.75),
('VC003', 3, '2023-03-20', '2', 320.00),
('VD004', 4, '2023-04-05', '3', 480.00),
('VE005', 5, '2023-05-18', '0', 600.50),
('VF006', 6, '2023-06-22', '1', 220.80),
('VG007', 7, '2023-07-30', '2', 310.20),
('VH008', 8, '2023-08-15', '3', 405.00),
('VI009', 9, '2023-09-10', '0', 710.00),
('VJ010', 10, '2023-10-05', '1', 555.50),
('VK011', 11, '2023-11-12', '2', 305.30),
('VL012', 12, '2023-12-20', '3', 810.00),
('VM013', 13, '2022-01-15', '0', 175.80),
('VN014', 14, '2022-02-10', '1', 240.50),
('VO015', 15, '2022-03-20', '2', 380.00),
('VP016', 16, '2022-04-05', '3', 410.00),
('VQ017', 17, '2022-05-18', '0', 540.20),
('VR018', 18, '2022-06-22', '1', 230.40),
('VS019', 19, '2022-07-30', '2', 360.50),
('VT020', 20, '2022-08-15', '3', 290.00),
('VA001', 21, '2022-09-10', '0', 510.00),
('VB002', 22, '2022-10-05', '1', 615.30),
('VC003', 23, '2022-11-12', '2', 430.00),
('VD004', 24, '2022-12-20', '3', 720.00),
('VE005', 25, '2021-01-15', '0', 140.50),
('VF006', 26, '2021-02-10', '1', 320.75),
('VG007', 27, '2021-03-20', '2', 210.00),
('VH008', 28, '2021-04-05', '3', 490.00),
('VI009', 29, '2021-05-18', '0', 350.50),
('VJ010', 30, '2021-06-22', '1', 190.80),
('VK011', 31, '2021-07-30', '2', 410.20),
('VL012', 32, '2021-08-15', '3', 530.00),
('VM013', 33, '2021-09-10', '0', 620.00),
('VN014', 34, '2021-10-05', '1', 465.50),
('VO015', 35, '2021-11-12', '2', 580.30),
('VP016', 1, '2021-12-20', '3', 310.00),
('VQ017', 2, '2020-01-15', '0', 255.80),
('VR018', 3, '2020-02-10', '1', 330.50),
('VS019', 4, '2020-03-20', '2', 410.00),
('VT020', 5, '2020-04-05', '3', 510.00),
('VA001', 6, '2020-05-18', '0', 470.20),
('VB002', 7, '2020-06-22', '1', 230.40),
('VC003', 8, '2020-07-30', '2', 290.50),
('VD004', 9, '2020-08-15', '3', 380.00),
('VE005', 10, '2020-09-10', '0', 610.00),
('VF006', 11, '2020-10-05', '1', 465.30),
('VG007', 12, '2020-11-12', '2', 390.00),
('VH008', 13, '2020-12-20', '3', 580.00);

-- Insertar datos en la tabla PRODUCTO
INSERT INTO PRODUCTO (idProducto, nombre, precioUnitario, stock) VALUES
('P001', 'Cola', 1.00, 100),
('P002', 'Sal', 0.50, 200),
('P003', 'Azúcar', 1.20, 150),
('P004', 'Papel Higiénico', 3.50, 200),
('P005', 'Detergente', 5.00, 50),
('P006', 'Arroz', 0.80, 15),
('P007', 'Frijoles', 1.50, 50),
('P008', 'Aceite', 2.00, 30),
('P009', 'Cereal', 2.50, 45),
('P010', 'Jabón', 0.75, 50),
('P011', 'Pasta', 1.00, 20),
('P012', 'Café', 3.00, 22),
('P013', 'Leche', 1.20, 32),
('P014', 'Galletas', 1.50, 20),
('P015', 'Yogur', 1.00, 50),
('P016', 'Pan', 0.50, 10),
('P017', 'Queso', 2.50, 20),
('P018', 'Mantequilla', 1.80, 30),
('P019', 'Cerveza', 1.20, 40),
('P020', 'Vino', 7.00, 58);


-- Insertar datos en la tabla DETALLE_COMPRA
INSERT INTO DETALLE_COMPRA (numOC, idProducto, cantidad, subTotal) VALUES
(1, 'P001', 10, 10.00),
(1, 'P002', 5, 2.50),
(2, 'P003', 8, 9.60),
(2, 'P004', 4, 14.00),
(3, 'P005', 3, 15.00),
(3, 'P006', 10, 8.00),
(4, 'P007', 6, 9.00),
(4, 'P008', 2, 4.00),
(5, 'P009', 5, 12.50),
(5, 'P010', 7, 5.25),
(6, 'P011', 12, 12.00),
(6, 'P012', 3, 9.00),
(7, 'P013', 15, 18.00),
(7, 'P014', 10, 15.00),
(8, 'P015', 8, 8.00),
(8, 'P016', 20, 10.00),
(9, 'P017', 5, 12.50),
(9, 'P018', 7, 12.60),
(10, 'P019', 10, 12.00),
(10, 'P020', 2, 14.00),
(11, 'P001', 20, 20.00),
(11, 'P002', 15, 7.50),
(12, 'P003', 10, 12.00),
(12, 'P004', 6, 21.00),
(13, 'P005', 8, 40.00),
(13, 'P006', 12, 9.60),
(14, 'P007', 4, 6.00),
(14, 'P008', 10, 20.00),
(15, 'P009', 8, 20.00),
(15, 'P010', 6, 4.50),
(16, 'P011', 5, 5.00),
(16, 'P012', 10, 30.00),
(17, 'P013', 12, 14.40),
(17, 'P014', 6, 9.00),
(18, 'P015', 10, 10.00),
(18, 'P016', 8, 4.00),
(19, 'P017', 3, 7.50),
(19, 'P018', 5, 9.00),
(20, 'P019', 4, 4.80),
(20, 'P020', 5, 35.00),
(21, 'P001', 7, 7.00),
(21, 'P002', 8, 4.00),
(22, 'P003', 5, 6.00),
(22, 'P004', 3, 10.50),
(23, 'P005', 6, 30.00),
(23, 'P006', 7, 5.60),
(24, 'P007', 9, 13.50),
(24, 'P008', 3, 6.00),
(25, 'P009', 6, 15.00),
(25, 'P010', 10, 7.50),
(26, 'P011', 15, 15.00),
(26, 'P012', 5, 15.00),
(27, 'P013', 8, 9.60),
(27, 'P014', 4, 6.00),
(28, 'P015', 7, 7.00),
(28, 'P016', 12, 6.00),
(29, 'P017', 6, 15.00),
(29, 'P018', 4, 7.20),
(30, 'P019', 5, 6.00),
(30, 'P020', 1, 7.00),
(31, 'P001', 12, 12.00),
(31, 'P002', 4, 2.00),
(32, 'P003', 15, 18.00),
(32, 'P004', 2, 7.00),
(33, 'P005', 9, 45.00),
(33, 'P006', 14, 11.20),
(34, 'P007', 3, 4.50),
(34, 'P008', 8, 16.00),
(35, 'P009', 10, 25.00),
(35, 'P010', 2, 1.50),
(36, 'P011', 9, 9.00),
(36, 'P012', 6, 18.00),
(37, 'P013', 11, 13.20),
(37, 'P014', 5, 7.50),
(38, 'P015', 9, 9.00),
(38, 'P016', 6, 3.00),
(39, 'P017', 4, 10.00),
(39, 'P018', 8, 14.40),
(40, 'P019', 3, 3.60),
(40, 'P020', 2, 14.00),
(41, 'P001', 8, 8.00),
(41, 'P002', 7, 3.50),
(42, 'P003', 12, 14.40),
(42, 'P004', 5, 17.50),
(43, 'P005', 10, 50.00),
(43, 'P006', 9, 7.20),
(44, 'P007', 7, 10.50),
(44, 'P008', 4, 8.00),
(45, 'P009', 9, 22.50),
(45, 'P010', 8, 6.00),
(46, 'P011', 14, 14.00),
(46, 'P012', 4, 12.00),
(47, 'P013', 7, 8.40),
(47, 'P014', 6, 9.00),
(48, 'P015', 12, 12.00);

--Consulta 
--a)Conocer los 10 mejores clientes de tipo natural del año 2023
SELECT TOP 10 c.nombreCli AS Nombre, c.apellidoCli as Apellido, SUM(valorTotal) as Total_Compras
FROM CLIENTE c
INNER JOIN ORDEN_COMPRA oc ON c.idCli = oc.idCli
INNER JOIN TIPOCLI tc ON c.tipoCli = tc.idTipo
WHERE tc.descripcion = 'natural con cédula' AND YEAR(oc.fecha) = 2023
GROUP BY c.idCli, c.nombreCli, c.apellidoCli
ORDER BY total_compras DESC;

--b)Listado alfabético de los clientes ordenados por el tipo de cliente
SELECT c.nombreCli as Nombre, c.apellidoCli as Apellido, TC.descripcion  AS Tipo_Cliente
FROM CLIENTE c
INNER JOIN TIPOCLI tc ON c.tipoCli = tc.idTipo
ORDER BY tipo_cliente;

--c)Conocer el total de compras efectivas (con estado de compra: realizada la entrega) del mes de
--diciembre del año 2023

SELECT SUM(oc.valorTotal) AS "Total de Compras"
FROM ORDEN_COMPRA oc
INNER JOIN ESTADO_COMPRA ec ON oc.idEstadoOC = ec.idEstadoOC
WHERE ec.descripcion = 'realizada la entrega'AND YEAR(oc.fecha) = 2023 AND MONTH(oc.fecha) = 12;



--d)Conocer los 3 mejores clientes de todas las Provincia que proceden en los últimos 3 años

SELECT top 3 c.idCli AS ID, c.nombreCli AS Nombre_Cliente, c.apellidoCli AS Apellido_Cliente, ci.nombre AS Ciudad, p.nombre AS Provincia, SUM(oc.valorTotal) AS Total_Compras
FROM ORDEN_COMPRA oc
JOIN CLIENTE c ON oc.idCli = c.idCli
JOIN CIUDAD ci ON c.ciudadResidencia = ci.idCiudad
JOIN PROVINCIA p ON ci.idProvincia = p.idProvincia
WHERE oc.fecha >= DATEADD(YEAR, -3, GETDATE())
GROUP BY c.idCli, c.nombreCli, c.apellidoCli, ci.nombre, p.nombre
ORDER BY total_compras DESC




--e)Conocer el número de clientes por su procedencia (ciudad y provincia)

SELECT p.nombre AS Provincia, ci.nombre AS Ciudad, COUNT(*) AS Numero_Clientes
FROM CLIENTE c
INNER JOIN CIUDAD ci ON c.ciudadResidencia = ci.idCiudad
INNER JOIN PROVINCIA p ON ci.idProvincia = p.idProvincia
GROUP BY p.nombre, ci.nombre;





--f)Conocer los productos que se han vendido por cada mes del año 2023
SELECT MONTH(oc.fecha) AS Mes, p.idProducto AS ID, p.nombre AS Nombre_Producto, SUM(dc.cantidad) AS Cantidad_Vendida
FROM DETALLE_COMPRA dc
    INNER JOIN ORDEN_COMPRA oc ON dc.numOC = oc.numOC
    INNER JOIN PRODUCTO p ON dc.idProducto = p.idProducto
WHERE YEAR(oc.fecha) = 2023
GROUP BY MONTH(oc.fecha), p.idProducto, p.nombre
ORDER BY mes, p.idProducto;


--g)Cantidad vendida por producto durante el mes de diciembre del año 2023

SELECT dc.idProducto as "ID Producto", p.nombre AS "Nombre Producto", SUM(dc.cantidad) AS "Cantidad Vendida"
FROM DETALLE_COMPRA dc
INNER JOIN ORDEN_COMPRA oc ON dc.numOC = oc.numOC
INNER JOIN PRODUCTO p ON dc.idProducto = p.idProducto
WHERE YEAR(oc.fecha) = 2023 AND MONTH(oc.fecha) = 12
GROUP BY dc.idProducto, p.nombre;

--h)Conocer el número de vendedores por su sexo

SELECT sexo AS Sexo, COUNT(*) AS Vendedores
FROM VENDEDOR
GROUP BY sexo;




--i)Listado de los vendedores que ingresaron en el último trimestre del año 2022
	SELECT idVen AS ID,nombreVen AS Nombre,salario AS Salario,fechaIngreso AS "Fecha Ingreso"
	FROM VENDEDOR
	WHERE fechaIngreso BETWEEN '2022-10-01' AND '2022-12-31';

--j)Conocer la ciudad que con el mayor número de ordenes de compras se ha pedido

SELECT  TOP 1 ci.idCiudad AS ID, ci.nombre AS Ciudad,COUNT(*) AS "Numeros de Compra"
FROM ORDEN_COMPRA oc
INNER JOIN CLIENTE c ON oc.idCli = c.idCli
INNER JOIN CIUDAD ci ON c.ciudadResidencia = ci.idCiudad
GROUP BY ci.idCiudad, ci.nombre
ORDER BY "Numeros de Compra" DESC;

--k)Conocer el número de ordenes de compras de acuerdo con su estado

SELECT OC.idEstadoOC AS ID,EC.descripcion AS Estado,COUNT(EC.descripcion) AS "Cantidad de Compras"
FROM ORDEN_COMPRA AS OC
INNER JOIN ESTADO_COMPRA AS EC ON OC.idEstadoOC = EC.idEstadoOC
GROUP BY OC.idEstadoOC, descripcion;

--l)Conocer las órdenes de compra pendientes de entrega

SELECT OC.numOC AS "# Orden",P.nombre AS "Nombre Producto",EC.descripcion AS Estado
FROM ORDEN_COMPRA AS OC
INNER JOIN ESTADO_COMPRA AS EC ON OC.idEstadoOC = EC.idEstadoOC
INNER JOIN DETALLE_COMPRA AS DC ON OC.numOC = DC.numOC
INNER JOIN PRODUCTO AS P ON DC.idProducto = P.idProducto
WHERE EC.descripcion = 'pendiente de entrega';


--m)Conocer los vendedores que tienen órdenes de compra pedidas y que no se hizo el pago
--correspondiente

SELECT DISTINCT v.idVen AS Nombre, v.nombreVen as Nombre
FROM VENDEDOR v
INNER JOIN ORDEN_COMPRA oc ON v.idVen = oc.idVen
INNER JOIN ESTADO_COMPRA ec ON oc.idEstadoOC = ec.idEstadoOC
WHERE ec.descripcion = 'pedido de compra'; 
-- Asumiendo que 'pedido de compra' representa el estado de la orden cuando no se ha realizado el pago

--n)Conocer el mejor vendedor del año 2023. Se determina el mejor vendedor con base en el número
--de ventas realizadas

SELECT TOP 1 v.idVen AS ID, v.nombreVen AS Nombre, COUNT(oc.numOC) AS num_ventas_realizadas
FROM  VENDEDOR v
INNER JOIN ORDEN_COMPRA oc ON v.idVen = oc.idVen
WHERE YEAR(oc.fecha) = 2023
GROUP BY  v.idVen, v.nombreVen
ORDER BY num_ventas_realizadas DESC

--o)Conocer el promedio de venta mensual (por cada mes) del año 2022

SELECT MONTH(fecha) AS Mes, AVG(valorTotal) AS "Promedio Venta Mensual"
FROM ORDEN_COMPRA
WHERE YEAR(fecha) = 2022
GROUP BY MONTH(fecha)
ORDER BY MONTH(fecha);


--p)Conocer los vendedores que cuyo promedio de ventas del año 2023 no pasaron del promedio en
--ventas anual.          
SELECT v.idVen AS ID, v.nombreVen AS Nombre, AVG(oc.valorTotal) AS "Promedio Ventas Anual 2023"
FROM VENDEDOR v
INNER JOIN ORDEN_COMPRA oc ON v.idVen = oc.idVen
WHERE YEAR(oc.fecha) = 2023
GROUP BY v.idVen, v.nombreVen
HAVING AVG(oc.valorTotal) <= (
						 SELECT AVG(valorTotal)
						 FROM ORDEN_COMPRA
						 WHERE YEAR(fecha) = 2023);




SELECT P.nombre AS Provincia, C.nombreCli AS Nombre, C.apellidoCli as Apellido, SUM(O.valorTotal) AS Total_Compras
FROM CLIENTE C
INNER JOIN ORDEN_COMPRA O ON C.idCli = O.idCli
INNER JOIN CIUDAD CI ON C.ciudadResidencia = CI.idCiudad
INNER JOIN PROVINCIA P ON CI.idProvincia = P.idProvincia
INNER JOIN (
		SELECT c.idCli,ci.idProvincia
		FROM CLIENTE c
            INNER JOIN ORDEN_COMPRA oc ON c.idCli = oc.idCli
            INNER JOIN CIUDAD ci ON c.ciudadResidencia = ci.idCiudad
		WHERE oc.fecha >= DATEADD(YEAR, -3, GETDATE())
		GROUP BY c.idCli, ci.idProvincia
		HAVING COUNT(*) <= 3) AS mejores_clientes ON c.idCli = mejores_clientes.idCli AND ci.idProvincia = mejores_clientes.idProvincia
WHERE O.fecha >= DATEADD(YEAR, -3, GETDATE())
GROUP BY p.nombre, C.nombreCli, C.apellidoCli;