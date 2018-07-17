USE DB_Error404

/* Pagos de un jugador */
GO
CREATE VIEW VistaPagosJugador
AS
	SELECT NombreP as Nombre, CedJugador as [N° Cedula], NumeroRecibo as [N° Recibo], Fecha, Monto, Detalle, NombreEscuela as Escuela
	FROM PagosDeJugador left join Persona ON Cedula = CedJugador;
GO

/* Entrenamientos de un jugador */
GO
CREATE VIEW VerEntrenamientosJugador
AS
SELECT
	Esta_En.NomEscuela as Escuela,
	Asiste.CedJugador AS Cédula,
	Persona.NombreP AS Nombre,
	Persona.Apellido1 AS Apellido,
	Asiste.FecEntrenamiento AS Fecha 
FROM 
	Asiste join Persona on Asiste.CedJugador = Persona.Cedula 
	join Esta_en on Asiste.CedJugador = Esta_En. CedJugador
GO

/* Ver la informacion del encargado de un jugador */
GO
CREATE VIEW verInforEncargado
AS
SELECT 
	Encargado.CedEncargado AS Cedula,
	Persona.NombreP AS Nombre,
	Persona.Apellido1,
	Persona.Apellido2
FROM 
	Encargado join Persona on Encargado.CedEncargado = Persona.Cedula;
GO

/* Ver la informacion de las cedulas de los jugadores */
GO
CREATE VIEW VistaInfoCedulasJugador
	AS
		SELECT CedJugador as Cedula ,NombreP as Nombre, Apellido1 as [Primer Apellido], Apellido1 as [Segundo Apellido]
		FROM Jugador join Persona ON Cedula = CedJugador;
GO

/* Ver la informacion de un jugador */
GO
CREATE VIEW VistaInformacionJugador
AS
SELECT 
	Jugador.CedJugador as 'N° Cédula',
	Persona.NombreP as 'Nombre',
	Persona.Apellido1 as 'Primer Apellido',
	Persona.Apellido2 as 'Segundo Apellido',
	Jugador.Edad as 'Edad',
	Jugador.Sexo  as 'Sexo',
	Jugador.FechNac as 'Fecha Nacimiento',
	Jugador.FechaIngreso as 'Fecha Ingreso',
	Esta_En.NomEscuela as  'Escuela',
	Esta_En.Nivel as 'Nivel',
	t.CedEncargado as 'N° Cédula Encargado', 	
	t.NombreP  as 'Nombre Encargado',
	t.Apellido1 as 'Primer Apellido Encargado',
	t.Apellido2 as 'Segundo Apellido Encargado'
FROM 
	Jugador inner join Persona on Persona.Cedula = Jugador.CedJugador
	inner join (SELECT Encargado.CedEncargado,	Persona.NombreP, 
	Persona.Apellido1,Persona.Apellido2 FROM Encargado inner join Persona
	on Encargado.CedEncargado = Persona.Cedula) as t on Jugador.CedEncargado = t.CedEncargado
	inner join Esta_en on Jugador.CedJugador = Esta_En.CedJugador;
GO