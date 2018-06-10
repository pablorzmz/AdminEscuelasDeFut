USE DB_ERROR404;

CREATE TABLE Persona
(
	Cedula		CHAR(9) NOT NULL,
	NombreP		VARCHAR(15) NULL,
	Apellido1	VARCHAR(15) NULL,
	Apellido2	VARCHAR(15) NULL,
	CONSTRAINT Ced_Persona PRIMARY KEY ( Cedula )
);

CREATE TABLE TelefonoP
(
	Cedula 		CHAR(9) NOT NULL,
	Telefono 	VARCHAR(8) NOT NULL,
	CONSTRAINT Tels_Persona PRIMARY KEY ( Cedula, Telefono ),
	CONSTRAINT Ref_Per FOREIGN KEY ( Cedula ) REFERENCES Persona( Cedula )
	ON DELETE CASCADE
);
/* SCRIPT PARA LA TABLA ENCARGADO */
CREATE TABLE Encargado
(
	CedEncargado 			CHAR (9)NOT NULL,
	CONSTRAINT Ced_Encar 	PRIMARY KEY( CedEncargado ),
	CONSTRAINT Ref_Per_Encar FOREIGN KEY ( CedEncargado ) REFERENCES Persona(Cedula)
);

/* SCRIPT PARA LA TABLA JUGADOR */
CREATE TABLE Jugador
(
	CedJugador		CHAR (9) NOT NULL,
	Edad			TINYINT NOT NULL,
	Sexo			CHAR(1) NOT NULL CHECK( Sexo = 'm' OR Sexo = 'f'),
	FechNac			DATE NOT NULL,
	CedEncargado	CHAR(9) NOT NULL,
	CONSTRAINT	Ced_Jug PRIMARY KEY ( CedJugador ),
	CONSTRAINT Ref_Ced_Encar  FOREIGN KEY ( CedEncargado ) REFERENCES Encargado( CedEncargado )

);
/* SCRIPT PARA LA TABLA ESCUELA */
CREATE TABLE Instalacion
(
	Direccion	VARCHAR(30) NOT NULL,
	Telefono	VARCHAR(8) NULL,
	CONSTRAINT Dir_Inst PRIMARY KEY( Direccion )		
);

CREATE TABLE Escuela
(
	Nombre			VARCHAR(30) NOT NULL,
	Lugar			VARCHAR(30) NOT NULL,
	DireccionInst	VARCHAR(30) NOT NULL,
	CONSTRAINT Nomb_Esc PRIMARY KEY( Nombre ),
	CONSTRAINT Ref_Insta FOREIGN KEY ( DireccionInst ) REFERENCES Instalacion( Direccion )
		ON DELETE SET NULL
);

CREATE TABLE TelefonoE
(
	NombreEsc 		VARCHAR(30) NOT NULL,
	Telefono  		VARCHAR(8) NOT NULL,
	CONSTRAINT Telf_Esc PRIMARY KEY ( NombreEsc, Telefono ),
	CONSTRAINT Ref_Esc FOREIGN KEY ( NombreEsc ) REFERENCES Escuela ( Nombre )
		ON DELETE CASCADE
);

/* SCRIPT PARA LA TABLA DE PAGOS DEL JUGADOR */
CREATE TABLE PagosDeJugador
(
	NombreEscuela	VARCHAR(30) NOT NULL,
	NumeroRecibo	TINYINT NOT NULL,
	Fecha			DATE NOT NULL,
	Monto			NUMERIC(5,0) NOT NULL,
	Detalle			VARCHAR(300) NULL,
	CedJugador		CHAR(9) NOT NULL,
	CONSTRAINT Nomb_NumR PRIMARY KEY( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref_Jug	 FOREIGN KEY ( CedJugador ) REFERENCES Jugador ( CedJugador )
);

CREATE TABLE PagoMensualidad
(
	NombreEscuela 	VARCHAR(30) NOT NULL,
	NumeroRecibo 	TINYINT NOT NULL,
	CONSTRAINT Pago_Men PRIMARY KEY ( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref_Pago FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagosDeJugador( NombreEscuela, NumeroRecibo )
		ON DELETE CASCADE
);

CREATE TABLE Mes
(
	NombreEscuela 	VARCHAR(30) NOT NULL,
	NumeroRecibo 	TINYINT NOT NULL,
	Mes			 	TINYINT NOT NULL,
	Año			 	TINYINT NOT NULL,
	CONSTRAINT Pago_Meses PRIMARY KEY ( NombreEscuela, NumeroRecibo, Mes, Año ),
	CONSTRAINT Ref_PagoM  FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagoMensualidad ( NombreEscuela, NumeroRecibo )      
		ON DELETE CASCADE
);

CREATE TABLE PagoMatricula
(
	NombreEscuela 	VARCHAR(30) NOT NULL,
	NumeroRecibo 	TINYINT NOT NULL,
	CONSTRAINT Pago_Matri PRIMARY KEY ( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref2_Pago FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagosDeJugador( NombreEscuela, NumeroRecibo )
);

/* SCRIPT PARA LA TABLA DE ENTRENAMIENTOS */
CREATE TABLE Entrenamiento
(
	Fecha 			DATE NOT NULL,
	Hora 			TIME NOT NULL,
	CONSTRAINT Fecha_entreno PRIMARY KEY( Fecha )
);

/* SCRIPT PARA LA TABLA DE NIVELES */
CREATE TABLE Nivel
(
	Numero 			TINYINT(30) NOT NULL,
	EdadInicio	 	Date NOT NULL,
	EdadFin	 		Date NOT NULL,
	CONSTRAINT Num_nivel PRIMARY KEY ( Numero)
);