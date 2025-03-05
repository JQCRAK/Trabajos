CREATE DATABASE Ejercicio5;
GO

USE Ejercicio5;
	GO
	select * from pieza
Create table prov(
nombre nvarchar(100) primary key,
direccion nvarchar(200),
ciudad nvarchar(100),
provincia nvar	char(100)
);

CREATE TABLE pieza (
    nombreP NVARCHAR(100) PRIMARY KEY, -- Clave primaria
    color NVARCHAR(100),
    centro NVARCHAR(100),
    categ NVARCHAR(100) NOT NULL, -- Clave foránea
    CONSTRAINT FK_pieza_categoria FOREIGN KEY (categ)
    REFERENCES categoria (categ) ON DELETE CASCADE
);
Select * From categoria
Create table categoria(
categ nvarchar(100) primary key,
precio decimal(10,2) not null
);


create table suministra(
nombre nvarchar(100),
nombreP nvarchar(100),
cantidad int not null
primary key (nombre, nombreP),
foreign key (nombre)  references prov(nombre),
foreign key (nombreP)  references pieza(nombrep)
);

CREATE TABLE total_por_categoria (
    categ NVARCHAR(100) PRIMARY KEY, 
    total_piezas INT NOT NULL DEFAULT 0, 
    CONSTRAINT FK_total_categoria FOREIGN KEY (categ)
    REFERENCES categoria (categ) 
);

CREATE TABLE total_suministros_proveedor (
    nombre NVARCHAR(100) PRIMARY KEY, 
    total_suministros INT NOT NULL DEFAULT 0,  
    CONSTRAINT FK_suministros_proveedor FOREIGN KEY (nombre)
    REFERENCES prov (nombre)  
);


