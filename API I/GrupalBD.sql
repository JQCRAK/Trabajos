-- Crear la base de datos
CREATE DATABASE ProveedoresDB;
GO

USE ProveedoresDB;
GO

-- Crear la tabla de proveedores
CREATE TABLE Proveedor (
    nombre NVARCHAR(100) PRIMARY KEY, -- Clave primaria basada en 'nombre'
    direccion NVARCHAR(200),
    ciudad NVARCHAR(100),
    provincia NVARCHAR(100)
);

-- Crear la tabla de piezas
CREATE TABLE Pieza (
    nombre NVARCHAR(100) PRIMARY KEY, -- Clave primaria basada en 'nombre'
    color NVARCHAR(50),
    centro NVARCHAR(100)
);

-- Crear la tabla de categorías
CREATE TABLE Categoria (
    categ NVARCHAR(100) PRIMARY KEY, -- Clave primaria basada en 'categ'
    precio DECIMAL(10, 2) NOT NULL
);

-- Crear la tabla suministra (relación entre Proveedor y Pieza)
CREATE TABLE Suministra (
    nombreProveedor NVARCHAR(100) NOT NULL, -- Nombre del proveedor como clave foránea
    nombrePieza NVARCHAR(100) NOT NULL, -- Nombre de la pieza como clave foránea
    cantidad INT NOT NULL,
    PRIMARY KEY (nombreProveedor, nombrePieza),
    FOREIGN KEY (nombreProveedor) REFERENCES Proveedor(nombre) ON DELETE CASCADE,
    FOREIGN KEY (nombrePieza) REFERENCES Pieza(nombre) ON DELETE CASCADE
);

-- Crear la relación pertenece entre Pieza y Categoria
CREATE TABLE Pertenece (
    nombrePieza NVARCHAR(100) NOT NULL, -- Nombre de la pieza como clave foránea
    categ NVARCHAR(100) NOT NULL, -- Categoría como clave foránea
    PRIMARY KEY (nombrePieza, categ),
    FOREIGN KEY (nombrePieza) REFERENCES Pieza(nombre) ON DELETE CASCADE,
    FOREIGN KEY (categ) REFERENCES Categoria(categ) ON DELETE CASCADE
);

-- Mensaje de éxito
PRINT 'Base de datos y tablas creadas exitosamente.';
