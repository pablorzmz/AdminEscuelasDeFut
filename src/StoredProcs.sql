USE DB_ERROR404
/* Se necesitan al menos los siguientes procedimientos almacenados */


/* Para agregar datos. */

1- /* Registrar un nuevo pago mensual, de matricula o ambos de un jugador específico */

GO
--@tipo variable para saber que tipo de pago es, existen los siguientes casos:
--0->Pago matricula
--1->Pago mensualidad
--2->Pago de ambos 
CREATE PROCEDURE insertarPagoJugador @nombreEscuela VARCHAR(30), @numeroRecibo VARCHAR(5), @fecha DATE, @monto INT, @detalle VARCHAR(500), @cedula CHAR(9), @tipo TINYINT
AS 
	INSERT PagosDeJugador VALUES(@nombreEscuela, @numeroRecibo, @fecha , @monto, @detalle , @cedula) 
	--Si es distinto de pago de mensualidad, es de matricula o ambos
	IF( @tipo <> 1)
	BEGIN 
		INSERT PagoMatricula VALUES(@nombreEscuela, @numeroRecibo)
	END
	--Si es distinto de pago de matricula, es de mensualidad o ambos
	IF( @tipo <> 0)
	BEGIN 
		INSERT PagoMensualidad VALUES(@nombreEscuela, @numeroRecibo)
	END
	--Si tipo era igual a 2, se realizan ambos pagos
GO

2- /* Registrar un jugador nuevo ( con todos los atributos necesarios )en la base de datos */
GO
CREATE PROCEDURE insertarJugador @nombreJ VARCHAR(30), @Apellido1J VARCHAR(15), @tel1J VARCHAR(8), @tel2J VARCHAR(8),
				 @cedulaJ CHAR(9), @Apellido2J VARCHAR(15), @fechaNac DATE, @sexo CHAR(1),  @escuela VARCHAR(30),
				 @nombreE VARCHAR(30), @Apellido1E VARCHAR(15), @fechaIngreso DATE, @cedulaE CHAR(9), @Apellido2E VARCHAR(15)
AS 
	DECLARE @numTemp INT, @edad INT

	/*Verificar si existe la persona*/
	SET @numTemp = (SELECT count(Cedula)  FROM Persona where Cedula = @cedulaJ);
	IF( 0 = @numTemp )
	BEGIN
		/*Se inserta persona jugador*/
		INSERT INTO Persona VALUES( @cedulaJ, @nombreJ, @Apellido1J, @Apellido2J );
	END

	/*Verificar si existe la persona*/
	SET @numTemp = (SELECT count(Cedula)  FROM Persona WHERE Cedula = @cedulaE);
	IF( 0 = @numTemp )
	BEGIN
		/*Se inserta persona encargado*/
		INSERT INTO Persona VALUES( @cedulaE, @nombreE, @Apellido1E, @Apellido2E );
	END

	/*Se inserta encargado*/
	/*Verificar si existe un encargado*/
	SET @numTemp = (SELECT count(CedEncargado)  FROM Encargado WHERE CedEncargado = @cedulaE);
	IF( 0 = @numTemp )
	BEGIN
		INSERT INTO Encargado VALUES(@cedulaE);
	END
	
	/*Calcular la edad*/
	SET @edad = DATEDIFF(day,@fechaNac,GETDATE())/365;
	/*Se inserta jugador*/
	INSERT INTO Jugador VALUES(@cedulaJ, @edad, @sexo, @fechaNac, @cedulaE, @fechaIngreso);

	/*Se insertan los telefonos*/
	INSERT INTO TelefonoP VALUES( @cedulaJ , @tel1J );
	IF '' <> @tel2J
	BEGIN
		INSERT INTO TelefonoP VALUES( @cedulaJ , @tel2J );
	END

	/*Se inserta tupla Esta_en*/
	INSERT INTO Esta_En VALUES(@cedulaJ, @escuela, '1');

	
GO

3- /* Registrar un nuevo nivel que se imparte en las escuelas  */
GO
CREATE PROCEDURE insertarNivel @numero TINYINT,  @edadInicio TINYINT, @edadFin TINYINT
AS 
INSERT Nivel VALUES( @numero, @edadInicio, @edadFin)
GO

4- /* Registrar un nuevo entrenamiento que se vaya a realizar en las escuelas  */
GO
CREATE PROCEDURE registrarEntrenamiento @fecha DATE, @hora TIME(7)
AS 
INSERT Entrenamiento VALUES ( @fecha, @hora) 
GO

5- /* Registrar un entrenamiento realizado por un jugador especifico */
GO
CREATE PROCEDURE Registar_EntrenamientoJug
	@Cedula char(9),
	@Fecha date
	AS
		INSERT INTO Asiste VALUES (@Cedula, @Fecha);
GO
6- /* Registrar una nueva instalación */
GO
CREATE PROCEDURE Registrar_Instalacion
	@Direccion varchar(30), 
	@Telefono varchar (8)  
	AS
		INSERT INTO Instalacion VALUES (@Direccion, @Telefono);
GO

7- /* Registrar una nueva escuela */
GO
CREATE PROCEDURE Registrar_Escuela 
	@Nombre varchar(30),
	@Lugar varchar (30),
	@Direccion varchar (30)
	AS
		INSERT INTO Escuela VALUES (@Nombre, @Lugar, @Direccion);
GO

GO
CREATE PROCEDURE InsertarPagoMes
		@escuela varchar(30),
		@numRecibo varchar(5),
		@mes char(3),
		@ano char(4)
		AS
			INSERT INTO Mes VALUES (@escuela, @numRecibo, @mes, @ano);
GO
/* Para el borrado de datos */

1- /* Eliminar un jugador de la base de datos */
GO
CREATE PROCEDURE Eliminar_Jugador
	@Cedula char(9)
	AS
		DELETE FROM Asiste
		WHERE CedJugador = @Cedula;  /* Se elimina el jugador de la tabla asiste*/

		DELETE FROM Esta_En
		WHERE CedJugador = @Cedula;

		DELETE FROM Jugador 
		WHERE CedJugador = @Cedula;

		DELETE FROM Persona
		WHERE Cedula = @Cedula;
GO
2- /* Eliminar una escuela de la base de datos */

3- /* Eliminar una instalacion de la base de datos */

GO
CREATE PROCEDURE eliminarInstalacion @direccion VARCHAR(30)
AS 
DELETE Instalacion WHERE Direccion = @direccion
GO

4- /* Eliminar un nivel de la base de datos */
GO
CREATE PROCEDURE eliminarNivel @numero TINYINT
AS 
DELETE 
FROM Nivel
WHERE Numero = @numero
GO

5- /* Eliminar un entrenamiento de la base de datos */
GO
CREATE PROCEDURE eliminarEntrenamiento @fecha DATE
AS 
DELETE Entrenamiento 
WHERE fecha = @fecha 
GO

6- /* Eliminar un entrenamiento de un jugador de la base de datos */


7- /* Eliminar un pago de mensualidad, matricula o ambos de un jugador */

/* Prupuesta para triggers */

1- /* Eliminar un encargador hasta que el número de jugadores donde él sale a cargo sea de cero
y que no sea un entrenador,, adminsitrativo, etc */

2- /*A la hora de insertar un jugador en un nivel, verificar que la edad corresponda con el nivel*/



