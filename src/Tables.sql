USE DB_ERROR404;

/* Tabla de la entidad de Persona*/
CREATE TABLE Persona
(
	Cedula		CHAR(9)		NOT NULL,
	NombreP		VARCHAR(30) NULL,
	Apellido1	VARCHAR(15) NULL,
	Apellido2	VARCHAR(15) NULL,
	CONSTRAINT Ced_Persona PRIMARY KEY ( Cedula )
);

/*Atributo multivalor de los teléfonos de las personas*/
CREATE TABLE TelefonoP
(
	Cedula 		CHAR(9)		NOT NULL,
	Telefono 	VARCHAR(8)	NOT NULL,
	CONSTRAINT Tels_Persona PRIMARY KEY ( Cedula, Telefono ),
	CONSTRAINT Ref_Per FOREIGN KEY ( Cedula ) REFERENCES Persona( Cedula )
	ON DELETE CASCADE ON DELETE CASCADE
);
/* Tabla de la entidad especializada Encargado */
CREATE TABLE Encargado
(
	CedEncargado 			 CHAR (9)	NOT NULL,
	CONSTRAINT Ced_Encar 	 PRIMARY KEY( CedEncargado ),		
	CONSTRAINT Ref_Per_Encar FOREIGN KEY ( CedEncargado ) REFERENCES Persona( Cedula )
		ON UPDATE CASCADE
);
/* Tabla de la entidad especializada Jugador */
CREATE TABLE Jugador
(
	CedJugador		CHAR (9)	NOT NULL,
	Edad			TINYINT		NOT NULL,
	Sexo			CHAR(1)		NOT NULL CHECK( Sexo = 'm' OR Sexo = 'f'),
	FechNac			DATE		NOT NULL,
	CedEncargado	CHAR(9)		NOT NULL,
	CONSTRAINT	Ced_Jug PRIMARY KEY ( CedJugador ),
	CONSTRAINT Ref_Ced_Encar  FOREIGN KEY ( CedEncargado ) REFERENCES Encargado( CedEncargado )
		ON UPDATE CASCADE
	CONSTRAINT Ref_Jug_Pers FOREIGN KEY ( CedJugador ) REFERENCES Persona( Cedula )
		ON UPDATE CASCADE
);
/* Tabla entidad instalación */
CREATE TABLE Instalacion
(
	Direccion	VARCHAR(30) NOT NULL,
	Telefono	VARCHAR(8)  NULL DEFAULT '88888888',
	CONSTRAINT Dir_Inst PRIMARY KEY( Direccion )		
);

/* Tabla de la entidad Esculea */
CREATE TABLE Escuela
(
	Nombre			VARCHAR(30) NOT NULL,
	Lugar			VARCHAR(30) NOT NULL,
	DireccionInst	VARCHAR(30) NULL,
	CONSTRAINT Nomb_Esc  PRIMARY KEY( Nombre ),
	CONSTRAINT Ref_Insta FOREIGN KEY ( DireccionInst ) REFERENCES Instalacion( Direccion )
		ON DELETE SET NULL ON UPDATE CASCADE
);

/* Atributo multivalor de las escuelas */
CREATE TABLE TelefonoE
(
	NombreEsc 		VARCHAR(30)		NOT NULL,
	Telefono  		VARCHAR(8)		NOT NULL,
	CONSTRAINT Telf_Esc PRIMARY KEY ( NombreEsc, Telefono ),
	CONSTRAINT Ref_Esc FOREIGN KEY ( NombreEsc ) REFERENCES Escuela ( Nombre )
		ON DELETE CASCADE ON UPDATE CASCADE
);

/* Tabla de la entidad pagos del jugador */
CREATE TABLE PagosDeJugador
(
	NombreEscuela	VARCHAR(30)		NOT NULL,
	NumeroRecibo	VARCHAR(5)		NOT NULL,
	Fecha			DATE			NOT NULL,
	Monto			NUMERIC(6,0)	NOT NULL,
	Detalle			VARCHAR(500)	NULL,
	CedJugador		CHAR(9)			NOT NULL,
	CONSTRAINT Nomb_NumR PRIMARY KEY( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref_Jug1	 FOREIGN KEY ( CedJugador ) REFERENCES Jugador ( CedJugador )
		ON UPDATE CASCADE ON DELETE NO SET NULL,
	CONSTRAINT Ref_Escc	 FOREIGN KEY ( NombreEscuela ) REFERENCES Escuela ( Nombre )
		ON UPDATE CASCADE ON DELETE NO ACTION
);
/* Tabla de la entidad especializada pagos del jugador  mensualidad */
CREATE TABLE PagoMensualidad
(
	NombreEscuela 	VARCHAR(30)		NOT NULL,
	NumeroRecibo 	VARCHAR(5)			NOT NULL,
	CONSTRAINT Pago_Men PRIMARY KEY ( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref_Pago FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagosDeJugador( NombreEscuela, NumeroRecibo )
		ON UPDATE CASCADE 
);

/* Atributo multivalor de los meses pagados del pago mensualidad */
CREATE TABLE Mes
(
	NombreEscuela 	VARCHAR(30) NOT NULL,
	NumeroRecibo 	VARCHAR(5)		NOT NULL,
	Mes			 	CHAR(3)		NOT NULL,
	Año			 	CHAR(4)		NOT NULL,
	CONSTRAINT Pago_Meses PRIMARY KEY ( NombreEscuela, NumeroRecibo, Mes, Año ),
	CONSTRAINT Ref_PagoM  FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagoMensualidad ( NombreEscuela, NumeroRecibo )      
		ON DELETE CASCADE ON UPDATE CASCADE
);

/* Tabla de la entidad especializada pagos del jugador matrículas */
CREATE TABLE PagoMatricula
(
	NombreEscuela 	VARCHAR(30) NOT NULL,
	NumeroRecibo 	VARCHAR(5)		NOT NULL,
	CONSTRAINT Pago_Matri PRIMARY KEY ( NombreEscuela, NumeroRecibo ),
	CONSTRAINT Ref2_Pago FOREIGN KEY ( NombreEscuela, NumeroRecibo ) REFERENCES PagosDeJugador( NombreEscuela, NumeroRecibo )
		ON UPDATE CASCADE
);

/* Tabla de la entidad de entrenamientos */
CREATE TABLE Entrenamiento
(
	Fecha 			DATE NOT NULL,
	Hora 			TIME NOT NULL,
	CONSTRAINT Fecha_entreno PRIMARY KEY( Fecha )
);

/* Tabla de la entidad de nivel */
CREATE TABLE Nivel
(
	Numero 		    TINYINT		NOT NULL,
	EdadInicio	 	TINYINT	    NOT NULL,
	EdadFin	 		TINYINT		NOT NULL,
	CONSTRAINT Num_nivel PRIMARY KEY ( Numero)
);

/* Relación de los jugadores en un nivel y en una escuela específica */
CREATE TABLE Esta_En
(
	CedJugador		CHAR (9)		 NOT NULL,
	NomEscuela		VARCHAR	(30)	 NOT NULL,
	Nivel			TINYINT			 NOT NULL
	CONSTRAINT Esc_Jug_Niv PRIMARY KEY ( CedJugador, NomEscuela ), 			
	CONSTRAINT Ced_For FOREIGN KEY ( CedJugador ) REFERENCES Jugador( CedJugador )
		ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT Esc_For FOREIGN KEY ( NomEscuela ) REFERENCES Escuela ( Nombre )
		ON UPDATE CASCADE,
	CONSTRAINT Niv_For FOREIGN KEY ( Nivel ) REFERENCES Nivel ( Numero )
		ON UPDATE CASCADE
);

/* Relación de los entrenamientos a los que asiste el jugador */
CREATE TABLE Asiste
(
	CedJugador CHAR (9)		NOT NULL,
	FecEntrenamiento DATE	NOT NULL,
	CONSTRAINT Jug_Entre PRIMARY KEY ( CedJugador, FecEntrenamiento ),
	CONSTRAINT Ref_Jug	FOREIGN KEY ( CedJugador ) REFERENCES Jugador( CedJugador)
		ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT Ref_Entre FOREIGN KEY ( FecEntrenamiento ) REFERENCES Entrenamiento ( Fecha )
		ON UPDATE CASCADE,
);

/* Relación de los niveles que tiene una escuela */
CREATE TABLE Tiene 
(
	NomEsc			VARCHAR(30)		NOT NULL,
	NumNivel		TINYINT			NOT NULL,
	CONSTRAINT	Esc_Nivel  PRIMARY KEY ( NomEsc, NumNivel ) ,
	CONSTRAINT	Ref_Esc1	   FOREIGN KEY ( NomEsc ) REFERENCES Escuela ( Nombre )
		ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT	Ref_Esc2	   FOREIGN KEY ( NumNivel ) REFERENCES Nivel ( Numero )
		ON DELETE CASCADE ON UPDATE CASCADE
);
