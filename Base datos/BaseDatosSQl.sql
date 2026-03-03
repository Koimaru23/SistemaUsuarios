
-- Base de Datos 
CREATE DATABASE SistemaUsuarios;
GO

USE SistemaUsuarios;
GO

CREATE TABLE usuarios (
    id INT IDENTITY(1,1) NOT NULL,
    nombre VARCHAR(50) NULL,
    apellido VARCHAR(50) NULL,
    username VARCHAR(50) NULL,
    password CHAR(50) NULL, -- Se usa CHAR para longitud fija
    email VARCHAR(50) NULL,
    PRIMARY KEY (id)
);
GO

SET IDENTITY_INSERT usuarios ON;

INSERT INTO usuarios (id, nombre, apellido, username, password, email) 
VALUES (1, 'Pedro', 'Ramieres', 'pedrami', '123', 'ped@gmail.com');

INSERT INTO usuarios (id, nombre, apellido, username, password, email) 
VALUES (2, 'Hect', 'ramiro', 'adad', '123', 'fef@gmail.com');