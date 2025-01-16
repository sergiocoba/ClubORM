CREATE DATABASE Clubs;
GO
USE Clubs;
GO
USE bdCicles
DROP DATABASE Clubs
SELECT * FROM Galeria
SELECT * FROM Clubs
CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Continentes (
    ContinenteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Pais (
    PaisID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
    ContinenteID INT NOT NULL FOREIGN KEY REFERENCES Continentes(ContinenteID) ON DELETE CASCADE
);

CREATE TABLE Clubs (
    ClubID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL UNIQUE,
    Fundacion INT, 
    Horario NVARCHAR(500)
);

CREATE TABLE ClubCategorias (
	ClubCategoriasID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT NOT NULL,
    CategoriaID INT NOT NULL,
    FOREIGN KEY (ClubID) REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID) ON DELETE CASCADE
);

CREATE TABLE Ubicacion (
    UbicacionID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT UNIQUE FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Ciudad NVARCHAR(100),
    Direccion NVARCHAR(200),
    CodigoPostal NVARCHAR(10),
    PaisID INT FOREIGN KEY REFERENCES Pais(PaisID) ON DELETE CASCADE
);

CREATE TABLE Contacto (
    ContactoID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT UNIQUE FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE MediaVisual (
    ClubID INT PRIMARY KEY FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Logo VARCHAR(MAX),
    MiniaturaWeb VARCHAR(MAX),
    GoogleMapsURL VARCHAR(MAX)
);

CREATE TABLE Reseña (
    ReseñaID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Usuario NVARCHAR(255),
    Descripcion NVARCHAR(255),
    Valoracion TINYINT CHECK (Valoracion BETWEEN 1 AND 5)
);

CREATE TABLE Galeria (
	FotoId INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT NOT NULL,
    Foto VARCHAR(MAX),
    FOREIGN KEY (ClubID) REFERENCES Clubs(ClubID) ON DELETE CASCADE
);

SELECT * FROM MediaVisual
SELECT * FROM Ubicacion
INSERT INTO Continentes (Nombre)
VALUES 
('Europa'),
('América'),
('África'),
('Oceanía'),
('Antartida'),
('Asia');

INSERT INTO Pais (Nombre, ContinenteID)
VALUES
('España', 1),
('Francia', 1),
('Estados Unidos', 2), 
('Sudáfrica', 3), 
('Canadá', 2), 
('Argentina', 2),
('Nueva Zelanda', 4),
('Irlanda', 1), 
('México', 2),
('Australia', 4);

SELECT * FROM Ubicacion
-- INSERT para Categorias
INSERT INTO Categorias (Nombre)
VALUES ('Fútbol'), ('Rugby'), ('Baloncesto');

-- INSERT para Clubs
INSERT INTO Clubs (Nombre, Fundacion, Horario)
VALUES 
('Club Futbol Madrid', 1902, 'Lunes a Viernes: 10:00 - 20:00'),
('Club de Rugby Toulouse', 1907, 'Martes a Sábado: 9:00 - 18:00'),
('Angeles Lakers', 1947, 'Todos los días: 8:00 - 22:00'),
('Rugby Stormers', 1998, 'Martes a Viernes: 9:00 - 17:00'),
('Basket Toronto Raptors', 1995, 'Todos los días: 10:00 - 21:00'),
('Futbol Boca Juniors', 1905, 'Miércoles a Domingo: 11:00 - 19:00'),
('Club Rugby All Blacks', 1903, 'Lunes a Viernes: 8:00 - 18:00'),
('Club Atlético River Plate', 1901, 'Lunes a Viernes: 9:00 - 18:00'),
('Club Baloncesto Real Madrid', 1931, 'Todos los días: 10:00 - 22:00'),
('Club Rugby Leinster', 1875, 'Lunes a Viernes: 8:00 - 16:00'),
('Club Deportivo Guadalajara', 1906, 'Todos los días: 9:00 - 21:00'),
('Los Angeles Clippers', 1970, 'Miércoles a Domingo: 11:00 - 19:00'),
('Rugby Reds Queensland', 1882, 'Martes a Viernes: 8:00 - 17:00');

-- INSERT para ClubCategorias (Relación ternaria)
INSERT INTO ClubCategorias (ClubID, CategoriaID)
VALUES 
(1, 1), -- Club Futbol Madrid - Fútbol
(2, 2), -- Club de Rugby Toulouse - Rugby
(3, 3), -- Angeles Lakers - Baloncesto
(4, 2), -- Rugby Stormers - Rugby
(5, 3), -- Basket Toronto Raptors - Baloncesto
(6, 1), -- Futbol Boca Juniors - Fútbol
(7, 2), -- Club Rugby All Blacks - Rugby
(8, 1), -- Club Atlético River Plate - Fútbol
(9, 3), -- Club Baloncesto Real Madrid - Baloncesto
(10, 2), -- Club Rugby Leinster - Rugby
(11, 1), -- Club Deportivo Guadalajara - Fútbol
(12, 3), -- Los Angeles Clippers - Baloncesto
(13, 2); -- Rugby Reds Queensland - Rugby
INSERT INTO MediaVisual (ClubID, GoogleMapsURL)
VALUES
(1,'https://www.google.com/maps/@40.453054,-3.688344,18z'),
(2, 'https://www.google.com/maps/@43.5776734,1.4681809,18z'),
(3, 'https://www.google.com/maps/@34.0430042,-118.2698896,18z'),
(4, 'https://www.google.com/maps/@-33.9036452,18.4085026,902m,18z'),
(5, 'https://www.google.com/maps/@43.6432862,-79.3804312,331m,18z'),
(6,  'https://www.google.com/maps/@-34.63574,-58.3659794,447m,18z'),
(7, 'https://www.google.com/maps/@-36.87481,174.7438657,435m,18z'),
(8,'https://www.google.com/maps/@-34.5456,-58.4493,18z'),
(9,  'https://www.google.com/maps/@40.4258,-3.6717,18z'),
(10,  'https://www.google.com/maps/@53.3331,-6.2297,18z'),
(11,  'https://www.google.com/maps/@20.6743,-103.3475,18z'),
(12, 'https://www.google.com/maps/@34.0430,-118.2673,18z'),
(13,  'https://www.google.com/maps/@-27.4732,153.0146,18z');
INSERT INTO Reseña (ClubID, Usuario, Descripcion, Valoracion)
VALUES
(1, 'Carlos Pérez', 'Un club con mucha historia y excelente ambiente.', 5), 
(1, 'Laura Gómez', 'Necesita mejorar sus instalaciones.', 3), 
(2, 'Andrés Martín', 'Un gran equipo de rugby que brinda espectáculo.', 4), 
(3, 'Sofía Hernández', 'La energía en los partidos es insuperable.', 5), 
(4, 'Mateo López', 'Gran nivel de profesionalismo en el campo.', 4), 
(5, 'Mariana Torres', 'Los fanáticos hacen de este equipo algo especial.', 5), 
(6, 'Javier Ruiz', 'Un equipo emblemático con gran historia.', 5), 
(7, 'Isabela Fernández', 'Los All Blacks nunca decepcionan.', 5), 
(8, 'Lucas Ramírez', 'Una rivalidad icónica con Boca Juniors.', 5), 
(9, 'Elena Castillo', 'Un equipo que marca la diferencia en baloncesto.', 5),
(10, 'Diego Sánchez', 'Un equipo de rugby con una gran base de apoyo.', 4), 
(11, 'Camila Romero', 'El equipo más querido de México.', 4),
(12, 'Valeria Ortiz', 'Siempre emocionantes juegos en la NBA.', 4),
(13, 'Álvaro Vega', 'Un equipo sólido con gran espíritu.', 4); 

INSERT INTO Ubicacion (ClubID, Ciudad, Direccion, CodigoPostal,PaisID)
VALUES
(1, 'Madrid', 'Av. Santiago Bernabéu, 1', '28036',1),
(2, 'Toulouse', 'Rue des Rugbymen, 45', '31000',2),
(3, 'Los Ángeles', 'Staples Center, 1111 S Figueroa St', '90015',3),
(4, 'Ciudad del Cabo', 'Green Point Stadium, 1 Fritz Sonnenberg Rd', '8051',4),
(5, 'Toronto', 'Scotiabank Arena, 40 Bay St', 'M5J 2X2',5),
(6, 'Buenos Aires', 'Brandsen 805', '1161',6),
(7, 'Wellington', 'Sky Stadium, Waterloo Quay', '6011',7),
(8, 'Buenos Aires', 'Av. Figueroa Alcorta 7597', '1428',6),
(9, 'Madrid', 'Calle de Goya 90', '28009',1),
(10, 'Dublín', 'Ballsbridge, D4', '1234',8),
(11, 'Guadalajara', 'Calle Colomos 2300', '44660',9),
(12, 'Los Ángeles', '1111 S Figueroa St', '90015',3),
(13, 'Brisbane', '40 Castlemaine St', '4000',10);

INSERT INTO Contacto (ClubID, Telefono, Email)
VALUES
(1, '34910012345', 'info@realmadrid.com'),
(2, '33561422345', 'contact@rugbytoulouse.fr'),
(3, '12132223456', 'info@lakers.com'),
(4, '27212322345', 'info@stormers.co.za'),
(5, '14162223456', 'info@raptors.com'),
(6, '54112322345', 'info@bocajuniors.com'),
(7, '64422322345', 'info@allblacks.co.nz'),
(8, '541147312345', 'info@riverplate.com'),
(9, '34910123456', 'info@realmadridbasket.com'),
(10, '35312342345', 'info@leinsterrugby.ie'),
(11, '523334567890', 'info@chivas.com.mx'),
(12, '12132342345', 'info@clippers.com'),
(13, '61731234567', 'info@reds.com.au');

SELECT * FROM ClubCategorias
SELECT * FROM Contacto
SELECT * FROM MediaVisual
SELECT * FROM Clubs
select * from Continentes