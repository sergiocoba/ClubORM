CREATE DATABASE Clubs;
GO
USE Clubs;
GO

DROP DATABASE Clubs
USE bdEmpresa

CREATE TABLE Clubs (
    ClubID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Rese�a NVARCHAR(MAX),
	Fundacion INT,
    Valoracion TINYINT CHECK (Valoracion BETWEEN 1 AND 5),
    Horario NVARCHAR(500),
	CategoriaID INT FOREIGN KEY REFERENCES Categorias(CategoriaID) ON DELETE CASCADE,
	PaisID INT FOREIGN KEY REFERENCES Pais(PaisID) ON DELETE CASCADE
);
SELECT * FROM Clubs

CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE
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
ALTER TABLE MediaVisual
ADD PRIMARY KEY (ClubID);


CREATE TABLE Continentes (
    ContinenteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Pais (
    PaisID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
    ContinenteID INT NOT NULL FOREIGN KEY REFERENCES Continentes(ContinenteID) ON DELETE CASCADE
);

INSERT INTO Clubs (Nombre, Rese�a, Fundacion, Valoracion, Horario, CategoriaID, PaisID)
VALUES 
('Club Futbol Madrid', 'Club hist�rico con m�ltiples t�tulos.', 1902, 5, 'Lunes a Viernes: 10:00 - 20:00', 1, 1),
('Club de Rugby Toulouse', 'Equipo de rugby destacado en Europa.', 1907, 4, 'Martes a S�bado: 9:00 - 18:00', 2, 2),
('Angeles Lakers', 'Equipo de la NBA con gran tradici�n.', 1947, 5, 'Todos los d�as: 8:00 - 22:00', 3, 3),
('Rugby Stormers', 'Equipo profesional en la liga internacional.', 1998, 4, 'Martes a Viernes: 9:00 - 17:00', 2, 4),
('Basket Toronto Raptors', 'Campeones de la NBA en 2019.', 1995, 5, 'Todos los d�as: 10:00 - 21:00', 3, 5),
('Futbol Boca Juniors', 'Uno de los clubes m�s emblem�ticos de Argentina.', 1905, 5, 'Mi�rcoles a Domingo: 11:00 - 19:00', 1, 6),
('Club Rugby All Blacks', 'Conocidos por su Haka y gran desempe�o mundial.', 1903, 5, 'Lunes a Viernes: 8:00 - 18:00', 2, 7),
('Club Atl�tico River Plate', 'Uno de los clubes m�s grandes de Argentina.', 1901, 5, 'Lunes a Viernes: 9:00 - 18:00', 1, 6),
('Club Baloncesto Real Madrid', 'Equipo de baloncesto del Real Madrid.', 1931, 5, 'Todos los d�as: 10:00 - 22:00', 3, 1),
('Club Rugby Leinster', 'Equipo de rugby profesional en Dubl�n.', 1875, 5, 'Lunes a Viernes: 8:00 - 16:00', 2, 8),
('Club Deportivo Guadalajara', 'Mejor conocido como Chivas.', 1906, 4, 'Todos los d�as: 9:00 - 21:00', 1, 9),
('Los Angeles Clippers', 'Equipo de la NBA con base en Los �ngeles.', 1970, 4, 'Mi�rcoles a Domingo: 11:00 - 19:00', 3, 3),
('Rugby Reds Queensland', 'Equipo de rugby profesional australiano.', 1882, 4, 'Martes a Viernes: 8:00 - 17:00', 2, 10);



INSERT INTO Ubicacion (ClubID, Ciudad, Direccion, CodigoPostal)
VALUES
(1, 'Madrid', 'Av. Santiago Bernab�u, 1', '28036'),
(2, 'Toulouse', 'Rue des Rugbymen, 45', '31000'),
(3, 'Los �ngeles', 'Staples Center, 1111 S Figueroa St', '90015'),
(4, 'Ciudad del Cabo', 'Green Point Stadium, 1 Fritz Sonnenberg Rd', '8051'),
(5, 'Toronto', 'Scotiabank Arena, 40 Bay St', 'M5J 2X2'),
(6, 'Buenos Aires', 'Brandsen 805', '1161'),
(7, 'Wellington', 'Sky Stadium, Waterloo Quay', '6011'),
(8, 'Buenos Aires', 'Av. Figueroa Alcorta 7597', '1428'),
(9, 'Madrid', 'Calle de Goya 90', '28009'),
(10, 'Dubl�n', 'Ballsbridge, D4', '1234'),
(11, 'Guadalajara', 'Calle Colomos 2300', '44660'),
(12, 'Los �ngeles', '1111 S Figueroa St', '90015'),
(13, 'Brisbane', '40 Castlemaine St', '4000');

INSERT INTO Contacto (ClubID, Telefono, Email)
VALUES
(1, '+34910012345', 'info@realmadrid.com'),
(2, '+33561422345', 'contact@rugbytoulouse.fr'),
(3, '+12132223456', 'info@lakers.com'),
(4, '+27212322345', 'info@stormers.co.za'),
(5, '+14162223456', 'info@raptors.com'),
(6, '+54112322345', 'info@bocajuniors.com'),
(7, '+64422322345', 'info@allblacks.co.nz'),
(8, '+541147312345', 'info@riverplate.com'),
(9, '+34910123456', 'info@realmadridbasket.com'),
(10, '+35312342345', 'info@leinsterrugby.ie'),
(11, '+523334567890', 'info@chivas.com.mx'),
(12, '+12132342345', 'info@clippers.com'),
(13, '+61731234567', 'info@reds.com.au');

INSERT INTO Continentes (Nombre)
VALUES 
('Europa'),
('Am�rica'),
('�frica'),
('Ocean�a'),
('Antartida'),
('Asia');



INSERT INTO Pais (Nombre, ContinenteID)
VALUES
('Espa�a', 1),
('Francia', 1),
('Estados Unidos', 2), 
('Sud�frica', 3), 
('Canad�', 2), 
('Argentina', 2),
('Nueva Zelanda', 4),
('Irlanda', 1), 
('M�xico', 2),
('Australia', 4);


INSERT INTO Categorias (Nombre)
VALUES
('F�tbol'),
('Rugby'),
('Baloncesto');
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'MediaVisual';

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