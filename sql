--create database DBTienda;
--use DBTienda;

CREATE TABLE Persona (
PersonaID INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
ApellidoPaterno VARCHAR(25) NOT NULL,
ApellidoMaterno VARCHAR(25) NOT NULL,
FechaNacimiento DATETIME,
EstadoCivil VARCHAR(10),
Correo VARCHAR(50),
Telefono VARCHAR(10),
NumeroDoc INT UNIQUE
);

--COMANDO PARA ALTERAR LA COLUMNA DE ApellidoPaterno y cambiarle el VARCHAR(25)
ALTER TABLE Persona ALTER COLUMN FechaNacimiento DATE; 

CREATE TABLE Usuario (
UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
Usuario VARCHAR(25) UNIQUE NOT NULL,
Contrasenia VARCHAR(25) NOT NULL,
Estado VARCHAR(10),
PersonaID INT NOT NULL UNIQUE,
FOREIGN KEY (PersonaID) REFERENCES Persona(PersonaID),
);

SELECT * FROM Persona;

INSERT INTO Persona (Nombre,ApellidoPaterno, ApellidoMaterno, FechaNacimiento, EstadoCivil, Correo, Telefono, NumeroDoc)
VALUES ('Rodrigo', 'Peres', 'Mamani', '1999-08-12', 'Soltero', 'test3@gmail.com', '985652536', 77211258 );

UPDATE Persona SET FechaNacimiento = '2004/12/23' WHERE PersonaID in (8,9,10) ;

DELETE FROM Persona WHERE PersonaID = (3);
