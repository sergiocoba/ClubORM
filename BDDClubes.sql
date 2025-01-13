CREATE DATABASE Clubs;
GO
USE Clubs;
GO


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
    Nombre NVARCHAR(100) NOT NULL,
    Reseña NVARCHAR(MAX),
    Fundacion INT,
    Valoracion TINYINT CHECK (Valoracion BETWEEN 1 AND 5),
    Horario NVARCHAR(500),
    CategoriaID INT FOREIGN KEY REFERENCES Categorias(CategoriaID) ON DELETE CASCADE,
    PaisID INT FOREIGN KEY REFERENCES Pais(PaisID) ON DELETE CASCADE
);


CREATE TABLE Ubicacion (
    UbicacionID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Ciudad NVARCHAR(100),
    Direccion NVARCHAR(200),
    CodigoPostal NVARCHAR(10)
);

CREATE TABLE Contacto (
    ContactoID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE MediaVisual (
    ClubID INT FOREIGN KEY REFERENCES Clubs(ClubID) ON DELETE CASCADE,
    Logo NVARCHAR(255),
    MiniaturaWeb NVARCHAR(255),
    GoogleMapsURL NVARCHAR(255),
    PRIMARY KEY (ClubID, GoogleMapsURL) 
);

CREATE TABLE Galeria (
    ClubID INT NOT NULL,
    Foto NVARCHAR(255) NOT NULL, 
    PRIMARY KEY (ClubID, Foto),
    FOREIGN KEY (ClubID) REFERENCES Clubs(ClubID) ON DELETE CASCADE
);


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

INSERT INTO Categorias (Nombre)
VALUES
('Fútbol'),
('Rugby'),
('Baloncesto');

INSERT INTO Clubs (Nombre, Reseña, Fundacion, Valoracion, Horario, CategoriaID, PaisID)
VALUES 
('Club Futbol Madrid', 'Club histórico con múltiples títulos.', 1902, 5, 'Lunes a Viernes: 10:00 - 20:00', 1, 1),
('Club de Rugby Toulouse', 'Equipo de rugby destacado en Europa.', 1907, 4, 'Martes a Sábado: 9:00 - 18:00', 2, 2),
('Angeles Lakers', 'Equipo de la NBA con gran tradición.', 1947, 5, 'Todos los días: 8:00 - 22:00', 3, 3),
('Rugby Stormers', 'Equipo profesional en la liga internacional.', 1998, 4, 'Martes a Viernes: 9:00 - 17:00', 2, 4),
('Basket Toronto Raptors', 'Campeones de la NBA en 2019.', 1995, 5, 'Todos los días: 10:00 - 21:00', 3, 5),
('Futbol Boca Juniors', 'Uno de los clubes más emblemáticos de Argentina.', 1905, 5, 'Miércoles a Domingo: 11:00 - 19:00', 1, 6),
('Club Rugby All Blacks', 'Conocidos por su Haka y gran desempeño mundial.', 1903, 5, 'Lunes a Viernes: 8:00 - 18:00', 2, 7),
('Club Atlético River Plate', 'Uno de los clubes más grandes de Argentina.', 1901, 5, 'Lunes a Viernes: 9:00 - 18:00', 1, 6),
('Club Baloncesto Real Madrid', 'Equipo de baloncesto del Real Madrid.', 1931, 5, 'Todos los días: 10:00 - 22:00', 3, 1),
('Club Rugby Leinster', 'Equipo de rugby profesional en Dublín.', 1875, 5, 'Lunes a Viernes: 8:00 - 16:00', 2, 8),
('Club Deportivo Guadalajara', 'Mejor conocido como Chivas.', 1906, 4, 'Todos los días: 9:00 - 21:00', 1, 9),
('Los Angeles Clippers', 'Equipo de la NBA con base en Los Ángeles.', 1970, 4, 'Miércoles a Domingo: 11:00 - 19:00', 3, 3),
('Rugby Reds Queensland', 'Equipo de rugby profesional australiano.', 1882, 4, 'Martes a Viernes: 8:00 - 17:00', 2, 10);

INSERT INTO Ubicacion (ClubID, Ciudad, Direccion, CodigoPostal)
VALUES
(1, 'Madrid', 'Av. Santiago Bernabéu, 1', '28036'),
(2, 'Toulouse', 'Rue des Rugbymen, 45', '31000'),
(3, 'Los Ángeles', 'Staples Center, 1111 S Figueroa St', '90015'),
(4, 'Ciudad del Cabo', 'Green Point Stadium, 1 Fritz Sonnenberg Rd', '8051'),
(5, 'Toronto', 'Scotiabank Arena, 40 Bay St', 'M5J 2X2'),
(6, 'Buenos Aires', 'Brandsen 805', '1161'),
(7, 'Wellington', 'Sky Stadium, Waterloo Quay', '6011'),
(8, 'Buenos Aires', 'Av. Figueroa Alcorta 7597', '1428'),
(9, 'Madrid', 'Calle de Goya 90', '28009'),
(10, 'Dublín', 'Ballsbridge, D4', '1234'),
(11, 'Guadalajara', 'Calle Colomos 2300', '44660'),
(12, 'Los Ángeles', '1111 S Figueroa St', '90015'),
(13, 'Brisbane', '40 Castlemaine St', '4000');
