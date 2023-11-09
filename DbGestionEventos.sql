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
	(2,'Mar�a Isabel','L�pez',98145623,'mariaLopez@gmail.com','UoPq2nSv'),
	(1,'Andr�s Jos�','P�rez',32658791,'andresPerez@hotmail.com','RtYb4zXl'),
	(2,'Sof�a Carolina','Rodr�guez',45782369,'sofiRodri@gmail.com','oNqJ8sDp'),
	(1,'Carlos Alberto','Fern�ndez',59873142,'carlitosFer@gmail.com','aBvCpE8R'),
	(2,'Laura Cecilia','Ram�rez',21458637,'lauraRamirez@hotmail.com','ZsXtNv2W'),
	(1,'Diego Alejandro','L�pez',32874915,'diegoLopez@yahoo.com','KlMnO9pQ'),
	(2,'Valentina Fernanda','Garc�a',89412356,'valenGarcia@gmail.com','XwYzU1Jp'),
	(1,'Jos� Luis','Torres',45982314,'joseTorres@gmail.com','LmNopR3Q'),
	(2,'Camila Isabella','G�mez',36584127,'camilaGomez@hotmail.com','S4TUVwXy'),
	(1,'Manuel Alejandro','Rodr�guez',71843269,'manuelRodriguez@yahoo.com','Hx9KlMnO'),
	(2,'Ana Mar�a','Mart�nez',96587412,'anaMartinez@gmail.com','wXyZ7DpA'),
	(1,'Fernando Alberto','S�nchez',14785263,'fernandoSanchez@hotmail.com','qB4E6mN8'),
	(2,'Mariana Isabel','P�rez',52314786,'marianaPerez@gmail.com','zXtR9wQp'),
	(1,'Miguel �ngel','Garc�a',36478192,'miguelGarcia@yahoo.com','tU3O2NvP'),
	(2,'Luisa Fernanda','G�mez',98146527,'luisaGomez@gmail.com','nR4E2mN7'),
	(1,'Roberto Carlos','Fern�ndez',74152638,'robertoFernandez@hotmail.com','KlM1J3pW'),
	(2,'Cristina Isabel','Ram�rez',36587429,'cristinaRamirez@gmail.com','wX5T7v2J'),
	(1,'Juan Diego','Torres',21458736,'juanTorres@yahoo.com','zXpR1LwO'),
	(2,'Luc�a Carolina','Santini',98145672,'luciaSantini@hotmail.com','yD3pE8Rt'),
	(1,'Sergio Alberto','G�mez',74152396,'sergioGomez@gmail.com','qN7wXyZt'),
	(2,'Gabriela Isabel','Garc�a',36587452,'gabrielaGarcia@hotmail.com','vB2N8m3Q'),
	(1,'Pedro Alejandro','P�rez',52367841,'pedroPerez@gmail.com','uRwX4TlO'),
	(2,'Isabel Mar�a','Mart�nez',98142563,'isabelMartinez@yahoo.com','KlMnO7pW'),
	(1,'Pablo Alberto','Fern�ndez',36587412,'pabloFernandez@hotmail.com','qBvC8R2W'),
	(2,'Lorena Carolina','G�mez',74125836,'lorenaGomez@gmail.com','sXtRwQ3p'),
	(1,'Ricardo Alberto','Ram�rez',52316847,'ricardoRamirez@yahoo.com','zXyZvJpA'),
	(2,'Tatiana Isabel','Torres',98142376,'tatianaTorres@gmail.com','HxK7DpNv'),
	(1,'Javier Alejandro','S�nchez',93587412,'javierSanchez@hotmail.com','qBvCpRtW'),
	(2,'Elena Mar�a','L�pez',74152836,'elenaLopez@gmail.com','zX5T7vNpA'),
	(1,'V�ctor Alberto','Garc�a',21453736,'victorGarcia@yahoo.com','yXyZpRlO'),
	(2,'Amanda Isabel','P�rez',98145236,'amandaPerez@gmail.com','uRwX4DpL'),
	(1,'Federico Alberto','Mart�nez',36377412,'federicoMartinez@hotmail.com','qB2NvRtW'),
	(2,'Natalia Carolina','Fern�ndez',74125386,'nataliaFernandez@gmail.com','sXtR3mNvQ'),
	(1,'Ernesto Alberto','Ram�rez',21458116,'ernestoRamirez@yahoo.com','zXyZ7DpA'),
	(1,'Test','test',11111111,'test@test.com','test');


INSERT INTO SERVICIOS_PUBLICADOS VALUES
	(20,1,6000,'El servicio consta de entrada, plato principal, 1litro de bebida y postre por persona'),
	(3,7,40000,'El precio de servicio corresponde a DOS (2) personal de seguridad, para ser utilizados en vigilancia o control de recepcion'),
	(6, 2, 15000, 'Servicio de bebidas para tu evento'),
	(8, 3, 10000, 'Servicio de sonido e iluminaci�n para crear la atm�sfera perfecta'),
	(10, 4, 22000, 'Encuentra souvenirs �nicos para recordar tu evento'),
	(12, 5, 35000, 'Decora tu evento con nuestro servicio de decoraci�n personalizada'),
	(14, 6, 9000, 'Barras de bebidas personalizadas para tu evento'),
	(16, 7, 18000, 'Servicio de seguridad con dos profesionales para vigilancia o control de recepci�n'),
	(18, 8, 25000, 'Encuentra el espacio ideal para tu evento'),
	(20, 9, 7000, 'Servicio de animaci�n para mantener entretenidos a tus invitados'),
	(22, 10, 30000, 'Asador profesional para tus eventos al aire libre'),
	(24, 11, 12000, 'Servicio de fotograf�a para capturar los mejores momentos de tu evento'),
	(26, 1, 20000, 'Catering personalizado para tu ocasi�n especial'),
	(28, 2, 17000, 'Bebidas de alta calidad para complementar tu evento'),
	(30, 3, 6000, 'Sonido e iluminaci�n de primera para crear la atm�sfera perfecta'),
	(32, 4, 18000, 'Souvenirs �nicos y memorables para tus invitados'),
	(34, 5, 13000, 'Decoraci�n que har� que tu evento sea inolvidable'),
	(36, 6, 9000, 'Barras de bebidas personalizadas para hacer de tu evento una experiencia �nica'),
	(37, 7, 40000, 'Seguridad profesional para garantizar la tranquilidad de tu evento'),
	(2, 8, 16000, 'Espacios ideales para tu evento, adaptados a tus necesidades'),
	(6, 9, 7000, 'Servicio de animaci�n para mantener a tus invitados entretenidos y felices'),
	(8, 10, 24000, 'Servicio de asador para disfrutar de deliciosas parrilladas'),
	(10, 11, 28000, 'Fotograf�a de alta calidad para capturar los momentos m�s especiales de tu evento'),
	(12, 1, 12000, 'Catering excepcional que har� las delicias de tus invitados'),
	(14, 2, 18000, 'Amplia variedad de bebidas para satisfacer todos los gustos'),
	(16, 3, 8000, 'Sonido e iluminaci�n profesional para una experiencia inolvidable'),
	(18, 4, 21000, 'Souvenirs �nicos y personalizados para recordar tu evento'),
	(20, 5, 30000, 'Decoraci�n que transformar� tu espacio en un lugar m�gico'),
	(22, 6, 9500, 'Barras de bebidas con mix�logos expertos para sorprender a tus invitados'),
	(24, 7, 22000, 'Personal de seguridad altamente capacitado para garantizar la seguridad de tu evento'),
	(26, 8, 27000, 'Espacios vers�tiles y elegantes para todo tipo de eventos'),
	(28, 9, 7500, 'Animadores profesionales que har�n de tu evento una fiesta inolvidable'),
	(30, 10, 31000, 'Servicio de asador con chefs expertos para deleitar a tus invitados'),
	(32, 11, 12500, 'Fotograf�a de calidad para capturar los momentos m�s especiales'),
	(34, 1, 21000, 'Catering a medida para satisfacer los paladares m�s exigentes'),
	(36, 2, 15000, 'Variedad de bebidas premium para tu evento'),
	(38, 3, 35000, 'Ambiente excepcional con sonido e iluminaci�n de �ltima generaci�n');