-- Crear la base de datos
CREATE DATABASE API_BASE_de_Datos;

-- Usar la base de datos
USE API_BASE_de_Datos;

-- Crear la tabla
CREATE TABLE Personas (
    Codigo INT IDENTITY(1,1) PRIMARY KEY, -- C�digo incremental de 1 en 1
    Nombre VARCHAR(70) NOT NULL,         -- Nombre con un m�ximo de 70 caracteres
    Apellido VARCHAR(70) NOT NULL,       -- Apellido con un m�ximo de 70 caracteres
    Edad INT NOT NULL,                   -- Edad como tipo entero
    Telefono CHAR(10) NOT NULL           -- Tel�fono con longitud fija de 10 caracteres
);
