Create database MiBilleteraVirtual;

CREATE TABLE Provincia
( idprovincia int primary key,
provincia varchar(max)
);

CREATE TABLE Localidad
( idLocalidad int primary key,
Localidad varchar(max),
Domicilio varchar(max),
idProvincia int,

);

CREATE TABLE Moneda
( idMoneda int primary key,
Monto float,
 Nombre varchar(max),

);

CREATE TABLE Cuenta
( idCuenta int primary key,
Saldo float,
 CVU varchar(max),
 Habilitado bit,


);

CREATE TABLE Operacion
( idOperacion int primary key,
Fecha date,
 Monto float,
 Deposito bit,
 Extraccion bit,


);

CREATE TABLE Usuario
( idUsuario int primary key,
Nombre varchar(max),
Apellido varchar(max),
cuil int,
NombreUsuario varchar(max),
Email varchar(max),
Contraseña varchar(8),

);



ALTER TABLE Localidad
ADD idProvincia int;

ALTER TABLE Localidad
ADD FOREIGN KEY (idProvincia) REFERENCES Provincia(idprovincia);

ALTER TABLE Usuario
ADD idLocalidad int;

ALTER TABLE Usuario
ADD FOREIGN KEY (idLocalidad) REFERENCES Localidad(idLocalidad);

ALTER TABLE Operacion
ADD idCuenta int;

ALTER TABLE Operacion
ADD FOREIGN KEY (idCuenta) REFERENCES Cuenta(idCuenta);

ALTER TABLE Cuenta
ADD idUsuario int;

ALTER TABLE Cuenta
ADD FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario);


ALTER TABLE Moneda
ADD idUsuario int;

ALTER TABLE Moneda
ADD FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario);