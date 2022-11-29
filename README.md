# Script de base de datos

```
    DROP DATABASE IF EXISTS bdhotel;
    CREATE DATABASE bdhotel;
    USE bdhotel;

    CREATE TABLE habitaciones(
    IdHabitacion INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    NumHabitacion INT(5) NOT NULL,
    TipoHabitacion VARCHAR(20) NOT NULL,
    Descripcion TEXT NOT NULL,
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
    FOREIGN KEY fk_IdHabitacion(IdHabitacion) REFERENCES habitaciones(IdHabitacion)
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
    FOREIGN KEY fk_IdHabitacion(IdHabitacion) REFERENCES habitaciones(IdHabitacion)
    );

    ALTER TABLE habitaciones ADD FOREIGN KEY (IdUsuario) REFERENCES usuarios(IdUsuario); 

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


    INSERT INTO habitaciones (Nombre, NumHabitacion, TipoHabitacion, Descripcion, Precio, IdUsuario)
    VALUES 
    (
        "Pleasure Room", 5, "Premium", 
        "Habitacion para disfrutar de lo mejor con tu pareja, reservala ahora y disfruta de ella", 
        120000, null
    ),
    (
        "Himaura", 4, "Normal", 
        "Habitacion en el hotel Himaura cerca de la Universidad popular del Cesar por si eres un universitario", 
        60000, null
    ),
    (
        "Hogar de paso", 20, "Normal", 
        "Recibe la mejor atencion como si de tu casa se tratase",
        60000, null
    ),
    (
        "Habitación Sicarare", 8, "Comfort", 
        "Habitacion en el hotel Sicarare de Valledupar por si vas de paso y deseas darte un buen descanso", 
        28000, null
    ),
    (
        "Supreme", 20, "Comfort", 
        "El mejor hotel a toda tu disposición, disfrutaras de esta habitación como niguna otra",
        60000, null
    ),
    (
        "Casa campo", 8, "Normal", 
        "Una casa campo a tu disposicion para que te alejes un poco de la ciudad",
        60000, null
    ),
    (
        "Suit avanzada", 5, "Premium", 
        "Solo para gente adinerada",
        500000000, null
    );

    INSERT INTO usuarios (Nombre, Correo, UserName, Pssword, IdHabitacion) 
    VALUES 
    ("Prueba", "usuarioprueba@gmail.com","prueba", "prueba",1),
    ("Prueba2", "usuarioprueba2@gmail.com","prueba2", "prueba2", 3),
    ("Camila Sanchez", "camila@gmail.com","camilita", "fancygirl08",5);

    update habitaciones SET IdUsuario = 1 where IdHabitacion = 1;
    update habitaciones SET IdUsuario = 2 where IdHabitacion = 3;
    update habitaciones SET IdUsuario = 3 where IdHabitacion = 5;

    INSERT INTO comentarios (IdUsuario, IdHabitacion, Comentario) 
    values
    (
        1, 1, "La habitación esta buena, con aire acondicionado y bien amoblada la verdad es que la recomiendo. EL servicio por parte del hotel es excelente y responden cualquier inquietud de inmediato"
    ),
    (
        1, 2, "Fantastica, disfrute completamente mi estancia en ese lugar"
    ),
    (
        2, 2, "Fui en una vispera de año nuevo y no me gusto la recepción para nada, el personal no me brindo buena atención y esta muy desesperado por irme de ese lugar"
    );
```