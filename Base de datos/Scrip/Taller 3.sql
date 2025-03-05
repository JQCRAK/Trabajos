-- Crear tabla PROVINCIA

CREATE TABLE PROVINCIA (
  idProvincia CHAR(5) PRIMARY KEY,
  nombre VARCHAR(70) NOT NULL
);
--Crear tabla CIUDAD
CREATE TABLE CIUDAD(
idCiudad CHAR(8) PRIMARY KEY,
nombre varchar(70) NOT NULL,
idProvincia CHAR(5) NOT NULL
FOREIGN KEY (idProvincia) REFERENCES PROVINCIA(idProvincia)
);

 --Crear tabla TIPOCLI
CREATE TABLE TIPOCLI (
    idTipo CHAR(1) PRIMARY KEY,
    descripcion VARCHAR(70) NOT NULL,
    CONSTRAINT chk_idTipo CHECK (idTipo IN ('0', '1', '2')),
    CONSTRAINT chk_descripcion CHECK (descripcion IN ('consumidor final', 'natural con cédula', 'jurídica con RUC'))
);


--Crear tabla ESTADO_COMPRA
CREATE TABLE ESTADO_COMPRA(
idEstadoOC CHAR(1) PRIMARY KEY,
descripcion VARCHAR(70) NOT NULL,
CONSTRAINT chk_idEstadoOC CHECK (idEstadoOC IN ('0', '1', '2','3')),
CONSTRAINT chk_descripcion1 CHECK (descripcion IN ('pedido de compra', 'pago realizado', 'pendiente de entrega','realizada la entrega'))
);
--Crear tabla VENDEDOR
CREATE TABLE VENDEDOR(
idVen char(8) PRIMARY KEY,
nombreVen VARCHAR(70) NOT NULL,
sexo CHAR(1) NOT NULL CHECK (sexo IN ('H', 'M')),
salario DECIMAL (8,2) NOT NULL, 
fechaIngreso DATE NOT NULL,
vigencia DATE NOT NULL
);

--Crear Tabla CLIENTE
CREATE TABLE CLIENTE(
idCli INT PRIMARY KEY,
apellidoCli VARCHAR(70) NOT NULL,
nombreCli VARCHAR(70) NOT NULL,
ciudadResidencia CHAR (8) NOT NULL,
tipoCli CHAR(1) NOT NULL
FOREIGN KEY (ciudadResidencia) REFERENCES CIUDAD(idCiudad),
FOREIGN KEY (tipoCli) REFERENCES TIPOCLI(idTipo)
);


--Crear Tabla ORDEN_COMPRA
CREATE TABLE ORDEN_COMPRA(
numOC INT IDENTITY(1,1) PRIMARY KEY,
idVen CHAR(8) NOT NULL,
idCli INT NOT NULL,
fecha DATE NOT NULL, 
idEstadoOC CHAR(1) NOT NULL,
valorTotal DECIMAL(8,2) NOT NULL
FOREIGN KEY (idVen) REFERENCES VENDEDOR(idVen),
FOREIGN KEY (idCli) REFERENCES CLIENTE(idCli),
FOREIGN KEY (idEstadoOC) REFERENCES ESTADO_COMPRA(idEstadoOC)
);	

--Crear Tabla Producto
CREATE TABLE PRODUCTO(
idProducto CHAR(8) PRIMARY KEY,
nombre VARCHAR(100) NOT NULL,
precioUnitario DECIMAL(8,2) NOT NULL
);

--Crear Tabla DETALLE_COMPRA
CREATE TABLE DETALLE_COMPRA(
numOC INT NOT NULL, 
idProducto CHAR(8) NOT NULL, 
cantidad INT NOT NULL , 
subtotal DECIMAL(8,2) NOT NULL,
PRIMARY KEY (numOC, idProducto),
FOREIGN KEY (numOC) REFERENCES ORDEN_COMPRA(numOC), 
FOREIGN KEY (idProducto) REFERENCES PRODUCTO(idProducto)
);

-- Agregar columnas sexo y fechaNacimiento a la tabla CLIENTE
ALTER TABLE CLIENTE
ADD sexo CHAR(1) CHECK (sexo IN ('H', 'M')),
    fechaNacimiento DATE CHECK (fechaNacimiento < GETDATE());


-- Agregar columna stock a la tabla PRODUCTO
ALTER TABLE PRODUCTO
ADD stock TINYINT;

-- Eliminar la columna vigencia de la tabla Vendedor
ALTER TABLE VENDEDOR
DROP COLUMN vigencia;


SELECT *FROM [dbo].[VENDEDOR]



DROP TABLE PRODUCTO;

SELECT * FROM sys.tables;

INSERT INTO PROVINCIA (idProvincia, nombre) VALUES
('A01', 'AZUAY'),
('B02', 'BOLIVAR'),
('C03','CAÑAR'),
('E07','EL ORO'),
('G09','GALAPAGOS');

INSERT INTO PRODUCTO (idProducto, nombre, precioUnitario, stock) VALUES
('LV1001', 'La Vaquita', '2.50', '50'),
('AM2002', 'Arroz Molinero', '7.99', '40'),
('AE3003', 'Aceite La Española', '5.49', '30'),
('DA4004', 'Detergente Ariel', '8.75', '20'),
('PH5005', 'Papel Scottex', '6.99', '35');

INSERT INTO ESTADO_COMPRA(idEstadoOC, descripcion) VALUES
('0', 'pedido de compra'),
('1', 'pago realizado'),
('2','pendiente de entrega'),
('3','realizada la entrega');

INSERT INTO TIPOCLI (idTipo, descripcion) VALUES
('0', 'consumidor final'),
('1', 'natural con cédula'),
('2', 'jurídica con RUC');

INSERT INTO VENDEDOR (idVen, nombreVen, sexo, salario, fechaIngreso) VALUES
('VEN001', 'Juan', 'H', 2500.00, '2023-01-15'),
('VEN002', 'María', 'M', 2200.00, '2022-11-10'),
('VEN003', 'Pedro', 'H', 2700.00, '2023-03-20'),
('VEN004', 'Ana', 'M', 2400.00, '2022-09-05'),
('VEN005', 'Luis', 'H', 2600.00, '2023-05-12');

INSERT INTO CIUDAD (idCiudad, nombre, idProvincia) VALUES
('A25', 'CUENCA','A01'),
('B26', 'GUARANDA', 'B02'),
('C27','CAÑAR', 'C03'),
('E31','MACHALA', 'E07'),
('E35','ZARUMA', 'E07');

INSERT INTO CLIENTE (idCli, apellidoCli, nombreCli, ciudadResidencia, tipoCli, sexo, fechaNacimiento) VALUES
(1, 'López', 'María', 'A25', '1', 'M', '1990-05-15'),
(2, 'Martínez', 'Juan', 'B26', '2', 'H', '1985-10-20'),
(3, 'García', 'Ana', 'C27', '0', 'M', '1978-07-03'),
(4, 'Rodríguez', 'Pedro', 'B26', '1', 'H', '1992-12-28'),
(5, 'Sánchez', 'Laura', 'E35', '2', 'M', '1989-04-09');

INSERT INTO ORDEN_COMPRA (numOC, idVen, idCli, fecha, idEstadoOC, valorTotal) VALUES
('001', 'VEN001', 1, '2024-04-10', '1', 120.50),
('002', 'VEN002', 2, '2024-04-11', '2', 95.75),
('033', 'VEN001', 3, '2024-04-12', '0', 150.00),
('055', 'VEN004', 4, '2024-04-13', '0', 200.25),
('022', 'VEN003', 5, '2024-04-14', '1', 175.00);

DELETE FROM ORDEN_COMPRA;


INSERT INTO ORDEN_COMPRA (idVen, idCli, fecha, idEstadoOC, valorTotal) VALUES
('VEN003', 3, '2024-04-12', '0', 150.00),
('VEN004', 4, '2024-04-13', '0', 200.25),
('VEN005', 5, '2024-04-14', '1', 175.00);

SELECT *FROM [dbo].[ORDEN_COMPRA] --MIRAR LOS DATOS DE LA TABLA

DELETE FROM ORDEN_COMPRA; --ELIMINAR DATOS DE UNA TABLA

DELETE FROM ORDEN_COMPRA
WHERE numOC = 23;


INSERT INTO DETALLE_COMPRA (numOC, idProducto, cantidad, subtotal) VALUES
(31, 'LV1001', 2, 5.00),
(32, 'AM2002', 1, 7.99),
(33, 'AE3003', 3, 16.47),
(34, 'DA4004', 2, 17.50),
(35, 'PH5005', 4, 27.96);
