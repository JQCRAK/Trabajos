INSERT INTO sede (cod_sede, nombre) VALUES
('EC060155','MATRIZ RIOBAMBA'),
('SM050156','SEDE MORONA SANTIAGO'),
('SO040157','SEDE ORELLANA');

INSERT INTO etnia (cod_etnia, nombre) VALUES
('ET001', 'Mestizo'),
('ET002', 'Indígena'),
('ET003', 'Afrodescendiente'),
('ET004', 'Blanco'),
('ET005', 'Mulato');

INSERT INTO estado_mat (cod_estado_mat, nombre) VALUES
('EM1', 'Aprobado'),
('EM2', 'Desaprobado'),
('EM3', 'Pendiente');

INSERT INTO estado_eva (cod_estado_eva, nombre) VALUES
('EE1', 'Aprobado'),
('EE2', 'Desaprobado'),
('EE3', 'Suspenso');

INSERT INTO periodo (cod_periodo, descripcion, fecha_inicio, fecha_fin) VALUES
('PA24', 'Abril - Agosto', '2024-04-01', '2024-08-19');
INSERT INTO periodo (cod_periodo, descripcion, fecha_inicio, fecha_fin) VALUES 
('PM23', 'Enero - Mayo', '2023-01-01', '2023-05-31'),
('PJ22', 'Junio - Octubre', '2022-06-01', '2022-10-31'),
('PN21', 'Noviembre - Marzo', '2021-11-01', '2022-03-31'),
('PA21', 'Abril - Agosto', '2021-04-01', '2021-08-31'),
('PS20', 'Septiembre - Enero', '2020-09-01', '2021-01-31');

Select *from periodo


INSERT INTO area (cod_area, nombre) VALUES
('AR04', 'Unidad Basica'),
('AR05','Unidad Profesional'),
('AR06','Unidad Integracion Curricular');

INSERT INTO facultad (cod_facultad, nombre, sede) VALUES
('FI01', 'Facultad de Informática y Electrónica', 'EC060155');
INSERT INTO facultad (cod_facultad, nombre, sede) VALUES
('MD01', 'Facultad de Medicina', 'EC060155'),
('FT02', 'Facultad de Turismo', 'EC060155'),
('AD03', 'Facultad de Administración de Empresas', 'EC060155'),
('DE04', 'Facultad de Derecho', 'EC060155'),
('EN05', 'Facultad de Ingeniería', 'EC060155'),
('ED06', 'Facultad de Educación', 'EC060155'),
('PS07', 'Facultad de Psicología', 'EC060155'),
('BI08', 'Facultad de Biología', 'EC060155'),
('CO09', 'Facultad de Comunicación', 'EC060155');
Select *from [dbo].[facultad]

INSERT INTO carrera (cod_carrera, nombre, cod_facultad) VALUES
('CS01', 'Software', 'FI01');
INSERT INTO carrera (cod_carrera, nombre, cod_facultad) VALUES
('MS01', 'Medicina General', 'MD01'),
('TH02', 'Turismo y Hospitalidad', 'FT02'),
('AE03', 'Administración de Empresas', 'AD03'),
('JD04', 'Jurisprudencia', 'DE04'),
('CE05', 'Ingeniería Civil', 'EN05'),
('PE06', 'Pedagogía', 'ED06'),
('PS07', 'Psicología Clínica', 'PS07'),
('BI08', 'Biología Marina', 'BI08'),
('CM09', 'Comunicación Social', 'CO09');

Select *from [dbo].[carrera]

INSERT INTO materia (cod_materia, nombre, semestre, cod_area, cod_carrera) VALUES
('SOFIB01','INGLÉS I','PAO1','AR04','CS01'),
('SOFIB02','EDUCACIÓN FÍSICA ','PAO1','AR04','CS01'),
('SOFIB03','FUNDAMENTOS DE PROGRAMACIÓN','PAO1','AR04','CS01'),
('SOFIB04','FÍSICA I ','PAO1','AR04','CS01'),
('SOFIB05','CÁLCULO I ','PAO1','AR04','CS01'),
('SOFIB06','EPISTEMOLOGÍA DEL SOFTWARE','PAO1','AR04','CS01'),
('SOFIB07','INGLÉS II ','PAO2','AR04','CS01'),
('SOFIB08','COMUNICACIÓN ORAL Y ESCRITA','PAO2','AR04','CS01'),
('SOFIB09','CÁLCULO II','PAO2','AR04','CS01'),
('SOFIB10','ÁLGEBRA LINEAL','PAO2','AR04','CS01'),
('SOFIB11','FÍSICA II ','PAO2','AR04','CS01'),
('SOFIB12','PROGRAMACIÓN ORIENTADO A OBJETOS ','PAO2','AR04','CS01'),
('SOFIB13','INGLÉS III','PAO3','AR04','CS01'),
('SOFIB14','SOSTENIBILIDAD AMBIENTAL','PAO3','AR04','CS01'),
('SOFIB15','ESTADÍSTICA','PAO3','AR04','CS01'),
('SOFIB16','MATEMÁTICA DISCRETA I','PAO3','AR05','CS01'),
('SOFIB17','ARQUITECTURA DE COMPUTADORES ','PAO3','AR05','CS01'),
('SOFIB18','FUNDAMENTOS DE INGENIERÍA DE SOFTWARE','PAO3','AR05','CS01'),
('SOFIB19','INGLÉS IV ','PAO4','AR04','CS01'),
('SOFIP20','ALGORITMOS','PAO4','AR05','CS01'),
('SOFIP21','MATEMÁTICA DISCRETA II','PAO4','AR05','CS01'),
('SOFIP22','BASE DE DATOS I','PAO4','AR05','CS01'),
('SOFIP23','ESTRUCTURAS DE DATOS','PAO4','AR05','CS01'),
('SOFIP24','GESTIÓN ADMINISTRATIVA','PAO4','AR05','CS01'),
('SOFIP25','BASE DE DATOS II','PAO5','AR05','CS01'),
('SOFIP26','CONSTRUCCIÓN DE SOFTWARE','PAO5','AR05','CS01'),
('SOFIP27','EMPRENDIMIENTO','PAO5','AR05','CS01'),
('SOFIP28','INTERACCIÓN HOMBRE MÁQUINA','PAO5','AR05','CS01'),
('SOFIP29','APLICACIONES INFORMÁTICAS I','PAO5','AR05','CS01'),
('SOFIP30','SISTEMAS OPERATIVOS','PAO5','AR05','CS01');

INSERT INTO materia (cod_materia, nombre, semestre, cod_area, cod_carrera) VALUES
('SOFIP31','REDES I','PAO6','AR05','CS01'),
('SOFIP32','INTELIGENCIA ARTIFICIAL','PAO6','AR05','CS01'),
('SOFIP33','ENTORNOS VIRTUALES DE APRENDIZAJE','PAO6','AR05','CS01'),
('SOFIP34','REQUISITOS DE SOFTWARE','PAO6','AR05','CS01'),
('SOFIP35','INVESTIGACION FORMATIVA','PAO6','AR05','CS01'),
('SOFIP36','ASEGURAMIENTO DE LA CALIDAD DE SOFTWARE','PAO6','AR05','CS01'),
('SOFIP37','SISTEMA DE INFORMACION Y PROCESAMIENTO DE DATOS','PAO6','AR05','CS01');

INSERT INTO materia (cod_materia, nombre, semestre, cod_area, cod_carrera) VALUES
('SOFIP38','BASE DE CONOCIMIENTO','PAO7','AR05','CS01'),
('SOFIP39','COMPUTACION PARA LA NUBE','PAO7','AR05','CS01'),
('SOFIP40','GESTION DE PROYECTOS DE SOFTWARE','PAO7','AR05','CS01'),
('SOFIP41','SEGURIDAD INFORMATICA','PAO7','AR05','CS01'),
('SOFIP42','SOTWARE EN TIMEPO REAL','PAO7','AR05','CS01'),
('SOFIP43','REDES II','PAO7','AR05','CS01'),
('SOFIP44','ARQUITECTURA DE SOFTWARE','PAO7','AR05','CS01'),
('SOFIP45','TÉCNICAS DE SIMULACIÓN','PAO8','AR05','CS01'),
('SOFIP46','VALIDACIÓN Y VERIFICACIÓN DE SOFTWARE','PAO8','AR05','CS01'),
('SOFIP47','APLICACIONES INFORMÁTICAS II','PAO8','AR05','CS01'),
('SOFIP48','DESARROLLO Y OPERACIONES DE SOFTWARE','PAO8','AR05','CS01'),
('SOFIP49','PRÁCTICAS DE SERVICIO COMUNITARIO','PAO8','AR05','CS01'),
('SOFII50','METODOLOGÍA PARA EL TRABAJO DE TITULACIÓN','PAO8','AR06','CS01'),
('SOFIP51','PRACTICAS LABORALES','PAO9','AR06','CS01'),
('SOFIP52','COMPUTACION CIENTIFICA','PAO9','AR05','CS01'),
('SOFIP53','SISTEMAS MULTIMEDIA Y GAMIFICACION','PAO9','AR05','CS01'),
('SOFII54','SISTEMA DE TITULACION','PAO9','AR06','CS01');
Select *from [dbo].[materia]

INSERT INTO estudiante (cod_estudiante, cedula, nombre, apellido, fecha_nac, direccion, discapacidad, sexo, etnia) VALUES
('7100', '1234567890', 'Juan', 'Pérez', '2003-05-10', 'Calle Principal #123', 'No', 'M', 'ET001'),
('7101', '2345678901', 'María', 'López', '2002-09-15', 'Avenida Central #456', 'No', 'F', 'ET002'),
('7102', '3456789012', 'Carlos', 'González', '2001-12-20', 'Calle Secundaria #789', 'No', 'M', 'ET003'),
('7103', '4567890123', 'Ana', 'Martínez', '2004-03-25', 'Boulevard Norte #567', 'No', 'F', 'ET004'),
('7104', '5678901234', 'Pedro', 'Hernández', '2003-07-30', 'Avenida Sur #890', 'No', 'M', 'ET005'),
('7105', '6789012345', 'Laura', 'Díaz', '2002-11-05', 'Calle Este #1234', 'No', 'F', 'ET001'),
('7106', '7890123456', 'Santiago', 'Gómez', '2001-04-12', 'Avenida Oeste #5678', 'No', 'M', 'ET002'),
('7107', '8901234567', 'Valentina', 'Rodríguez', '2004-08-17', 'Calle Central #9012', 'No', 'F', 'ET003'),
('7108', '9012345678', 'Fernanda', 'Pérez', '2003-01-22', 'Boulevard Principal #3456', 'No', 'F', 'ET004'),
('7109', '0123456789', 'Diego', 'González', '2002-06-27', 'Avenida Norte #7890', 'No', 'M', 'ET005'),
('7110', '1234567890', 'Valeria', 'Martínez', '2001-10-03', 'Calle Este #1111', 'No', 'F', 'ET001'),
('7111', '2345678901', 'Javier', 'Hernández', '2004-02-08', 'Boulevard Oeste #2222', 'No', 'M', 'ET002'),
('7112', '3456789012', 'Mariana', 'López', '2003-05-15', 'Avenida Sur #3333', 'No', 'F', 'ET003'),
('7113', '4567890123', 'Alejandro', 'Díaz', '2002-09-20', 'Calle Principal #4444', 'No', 'M', 'ET004'),
('7114', '5678901234', 'Daniela', 'Gómez', '2001-12-25', 'Boulevard Norte #5555', 'No', 'F', 'ET005'),
('7115', '6789012345', 'Mateo', 'Rodríguez', '2004-03-02', 'Avenida Central #6666', 'No', 'M', 'ET001'),
('7116', '7890123456', 'Camila', 'Pérez', '2003-07-07', 'Calle Secundaria #7777', 'No', 'F', 'ET002'),
('7117', '8901234567', 'Lucas', 'González', '2002-11-12', 'Boulevard Sur #8888', 'No', 'M', 'ET003'),
('7118', '9012345678', 'Isabella', 'Martínez', '2001-04-17', 'Avenida Este #9999', 'No', 'F', 'ET004'),
('7119', '0123456789', 'Gabriel', 'Hernández', '2004-08-22', 'Calle Principal #1010', 'No', 'M', 'ET005'),
('7120', '1234567890', 'Sofía', 'López', '2003-01-28', 'Boulevard Oeste #1212', 'No', 'F', 'ET001');
INSERT INTO estudiante (cod_estudiante, cedula, nombre, apellido, fecha_nac, direccion, discapacidad, sexo, etnia)  VALUES
('7221', '2345678901', 'Luis', 'Sánchez', '2002-03-15', 'Avenida Principal #1234', 'No', 'M', 'ET002'),
('7222', '3456789012', 'Carmen', 'Ramírez', '2003-08-20', 'Calle Central #5678', 'No', 'F', 'ET003'),
('7223', '4567890123', 'Diego', 'Martínez', '2001-11-25', 'Boulevard Este #9012', 'No', 'M', 'ET004'),
('7224', '5678901234', 'Elena', 'González', '2004-04-30', 'Avenida Sur #1111', 'No', 'F', 'ET005'),
('7225', '6789012345', 'Javier', 'Gómez', '2003-09-05', 'Calle Secundaria #2222', 'No', 'M', 'ET001'),
('7226', '7890123456', 'Ana', 'López', '2002-01-10', 'Boulevard Norte #3333', 'No', 'F', 'ET002'),
('7227', '8901234567', 'Pedro', 'Hernández', '2001-04-15', 'Avenida Oeste #4444', 'No', 'M', 'ET003'),
('7228', '9012345678', 'María', 'Díaz', '2004-09-20', 'Calle Este #5555', 'No', 'F', 'ET004'),
('7229', '0123456789', 'Gabriela', 'Pérez', '2003-12-25', 'Boulevard Sur #6666', 'No', 'F', 'ET005'),
('7230', '1234567890', 'Mateo', 'Rodríguez', '2002-07-01', 'Avenida Central #7777', 'No', 'M', 'ET001'),
('7231', '2345678901', 'Sofía', 'Martínez', '2001-10-06', 'Calle Principal #8888', 'No', 'F', 'ET002'),
('7232', '3456789012', 'Luis', 'González', '2004-01-11', 'Boulevard Este #9999', 'No', 'M', 'ET003'),
('7233', '4567890123', 'Camila', 'Hernández', '2003-05-16', 'Avenida Oeste #1010', 'No', 'F', 'ET004'),
('7234', '5678901234', 'Carlos', 'López', '2002-08-21', 'Calle Secundaria #1212', 'No', 'M', 'ET005'),
('7235', '6789012345', 'Ana', 'Ramírez', '2001-11-26', 'Boulevard Norte #1313', 'No', 'F', 'ET001'),
('7236', '7890123456', 'Daniel', 'Gómez', '2004-04-01', 'Avenida Central #1414', 'No', 'M', 'ET002'),
('7237', '8901234567', 'Valeria', 'Sánchez', '2003-07-06', 'Calle Principal #1515', 'No', 'F', 'ET003'),
('7238', '9012345678', 'Martín', 'Pérez', '2002-10-11', 'Boulevard Este #1616', 'No', 'M', 'ET004'),
('7239', '0123456789', 'Laura', 'Ramírez', '2001-01-16', 'Avenida Oeste #1717', 'No', 'F', 'ET005'),
('7240', '1234567890', 'Diego', 'González', '2004-04-21', 'Calle Secundaria #1818', 'No', 'M', 'ET001');

INSERT INTO estudiante (cod_estudiante, cedula, nombre, apellido, fecha_nac, direccion, discapacidad, sexo, etnia) VALUES
('7341', '2345678901', 'Paola', 'Hernández', '2003-07-05', 'Boulevard Central #1920', 'No', 'F', 'ET001'),
('7342', '3456789012', 'Martín', 'Martínez', '2002-10-10', 'Calle Secundaria #2021', 'No', 'M', 'ET002'),
('7343', '4567890123', 'Valentina', 'Gómez', '2001-01-15', 'Avenida Norte #2122', 'No', 'F', 'ET003'),
('7344', '5678901234', 'Daniel', 'Ramírez', '2004-04-20', 'Boulevard Este #2223', 'No', 'M', 'ET004'),
('7345', '6789012345', 'Laura', 'Pérez', '2003-07-25', 'Calle Principal #2324', 'No', 'F', 'ET005'),
('7346', '7890123456', 'Eduardo', 'González', '2002-10-30', 'Avenida Sur #2425', 'No', 'M', 'ET001'),
('7347', '8901234567', 'Camila', 'López', '2001-02-04', 'Calle Este #2526', 'No', 'F', 'ET002'),
('7348', '9012345678', 'Juan', 'Sánchez', '2004-05-11', 'Boulevard Norte #2627', 'No', 'M', 'ET003'),
('7349', '0123456789', 'Valeria', 'Martínez', '2003-08-16', 'Avenida Oeste #2728', 'No', 'F', 'ET004'),
('7350', '1234567890', 'Carlos', 'Ramírez', '2002-11-21', 'Calle Secundaria #2829', 'No', 'M', 'ET005'),
('7351', '2345678901', 'María', 'Pérez', '2001-03-26', 'Boulevard Central #2930', 'No', 'F', 'ET001'),
('7352', '3456789012', 'Alejandro', 'González', '2004-06-01', 'Avenida Norte #3031', 'No', 'M', 'ET002'),
('7353', '4567890123', 'Ana', 'López', '2003-09-06', 'Calle Este #3132', 'No', 'F', 'ET003'),
('7354', '5678901234', 'Santiago', 'Sánchez', '2002-12-11', 'Boulevard Norte #3233', 'No', 'M', 'ET004'),
('7355', '6789012345', 'Luisa', 'Martínez', '2001-05-16', 'Avenida Oeste #3334', 'No', 'F', 'ET005'),
('7356', '7890123456', 'David', 'Ramírez', '2004-08-21', 'Calle Principal #3435', 'No', 'M', 'ET001'),
('7357', '8901234567', 'Fernanda', 'Gómez', '2003-01-26', 'Boulevard Central #3536', 'No', 'F', 'ET002'),
('7358', '9012345678', 'Javier', 'Pérez', '2002-04-02', 'Avenida Sur #3637', 'No', 'M', 'ET003'),
('7359', '0123456789', 'María', 'Hernández', '2001-07-07', 'Calle Este #3738', 'No', 'F', 'ET004'),
('7360', '1234567890', 'Diego', 'López', '2004-10-12', 'Boulevard Norte #3839', 'No', 'M', 'ET005'),
('7361', '2345678901', 'Paola', 'Hernández', '2003-07-05', 'Boulevard Central #1920', 'No', 'F', 'ET001'),
('7362', '3456789012', 'Martín', 'Martínez', '2002-10-10', 'Calle Secundaria #2021', 'No', 'M', 'ET002'),
('7363', '4567890123', 'Valentina', 'Gómez', '2001-01-15', 'Avenida Norte #2122', 'No', 'F', 'ET003'),
('7364', '5678901234', 'Daniel', 'Ramírez', '2004-04-20', 'Boulevard Este #2223', 'No', 'M', 'ET004'),
('7365', '1850867241', 'Jhostin', 'Quispe', '2003-10-21', 'Calle Principal #7365', 'No', 'M', 'ET001'),
('7366', '7890123456', 'Eduardo', 'González', '2002-10-30', 'Avenida Sur #2425', 'No', 'M', 'ET001'),
('7367', '8901234567', 'Camila', 'López', '2001-02-04', 'Calle Este #2526', 'No', 'F', 'ET002'),
('7368', '9012345678', 'Juan', 'Sánchez', '2004-05-11', 'Boulevard Norte #2627', 'No', 'M', 'ET003'),
('7369', '0123456789', 'Valeria', 'Martínez', '2003-08-16', 'Avenida Oeste #2728', 'No', 'F', 'ET004'),
('7370', '1234567890', 'Carlos', 'Ramírez', '2002-11-21', 'Calle Secundaria #2829', 'No', 'M', 'ET005');
INSERT INTO estudiante (cod_estudiante, cedula, nombre, apellido, fecha_nac, direccion, discapacidad, sexo, etnia) VALUES
('7470', '2345678901', 'Paola', 'Hernández', '2003-07-05', 'Boulevard Central #1920', 'No', 'F', 'ET001'),
('7471', '3456789012', 'Martín', 'Martínez', '2002-10-10', 'Calle Secundaria #2021', 'No', 'M', 'ET002'),
('7472', '4567890123', 'Valentina', 'Gómez', '2001-01-15', 'Avenida Norte #2122', 'No', 'F', 'ET003'),
('7473', '5678901234', 'Daniel', 'Ramírez', '2004-04-20', 'Boulevard Este #2223', 'No', 'M', 'ET004'),
('7474', '6789012345', 'Laura', 'Pérez', '2003-07-25', 'Calle Principal #2324', 'No', 'F', 'ET005'),
('7475', '7890123456', 'Eduardo', 'González', '2002-10-30', 'Avenida Sur #2425', 'No', 'M', 'ET001'),
('7476', '8901234567', 'Camila', 'López', '2001-02-04', 'Calle Este #2526', 'No', 'F', 'ET002'),
('7477', '9012345678', 'Juan', 'Sánchez', '2004-05-11', 'Boulevard Norte #2627', 'No', 'M', 'ET003'),
('7478', '0123456789', 'Valeria', 'Martínez', '2003-08-16', 'Avenida Oeste #2728', 'No', 'F', 'ET004'),
('7479', '1234567890', 'Carlos', 'Ramírez', '2002-11-21', 'Calle Secundaria #2829', 'No', 'M', 'ET005'),
('7480', '2345678901', 'María', 'Pérez', '2001-03-26', 'Boulevard Central #2930', 'No', 'F', 'ET001'),
('7481', '3456789012', 'Alejandro', 'González', '2004-06-01', 'Avenida Norte #3031', 'No', 'M', 'ET002'),
('7482', '4567890123', 'Ana', 'López', '2003-09-06', 'Calle Este #3132', 'No', 'F', 'ET003'),
('7483', '5678901234', 'Santiago', 'Sánchez', '2002-12-11', 'Boulevard Norte #3233', 'No', 'M', 'ET004'),
('7484', '6789012345', 'Luisa', 'Martínez', '2001-05-16', 'Avenida Oeste #3334', 'No', 'F', 'ET005'),
('7485', '7890123456', 'David', 'Ramírez', '2004-08-21', 'Calle Principal #3435', 'No', 'M', 'ET001'),
('7486', '8901234567', 'Fernanda', 'Gómez', '2003-01-26', 'Boulevard Central #3536', 'No', 'F', 'ET002'),
('7487', '9012345678', 'Javier', 'Pérez', '2002-04-02', 'Avenida Sur #3637', 'No', 'M', 'ET003'),
('7488', '0123456789', 'María', 'Hernández', '2001-07-07', 'Calle Este #3738', 'No', 'F', 'ET004'),
('7489', '1234567890', 'Diego', 'López', '2004-10-12', 'Boulevard Norte #3839', 'No', 'M', 'ET005'),
('7490', '2345678901', 'Joaquín', 'Quispe', '2003-02-17', 'Calle Principal #3940', 'No', 'M', 'ET001');


Select *from [dbo].[estudiante]

INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7100', 'SOFIB01','PS20','2020-10-01','EM1'),
('7100', 'SOFIB02','PS20','2020-10-01','EM1'),
('7100', 'SOFIB03','PS20','2020-10-01','EM1'),
('7100', 'SOFIB04','PS20','2020-10-01','EM1'),
('7100', 'SOFIB05','PS20','2020-10-01','EM1'),
('7100', 'SOFIB06','PS20','2020-10-01','EM1'),
('7101', 'SOFIB01','PS20','2020-10-01','EM1'),
('7101', 'SOFIB02','PS20','2020-10-01','EM1'),
('7101', 'SOFIB03','PS20','2020-10-01','EM1'),
('7101', 'SOFIB04','PS20','2020-10-01','EM2'),
('7101', 'SOFIB05','PS20','2020-10-01','EM1'),
('7101', 'SOFIB06','PS20','2020-10-01','EM1'),
('7102', 'SOFIB01','PS20','2020-10-01','EM1'),
('7102', 'SOFIB02','PS20','2020-10-01','EM3'),
('7102', 'SOFIB03','PS20','2020-10-01','EM1'),
('7102', 'SOFIB04','PS20','2020-10-01','EM1'),
('7102', 'SOFIB05','PS20','2020-10-01','EM1'),
('7102', 'SOFIB06','PS20','2020-10-01','EM3'),
('7103', 'SOFIB01','PS20','2020-10-01','EM1'),
('7103', 'SOFIB02','PS20','2020-10-01','EM2'),
('7103', 'SOFIB03','PS20','2020-10-01','EM1'),
('7103', 'SOFIB04','PS20','2020-10-01','EM1'),
('7103', 'SOFIB05','PS20','2020-10-01','EM3'),
('7103', 'SOFIB06','PS20','2020-10-01','EM1'),
('7104', 'SOFIB01','PS20','2020-10-01','EM1'),
('7104', 'SOFIB02','PS20','2020-10-01','EM1'),
('7104', 'SOFIB03','PS20','2020-10-01','EM3'),
('7104', 'SOFIB04','PS20','2020-10-01','EM1'),
('7104', 'SOFIB05','PS20','2020-10-01','EM2'),
('7104', 'SOFIB06','PS20','2020-10-01','EM2'),
('7105', 'SOFIB04','PS20','2020-10-01','EM1'),
('7105', 'SOFIB05','PS20','2020-10-01','EM1'),
('7105', 'SOFIB03','PS20','2020-10-01','EM1'),
('7106', 'SOFIB01','PS20','2020-10-01','EM1'),
('7106', 'SOFIB02','PS20','2020-10-01','EM1'),
('7106', 'SOFIB03','PS20','2020-10-01','EM2'),
('7106', 'SOFIB04','PS20','2020-10-01','EM1'),
('7106', 'SOFIB05','PS20','2020-10-01','EM2'),
('7106', 'SOFIB06','PS20','2020-10-01','EM1'),
('7107', 'SOFIB01','PS20','2020-10-01','EM1'),
('7107', 'SOFIB02','PS20','2020-10-01','EM2'),
('7107', 'SOFIB04','PS20','2020-10-01','EM1'),
('7107', 'SOFIB05','PS20','2020-10-01','EM3'),
('7107', 'SOFIB06','PS20','2020-10-01','EM1'),
('7108', 'SOFIB01','PS20','2020-10-01','EM1'),
('7108', 'SOFIB02','PS20','2020-10-01','EM1'),
('7108', 'SOFIB03','PS20','2020-10-01','EM2'),
('7108', 'SOFIB04','PS20','2020-10-01','EM1'),
('7108', 'SOFIB05','PS20','2020-10-01','EM1'),
('7108', 'SOFIB06','PS20','2020-10-01','EM2'),
('7109', 'SOFIB01','PS20','2020-10-01','EM2'),
('7109', 'SOFIB02','PS20','2020-10-01','EM1'),
('7109', 'SOFIB03','PS20','2020-10-01','EM1'),
('7109', 'SOFIB04','PS20','2020-10-01','EM1'),
('7109', 'SOFIB05','PS20','2020-10-01','EM1'),
('7109', 'SOFIB06','PS20','2020-10-01','EM2'),
('7110', 'SOFIB01','PS20','2020-10-01','EM1'),
('7110', 'SOFIB02','PS20','2020-10-01','EM1'),
('7110', 'SOFIB03','PS20','2020-10-01','EM1'),
('7110', 'SOFIB04','PS20','2020-10-01','EM1'),
('7110', 'SOFIB05','PS20','2020-10-01','EM1'),
('7110', 'SOFIB06','PS20','2020-10-01','EM1'),
('7111', 'SOFIB07','PA21','2021-05-01','EM1'),
('7111', 'SOFIB08','PA21','2021-05-01','EM1'),
('7111', 'SOFIB09','PA21','2021-05-01','EM1'),
('7111', 'SOFIB10','PA21','2021-05-01','EM1'),
('7111', 'SOFIB11','PA21','2021-05-01','EM1'),
('7111', 'SOFIB12','PA21','2021-05-01','EM1'),
('7112', 'SOFIB07','PA21','2021-05-01','EM1'),
('7112', 'SOFIB08','PA21','2021-05-01','EM2'),
('7112', 'SOFIB09','PA21','2021-05-01','EM1'),
('7112', 'SOFIB10','PA21','2021-05-01','EM2'),
('7112', 'SOFIB11','PA21','2021-05-01','EM1'),
('7112', 'SOFIB12','PA21','2021-05-01','EM3'),
('7113', 'SOFIB07','PA21','2021-05-01','EM3'),
('7113', 'SOFIB08','PA21','2021-05-01','EM1'),
('7113', 'SOFIB09','PA21','2021-05-01','EM1'),
('7113', 'SOFIB10','PA21','2021-05-01','EM3'),
('7113', 'SOFIB11','PA21','2021-05-01','EM1'),
('7113', 'SOFIB12','PA21','2021-05-01','EM1'),
('7114', 'SOFIB07','PA21','2021-05-01','EM1'),
('7114', 'SOFIB08','PA21','2021-05-01','EM1'),
('7114', 'SOFIB09','PA21','2021-05-01','EM1'),
('7114', 'SOFIB10','PA21','2021-05-01','EM1'),
('7114', 'SOFIB11','PA21','2021-05-01','EM1'),
('7114', 'SOFIB12','PA21','2021-05-01','EM1'),
('7115', 'SOFIB07','PA21','2021-05-01','EM1'),
('7115', 'SOFIB08','PA21','2021-05-01','EM1'),
('7115', 'SOFIB09','PA21','2021-05-01','EM1'),
('7115', 'SOFIB10','PA21','2021-05-01','EM3'),
('7115', 'SOFIB11','PA21','2021-05-01','EM1'),
('7115', 'SOFIB12','PA21','2021-05-01','EM1'),
('7116', 'SOFIB07','PA21','2021-05-01','EM1'),
('7116', 'SOFIB08','PA21','2021-05-01','EM1'),
('7116', 'SOFIB09','PA21','2021-05-01','EM3'),
('7116', 'SOFIB10','PA21','2021-05-01','EM1'),
('7116', 'SOFIB11','PA21','2021-05-01','EM1'),
('7116', 'SOFIB12','PA21','2021-05-01','EM3'),
('7117', 'SOFIB07','PA21','2021-05-01','EM1'),
('7117', 'SOFIB08','PA21','2021-05-01','EM1'),
('7117', 'SOFIB09','PA21','2021-05-01','EM1'),
('7117', 'SOFIB10','PA21','2021-05-01','EM1'),
('7117', 'SOFIB11','PA21','2021-05-01','EM3'),
('7117', 'SOFIB12','PA21','2021-05-01','EM1'),
('7118', 'SOFIB07','PA21','2021-05-01','EM1'),
('7118', 'SOFIB08','PA21','2021-05-01','EM1'),
('7118', 'SOFIB09','PA21','2021-05-01','EM1'),
('7118', 'SOFIB10','PA21','2021-05-01','EM1'),
('7118', 'SOFIB11','PA21','2021-05-01','EM1'),
('7118', 'SOFIB12','PA21','2021-05-01','EM1'),
('7119', 'SOFIB08','PA21','2021-05-01','EM1'),
('7119', 'SOFIB09','PA21','2021-05-01','EM1'),
('7119', 'SOFIB10','PA21','2021-05-01','EM1'),
('7119', 'SOFIB11','PA21','2021-05-01','EM1'),
('7119', 'SOFIB12','PA21','2021-05-01','EM1'),
('7120', 'SOFIB08','PA21','2021-05-01','EM1'),
('7120', 'SOFIB09','PA21','2021-05-01','EM1'),
('7120', 'SOFIB10','PA21','2021-05-01','EM1'),
('7120', 'SOFIB11','PA21','2021-05-01','EM1'),
('7120', 'SOFIB12','PA21','2021-05-01','EM3');
Select *from [dbo].[matricula]

INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7100', 'SOFIB01','PA21','2020-10-01','EM1'),
('7100', 'SOFIB02','PA21','2020-10-01','EM1'),
('7100', 'SOFIB04','PA21','2020-10-01','EM1'),
('7100', 'SOFIB05','PA21','2020-10-01','EM1'),
('7100', 'SOFIB06','PA21','2020-10-01','EM1'),
('7101', 'SOFIB06','PA21','2020-10-01','EM1'),
('7102', 'SOFIB01','PA21','2020-10-01','EM1'),
('7102', 'SOFIB03','PA21','2020-10-01','EM1'),
('7103', 'SOFIB05','PA21','2020-10-01','EM3'),
('7103', 'SOFIB06','PA21','2020-10-01','EM1'),
('7104', 'SOFIB01','PA21','2020-10-01','EM1'),
('7104', 'SOFIB02','PA21','2020-10-01','EM1'),
('7105', 'SOFIB05','PA21','2020-10-01','EM1'),
('7105', 'SOFIB03','PA21','2020-10-01','EM1'),
('7108', 'SOFIB01','PA21','2020-10-01','EM1'),
('7110', 'SOFIB06','PA21','2020-10-01','EM1');
INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7221', 'SOFIB13','PN21','2021-12-01','EM1'),
('7221', 'SOFIB14','PN21','2021-12-01','EM3'),
('7221', 'SOFIB15','PN21','2021-12-01','EM1'),
('7221', 'SOFIB16','PN21','2021-12-01','EM1'),
('7221', 'SOFIB17','PN21','2021-12-01','EM3'),
('7221', 'SOFIB18','PN21','2021-12-01','EM1'),
('7222', 'SOFIB13','PN21','2021-12-01','EM1'),
('7222', 'SOFIB14','PN21','2021-12-01','EM3'),
('7222', 'SOFIB15','PN21','2021-12-01','EM1'),
('7222', 'SOFIB16','PN21','2021-12-01','EM2'),
('7222', 'SOFIB17','PN21','2021-12-01','EM1'),
('7222', 'SOFIB18','PN21','2021-12-01','EM1'),
('7223', 'SOFIB13','PN21','2021-12-01','EM1'),
('7223', 'SOFIB14','PN21','2021-12-01','EM1'),
('7223', 'SOFIB15','PN21','2021-12-01','EM1'),
('7223', 'SOFIB16','PN21','2021-12-01','EM1'),
('7223', 'SOFIB17','PN21','2021-12-01','EM1'),
('7223', 'SOFIB18','PN21','2021-12-01','EM1'),
('7224', 'SOFIB13','PN21','2021-12-01','EM1'),
('7224', 'SOFIB14','PN21','2021-12-01','EM1'),
('7224', 'SOFIB15','PN21','2021-12-01','EM1'),
('7224', 'SOFIB16','PN21','2021-12-01','EM1'),
('7224', 'SOFIB17','PN21','2021-12-01','EM1'),
('7224', 'SOFIB18','PN21','2021-12-01','EM1'),
('7225', 'SOFIB13','PN21','2021-12-01','EM1'),
('7225', 'SOFIB14','PN21','2021-12-01','EM3'),
('7225', 'SOFIB15','PN21','2021-12-01','EM1'),
('7225', 'SOFIB16','PN21','2021-12-01','EM1'),
('7225', 'SOFIB17','PN21','2021-12-01','EM3'),
('7225', 'SOFIB18','PN21','2021-12-01','EM1'),
('7226', 'SOFIB13','PN21','2021-12-01','EM1'),
('7226', 'SOFIB14','PN21','2021-12-01','EM1'),
('7226', 'SOFIB15','PN21','2021-12-01','EM1'),
('7226', 'SOFIB16','PN21','2021-12-01','EM2'),
('7226', 'SOFIB18','PN21','2021-12-01','EM1'),
('7227', 'SOFIB13','PN21','2021-12-01','EM3'),
('7227', 'SOFIB14','PN21','2021-12-01','EM1'),
('7227', 'SOFIB15','PN21','2021-12-01','EM1'),
('7227', 'SOFIB16','PN21','2021-12-01','EM1'),
('7227', 'SOFIB17','PN21','2021-12-01','EM3'),
('7227', 'SOFIB18','PN21','2021-12-01','EM1'),
('7228', 'SOFIB13','PN21','2021-12-01','EM1'),
('7228', 'SOFIB14','PN21','2021-12-01','EM3'),
('7228', 'SOFIB15','PN21','2021-12-01','EM1'),
('7228', 'SOFIB16','PN21','2021-12-01','EM1'),
('7228', 'SOFIB17','PN21','2021-12-01','EM3'),
('7228', 'SOFIB18','PN21','2021-12-01','EM1'),
('7229', 'SOFIB13','PN21','2021-12-01','EM1'),
('7229', 'SOFIB14','PN21','2021-12-01','EM1'),
('7229', 'SOFIB15','PN21','2021-12-01','EM3'),
('7229', 'SOFIB18','PN21','2021-12-01','EM1'),
('7230', 'SOFIB13','PN21','2021-12-01','EM1'),
('7230', 'SOFIB14','PN21','2021-12-01','EM3'),
('7230', 'SOFIB15','PN21','2021-12-01','EM1'),
('7230', 'SOFIB16','PN21','2021-12-01','EM1'),
('7230', 'SOFIB17','PN21','2021-12-01','EM2'),
('7230', 'SOFIB18','PN21','2021-12-01','EM1'),
('7231', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7231', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7231', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7231', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7231', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7231', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7232', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7232', 'SOFIP20','PJ22','2022-07-01','EM2'),
('7232', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7232', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7232', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7232', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7233', 'SOFIB19','PJ22','2022-07-01','EM2'),
('7233', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7233', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7233', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7233', 'SOFIP23','PJ22','2022-07-01','EM3'),
('7233', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7234', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7234', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7234', 'SOFIP21','PJ22','2022-07-01','EM3'),
('7234', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7234', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7234', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7235', 'SOFIB19','PJ22','2022-07-01','EM3'),
('7235', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7235', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7235', 'SOFIP22','PJ22','2022-07-01','EM3'),
('7235', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7235', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7236', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7236', 'SOFIP20','PJ22','2022-07-01','EM3'),
('7236', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7236', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7236', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7236', 'SOFIP24','PJ22','2022-07-01','EM3'),
('7237', 'SOFIB19','PJ22','2022-07-01','EM2'),
('7237', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7237', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7237', 'SOFIP24','PJ22','2022-07-01','EM2'),
('7238', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7238', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7238', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7238', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7238', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7238', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7239', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7239', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7239', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7239', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7239', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7239', 'SOFIP24','PJ22','2022-07-01','EM1'),
('7240', 'SOFIB19','PJ22','2022-07-01','EM1'),
('7240', 'SOFIP20','PJ22','2022-07-01','EM1'),
('7240', 'SOFIP21','PJ22','2022-07-01','EM1'),
('7240', 'SOFIP22','PJ22','2022-07-01','EM1'),
('7240', 'SOFIP23','PJ22','2022-07-01','EM1'),
('7240', 'SOFIP24','PJ22','2022-07-01','EM1');
SELECT *FROM [dbo].[evaluacion]
INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7341', 'SOFIP25','PM23','2023-02-01','EM1'),
('7341', 'SOFIP26','PM23','2023-02-01','EM1'),
('7341', 'SOFIP27','PM23','2023-02-01','EM1'),
('7341', 'SOFIP28','PM23','2023-02-01','EM3'),
('7341', 'SOFIP29','PM23','2023-02-01','EM1'),
('7341', 'SOFIP30','PM23','2023-02-01','EM1'),
('7342', 'SOFIP25','PM23','2023-02-01','EM1'),
('7342', 'SOFIP26','PM23','2023-02-01','EM3'),
('7342', 'SOFIP27','PM23','2023-02-01','EM1'),
('7342', 'SOFIP28','PM23','2023-02-01','EM1'),
('7342', 'SOFIP29','PM23','2023-02-01','EM3'),
('7342', 'SOFIP30','PM23','2023-02-01','EM1'),
('7343', 'SOFIP25','PM23','2023-02-01','EM1'),
('7343', 'SOFIP26','PM23','2023-02-01','EM3'),
('7343', 'SOFIP27','PM23','2023-02-01','EM1'),
('7343', 'SOFIP28','PM23','2023-02-01','EM1'),
('7343', 'SOFIP29','PM23','2023-02-01','EM1'),
('7343', 'SOFIP30','PM23','2023-02-01','EM1'),
('7344', 'SOFIP25','PM23','2023-02-01','EM1'),
('7344', 'SOFIP26','PM23','2023-02-01','EM1'),
('7344', 'SOFIP27','PM23','2023-02-01','EM3'),
('7344', 'SOFIP29','PM23','2023-02-01','EM1'),
('7344', 'SOFIP30','PM23','2023-02-01','EM1'),
('7345', 'SOFIP25','PM23','2023-02-01','EM1'),
('7345', 'SOFIP26','PM23','2023-02-01','EM1'),
('7345', 'SOFIP27','PM23','2023-02-01','EM2'),
('7345', 'SOFIP29','PM23','2023-02-01','EM1'),
('7345', 'SOFIP30','PM23','2023-02-01','EM1'),
('7346', 'SOFIP25','PM23','2023-02-01','EM1'),
('7346', 'SOFIP26','PM23','2023-02-01','EM1'),
('7346', 'SOFIP27','PM23','2023-02-01','EM1'),
('7346', 'SOFIP28','PM23','2023-02-01','EM1'),
('7346', 'SOFIP29','PM23','2023-02-01','EM1'),
('7346', 'SOFIP30','PM23','2023-02-01','EM1'),
('7347', 'SOFIP25','PM23','2023-02-01','EM1'),
('7347', 'SOFIP26','PM23','2023-02-01','EM1'),
('7347', 'SOFIP27','PM23','2023-02-01','EM1'),
('7347', 'SOFIP28','PM23','2023-02-01','EM1'),
('7347', 'SOFIP29','PM23','2023-02-01','EM1'),
('7347', 'SOFIP30','PM23','2023-02-01','EM1'),
('7348', 'SOFIP25','PM23','2023-02-01','EM1'),
('7348', 'SOFIP26','PM23','2023-02-01','EM1'),
('7348', 'SOFIP27','PM23','2023-02-01','EM1'),
('7348', 'SOFIP28','PM23','2023-02-01','EM1'),
('7348', 'SOFIP29','PM23','2023-02-01','EM1'),
('7348', 'SOFIP30','PM23','2023-02-01','EM1'),
('7349', 'SOFIP25','PM23','2023-02-01','EM1'),
('7349', 'SOFIP26','PM23','2023-02-01','EM1'),
('7349', 'SOFIP27','PM23','2023-02-01','EM3'),
('7349', 'SOFIP28','PM23','2023-02-01','EM1'),
('7349', 'SOFIP29','PM23','2023-02-01','EM1'),
('7349', 'SOFIP30','PM23','2023-02-01','EM2'),
('7350', 'SOFIP25','PM23','2023-02-01','EM1'),
('7350', 'SOFIP26','PM23','2023-02-01','EM1'),
('7350', 'SOFIP29','PM23','2023-02-01','EM3'),
('7350', 'SOFIP30','PM23','2023-02-01','EM1'),
('7351', 'SOFIP25','PM23','2023-02-01','EM1'),
('7351', 'SOFIP26','PM23','2023-02-01','EM1'),
('7351', 'SOFIP27','PM23','2023-02-01','EM1'),
('7351', 'SOFIP28','PM23','2023-02-01','EM1'),
('7351', 'SOFIP29','PM23','2023-02-01','EM3'),
('7351', 'SOFIP30','PM23','2023-02-01','EM1'),
('7352', 'SOFIP25','PM23','2023-02-01','EM1'),
('7352', 'SOFIP26','PM23','2023-02-01','EM1'),
('7352', 'SOFIP27','PM23','2023-02-01','EM1'),
('7352', 'SOFIP28','PM23','2023-02-01','EM1'),
('7352', 'SOFIP29','PM23','2023-02-01','EM1'),
('7352', 'SOFIP30','PM23','2023-02-01','EM1'),
('7353', 'SOFIP25','PM23','2023-02-01','EM1'),
('7353', 'SOFIP26','PM23','2023-02-01','EM1'),
('7353', 'SOFIP27','PM23','2023-02-01','EM1'),
('7353', 'SOFIP30','PM23','2023-02-01','EM1'),
('7354', 'SOFIP25','PM23','2023-02-01','EM1'),
('7354', 'SOFIP26','PM23','2023-02-01','EM1'),
('7354', 'SOFIP27','PM23','2023-02-01','EM1'),
('7354', 'SOFIP28','PM23','2023-02-01','EM1'),
('7354', 'SOFIP29','PM23','2023-02-01','EM1'),
('7354', 'SOFIP30','PM23','2023-02-01','EM1'),
('7355', 'SOFIP25','PM23','2023-02-01','EM1'),
('7355', 'SOFIP26','PM23','2023-02-01','EM1'),
('7355', 'SOFIP27','PM23','2023-02-01','EM1'),
('7355', 'SOFIP28','PM23','2023-02-01','EM1'),
('7355', 'SOFIP29','PM23','2023-02-01','EM1'),
('7355', 'SOFIP30','PM23','2023-02-01','EM1'),
('7356', 'SOFIP31','PM23','2023-02-01','EM1'),
('7356', 'SOFIP32','PM23','2023-02-01','EM1'),
('7356', 'SOFIP33','PM23','2023-02-01','EM1'),
('7356', 'SOFIP34','PM23','2023-02-01','EM1'),
('7356', 'SOFIP35','PM23','2023-02-01','EM1'),
('7356', 'SOFIP36','PM23','2023-02-01','EM1'),
('7356', 'SOFIP37','PM23','2023-02-01','EM1'),
('7357', 'SOFIP31','PM23','2023-02-01','EM1'),
('7357', 'SOFIP33','PM23','2023-02-01','EM1'),
('7357', 'SOFIP34','PM23','2023-02-01','EM1'),
('7357', 'SOFIP37','PM23','2023-02-01','EM1'),
('7358', 'SOFIP31','PM23','2023-02-01','EM1'),
('7358', 'SOFIP32','PM23','2023-02-01','EM1'),
('7358', 'SOFIP34','PM23','2023-02-01','EM1'),
('7358', 'SOFIP35','PM23','2023-02-01','EM1'),
('7358', 'SOFIP36','PM23','2023-02-01','EM1'),
('7359', 'SOFIP31','PM23','2023-02-01','EM2'),
('7359', 'SOFIP32','PM23','2023-02-01','EM1'),
('7359', 'SOFIP33','PM23','2023-02-01','EM1'),
('7359', 'SOFIP34','PM23','2023-02-01','EM3'),
('7359', 'SOFIP35','PM23','2023-02-01','EM1'),
('7359', 'SOFIP36','PM23','2023-02-01','EM1'),
('7359', 'SOFIP37','PM23','2023-02-01','EM1'),
('7360', 'SOFIP31','PM23','2023-02-01','EM1'),
('7360', 'SOFIP32','PM23','2023-02-01','EM1'),
('7360', 'SOFIP33','PM23','2023-02-01','EM1'),
('7360', 'SOFIP34','PM23','2023-02-01','EM3'),
('7360', 'SOFIP35','PM23','2023-02-01','EM1'),
('7360', 'SOFIP36','PM23','2023-02-01','EM2'),
('7360', 'SOFIP37','PM23','2023-02-01','EM1'),
('7361', 'SOFIP31','PM23','2023-02-01','EM1'),
('7361', 'SOFIP32','PM23','2023-02-01','EM1'),
('7361', 'SOFIP33','PM23','2023-02-01','EM2'),
('7361', 'SOFIP34','PM23','2023-02-01','EM1'),
('7361', 'SOFIP35','PM23','2023-02-01','EM1'),
('7361', 'SOFIP36','PM23','2023-02-01','EM3'),
('7361', 'SOFIP37','PM23','2023-02-01','EM1'),
('7362', 'SOFIP31','PM23','2023-02-01','EM1'),
('7362', 'SOFIP32','PM23','2023-02-01','EM1'),
('7362', 'SOFIP33','PM23','2023-02-01','EM1'),
('7362', 'SOFIP34','PM23','2023-02-01','EM1'),
('7362', 'SOFIP35','PM23','2023-02-01','EM1'),
('7362', 'SOFIP36','PM23','2023-02-01','EM1'),
('7362', 'SOFIP37','PM23','2023-02-01','EM1'),
('7363', 'SOFIP31','PM23','2023-02-01','EM3'),
('7363', 'SOFIP32','PM23','2023-02-01','EM1'),
('7363', 'SOFIP33','PM23','2023-02-01','EM1'),
('7363', 'SOFIP35','PM23','2023-02-01','EM1'),
('7363', 'SOFIP36','PM23','2023-02-01','EM1'),
('7363', 'SOFIP37','PM23','2023-02-01','EM1'),
('7364', 'SOFIP31','PM23','2023-02-01','EM1'),
('7364', 'SOFIP32','PM23','2023-02-01','EM3'),
('7364', 'SOFIP34','PM23','2023-02-01','EM1'),
('7364', 'SOFIP35','PM23','2023-02-01','EM1'),
('7364', 'SOFIP36','PM23','2023-02-01','EM1'),
('7364', 'SOFIP37','PM23','2023-02-01','EM3'),
('7365', 'SOFIP31','PM23','2023-02-01','EM1'),
('7365', 'SOFIP32','PM23','2023-02-01','EM1'),
('7365', 'SOFIP33','PM23','2023-02-01','EM1'),
('7365', 'SOFIP34','PM23','2023-02-01','EM1'),
('7365', 'SOFIP36','PM23','2023-02-01','EM1'),
('7365', 'SOFIP37','PM23','2023-02-01','EM3'),
('7366', 'SOFIP31','PM23','2023-02-01','EM1'),
('7366', 'SOFIP32','PM23','2023-02-01','EM1'),
('7366', 'SOFIP33','PM23','2023-02-01','EM2'),
('7366', 'SOFIP34','PM23','2023-02-01','EM1'),
('7366', 'SOFIP35','PM23','2023-02-01','EM1'),
('7366', 'SOFIP36','PM23','2023-02-01','EM3'),
('7366', 'SOFIP37','PM23','2023-02-01','EM1'),
('7367', 'SOFIP31','PM23','2023-02-01','EM1'),
('7367', 'SOFIP32','PM23','2023-02-01','EM1'),
('7367', 'SOFIP33','PM23','2023-02-01','EM1'),
('7367', 'SOFIP34','PM23','2023-02-01','EM1'),
('7367', 'SOFIP35','PM23','2023-02-01','EM1'),
('7367', 'SOFIP36','PM23','2023-02-01','EM1'),
('7367', 'SOFIP37','PM23','2023-02-01','EM1'),
('7368', 'SOFIP31','PM23','2023-02-01','EM1'),
('7368', 'SOFIP32','PM23','2023-02-01','EM3'),
('7368', 'SOFIP33','PM23','2023-02-01','EM1'),
('7368', 'SOFIP34','PM23','2023-02-01','EM1'),
('7368', 'SOFIP35','PM23','2023-02-01','EM1'),
('7368', 'SOFIP36','PM23','2023-02-01','EM1'),
('7368', 'SOFIP37','PM23','2023-02-01','EM1'),
('7369', 'SOFIP31','PM23','2023-02-01','EM2'),
('7369', 'SOFIP32','PM23','2023-02-01','EM1'),
('7369', 'SOFIP33','PM23','2023-02-01','EM1'),
('7369', 'SOFIP34','PM23','2023-02-01','EM1'),
('7369', 'SOFIP36','PM23','2023-02-01','EM1'),
('7369', 'SOFIP37','PM23','2023-02-01','EM3'),
('7370', 'SOFIP31','PM23','2023-02-01','EM1'),
('7370', 'SOFIP32','PM23','2023-02-01','EM1'),
('7370', 'SOFIP33','PM23','2023-02-01','EM1'),
('7370', 'SOFIP34','PM23','2023-02-01','EM1'),
('7370', 'SOFIP35','PM23','2023-02-01','EM1'),
('7370', 'SOFIP37','PM23','2023-02-01','EM1');

INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7341', 'SOFIP25','PA24','2023-02-01','EM1'),
('7343', 'SOFIP25','PA24','2023-02-01','EM1'),
('7343', 'SOFIP26','PA24','2023-02-01','EM3'),
('7344', 'SOFIP25','PA24','2023-02-01','EM1'),
('7344', 'SOFIP30','PA24','2023-02-01','EM1'),
('7345', 'SOFIP25','PA24','2023-02-01','EM1'),
('7345', 'SOFIP26','PA24','2023-02-01','EM1'),
('7345', 'SOFIP30','PA24','2023-02-01','EM1'),
('7346', 'SOFIP25','PA24','2023-02-01','EM1'),
('7347', 'SOFIP25','PA24','2023-02-01','EM1'),
('7347', 'SOFIP30','PA24','2023-02-01','EM1'),
('7348', 'SOFIP25','PA24','2023-02-01','EM1'),
('7349', 'SOFIP25','PA24','2023-02-01','EM1'),
('7350', 'SOFIP25','PA24','2023-02-01','EM1'),
('7351', 'SOFIP25','PA24','2023-02-01','EM1'),
('7352', 'SOFIP25','PA24','2023-02-01','EM1'),
('7352', 'SOFIP29','PA24','2023-02-01','EM1'),
('7352', 'SOFIP30','PA24','2023-02-01','EM1'),
('7354', 'SOFIP25','PA24','2023-02-01','EM1'),
('7354', 'SOFIP26','PA24','2023-02-01','EM1'),
('7355', 'SOFIP25','PA24','2023-02-01','EM1');

INSERT INTO matricula (cod_estudiante, cod_materia, cod_periodo, fecha_matricula, estado) VALUES
('7470', 'SOFIP38','PA24','2024-05-01','EM1'),
('7470', 'SOFIP39','PA24','2024-05-01','EM1'),
('7470', 'SOFIP40','PA24','2024-05-01','EM2'),
('7470', 'SOFIP41','PA24','2024-05-01','EM1'),
('7470', 'SOFIP42','PA24','2024-05-01','EM1'),
('7470', 'SOFIP43','PA24','2024-05-01','EM3'),
('7470', 'SOFIP44','PA24','2024-05-01','EM1'),
('7471', 'SOFIP38','PA24','2024-05-01','EM1'),
('7471', 'SOFIP39','PA24','2024-05-01','EM1'),
('7471', 'SOFIP40','PA24','2024-05-01','EM1'),
('7471', 'SOFIP41','PA24','2024-05-01','EM1'),
('7471', 'SOFIP42','PA24','2024-05-01','EM2'),
('7471', 'SOFIP43','PA24','2024-05-01','EM3'),
('7471', 'SOFIP44','PA24','2024-05-01','EM1'),
('7472', 'SOFIP38','PA24','2024-05-01','EM1'),
('7472', 'SOFIP39','PA24','2024-05-01','EM1'),
('7472', 'SOFIP40','PA24','2024-05-01','EM1'),
('7472', 'SOFIP41','PA24','2024-05-01','EM3'),
('7472', 'SOFIP42','PA24','2024-05-01','EM1'),
('7472', 'SOFIP44','PA24','2024-05-01','EM2'),
('7473', 'SOFIP38','PA24','2024-05-01','EM1'),
('7473', 'SOFIP39','PA24','2024-05-01','EM1'),
('7473', 'SOFIP40','PA24','2024-05-01','EM1'),
('7473', 'SOFIP41','PA24','2024-05-01','EM1'),
('7473', 'SOFIP42','PA24','2024-05-01','EM1'),
('7473', 'SOFIP43','PA24','2024-05-01','EM3'),
('7473', 'SOFIP44','PA24','2024-05-01','EM1'),
('7474', 'SOFIP38','PA24','2024-05-01','EM2'),
('7474', 'SOFIP41','PA24','2024-05-01','EM1'),
('7474', 'SOFIP42','PA24','2024-05-01','EM3'),
('7474', 'SOFIP43','PA24','2024-05-01','EM1'),
('7474', 'SOFIP44','PA24','2024-05-01','EM1'),
('7475', 'SOFIP38','PA24','2024-05-01','EM1'),
('7475', 'SOFIP39','PA24','2024-05-01','EM1'),
('7475', 'SOFIP40','PA24','2024-05-01','EM1'),
('7475', 'SOFIP41','PA24','2024-05-01','EM1'),
('7475', 'SOFIP42','PA24','2024-05-01','EM1'),
('7475', 'SOFIP43','PA24','2024-05-01','EM1'),
('7475', 'SOFIP44','PA24','2024-05-01','EM1'),
('7476', 'SOFIP38','PA24','2024-05-01','EM1'),
('7476', 'SOFIP39','PA24','2024-05-01','EM1'),
('7476', 'SOFIP40','PA24','2024-05-01','EM1'),
('7476', 'SOFIP41','PA24','2024-05-01','EM1'),
('7476', 'SOFIP42','PA24','2024-05-01','EM1'),
('7476', 'SOFIP43','PA24','2024-05-01','EM1'),
('7476', 'SOFIP44','PA24','2024-05-01','EM1'),
('7477', 'SOFIP38','PA24','2024-05-01','EM1'),
('7477', 'SOFIP39','PA24','2024-05-01','EM2'),
('7477', 'SOFIP40','PA24','2024-05-01','EM1'),
('7477', 'SOFIP41','PA24','2024-05-01','EM1'),
('7477', 'SOFIP42','PA24','2024-05-01','EM1'),
('7477', 'SOFIP43','PA24','2024-05-01','EM1'),
('7477', 'SOFIP44','PA24','2024-05-01','EM1'),
('7478', 'SOFIP38','PA24','2024-05-01','EM1'),
('7478', 'SOFIP39','PA24','2024-05-01','EM2'),
('7478', 'SOFIP40','PA24','2024-05-01','EM1'),
('7478', 'SOFIP41','PA24','2024-05-01','EM1'),
('7478', 'SOFIP42','PA24','2024-05-01','EM1'),
('7478', 'SOFIP43','PA24','2024-05-01','EM1'),
('7478', 'SOFIP44','PA24','2024-05-01','EM1'),
('7479', 'SOFIP38','PA24','2024-05-01','EM3'),
('7479', 'SOFIP39','PA24','2024-05-01','EM1'),
('7479', 'SOFIP40','PA24','2024-05-01','EM1'),
('7479', 'SOFIP41','PA24','2024-05-01','EM1'),
('7479', 'SOFIP42','PA24','2024-05-01','EM1'),
('7479', 'SOFIP43','PA24','2024-05-01','EM1'),
('7479', 'SOFIP44','PA24','2024-05-01','EM3'),
('7480', 'SOFIP45','PA24','2024-05-01','EM1'),
('7480', 'SOFIP46','PA24','2024-05-01','EM1'),
('7480', 'SOFIP47','PA24','2024-05-01','EM1'),
('7480', 'SOFIP48','PA24','2024-05-01','EM1'),
('7480', 'SOFIP49','PA24','2024-05-01','EM1'),
('7480', 'SOFII50','PA24','2024-05-01','EM3'),
('7481', 'SOFIP45','PA24','2024-05-01','EM1'),
('7481', 'SOFIP46','PA24','2024-05-01','EM1'),
('7481', 'SOFIP47','PA24','2024-05-01','EM1'),
('7481', 'SOFIP48','PA24','2024-05-01','EM1'),
('7481', 'SOFIP49','PA24','2024-05-01','EM3'),
('7481', 'SOFII50','PA24','2024-05-01','EM1'),
('7482', 'SOFIP45','PA24','2024-05-01','EM1'),
('7482', 'SOFIP46','PA24','2024-05-01','EM1'),
('7482', 'SOFIP47','PA24','2024-05-01','EM1'),
('7482', 'SOFIP48','PA24','2024-05-01','EM1'),
('7482', 'SOFIP49','PA24','2024-05-01','EM3'),
('7482', 'SOFII50','PA24','2024-05-01','EM1'),
('7483', 'SOFIP45','PA24','2024-05-01','EM1'),
('7483', 'SOFIP46','PA24','2024-05-01','EM1'),
('7483', 'SOFIP47','PA24','2024-05-01','EM1'),
('7483', 'SOFIP49','PA24','2024-05-01','EM1'),
('7483', 'SOFII50','PA24','2024-05-01','EM3'),
('7485', 'SOFIP45','PA24','2024-05-01','EM1'),
('7485', 'SOFIP46','PA24','2024-05-01','EM1'),
('7485', 'SOFIP47','PA24','2024-05-01','EM1'),
('7485', 'SOFIP48','PA24','2024-05-01','EM2'),
('7485', 'SOFIP49','PA24','2024-05-01','EM1'),
('7485', 'SOFII50','PA24','2024-05-01','EM3'),
('7486', 'SOFIP51','PA24','2024-05-01','EM1'),
('7486', 'SOFIP52','PA24','2024-05-01','EM1'),
('7486', 'SOFIP53','PA24','2024-05-01','EM1'),
('7486', 'SOFII54','PA24','2024-05-01','EM1'),
('7487', 'SOFIP51','PA24','2024-05-01','EM1'),
('7487', 'SOFIP52','PA24','2024-05-01','EM1'),
('7487', 'SOFIP53','PA24','2024-05-01','EM1'),
('7487', 'SOFII54','PA24','2024-05-01','EM1'),
('7488', 'SOFIP51','PA24','2024-05-01','EM1'),
('7488', 'SOFIP52','PA24','2024-05-01','EM1'),
('7488', 'SOFIP53','PA24','2024-05-01','EM1'),
('7488', 'SOFII54','PA24','2024-05-01','EM1'),
('7489', 'SOFIP51','PA24','2024-05-01','EM1'),
('7489', 'SOFIP52','PA24','2024-05-01','EM1'),
('7489', 'SOFIP53','PA24','2024-05-01','EM1'),
('7489', 'SOFII54','PA24','2024-05-01','EM1'),
('7490', 'SOFIP51','PA24','2024-05-01','EM1'),
('7490', 'SOFIP52','PA24','2024-05-01','EM1'),
('7490', 'SOFIP53','PA24','2024-05-01','EM1'),
('7490', 'SOFII54','PA24','2024-05-01','EM1');
SELECT *FROM [dbo].[evaluacion]

INSERT INTO evaluacion (cod_estudiante, cod_materia, cod_periodo, nota1, nota2, notaFinal, estado) VALUES
('7100', 'SOFIB01','PS20','8','10','18','EE1'),
('7100', 'SOFIB02','PS20','8','4','12','EE2'),
('7100', 'SOFIB03','PS20','6','6','12','EE3'),
('7100', 'SOFIB04','PS20','3','2','5','EE2'),
('7100', 'SOFIB05','PS20','7','10','17','EE1'),
('7100', 'SOFIB06','PS20','8','10','18','EE1'),
('7101', 'SOFIB01','PS20','7','10','17','EE1'),
('7101', 'SOFIB02','PS20','6','6','12','EE3'),
('7101', 'SOFIB03','PS20','3','2','5','EE2'),
('7101', 'SOFIB04','PS20','7','10','17','EE1'),
('7101', 'SOFIB05','PS20','3','3','6','EE2'),
('7101', 'SOFIB06','PS20','3','2','5','EE2'),
('7102', 'SOFIB01','PS20','7','10','17','EE1'),
('7102', 'SOFIB02','PS20','6','6','12','EE3'),
('7102', 'SOFIB03','PS20','7','7','14','EE1'),
('7102', 'SOFIB04','PS20','7','10','17','EE1'),
('7102', 'SOFIB05','PS20','6','6','12','EE3'),
('7102', 'SOFIB06','PS20','6','6','12','EE3'),
('7103', 'SOFIB01','PS20','7','10','17','EE1'),
('7103', 'SOFIB02','PS20','6','10','16','EE1'),
('7103', 'SOFIB03','PS20','3','2','5','EE2'),
('7103', 'SOFIB04','PS20','8','10','18','EE1'),
('7103', 'SOFIB05','PS20','7','10','17','EE1'),
('7103', 'SOFIB06','PS20','8','10','18','EE1'),
('7104', 'SOFIB01','PS20','6','6','12','EE3'),
('7104', 'SOFIB02','PS20','7','10','17','EE1'),
('7104', 'SOFIB03','PS20','8','10','18','EE1'),
('7104', 'SOFIB04','PS20','7','10','17','EE1'),
('7104', 'SOFIB05','PS20','3','2','5','EE2'),
('7104', 'SOFIB06','PS20','8','10','18','EE1'),
('7105', 'SOFIB04','PS20','7','10','17','EE1'),
('7105', 'SOFIB05','PS20','8','4','12','EE2'),
('7105', 'SOFIB03','PS20','3','2','5','EE2'),
('7106', 'SOFIB01','PS20','6','6','12','EE3'),
('7106', 'SOFIB02','PS20','6','6','12','EE3'),
('7106', 'SOFIB03','PS20','8','4','12','EE2'),
('7106', 'SOFIB04','PS20','7','10','17','EE1'),
('7106', 'SOFIB05','PS20','8','10','18','EE1'),
('7106', 'SOFIB06','PS20','6','6','12','EE3'),
('7107', 'SOFIB01','PS20','7','10','17','EE1'),
('7107', 'SOFIB02','PS20','8','10','18','EE1'),
('7107', 'SOFIB04','PS20','7','10','17','EE1'),
('7107', 'SOFIB05','PS20','8','4','12','EE2'),
('7107', 'SOFIB06','PS20','3','2','5','EE2'),
('7108', 'SOFIB01','PS20','8','4','12','EE2'),
('7108', 'SOFIB02','PS20','6','6','12','EE3'),
('7108', 'SOFIB03','PS20','8','4','12','EE2'),
('7108', 'SOFIB04','PS20','7','10','17','EE1'),
('7108', 'SOFIB05','PS20','8','10','18','EE1'),
('7108', 'SOFIB06','PS20','8','10','18','EE1'),
('7109', 'SOFIB01','PS20','8','10','18','EE1'),
('7109', 'SOFIB02','PS20','6','6','12','EE3'),
('7109', 'SOFIB03','PS20','3','2','5','EE2'),
('7109', 'SOFIB04','PS20','8','4','12','EE2'),
('7109', 'SOFIB05','PS20','3','2','5','EE2'),
('7109', 'SOFIB06','PS20','8','10','18','EE1'),
('7110', 'SOFIB01','PS20','8','10','18','EE1'),
('7110', 'SOFIB02','PS20','7','10','17','EE1'),
('7110', 'SOFIB03','PS20','8','10','18','EE1'),
('7110', 'SOFIB04','PS20','3','2','5','EE2'),
('7110', 'SOFIB05','PS20','8','10','18','EE1'),
('7110', 'SOFIB06','PS20','6','6','12','EE3'),
('7111', 'SOFIB07','PA21','7','10','17','EE1'),
('7111', 'SOFIB08','PA21','8','10','18','EE1'),
('7111', 'SOFIB09','PA21','3','2','5','EE2'),
('7111', 'SOFIB10','PA21','8','4','12','EE2'),
('7111', 'SOFIB11','PA21','7','10','17','EE1'),
('7111', 'SOFIB12','PA21','8','10','18','EE1'),
('7112', 'SOFIB07','PA21','3','2','5','EE2'),
('7112', 'SOFIB08','PA21','6','6','12','EE3'),
('7112', 'SOFIB09','PA21','7','10','17','EE1'),
('7112', 'SOFIB10','PA21','8','10','18','EE1'),
('7112', 'SOFIB11','PA21','3','2','5','EE2'),
('7112', 'SOFIB12','PA21','8','4','12','EE2'),
('7113', 'SOFIB07','PA21','7','10','17','EE1'),
('7113', 'SOFIB08','PA21','8','10','18','EE1'),
('7113', 'SOFIB09','PA21','3','2','5','EE2'),
('7113', 'SOFIB10','PA21','6','6','12','EE3'),
('7113', 'SOFIB11','PA21','7','10','17','EE1'),
('7113', 'SOFIB12','PA21','8','10','18','EE1'),
('7114', 'SOFIB07','PA21','8','4','12','EE2'),
('7114', 'SOFIB08','PA21','6','6','12','EE3'),
('7114', 'SOFIB09','PA21','3','2','5','EE2'),
('7114', 'SOFIB10','PA21','8','10','18','EE1'),
('7114', 'SOFIB11','PA21','8','10','18','EE1'),
('7114', 'SOFIB12','PA21','8','10','18','EE1'),
('7115', 'SOFIB07','PA21','8','10','18','EE1'),
('7115', 'SOFIB08','PA21','8','4','12','EE2'),
('7115', 'SOFIB09','PA21','7','10','17','EE1'),
('7115', 'SOFIB10','PA21','6','6','12','EE3'),
('7115', 'SOFIB11','PA21','8','10','18','EE1'),
('7115', 'SOFIB12','PA21','3','2','5','EE2'),
('7116', 'SOFIB07','PA21','7','10','17','EE1'),
('7116', 'SOFIB08','PA21','8','4','12','EE2'),
('7116', 'SOFIB09','PA21','6','6','12','EE3'),
('7116', 'SOFIB10','PA21','8','10','18','EE1'),
('7116', 'SOFIB11','PA21','6','6','12','EE3'),
('7116', 'SOFIB12','PA21','8','4','12','EE2'),
('7117', 'SOFIB07','PA21','8','4','12','EE2'),
('7117', 'SOFIB08','PA21','3','2','5','EE2'),
('7117', 'SOFIB09','PA21','8','10','18','EE1'),
('7117', 'SOFIB10','PA21','8','10','18','EE1'),
('7117', 'SOFIB11','PA21','7','10','17','EE1'),
('7117', 'SOFIB12','PA21','6','6','12','EE3'),
('7118', 'SOFIB07','PA21','3','2','5','EE2'),
('7118', 'SOFIB08','PA21','8','10','18','EE1'),
('7118', 'SOFIB09','PA21','8','10','18','EE1'),
('7118', 'SOFIB10','PA21','8','4','12','EE2'),
('7118', 'SOFIB11','PA21','6','6','12','EE3'),
('7118', 'SOFIB12','PA21','8','10','18','EE1'),
('7119', 'SOFIB08','PA21','8','10','18','EE1'),
('7119', 'SOFIB09','PA21','7','10','17','EE1'),
('7119', 'SOFIB10','PA21','3','2','5','EE2'),
('7119', 'SOFIB11','PA21','8','10','18','EE1'),
('7119', 'SOFIB12','PA21','6','6','12','EE3'),
('7120', 'SOFIB08','PA21','3','2','5','EE2'),
('7120', 'SOFIB09','PA21','8','10','18','EE1'),
('7120', 'SOFIB10','PA21','8','4','12','EE2'),
('7120', 'SOFIB11','PA21','8','4','12','EE2'),
('7120', 'SOFIB12','PA21','8','10','18','EE1');
SELECT *FROM [dbo].[evaluacion]
INSERT INTO evaluacion (cod_estudiante, cod_materia, cod_periodo, nota1, nota2, notaFinal, estado) VALUES
('7100', 'SOFIB01','PA21','3','2','5','EE2'),
('7100', 'SOFIB02','PA21','3','2','5','EE2'),
('7100', 'SOFIB04','PA21','8','10','18','EE1'),
('7100', 'SOFIB05','PA21','3','2','5','EE2'),
('7100', 'SOFIB06','PA21','8','10','18','EE1'),
('7101', 'SOFIB06','PA21','3','2','5','EE2'),
('7102', 'SOFIB01','PA21','8','10','18','EE1'),
('7102', 'SOFIB03','PA21','6','6','12','EE3'),
('7103', 'SOFIB05','PA21','3','2','5','EE2'),
('7103', 'SOFIB06','PA21','8','10','18','EE1'),
('7104', 'SOFIB01','PA21','6','6','12','EE3'),
('7104', 'SOFIB02','PA21','6','6','12','EE3'),
('7105', 'SOFIB05','PA21','8','10','18','EE1'),
('7105', 'SOFIB03','PA21','6','6','12','EE3'),
('7108', 'SOFIB01','PA21','6','6','12','EE3'),
('7110', 'SOFIB06','PA21','8','10','18','EE1');

INSERT INTO evaluacion (cod_estudiante, cod_materia, cod_periodo, nota1, nota2, notaFinal, estado) VALUES
('7341', 'SOFIP25','PM23','8','10','18','EE1'),
('7341', 'SOFIP26','PM23','7','10','17','EE1'),
('7341', 'SOFIP27','PM23','8','10','18','EE1'),
('7341', 'SOFIP28','PM23','7','10','17','EE1'),
('7341', 'SOFIP29','PM23','8','10','18','EE1'),
('7341', 'SOFIP30','PM23','6','6','12','EE3'),
('7342', 'SOFIP25','PM23','7','10','17','EE1'),
('7342', 'SOFIP26','PM23','8','10','18','EE1'),
('7342', 'SOFIP27','PM23','6','6','12','EE3'),
('7342', 'SOFIP28','PM23','7','10','17','EE1'),
('7342', 'SOFIP29','PM23','8','10','18','EE1'),
('7342', 'SOFIP30','PM23','6','6','12','EE3'),
('7343', 'SOFIP25','PM23','7','10','17','EE1'),
('7343', 'SOFIP26','PM23','6','6','12','EE3'),
('7343', 'SOFIP27','PM23','8','10','18','EE1'),
('7343', 'SOFIP28','PM23','6','6','12','EE3'),
('7343', 'SOFIP29','PM23','6','6','12','EE3'),
('7343', 'SOFIP30','PM23','7','10','17','EE1'),
('7344', 'SOFIP25','PM23','6','6','12','EE3'),
('7344', 'SOFIP26','PM23','8','10','18','EE1'),
('7344', 'SOFIP27','PM23','6','6','12','EE3'),
('7344', 'SOFIP29','PM23','7','10','17','EE1'),
('7344', 'SOFIP30','PM23','6','6','12','EE3'),
('7345', 'SOFIP25','PM23','8','10','18','EE1'),
('7345', 'SOFIP26','PM23','8','10','18','EE1'),
('7345', 'SOFIP27','PM23','3','2','5','EE2'),
('7345', 'SOFIP29','PM23','8','10','18','EE1'),
('7345', 'SOFIP30','PM23','3','2','5','EE2'),
('7346', 'SOFIP25','PM23','7','10','17','EE1'),
('7346', 'SOFIP26','PM23','8','10','18','EE1'),
('7346', 'SOFIP27','PM23','3','2','5','EE2'),
('7346', 'SOFIP28','PM23','8','10','18','EE1'),
('7346', 'SOFIP29','PM23','6','6','12','EE3'),
('7346', 'SOFIP30','PM23','7','10','17','EE1'),
('7347', 'SOFIP25','PM23','6','6','12','EE3'),
('7347', 'SOFIP26','PM23','8','10','18','EE1'),
('7347', 'SOFIP27','PM23','3','2','5','EE2'),
('7347', 'SOFIP28','PM23','8','10','18','EE1'),
('7347', 'SOFIP29','PM23','7','10','17','EE1'),
('7347', 'SOFIP30','PM23','8','10','18','EE1'),
('7348', 'SOFIP25','PM23','6','6','12','EE3'),
('7348', 'SOFIP26','PM23','7','10','17','EE1'),
('7348', 'SOFIP27','PM23','7','10','17','EE1'),
('7348', 'SOFIP28','PM23','7','10','17','EE1'),
('7348', 'SOFIP29','PM23','6','6','12','EE3'),
('7348', 'SOFIP30','PM23','8','10','18','EE1'),
('7349', 'SOFIP25','PM23','6','6','12','EE3'),
('7349', 'SOFIP26','PM23','7','10','17','EE1'),
('7349', 'SOFIP27','PM23','6','6','12','EE3'),
('7349', 'SOFIP28','PM23','8','10','18','EE1'),
('7349', 'SOFIP29','PM23','6','6','12','EE3'),
('7349', 'SOFIP30','PM23','7','10','17','EE1'),
('7350', 'SOFIP25','PM23','6','6','12','EE3'),
('7350', 'SOFIP26','PM23','8','10','18','EE1'),
('7350', 'SOFIP29','PM23','6','6','12','EE3'),
('7350', 'SOFIP30','PM23','7','10','17','EE1'),
('7351', 'SOFIP25','PM23','6','6','12','EE3'),
('7351', 'SOFIP26','PM23','8','10','18','EE1'),
('7351', 'SOFIP27','PM23','3','2','5','EE2'),
('7351', 'SOFIP28','PM23','8','10','18','EE1'),
('7351', 'SOFIP29','PM23','8','10','18','EE1'),
('7351', 'SOFIP30','PM23','3','2','5','EE2'),
('7352', 'SOFIP25','PM23','3','2','5','EE2'),
('7352', 'SOFIP26','PM23','7','10','17','EE1'),
('7352', 'SOFIP27','PM23','3','2','5','EE2'),
('7352', 'SOFIP28','PM23','8','10','18','EE1'),
('7352', 'SOFIP29','PM23','6','6','12','EE3'),
('7352', 'SOFIP30','PM23','3','2','5','EE2'),
('7353', 'SOFIP25','PM23','8','10','18','EE1'),
('7353', 'SOFIP26','PM23','6','6','12','EE3'),
('7353', 'SOFIP27','PM23','7','10','17','EE1'),
('7353', 'SOFIP30','PM23','6','6','12','EE3'),
('7354', 'SOFIP25','PM23','7','10','17','EE1'),
('7354', 'SOFIP26','PM23','3','2','5','EE2'),
('7354', 'SOFIP27','PM23','7','10','17','EE1'),
('7354', 'SOFIP28','PM23','8','10','18','EE1'),
('7354', 'SOFIP29','PM23','6','6','12','EE3'),
('7354', 'SOFIP30','PM23','8','10','18','EE1'),
('7355', 'SOFIP25','PM23','6','6','12','EE3'),
('7355', 'SOFIP26','PM23','7','10','17','EE1'),
('7355', 'SOFIP27','PM23','8','10','18','EE1'),
('7355', 'SOFIP28','PM23','8','10','18','EE1'),
('7355', 'SOFIP29','PM23','8','10','18','EE1'),
('7355', 'SOFIP30','PM23','8','10','18','EE1');


INSERT INTO evaluacion (cod_estudiante, cod_materia, cod_periodo, nota1, nota2, notaFinal, estado) VALUES
('7341', 'SOFIP25','PA24','8','10','18','EE1'),
('7343', 'SOFIP25','PA24','8','10','18','EE1'),
('7343', 'SOFIP26','PA24','8','10','18','EE1'),
('7344', 'SOFIP25','PA24','7','10','17','EE1'),
('7344', 'SOFIP30','PA24','7','10','17','EE1'),
('7345', 'SOFIP25','PA24','7','10','17','EE1'),
('7345', 'SOFIP26','PA24','7','10','17','EE1'),
('7345', 'SOFIP30','PA24','7','10','17','EE1'),
('7346', 'SOFIP25','PA24','8','10','18','EE1'),
('7347', 'SOFIP25','PA24','7','10','17','EE1'),
('7347', 'SOFIP30','PA24','7','10','17','EE1'),
('7348', 'SOFIP25','PA24','8','10','18','EE1'),
('7349', 'SOFIP25','PA24','7','10','17','EE1'),
('7350', 'SOFIP25','PA24','7','10','17','EE1'),
('7351', 'SOFIP25','PA24','8','10','18','EE1'),
('7352', 'SOFIP25','PA24','8','10','18','EE1'),
('7352', 'SOFIP29','PA24','7','10','17','EE1'),
('7352', 'SOFIP30','PA24','7','10','17','EE1'),
('7354', 'SOFIP25','PA24','7','10','17','EE1'),
('7354', 'SOFIP26','PA24','8','10','18','EE1'),
('7355', 'SOFIP25','PA24','8','10','18','EE1');


SELECT *FROM [dbo].[evaluacion]  	--MIRAR DATOS (Fila)


DELETE FROM	[dbo].[evaluacion]	--ELIMINAR DATOS DE LA TABLA (Fila)


--CONOCER LOS ESTUDIANTES QUE ESTAN MATRICULADOS EN UNA MATERIA ESPECIFICA
SELECT distinct cod_estudiante, cod_materia
from matricula
where cod_materia = 'SOFIB14'
 --CONOCER LOS ESTUDIANTES QUE ESTAN MATRICULADOS EN UN MATERIA ESPECIFICA Y EN UN PERIODO ESPECIFICO

SELECT cod_estudiante, cod_periodo, cod_materia
from matricula
where cod_periodo = 'PN21' AND cod_materia = 'SOFIB14'

select *from [dbo].[matricula]

--QUIERO UN LISTADO ALFABETICO DE LOS ESTUDIANTES QUE ESTAN REGISTRADOS

SELECT cod_estudiante+ ' '+ nombre 
from estudiante
ORDER BY apellido

--Un listado alfabetico de las estudiantes muejeres REGISTRADOS
SELECT cod_estudiante, nombre, apellido, sexo 
from estudiante
where sexo='F'
ORDER BY apellido asc

--QUIERO  CONOCER LOS ESTUDIANTES CON NOTA QUE APROBARON UNA MATERIA ESPECIFICA Y PERIDOD ESPECIFICO
SELECT cod_estudiante, cod_periodo, notaFinal
FROM evaluacion
WHERE notaFinal >= 14 AND cod_materia = 'SOFIB01'

--BUSCAR UN ESTUDIANTE POR APELLIDO QUE EMPIEZEN CO "C"
SELECT cod_estudiante,nombre, apellido
FROM estudiante
WHERE apellido Like 'S%'

SELECT *FROM [dbo].[estudiante]

--SE BUSCA CUYO APELLIDO TENGA "EZ"
SELECT cod_estudiante,nombre, apellido
FROM estudiante
WHERE apellido Like '%rt%'

--todos los estudiante que empiezen con [A-G]
SELECT cod_estudiante,nombre, apellido
FROM estudiante
WHERE nombre Like '[A-G]%'

--se necesita saber que sale "apelldio like '___ez' "

SELECT cod_estudiante,nombre, apellido
FROM estudiante
WHERE apellido Like '___ez'

--CUANTO ESTUDIANTES ESTAN REGISTRADOS
SELECT count(*) as conteo
FROM estudiante

--QUIERO SABER LA NOTA FINAL MAXIMA 
SELECT MAX(notaFinal) as notaMaxima
FROM evaluacion

--QUIERO SABER LA NOTA FINAL MAXIMA Y UNA MATERIA ESPECIFICA
SELECT MAX(notaFinal) as notaMaxima
FROM evaluacion

SELECT sexo,count(sexo) as con
FROM estudiante
GROUP BY sexo
--
Select cod_materia,cod_periodo, max(notafinal) as notaMaxima
from evaluacion
GROUP BY cod_materia,cod_periodo
order by 1

--numero de estudiantes por cada materia matriculados de cada materia 

SELECT cod_materia,count(distinct  cod_estudiante) as "Numero Estudante"
FROM matricula
GROUP BY cod_materia

-- Conocer numero de estudiantes matriculados por periodo y materia
Select cod_materia, cod_periodo,  count(cod_estudiante) as "Numero Estudiante"
from matricula 
group by cod_materia, cod_periodo
order by 1,2

--Conoer la nota promedio de cada asignatura

Select cod_materia, cod_periodo, AVG(notaFinal) AS promedio
from evaluacion
group by cod_materia, cod_periodo

-- top 2 cuales son los cursos con las notas promedios  mas altas 
Select top 2 cod_materia, cod_periodo, AVG(notaFinal) AS promedio
from evaluacion
group by cod_materia, cod_periodo
order by 3 desc												--notas altas

--conocer de el promedio de los cursos con las 3 notas
Select cod_materia, cod_periodo, AVG(nota1) as "Promedio nota 1",AVG(nota2)as "Promedio nota 2",AVG(notaFinal) AS "Promedio Final"
from evaluacion
group by cod_materia, cod_periodo
--quiero conocer cual el curso con las notas promedios de bajo redimiento con where 

Select cod_materia, cod_periodo, AVG(notaFinal) as "Promedio Nota Final Bajas"
from evaluacion
where AVG(notaFinal) < 14
group by cod_materia, cod_periodo


--quiero conocer cual el curso con las notas promedios de bajo redimiento 

Select cod_materia, cod_periodo, AVG(notaFinal) as "Promedio Nota Final Bajas"
from evaluacion
group by cod_materia, cod_periodo
having  AVG(notaFinal) < 14

--conocer los cursos con menor numero de estudiantes matriculados menor de 3 estudiantes
SELECT cod_materia, cod_periodo, count(distinct  cod_estudiante) as "Numero Estudante"
FROM matricula
GROUP BY cod_materia



--conocer la fecha actual la fecha actual
Select GETDATE() as "Fecha Actual";					--año'mes'dia
Select YEAR(GETDATE()) as "AÑO ACTUAL";						--Año
Select DAY(GETDATE()) as "DIA ACTUAL";					--Dia
Select month(GETDATE()) as "Mes Actual";					--Mes



-- (CAST) es estandar (CONVERT ) una funcion transa
--CAST ES CONVERSION DE TIPOS DE DATOS 
SELECT CAST ( GETDATE() AS INT );
sELECT CAST(45425 as DATETIME )
--Ingresar una fecha
SELECT CAST ( CAST('1900-01-01' As DATETIME )AS INT);
sELECT CAST(0 as DATETIME )

--(CONVERT)
SELECT CONVERT ( INT , GETDATE() )
SELECT CONVERT (DATETIME, 45425)

SELECT CONVERT(INT, CONVERT( DATETIME, '1901-02-01'))
SELECT CONVERT (DATETIME, 396)

--CONOCER EL NUMEROS DE ESTUDIANTES REGISTRADOS POR SEXO 
SELECT  sexo,count(cod_estudiante) as contar
FROM estudiante
GROUP BY sexo

--CONOCER EL NUMEROS DE ESTUDIANTES REGISTRADOS POR SEXO 
SELECT  CASE sexo WHEN 'M' THEN 'Hombre'
		ELSE 'Mujer' END,
	count(cod_estudiante) as contar
FROM estudiante
GROUP BY sexo



select count(*)
from estudiante
select count(*)
from matricula

--Listado de los estudiantes que estan matriculados en una materia especifica
Select distinct nombre,apellido, estudiante.cod_estudiante
from estudiante, matricula
where estudiante.cod_estudiante = matricula.cod_estudiante

--Listado de los estudiantes que estan matriculados en una materia especifica
Select distinct nombre,apellido, f.cod_estudiante
from estudiante as e, matricula as f			--con alias nombres 
where e.cod_estudiante  = f.cod_estudiante

--Join Listado de los estudiantes que estan matriculados en una materia especifica
Select distinct e.nombre,apellido, f.cod_estudiante, m.nombre
from estudiante as e
inner join  matricula as f on e.cod_estudiante  = f.cod_estudiante
inner join materia as m on m.cod_materia = m.cod_materia



--Conocer la materia que tenga mas de 3 estudinates matriculados 
Select Ma.nombre, Ma.cod_materia, count(cod_estudiante) as contar
FROM matricula as M
INNER JOIN materia as Ma on M.cod_materia = Ma.cod_materia 
GROUP BY Ma.nombre, Ma.cod_materia
having count(cod_estudiante)>3


--Conocer la materia que tenga mas de 3 estudinates matriculados por periodo
Select Ma.nombre, Ma.cod_materia, cod_periodo, count(cod_estudiante) as contar
FROM matricula as M
INNER JOIN materia as Ma on M.cod_materia = Ma.cod_materia 
GROUP BY Ma.nombre, Ma.cod_materia, cod_periodo
having count(cod_estudiante)>3



/*amiguedad siempre dara un error significa que en este caso el 
codigo de estudiante estan en las dos tablas */


--listado de estudiante reprobados de una periodo especifica
select es.nombre, es.apellido, mt.nombre, ev.estado, ev.cod_periodo
from estudiante as es
inner join matricula as ma on es.cod_estudiante = ma.cod_estudiante
inner join evaluacion as ev on es.cod_estudiante = ev.cod_estudiante and ma.cod_materia = ev.cod_materia and ev.cod_periodo=ma.cod_periodo
inner join materia as mt on mt.cod_materia = ma.cod_materia 
where ev.estado = 'EE2' 


--LAS DOS MATERIAS CON EL PROMEDIO MAS BAJO
select  top 2 mt.nombre, ev.estado, ev.cod_periodO , avg(ev.notaFinal) 
from materia as es
inner join evaluacion as ev on es.cod_estudiante = ev.cod_estudiante and ma.cod_materia = ev.cod_materia and ev.cod_periodo=ma.cod_periodo
inner join materia as mt on mt.cod_materia = 
group by 
having avg(ev.notaFinal)  < 7


Select *from [dbo].[estudiante]
select *from[dbo].[evaluacion]

--Join Estrenos

--Conocer los estudiantes que aun no se an matriculado

Select a.nombre, a.apellido, b.estado 
from estudiante as a
left join matricula as b on a.cod_estudiante = b.cod_estudiante
where b.cod_estudiante IS NULL
ORDER BY 2

--Conocer las asignaturas que no tiene estudiantes matriculados con sus respectivas carreras
--Ojo: El orden de los join es importante 
--Corregir los datos poque no salen estudiantes no matriculados en asignatura 
Select c.nombre, c.cod_carrera, a.nombre, a.cod_materia
from materia as a
join carrera as c on c.cod_carrera =a.cod_carrera
left join matricula as b on a.cod_materia = b.cod_materia
where b.cod_materia IS NULL
ORDER BY 2,4

--Conocer las materias que aun no han pasados nota 1 
Select *
From materia as a
inner join evaluacion as eva on a.cod_materia = eva.cod_materia


--opcion 2

--Conocer las materias que aun no han pasados nota 1 
select M.nombre, M.semestre
from Evaluacion Ev
left join Materia M
     on Ev.cod_materia = M.cod_materia
where EV.nota1 is null
order by 2;


