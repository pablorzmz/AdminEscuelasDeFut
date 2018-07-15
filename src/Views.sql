USE DB_Error404

GO
CREATE VIEW VistaPagosJugador
AS
	SELECT NombreP as Nombre, CedJugador as [N° Cedula], NumeroRecibo as [N° Recibo], Fecha, Monto, Detalle, NombreEscuela as Escuela
	FROM PagosDeJugador join Persona ON Cedula = CedJugador;
GO