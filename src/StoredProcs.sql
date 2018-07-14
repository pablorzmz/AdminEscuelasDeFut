USE DB_ERROR404
/* Se necesitan al menos los siguientes procedimientos almacenados */


/* Para agregar datos. */

1- /* Registrar un nuevo pago mensual, de matricula o ambos de un jugador específico */

2- /* Registrar un jugador nuevo ( con todos los atributos necesarios )en la base de datos */

3- /* Registrar un nuevo nivel que se imparte en las escuelas  */

4- /* Registrar un nuevo entrenamiento que se vaya a realizar en las escuelas  */

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

4- /* Eliminar un nivel de la base de datos */

5- /* Eliminar un entrenamiento de la base de datos */

6- /* Eliminar un entrenamiento de un jugador de la base de datos */

7- /* Eliminar un pago de mensualidad, matricula o ambos de un jugador */

/* Prupuesta para triggers */

1- /* Eliminar un encargador hasta que el número de jugadores donde él sale a cargo sea de cero
y que no sea un entrenador,, adminsitrativo, etc */

2- /*A la hora de insertar un jugador en un nivel, verificar que la edad corresponda con el nivel*/