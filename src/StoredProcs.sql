USE DB_ERROR404
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
	/*Se inserta tupla Nivel*/
	INSERT Nivel VALUES( @numero, @edadInicio, @edadFin)
GO

4- /* Registrar un nuevo entrenamiento que se vaya a realizar en las escuelas  */
GO
CREATE PROCEDURE registrarEntrenamiento @fecha DATE, @hora TIME(7)
	AS 
	/*Se inserta tupla Entrenamiento*/
	INSERT Entrenamiento VALUES ( @fecha, @hora) 
GO

5- /* Registrar un entrenamiento realizado por un jugador especifico */
GO
CREATE PROCEDURE Registar_EntrenamientoJug
	@Cedula char(9),
	@Fecha date
	AS
		/*Se inserta tupla Entrenamiento*/
		INSERT INTO Asiste VALUES (@Cedula, @Fecha);
GO

6- /* Registrar una nueva instalación */
GO
CREATE PROCEDURE Registrar_Instalacion
	@Direccion varchar(30), 
	@Telefono varchar (8)  
	AS
		IF @Telefono = '' BEGIN  /*Si el telefono es vacio solo se inserta direccion*/
			INSERT INTO Instalacion(Direccion) VALUES (@Direccion);
		END

		IF @Telefono <> '' BEGIN /*Si el telefono no es vacio se inserta todo*/
			INSERT INTO Instalacion VALUES (@Direccion, @Telefono);
		END
GO

7- /* Registrar una nueva escuela */
GO
CREATE PROCEDURE Registrar_Escuela
	@Nombre varchar(30),
	@Lugar varchar (30),
	@Direccion varchar (30),
	@tel1 VARCHAR(8), 
	@tel2 VARCHAR(8)
	AS
		IF '' <> @Direccion BEGIN    /*Si la direccion no es vacia*/
			INSERT INTO Escuela VALUES (@Nombre, @Lugar, @Direccion);
		END

		IF '' = @Direccion BEGIN	/*Si la direccion es vacia*/
			INSERT INTO Escuela VALUES (@Nombre, @Lugar, NULL);
		END

		IF '' <> @tel1 BEGIN	/*SI el telefono1 no es vacio*/
			INSERT INTO TelefonoE VALUES( @Nombre , @tel1 );
		END

		IF '' <> @tel2 BEGIN    /*SI el telefono2 no es vacio*/
			INSERT INTO TelefonoE VALUES( @Nombre , @tel2 );
		END
GO

8- /* Registrar un pago de mensualidad */
GO
CREATE PROCEDURE InsertarPagoMes
		@escuela varchar(30),
		@numRecibo varchar(5),
		@mes char(3),
		@ano char(4)
		AS
			/*Se inserta tupla Mes*/
			INSERT INTO Mes VALUES (@escuela, @numRecibo, @mes, @ano);
GO

9- /* Agregarle numeros de telefonos a jugadores existentes */
GO
CREATE PROCEDURE agregarTelefonoJugadorExistente
	@CedJugador char (9),
	@Telefono1 varchar(8),
	@Telefono2 varchar(8)
	AS
	IF @Telefono1 <> '-1' BEGIN /*Si telefono1 no existe se inserta*/
		INSERT INTO 
			TelefonoP
		VALUES ( @CedJugador, @Telefono1 )
	END
	IF @Telefono2 <> '-1' BEGIN  /*Si telefono1 no existe se inserta*/
		INSERT INTO 
			TelefonoP
		VALUES ( @CedJugador, @Telefono2 )
	END
GO

10- /* Insertar un encargado */
GO
CREATE  PROCEDURE insertarEncargado
	@Cedula char(9),
	@Nombre varchar(30),
	@Apellido1 varchar(15),
	@Apellido2 varchar (15)
	AS
	INSERT INTO PERSONA		/*Se inserta primero en persona*/
	VALUES (@Cedula,@Nombre,@Apellido1,@Apellido2)

	INSERT INTO Encargado	/*Se inserta en Encargado*/
		VALUES (@Cedula)
GO

11- /* Agregar a una escuela un nivel */
GO
CREATE PROCEDURE insertarNivelesAEscuela
	@nombreEsc VARCHAR(30),
	@numNivel TINYINT
	AS BEGIN
		/*Se inserta el nivel en la escuela*/
		INSERT INTO TIENE VALUES
		(@nombreEsc, @numNivel);
	END
GO

12- /* Insertar Telefonos a una Escuela */
GO
CREATE PROCEDURE insertarTelefonoE
	@nombreEsc VARCHAR(30),
	@tel1 VARCHAR(8), 
	@tel2 VARCHAR(8)
	AS BEGIN
		IF '' <> @tel1 BEGIN /*Si el telefono1 no es vacio se inserta*/
			INSERT INTO TelefonoE VALUES( @nombreEsc , @tel1 );
		END

		IF '' <> @tel2 BEGIN   /*Si el telefono2 no es vacio se inserta*/
			INSERT INTO TelefonoE VALUES( @nombreEsc , @tel2 );
		END
	END
GO

/* Para actualizar Datos */

1- /* Actualizar o Insertar el Telefono de un Jugador */
GO
CREATE PROCEDURE actualizaOInsertarTelefonoNuevo
	@Cedula CHAR(9),
	@NTel1 VARCHAR(8),
	@Ntel2 VARCHAR(8),
	@VTel1 VARCHAR(8),
	@Vtel2 VARCHAR(8)
	AS
	DECLARE @COUNT TINYINT

	/*Existencia telefono 1*/
	SELECT 
		@COUNT = COUNT(*)
	FROM	
		TelefonoP
	WHERE
		TelefonoP.Cedula = @Cedula AND
		TelefonoP.Telefono = @VTel1
	IF @COUNT = 0 BEGIN				/*Si no existe telefono1*/
		IF @VTel1 <> '' BEGIN			/*y si el telefono nuevo no es vacio se inserta*/
			INSERT INTO
				TelefonoP
			VALUES (@Cedula,@VTel1)
			PRINT 'TELEFONO 1 Insertado'
		END
	END
	ELSE BEGIN
		UPDATE						/*Si el telefono1 si existe se actualiza*/
			TelefonoP
		SET 
			Telefono = @NTel1
		WHERE
			Cedula = @Cedula AND
			Telefono = @VTel1
			PRINT 'TELEFONO 1 ACTUALIZADO'
	END
		/*Existencia telefono 2*/
	SELECT 
		@COUNT = COUNT(*)
	FROM	
		TelefonoP
	WHERE
		TelefonoP.Cedula = @Cedula AND
		TelefonoP.Telefono = @VTel2
	IF @COUNT = 0 BEGIN				/*Si no existe telefono2*/
		IF @VTel2 <> '' BEGIN			/*y si el telefono nuevo no es vacio se inserta*/
			INSERT INTO
				TelefonoP
			VALUES (@Cedula,@VTel2)
			PRINT 'TELEFONO 2 Insertado'
		END
	END
	ELSE BEGIN
		UPDATE						/*Si el telefono2 si existe se actualiza*/
			TelefonoP
		SET 
			Telefono = @NTel2
		WHERE
			Cedula = @Cedula AND
			Telefono = @VTel2
		PRINT 'TELEFONO 2 ACTUALIZADO'
	END
GO

2- /* Actualizar un Encargado */
GO
CREATE PROCEDURE actualizarEncargado
	@NCedula char(9),
	@NNombre varchar(30),	
	@NApellido1 varchar(15),
	@NApellido2 varchar (15),
	@VCedula char(9),
	@VNombre varchar(30),
	@VApellido1 varchar(15),
	@VApellido2 varchar (15)
	AS
	UPDATE				/*Se actualiza el encargado*/
		Persona
									/*Valores nuevos*/
		Cedula = @NCedula,
		NombreP = @NNombre,
		Apellido1 = @NApellido1,
		Apellido2 = @NApellido2
	WHERE							/*Valores viejos*/
		Cedula = @VCedula AND
		NombreP = @VNombre AND
		Apellido1 = @VApellido1 AND
		Apellido2 = @VApellido2
GO

3- /* Actualizar un Entrenamiento */
GO
CREATE PROCEDURE actualizarEntrenamiento
	@fechaV DATE, 
	@fechaN DATE, 
	@horaN TIME(7)
	AS 
		UPDATE Entrenamiento		/*Se actualiza el entrenamiento*/
		SET Fecha = @fechaN,Hora = @horaN   /*Valores nuevos*/
		WHERE Fecha = @fechaV				/*Fecha del entrenamiento*/
GO

4- /* Actualizar el entrenamiento de un Jugador */
GO
CREATE PROCEDURE actualizarEntrenamientoJugador
	@CedJugador char(9),
	@NuevoFecha date,
	@ViejaFecha date
	AS
	UPDATE		/*Se actualiza la asistencia de un jugador a un entrenamiento*/
		Asiste
	SET 
		Asiste.FecEntrenamiento = @NuevoFecha
	WHERE
		CedJugador = @CedJugador AND
		FecEntrenamiento = @ViejaFecha;
GO

5- /* Actualizar una Escuela */
GO
CREATE PROCEDURE ActualizarEscuela
	@nombreEscViejo VARCHAR(30),
	@tel1Viejo VARCHAR(8),
	@tel2Viejo VARCHAR(8),
	@nombreEscNuevo VARCHAR(30),
	@Lugar VARCHAR (30),
	@Direccion VARCHAR (30),
	@tel1Nuevo VARCHAR(8),
	@tel2Nuevo VARCHAR(8)
	AS BEGIN
		IF @nombreEscViejo <> @nombreEscNuevo BEGIN	/*Si el nombre nuevo es diferente se actualiza*/
			UPDATE Escuela 
			SET Nombre = @nombreEscNuevo
			WHERE Nombre = @nombreEscViejo;
		END

		UPDATE Escuela						/*Los demas valores de la escuela se actualizan*/
		SET Lugar = @Lugar, DireccionInst = @Direccion
		WHERE Nombre = @nombreEscNuevo;

		IF @tel1Viejo <> '' BEGIN		/*Si existe un telefono1 se actualiza*/
			UPDATE TelefonoE
			SET Telefono = @tel1Nuevo
			WHERE NombreEsc = @nombreEscNuevo AND Telefono = @tel1Viejo;
		END

		IF @tel1Viejo = '' AND @tel1Nuevo <> '' BEGIN	/*Si no existe un telefono1 se inserta uno, si lo hay*/
			INSERT INTO TelefonoE VALUES( @nombreEscNuevo , @tel1Nuevo );
		END

		IF @tel2Viejo <> '' BEGIN	/*Si existe un telefono2 se actualiza*/
			UPDATE TelefonoE
			SET Telefono = @tel2Nuevo
			WHERE NombreEsc = @nombreEscNuevo AND Telefono = @tel2Viejo;
		END

		IF @tel2Viejo = '' AND @tel2Nuevo <> '' BEGIN	/*Si no existe un telefono2 se inserta uno, si lo hay*/
			INSERT INTO TelefonoE VALUES( @nombreEscNuevo , @tel2Nuevo );
		END
	END
GO

6- /* Actualizar una Instalacion */
GO
CREATE PROCEDURE actualizarInstalacion
	@direccionV VARCHAR(30), 
	@direccionN VARCHAR(30), 
	@telefono VARCHAR(8)
AS 
	UPDATE Instalacion		/*Se actualizan los valores de la instalacion*/
	SET Direccion = @direccionN, Telefono = @telefono
	WHERE Direccion = @direccionV
GO

7- /* Actualizar un Jugador */
GO
CREATE PROCEDURE actualizarJugador
	@ViejaCedJugador	CHAR (9), 
	@ViejoTelefono1Jugador	VARCHAR(8),
	@ViejoTelefono2Jugador	VARCHAR(8),
	@NuevaCedJugador	CHAR (9),
	@Edad				TINYINT,
	@Sexo				CHAR(1) ,
	@FechaNacimiento	DATE,
	@NuevaCedEncargado	CHAR (9),
	@FechaIngreso		DATE,
	@NombreJug			VARCHAR(30),
	@Apellido1Jug		VARCHAR(15),
	@Apellido2Jug		VARCHAR(15),
	@NombreEncargado	VARCHAR(30),
	@Apellido1Encar		VARCHAR(15),
	@Apellido2Encar		VARCHAR(15),
	@NomEscuela			VARCHAR(30),
	@Nivel				TINYINT,
	@NuevoTelefono1Jugador	VARCHAR(8),
	@NuevoTelefono2Jugador	VARCHAR(8)
	AS
	BEGIN TRANSACTION
	/*Primero actualiza la referencia en persona*/
		UPDATE Persona
		SET 
			Persona.Cedula = @NuevaCedJugador
		WHERE 
			Persona.Cedula = @ViejaCedJugador;
    /*Luego se actualiza en jugador*/
		UPDATE Jugador
		SET 
			Jugador.CedJugador = @NuevaCedJugador
		WHERE 
			Jugador.CedJugador = @ViejaCedJugador;
	COMMIT
	/*Se actualiza la informacíon personal del Jugador */
	UPDATE 
		Persona
	SET
		Persona.NombreP = @NombreJug,
		Persona.Apellido1 = @Apellido1Jug,
		Persona.Apellido2 = @Apellido2Jug
	WHERE
		Persona.Cedula = @NuevaCedJugador;

	/*Se actualiza la informacíon basica del Jugador */
	Update 
		Jugador
	SET
		Jugador.Edad = @Edad,
		Jugador.Sexo = @Sexo,
		Jugador.FechaIngreso = @FechaIngreso,
		Jugador.FechNac = @FechaNacimiento,
		Jugador.CedEncargado = @NuevaCedEncargado
	WHERE
		Jugador.CedJugador = @NuevaCedJugador;
	/*Se actualiza toda de Esta_En correspondiente */
	UPDATE   /*Se actualiza la informacíon de acuerdo a la escuela a la que pertenece*/
		Esta_En
	SET
		Esta_En.NomEscuela = @NomEscuela,
		Esta_En.Nivel = @Nivel
	WHERE
		Esta_En.CedJugador = @NuevaCedJugador;
	/*Se insertan o actualizan los telefonos de persona-Jugador */	
	EXEC actualizaOInsertarTelefonoNuevo 
				@NuevaCedJugador,
				@NuevoTelefono1Jugador,
				@NuevoTelefono2Jugador,
				@ViejoTelefono1Jugador,
				@ViejoTelefono2Jugador
GO


8- /* Actualizar un Nivel */
GO
CREATE PROCEDURE actualizarNivel 
	@numeroV TINYINT, 
	@numeroN TINYINT, 
	@edadInicio TINYINT, 
	@edadFin TINYINT
AS 
	UPDATE Nivel /*Se actualiza la informacion del nivel*/
	SET Numero = @numeroN, EdadInicio = @edadInicio, EdadFin = @edadFin
	WHERE Numero = @numeroV
GO

9- /* Actualizar el Nivel de una Escuela */
GO
CREATE PROCEDURE ActualizarNivelesDeEscuela
	@numNivelViejo TINYINT,
	@numNivelNuevo TINYINT,
	@nombreEsc VARCHAR(30)
	AS BEGIN
		UPDATE TIENE /*Se actualiza un nivel perteneciente a una escuela*/
		SET NumNivel = @numNivelNuevo
		WHERE NomEsc = @nombreEsc AND NumNivel = @numNivelViejo;
	END
GO


/* Para el borrado de datos */

1- /* Eliminar un jugador de la base de datos */
GO
CREATE PROCEDURE Eliminar_Jugador
	@Cedula char(9)
	AS
		DECLARE @CedEncargado CHAR(9)
		DECLARE @Detalle varchar (500)
		/*Se actualiza el detalle de los pagos asociados al jugador*/
		DECLARE  cursorPagos CURSOR FOR
		(SELECT 
			Detalle 
		FROM 
			PagosDeJugador 
		WHERE
			CedJugador = @Cedula);

		OPEN cursorPagos
		FETCH NEXT FROM cursorPagos into @Detalle
		WHILE @@FETCH_STATUS = 0 BEGIN
			UPDATE
				PagosDeJugador
			SET
				Detalle = /*Con esto se salva la cedula de la persona que ha realizado pagos*/
				CONCAT(@Detalle,' (Pago del jugador eliminado con cédula',@Cedula,')')
			WHERE
				CedJugador = @Cedula
			FETCH NEXT FROM cursorPagos into @Detalle
		END
		CLOSE cursorPagos
		DEALLOCATE  cursorPagos
		/*finalmente se elimina al jugador*/
		DELETE FROM Jugador 
		WHERE CedJugador = @Cedula;

		/*finalmente se elimina persona asociada*/
		DELETE FROM Persona
		WHERE Cedula = @Cedula;

		/*Y se elimina el encargado si se dispara el trigger correspondiente*/
		SELECT 
			@CedEncargado = CedEncargado
		FROM
			Jugador
		WHERE
			CedJugador = @Cedula

		DELETE FROM Encargado WHERE CedEncargado = @CedEncargado
GO

2- /* Eliminar una escuela de la base de datos */
GO
CREATE PROCEDURE eliminarEscuela
	@nombre VARCHAR(30)
	AS BEGIN
		DECLARE @ced CHAR(9)
		DECLARE Cursor1 CURSOR
		FOR SELECT CedJugador FROM Esta_En WHERE NomEscuela = @nombre;
		OPEN Cursor1
		FETCH NEXT FROM Cursor1 INTO @ced
		WHILE @@fetch_status = 0 BEGIN /*Este procedimiento debe eliminar los jugadores que pertenecen a la escuela*/
			EXEC Eliminar_Jugador @ced;
			FETCH NEXT FROM Cursor1 INTO @ced
		END
		CLOSE Cursor1
		DEALLOCATE Cursor1
		DELETE FROM Escuela  /*Despues de que se eliminan todos los jugadores se elimina la escuela*/
		WHERE Nombre = @nombre;
	END
GO

3- /* Eliminar una instalacion de la base de datos */
GO
CREATE PROCEDURE eliminarInstalacion 
	@direccion VARCHAR(30)
AS 
	DELETE Instalacion WHERE Direccion = @direccion /*Se elimina la instalacion*/
GO

4- /* Eliminar un nivel de la base de datos */
GO
CREATE PROCEDURE eliminarNivel 
	@numero TINYINT
AS 
	DELETE 
	FROM Nivel	/*Se elimina el nivel*/
	WHERE Numero = @numero
GO

5- /* Eliminar un entrenamiento de la base de datos */
GO
CREATE PROCEDURE eliminarEntrenamiento 
	@fecha DATE
AS 
	DELETE Entrenamiento /*Se elimina el entrenamiento*/
	WHERE fecha = @fecha 
GO

6- /* Eliminar un entrenamiento de un jugador de la base de datos */
GO
CREATE PROCEDURE EliminarEntrenamientoDeJugador
	@CedJugador char (9),
	@FechEntren date 
	AS
	DELETE  FROM Asiste WHERE Asiste.CedJugador = @CedJugador /*Se elimina el entrenamiento del jugador*/
							  AND Asiste.FecEntrenamiento = @FechEntren									
GO

7- /* Eliminar un Encargado */
GO
CREATE PROCEDURE eliminarEncargado
	@Cedula char(9)
	AS	
	DELETE FROM Encargado WHERE CedEncargado = @Cedula /*Se elimina el encargado*/
	--DELETE FROM Persona WHERE Cedula = @Cedula
GO

8- /* Eliminar el nivel de una escuela */
GO
CREATE PROCEDURE eliminarNivelesDeEscuela
	@nombreEsc VARCHAR(30),
	@numNivel TINYINT
	AS BEGIN
		DELETE FROM TIENE /*Se elimina el nivel perteneciente a la escuela*/
		WHERE NomEsc = @nombreEsc AND NumNivel = @numNivel;
	END
GO

9- /* Eliminar un pago general de un jugador */
GO
CREATE PROCEDURE EliminarPagoGeneralJugador
	@NombreEscuela varchar (30),
	@NumeroRecibo varchar (5)
	AS
			DELETE FROM PagosDeJugador WHERE  /*Se elimina el pago del jugador (General)*/
			PagosDeJugador.NombreEscuela = @NombreEscuela AND
			PagosDeJugador.NumeroRecibo = @NumeroRecibo
GO

10- /* Eliminar un pago de matricula de un jugador */
GO
CREATE PROCEDURE EliminarPagoMatriculaJugador
	@NombreEscuela varchar (30),
	@NumeroRecibo varchar (5)
	AS
			DELETE FROM PagoMatricula WHERE		/*Se elimina el pago del jugador (Matricula)*/
			PagoMatricula.NombreEscuela = @NombreEscuela AND
			PagoMatricula.NumeroRecibo = @NumeroRecibo
GO

11- /* Eliminar un pago de mensualidad de un jugador */
GO
CREATE PROCEDURE EliminarPagoMensualidadJugador
	@NombreEscuela varchar (30),
	@NumeroRecibo varchar (5),
	@Mes char (3),
	@Año char (4)
	AS
		DELETE FROM Mes WHERE		/*Se elimina el pago del registro de meses*/
			Mes.NombreEscuela = @NombreEscuela AND
			Mes.NumeroRecibo = @NumeroRecibo AND
			Mes.Mes = @Mes AND
			Mes.Año = @Año

		DELETE FROM PagoMensualidad WHERE /*Se elimina el pago del jugador (Mensual)*/
			PagoMensualidad.NombreEscuela = @NombreEscuela AND
			PagoMensualidad.NumeroRecibo = @NumeroRecibo
GO


/* Triggers */

1- /* Eliminar un encargador hasta que el número de jugadores donde él sale a cargo sea de cero
y que no sea un entrenador,, adminsitrativo, etc */
GO
CREATE TRIGGER EliminaEncargadoSinJugadores 
ON Encargado
	INSTEAD OF DELETE	
	AS
	DECLARE @COUNTER TINYINT
	DECLARE @CedEncargado char(9)
	
	SELECT 
		@CedEncargado = CedEncargado
	FROM 
		DELETED;

	SELECT 
		@COUNTER =  COUNT(J.CedJugador) 
	FROM 
		Encargado as E left join Jugador as J on E.CedEncargado = J.CedEncargado
	WHERE E.CedEncargado = @CedEncargado;	
	
	IF @COUNTER = 0 BEGIN /*Si el encargado ya no tiene jugadores se elimina*/
		DELETE 
		FROM 
			Encargado
		WHERE
			CedEncargado = @CedEncargado
		DELETE FROM Persona WHERE Cedula = @CedEncargado
	END	
GO


2- /*A la hora de insertar un jugador en un nivel, verificar que la edad corresponda con el nivel si no insertarlo en el que corresponda */
GO
CREATE TRIGGER insertarJugANivel
	ON Esta_En
	INSTEAD OF INSERT
	AS BEGIN
		DECLARE @edad TINYINT,
				@nivel TINYINT,
				@ced CHAR(9),
				@escuela VARCHAR(30),
				@nivelEsc TINYINT,
				@edadI TINYINT,
				@edadF TINYINT
		SELECT @nivel = Nivel, @ced = CedJugador, @escuela = NomEscuela 
		FROM INSERTED;
		
		SELECT @edad = Edad
		FROM Jugador
		WHERE CedJugador = @ced;
		
		DECLARE Cursor1 CURSOR LOCAL
		FOR SELECT NumNivel, EdadInicio, EdadFin FROM Tiene JOIN Nivel
		ON Nivel.Numero = Tiene.NumNivel WHERE NomEsc = @escuela;
		
		OPEN Cursor1
		FETCH NEXT FROM Cursor1 INTO @nivelEsc, @edadI, @edadF;
		WHILE @@fetch_status = 0 BEGIN
			
			IF @edad >= @edadI AND @edad <= @edadF BEGIN  /*Se verifica a cual nivel de la escuela pertenece el jugador*/
				INSERT INTO Esta_En VALUES
				(@ced, @escuela, @nivelEsc);
			END

			FETCH NEXT FROM Cursor1 INTO @nivelEsc, @edadI, @edadF;
		END
		CLOSE Cursor1
		DEALLOCATE Cursor1
	END
GO



