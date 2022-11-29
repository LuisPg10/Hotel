# Script de base de datos


DROP DATABASE IF EXISTS bdhotel;
CREATE DATABASE bdhotel;
USE bdhotel;

CREATE TABLE habitaciones(
 IdHabitacion INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
 NumHabitacion INT(5) NOT NULL UNIQUE,
 TipoHabitacion VARCHAR(20) NOT NULL,
 Precio Double NOT NULL,
 IdUsuario INT(10)
);

CREATE TABLE usuarios(
 IdUsuario INT(10) NOT NULL AUTO_INCREMENT,
 Nombre VARCHAR(20) NOT NULL,
 Correo VARCHAR(25) NOT NULL UNIQUE,
 UserName VARCHAR(20) NOT NULL UNIQUE,
 Pssword VARCHAR(20) NOT NULL,
 IdHabitacion INT(10) NULL,
 PRIMARY KEY(IdUsuario),
 FOREIGN KEY fk_IdHabitacion(IdHabitacion) REFERENCES habitaciones(IdHabitacion),
 INDEX idx_IdHabitacion(IdHabitacion)
);

CREATE TABLE administradores(
 IdAdministrador INT(10) NOT NULL AUTO_INCREMENT,
 UserName VARCHAR(20) NOT NULL UNIQUE,
 Pssword VARCHAR(20) NOT NULL,
 PRIMARY KEY(IdAdministrador)
);

CREATE TABLE gerentes(
 IdGerente INT(10) NOT NULL AUTO_INCREMENT,
 UserName VARCHAR(20) NOT NULL UNIQUE,
 Pssword VARCHAR(20) NOT NULL,
 PRIMARY KEY(IdGerente)
);

CREATE TABLE comentarios(
 IdComentario INT(10) NOT NULL AUTO_INCREMENT,
 IdUsuario INT(10),
 IdHabitacion INT(10),
 Comentario TEXT NOT NULL,
 PRIMARY KEY(IdComentario),
 FOREIGN KEY fk_IdUsuario(IdUsuario) REFERENCES usuarios(IdUsuario),
 FOREIGN KEY fk_IdHabitacion(IdHabitacion) REFERENCES usuarios(IdHabitacion)
);

ALTER TABLE habitaciones ADD FOREIGN KEY (IdUsuario) REFERENCES usuarios(IdUsuario); 

/*Datos de prueba para la base de datos*/
INSERT INTO  gerentes (Username, Pssword) 
VALUES 
("luis", "luis10"),
("nayid", "nayid04"),
("cataño", "cataño25"),
("patiño", "profe");

INSERT INTO administradores (Username, Pssword)
VALUES
("Aluis", "luis10"),
("Anayid", "nayid04"),
("Acataño", "cataño25"),
("Apatiño", "profe");

INSERT INTO habitaciones (NumHabitacion, TipoHabitacion, Precio, IdUsuario)
VALUES (5, "Premium", 120000, NULL);

INSERT INTO habitaciones (NumHabitacion, TipoHabitacion, Precio, idUsuario)
VALUES(8, "Comfort", 28000, NULL);

INSERT INTO usuarios (Nombre, Correo, UserName, Pssword, IdHabitacion) 
VALUES ("Prueba", "usuarioprueba@gmail.com","prueba", "prueba", 1);

INSERT INTO usuarios (Nombre, Correo, UserName, Pssword, IdHabitacion) 
VALUES ("Prueba2", "usuarioprueba2@gmail.com","prueba2", "prueba2", NULL);

INSERT INTO comentarios (IdUsuario, IdHabitacion, Comentario) 
VALUES
(
	1,
	1,
	"La habitación esta buena, con aire acondicionado y 
	bien amoblada la verdad es que la recomiendo. EL
	servicio por parte del hotel es excelente y responden
	cualquier inquietud de inmediato"
);