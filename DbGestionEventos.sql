CREATE DATABASE DbGestionEventos;
GO
USE DbGestionEventos;



CREATE TABLE TIPO_USUARIO(
	ID_TIPO_USUARIO INT IDENTITY(1,1), --PK
	TIPO VARCHAR(30),
	CONSTRAINT PK_TIPO_USUARIO PRIMARY KEY(ID_TIPO_USUARIO)
);

CREATE TABLE SERVICIOS(
	ID_SERVICIO INT IDENTITY(1,1), --PK
	SERVICIO VARCHAR(30),	
	CONSTRAINT PK_SERVICIOS PRIMARY KEY(ID_SERVICIO)
);

CREATE TABLE USUARIOS(
	ID_USUARIO INT IDENTITY(1,1), --PK
	ID_TIPO_USUARIO INT NOT NULL, --FK
	NOMBRE VARCHAR(50) NOT NULL,
	APELLIDO VARCHAR(30) NOT NULL,
	DNI BIGINT UNIQUE NOT NULL,
	EMAIL VARCHAR(50) UNIQUE NOT NULL,
	[PASSWORD] VARCHAR(16),
	CONSTRAINT PK_USUARIOS PRIMARY KEY(ID_USUARIO)
);

CREATE TABLE SERVICIOS_PUBLICADOS(
	ID_USUARIO INT,--PK,FK
	ID_SERVICIO INT,--PK,FK	
	PRECIO DECIMAL(10,2) NOT NULL,
	DESCRIPCION VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_SERVICIOS_PUBLICADOS PRIMARY KEY(ID_USUARIO,ID_SERVICIO)
);

CREATE TABLE EVENTOS(
	ID_EVENTO INT IDENTITY(1,1), --PK
	ID_USUARIO INT NOT NULL,--FK
	FECHA_HORA DATETIME NOT NULL,
	LUGAR VARCHAR(100),
	PAGO BIT DEFAULT 0,
	CONSTRAINT PK_EVENTOS PRIMARY KEY(ID_EVENTO)
);

CREATE TABLE EVENTOS_SERVICIOS(
	ID_EVENTO INT,--PK,FK
	ID_SERVICIO INT ,--PK,FK
	ID_PROVEEDOR INT ,--PK,FK
	SUBTOTAL DECIMAL(10,2),
	CONSTRAINT PK_EVENTOS_SERVICIOS PRIMARY KEY(ID_EVENTO,ID_SERVICIO,ID_PROVEEDOR)
);

CREATE TABLE PAGO (
	ID_PAGO INT IDENTITY(1,1), --PK
	ID_EVENTO INT,--PK,FK
	FECHA_PAGO DATE NOT NULL,
	TOTAL DECIMAL(10,2),
	CONSTRAINT PK_PAGO PRIMARY KEY(ID_PAGO)
);

CREATE TABLE INVITADOS(
	ID_EVENTO INT,--PK,FK
	EMAIL VARCHAR(50),--PK
	NOMBRE VARCHAR(50),
	APELLIDO VARCHAR(30),
	CONSTRAINT PK_INVITADOS PRIMARY KEY(ID_EVENTO, EMAIL)
);


/*DECLARACION DE FOREIGN KEYS*/
ALTER TABLE USUARIOS ADD
CONSTRAINT FK_USUARIOS_TIPO_USUARIO 
	FOREIGN KEY (ID_TIPO_USUARIO) REFERENCES TIPO_USUARIO (ID_TIPO_USUARIO);

ALTER TABLE SERVICIOS_PUBLICADOS ADD
CONSTRAINT FK_SERVICIOS_PUBLICADOS_SERVICIOS 
	FOREIGN KEY (ID_SERVICIO) REFERENCES SERVICIOS (ID_SERVICIO),
CONSTRAINT FK_SERVICIOS_PUBLICADOS_USUARIOS 
	FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS (ID_USUARIO);

ALTER TABLE EVENTOS ADD
CONSTRAINT FK_EVENTOS_USUARIOS
	FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO);
-----------------------------------------------------------
ALTER TABLE EVENTOS_SERVICIOS ADD
CONSTRAINT FK_EVENTOS_SERVICIOS_EVENTOS
	FOREIGN KEY(ID_EVENTO) REFERENCES EVENTOS(ID_EVENTO),
CONSTRAINT FK_EVENTOS_SERVICIOS_SERVICIOS_PUBLICADOS
	FOREIGN KEY (ID_PROVEEDOR,ID_SERVICIO) REFERENCES SERVICIOS_PUBLICADOS(ID_USUARIO,ID_SERVICIO);

ALTER TABLE PAGO ADD
CONSTRAINT FK_PAGO_EVENTOS
	FOREIGN KEY (ID_EVENTO) REFERENCES EVENTOS(ID_EVENTO);

ALTER TABLE INVITADOS ADD
CONSTRAINT FK_INVITADOS_EVENTOS
	FOREIGN KEY (ID_EVENTO) REFERENCES EVENTOS (ID_EVENTO);
GO

INSERT INTO TIPO_USUARIO VALUES ('Organizar'),('Proveedor');

INSERT INTO SERVICIOS VALUES
	('Catering'),
	('Bebidas'),
	('Sonido e iluminacion'),
	('Souvenirs'),
	('Decoracion'),
	('Barras'),
	('Seguridad'),
	('Espacios'),
	('Animacion'),
	('Asador'),
	('Fotografia');

INSERT INTO USUARIOS VALUES
	(1,'Alberto Alfredo','Carabajal',36541258,'AlbertoCarabajal@hotmail.com','albertitoDSM'),
	(2,'Beatriz Clara','Fernandez',85123641,'betiClarita@gmail.com','asd9684s'),
	(2,'Santiago Diego','Martinez',63541258,'santiMartincito64@yahoo.com','hfae6W'),
	(1,'Ana Sandra','Santini',21456314,'4nit4deboulogne98@live.com','laskie6sO'),
	(1,'Luis Eduardo','Gonzalez',74582361,'luisitoG@gmail.com','pIhj56Kd'),
	(2,'María Isabel','López',98145623,'mariaLopez@gmail.com','UoPq2nSv'),
	(1,'Andrés José','Pérez',32658791,'andresPerez@hotmail.com','RtYb4zXl'),
	(2,'Sofía Carolina','Rodríguez',45782369,'sofiRodri@gmail.com','oNqJ8sDp'),
	(1,'Carlos Alberto','Fernández',59873142,'carlitosFer@gmail.com','aBvCpE8R'),
	(2,'Laura Cecilia','Ramírez',21458637,'lauraRamirez@hotmail.com','ZsXtNv2W'),
	(1,'Diego Alejandro','López',32874915,'diegoLopez@yahoo.com','KlMnO9pQ'),
	(2,'Valentina Fernanda','García',89412356,'valenGarcia@gmail.com','XwYzU1Jp'),
	(1,'José Luis','Torres',45982314,'joseTorres@gmail.com','LmNopR3Q'),
	(2,'Camila Isabella','Gómez',36584127,'camilaGomez@hotmail.com','S4TUVwXy'),
	(1,'Manuel Alejandro','Rodríguez',71843269,'manuelRodriguez@yahoo.com','Hx9KlMnO'),
	(2,'Ana María','Martínez',96587412,'anaMartinez@gmail.com','wXyZ7DpA'),
	(1,'Fernando Alberto','Sánchez',14785263,'fernandoSanchez@hotmail.com','qB4E6mN8'),
	(2,'Mariana Isabel','Pérez',52314786,'marianaPerez@gmail.com','zXtR9wQp'),
	(1,'Miguel Ángel','García',36478192,'miguelGarcia@yahoo.com','tU3O2NvP'),
	(2,'Luisa Fernanda','Gómez',98146527,'luisaGomez@gmail.com','nR4E2mN7'),
	(1,'Roberto Carlos','Fernández',74152638,'robertoFernandez@hotmail.com','KlM1J3pW'),
	(2,'Cristina Isabel','Ramírez',36587429,'cristinaRamirez@gmail.com','wX5T7v2J'),
	(1,'Juan Diego','Torres',21458736,'juanTorres@yahoo.com','zXpR1LwO'),
	(2,'Lucía Carolina','Santini',98145672,'luciaSantini@hotmail.com','yD3pE8Rt'),
	(1,'Sergio Alberto','Gómez',74152396,'sergioGomez@gmail.com','qN7wXyZt'),
	(2,'Gabriela Isabel','García',36587452,'gabrielaGarcia@hotmail.com','vB2N8m3Q'),
	(1,'Pedro Alejandro','Pérez',52367841,'pedroPerez@gmail.com','uRwX4TlO'),
	(2,'Isabel María','Martínez',98142563,'isabelMartinez@yahoo.com','KlMnO7pW'),
	(1,'Pablo Alberto','Fernández',36587412,'pabloFernandez@hotmail.com','qBvC8R2W'),
	(2,'Lorena Carolina','Gómez',74125836,'lorenaGomez@gmail.com','sXtRwQ3p'),
	(1,'Ricardo Alberto','Ramírez',52316847,'ricardoRamirez@yahoo.com','zXyZvJpA'),
	(2,'Tatiana Isabel','Torres',98142376,'tatianaTorres@gmail.com','HxK7DpNv'),
	(1,'Javier Alejandro','Sánchez',93587412,'javierSanchez@hotmail.com','qBvCpRtW'),
	(2,'Elena María','López',74152836,'elenaLopez@gmail.com','zX5T7vNpA'),
	(1,'Víctor Alberto','García',21453736,'victorGarcia@yahoo.com','yXyZpRlO'),
	(2,'Amanda Isabel','Pérez',98145236,'amandaPerez@gmail.com','uRwX4DpL'),
	(1,'Federico Alberto','Martínez',36377412,'federicoMartinez@hotmail.com','qB2NvRtW'),
	(2,'Natalia Carolina','Fernández',74125386,'nataliaFernandez@gmail.com','sXtR3mNvQ'),
	(1,'Ernesto Alberto','Ramírez',21458116,'ernestoRamirez@yahoo.com','zXyZ7DpA'),
	(1,'Test','test',11111111,'test@test.com','test');


INSERT INTO SERVICIOS_PUBLICADOS VALUES
	(20,1,6000,'El servicio consta de entrada, plato principal, 1litro de bebida y postre por persona'),
	(3,7,40000,'El precio de servicio corresponde a DOS (2) personal de seguridad, para ser utilizados en vigilancia o control de recepcion'),
	(6, 2, 15000, 'Servicio de bebidas para tu evento'),
	(8, 3, 10000, 'Servicio de sonido e iluminación para crear la atmósfera perfecta'),
	(10, 4, 22000, 'Encuentra souvenirs únicos para recordar tu evento'),
	(12, 5, 35000, 'Decora tu evento con nuestro servicio de decoración personalizada'),
	(14, 6, 9000, 'Barras de bebidas personalizadas para tu evento'),
	(16, 7, 18000, 'Servicio de seguridad con dos profesionales para vigilancia o control de recepción'),
	(18, 8, 25000, 'Encuentra el espacio ideal para tu evento'),
	(20, 9, 7000, 'Servicio de animación para mantener entretenidos a tus invitados'),
	(22, 10, 30000, 'Asador profesional para tus eventos al aire libre'),
	(24, 11, 12000, 'Servicio de fotografía para capturar los mejores momentos de tu evento'),
	(26, 1, 20000, 'Catering personalizado para tu ocasión especial'),
	(28, 2, 17000, 'Bebidas de alta calidad para complementar tu evento'),
	(30, 3, 6000, 'Sonido e iluminación de primera para crear la atmósfera perfecta'),
	(32, 4, 18000, 'Souvenirs únicos y memorables para tus invitados'),
	(34, 5, 13000, 'Decoración que hará que tu evento sea inolvidable'),
	(36, 6, 9000, 'Barras de bebidas personalizadas para hacer de tu evento una experiencia única'),
	(37, 7, 40000, 'Seguridad profesional para garantizar la tranquilidad de tu evento'),
	(2, 8, 16000, 'Espacios ideales para tu evento, adaptados a tus necesidades'),
	(6, 9, 7000, 'Servicio de animación para mantener a tus invitados entretenidos y felices'),
	(8, 10, 24000, 'Servicio de asador para disfrutar de deliciosas parrilladas'),
	(10, 11, 28000, 'Fotografía de alta calidad para capturar los momentos más especiales de tu evento'),
	(12, 1, 12000, 'Catering excepcional que hará las delicias de tus invitados'),
	(14, 2, 18000, 'Amplia variedad de bebidas para satisfacer todos los gustos'),
	(16, 3, 8000, 'Sonido e iluminación profesional para una experiencia inolvidable'),
	(18, 4, 21000, 'Souvenirs únicos y personalizados para recordar tu evento'),
	(20, 5, 30000, 'Decoración que transformará tu espacio en un lugar mágico'),
	(22, 6, 9500, 'Barras de bebidas con mixólogos expertos para sorprender a tus invitados'),
	(24, 7, 22000, 'Personal de seguridad altamente capacitado para garantizar la seguridad de tu evento'),
	(26, 8, 27000, 'Espacios versátiles y elegantes para todo tipo de eventos'),
	(28, 9, 7500, 'Animadores profesionales que harán de tu evento una fiesta inolvidable'),
	(30, 10, 31000, 'Servicio de asador con chefs expertos para deleitar a tus invitados'),
	(32, 11, 12500, 'Fotografía de calidad para capturar los momentos más especiales'),
	(34, 1, 21000, 'Catering a medida para satisfacer los paladares más exigentes'),
	(36, 2, 15000, 'Variedad de bebidas premium para tu evento'),
	(38, 3, 35000, 'Ambiente excepcional con sonido e iluminación de última generación');