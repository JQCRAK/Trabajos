CREATE DATABASE MusicPlayerDB;
GO
USE MusicPlayerDB;

CREATE TABLE Canciones (
    CancionID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL,
    RutaArchivo VARCHAR(500) NOT NULL, -- Dirección del archivo en el equipo
    Duracion TIME NOT NULL, -- Duración de la canción
    BPM INT NOT NULL, -- Beats per minute
    GeneroID INT, -- Relacionado con la tabla Generos
    Estado VARCHAR(50) DEFAULT 'Disponible', -- Estado: Disponible o Reproducida
    FechaAgregada DATETIME DEFAULT GETDATE(), -- Fecha de adición
    FOREIGN KEY (GeneroID) REFERENCES Generos(GeneroID)
);


CREATE TABLE Generos (
    GeneroID INT PRIMARY KEY IDENTITY(1,1),
    NombreGenero VARCHAR(100) NOT NULL
);


DROP TABLE Voces;

CREATE TABLE Voces (
    VozID INT PRIMARY KEY IDENTITY(1,1),        -- Identificador único de la voz
    NombreVoz VARCHAR(100) NOT NULL,             -- Nombre de la voz (Ej. "Saludo", "Transición", etc.)
    RutaArchivo VARCHAR(500) NOT NULL,           -- Ruta del archivo de voz
    CategoriaID INT,                            -- Clave foránea que apunta a la tabla Categorias
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID) -- Relación con la tabla Categorias
);

CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,  -- Identificador único de la categoría
    NombreCategoria VARCHAR(50) NOT NULL         -- Nombre de la categoría (Transición, Suspenso, etc.)
);


INSERT INTO Generos (NombreGenero) 
VALUES ('Phonk'), ('EDM'), ('Reggaetón'), ('Rock'), ('Pop');

-- Insertar género "Otros" en la tabla Generos
INSERT INTO Generos (NombreGenero)
VALUES ('Otros');
Select * From Generos

DELETE FROM Generos
WHERE NombreGenero = 'Pop';

-- Eliminar la columna BPM de la tabla Canciones
ALTER TABLE Canciones
DROP COLUMN BPM;

Select * from Canciones

-- Asegúrate de insertar canciones con su nombre y ruta (y el género correspondiente)
INSERT INTO Canciones (Nombre, RutaArchivo, Duracion, GeneroID)
VALUES ('Danca Love', 'C:\Users\Jostin\Music\MUSICA BD\PHONK\Dança Love - XdrianGM .mp3', '00:01:54', 1),
       ('Haunt Funk', 'C:\Users\Jostin\Music\MUSICA BD\PHONK\HAUNT FUNK - Release .mp3', '00:01:30', 1),
       ('FUNK MORENO', 'C:\Users\Jostin\Music\MUSICA BD\PHONK\Irokz - FUNK MORENO - Irokz.mp3', '00:02:57',  1),
	   ('Mazko', 'C:\Users\Jostin\Music\MUSICA BD\PHONK\MAZKO - Release .mp3', '00:01:15',  1),
	   ('SLIDE MOTIVE', 'C:\Users\Jostin\Music\MUSICA BD\PHONK\SLIDE MOTIVE - XdrianGM.mp3', '00:02:57',  1),
	   ('FADED', 'C:\Users\Jostin\Music\MUSICA BD\EDM\Alan Walker - Faded .mp3', '00:03:32',  2),
	   ('Sing Me To Sleep', 'C:\Users\Jostin\Music\MUSICA BD\EDM\Alan Walker - Sing Me To Sleep.mp3', '00:03:11',  2),
	   ('Waiting For Love', 'C:\Users\Jostin\Music\MUSICA BD\EDM\Avicii - Waiting For Love.mp3', '00:03:50',  2),
	   ('Summer', 'C:\Users\Jostin\Music\MUSICA BD\EDM\Calvin Harris - Summer.mp3', '00:03:53',  2),
	   ('Animals', 'C:\Users\Jostin\Music\MUSICA BD\EDM\Martin Garrix - Animals.mp3', '00:03:07',  2),
	   ('Safari', 'C:\Users\Jostin\Music\MUSICA BD\Regueton\J Balvin - Safari ft. Pharrell Williams, BIA, Sky.mp3', '00:03:24',  3),
	   ('Candy', 'C:\Users\Jostin\Music\MUSICA BD\Regueton\Plan B - Candy.mp3', '00:03:34',  3),
	   ('Fanatica Sensual', 'C:\Users\Jostin\Music\MUSICA BD\Regueton\Plan B - Fanatica Sensual.mp3', '00:04:00',  3),
	   ('Mi Vecinita', 'C:\Users\Jostin\Music\MUSICA BD\Regueton\Plan B - Mi Vecinita.mp3', '00:03:03',  3),
	   ('QUEVEDO', 'C:\Users\Jostin\Music\MUSICA BD\Regueton\QUEVEDO __ BZRP.mp3', '00:03:23',  3),
	   ('Back in Black', 'C:\Users\Jostin\Music\MUSICA BD\Rock\Back in Black - AC_DC.mp3', '00:04:04',  4),
	   ('Call Me', 'C:\Users\Jostin\Music\MUSICA BD\Rock\Call Me - Blondie.mp3', '00:08:06',  4),
	   ('I Was Made For Lovin', 'C:\Users\Jostin\Music\MUSICA BD\Rock\Kiss - I Was Made For Lovin You.mp3', '00:03:58',  4),
	   ('La Costa del Silencio', 'C:\Users\Jostin\Music\MUSICA BD\Rock\Mägo de Oz - La Costa del Silencio.mp3', '00:04:09',  4),
	   ('Smells Like Teen Spirit', 'C:\Users\Jostin\Music\MUSICA BD\Rock\Nirvana - Smells Like Teen Spirit.mp3', '00:04:38',  4),
	   ('Ayer y Hoy', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Ayer y Hoy Julio Jaramillo.mp3', '00:02:58',  6),
	   ('Colapso', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Kevin Kaarl - Colapso - Kevin Kaarl.mp3', '00:03:29',  6),
	   ('Me enamoré de alguien', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Me enamoré de alguien que también se enamoró - 𝐴𝑛𝑎.mp3', '00:01:50',  6),
	   ('PROTECTION CHARM', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Miguel Angeles - PROTECTION CHARM .mp3', '00:03:00',  6),
	   ('Nothings New', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Nothings New __ Rio Romeo __ Adventure Time_ Fionna and Cak.mp3', '00:03:38',  6),
	   ('Tu Boda', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Oscar Maydon, Fuerza Regida - Tu Boda (Letra).mp3', '00:03:45',  6),
	   ('Que Nadie Sepa Mi Sufrir', 'C:\Users\Jostin\Music\MUSICA BD\Otro\Que Nadie Sepa Mi Sufrir, Julio Jaramillo.mp3', '00:02:43',  6),
	   ('Lost and Found', 'C:\Users\Jostin\Music\MUSICA BD\Otro\XdrianGM - Lost and Found.mp3', '00:03:15',  6);


-- Inserta las categorías
INSERT INTO Categorias (NombreCategoria)
VALUES ('Transicion'),
       ('Suspenso'),
       ('Finalizar'),
       ('Saludo');

	   Select * From Categorias
INSERT INTO Voces (NombreVoz, RutaArchivo, CategoriaID)
VALUES ('Atención', 'C:\Users\Jostin\Music\Frases para Transiciones Musicales\¡Atención! Viene otro gran tema.mp3', 1),
	   ('No pares', 'C:\Users\Jostin\Music\Frases para Transiciones Musicales\No pares, hay más por disfrutar.mp3', 1),
	   ('Qué ritmo', 'C:\Users\Jostin\Music\Frases para Transiciones Musicales\Qué ritmo, seguimos con más música.mp3', 1),
	   ('Relájate', 'C:\Users\Jostin\Music\Frases para Transiciones Musicales\Relájate, lo mejor está por sonar.mp3', 1),
	   ('Atentos', 'C:\Users\Jostin\Music\Frases para Crear Suspenso\Atentos, esta es especial.mp3', 2),
	   ('Aún hay más', 'C:\Users\Jostin\Music\Frases para Crear Suspenso\Aún hay más, no te lo pierdas.mp3', 2),
	   ('Lo que viene es puro fuego', 'C:\Users\Jostin\Music\Frases para Crear Suspenso\Lo que viene es puro fuego.mp3', 2),
	   ('Prepárate, esto te va a gustar', 'C:\Users\Jostin\Music\Frases para Crear Suspenso\Prepárate, esto te va a gustar.mp3', 2),
	   ('Una favorita, seguro te encanta', 'C:\Users\Jostin\Music\Frases para Crear Suspenso\Una favorita, seguro te encanta.mp3', 2),
	   ('Cerramos con estilo', 'C:\Users\Jostin\Music\Frases para Finalizar la Playlist o Sesión\Cerramos con estilo, ¡hasta la próxima!.mp3', 3),
	   ('Eso fue todo', 'C:\Users\Jostin\Music\Frases para Finalizar la Playlist o Sesión\Eso fue todo, hasta pronto.mp3', 3),
	   ('Fin por ahora', 'C:\Users\Jostin\Music\Frases para Finalizar la Playlist o Sesión\Fin por ahora, vuelve por más.mp3', 3),
	   ('Gracias por escuchar', 'C:\Users\Jostin\Music\Frases para Finalizar la Playlist o Sesión\Gracias por escuchar, vuelve pronto.mp3', 3),
	   ('Nos vemos', 'C:\Users\Jostin\Music\Frases para Finalizar la Playlist o Sesión\Nos vemos, pero la música sigue.mp3', 3),
	   ('Saludo 1', 'C:\Users\Jostin\Music\Frases de Saludo\¡Hola! ¿Cómo estás Vamos a disfrutar de los mejores temas..mp3', 4),
	   ('Hola, qué tal', 'C:\Users\Jostin\Music\Frases de Saludo\¡Hola, qué tal! Prepárate para disfrutar..mp3', 4),
	   ('Qué tal', 'C:\Users\Jostin\Music\Frases de Saludo\¡Qué tal! Comenzamos con algo especial hoy..mp3', 4);

		Select * From Generos


DROP TABLE AnalisisMusical;
Select * From AnalisisMusical;
Select * FrOM Canciones


CREATE TABLE AnalisisMusical (
    AnalisisID INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único del análisis
    CancionID INT NOT NULL,                  -- Relación con la tabla Canciones
    BPM float NOT NULL,                        -- Ritmo de la canción en BPM
    ClaveMusical NVARCHAR(15) NOT NULL,       -- Clave musical de la canción (Ej: "C#m")
    FrecuenciaPromedio FLOAT NOT NULL,       -- Frecuencia promedio de la canción
    Energia FLOAT NOT NULL,                  -- Intensidad o energía promedio (RMS)
    Genero NVARCHAR(70),                     -- Género musical
    FOREIGN KEY (CancionID) REFERENCES Canciones(CancionID) -- Relación con Canciones
);

SELECT 
    CancionID, 
    Nombre, 
    RutaArchivo, 
    Duracion, 
    (SELECT NombreGenero FROM Generos WHERE Generos.GeneroID = Canciones.GeneroID) AS Genero
FROM 
    Canciones
WHERE 
    CancionID NOT IN (SELECT CancionID FROM AnalisisMusical);
