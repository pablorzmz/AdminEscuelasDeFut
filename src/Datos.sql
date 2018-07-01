USE DB_ERROR404;

/*
	Escuela de Socorro
*/
INSERT INTO Persona VALUES
	/*Jugadores*/
	('118970385','Gabriel','Alpizar','Garcia'),
	('121110544','Marco','Badilla','Arroyo'),
	('119240631','Habacuc','Bejarano','Sanchez'),
	('119850549','Arith','Bermudez','Yepes'),
	('120620453','Mathias','Bolaños','Zuñiga'),
	('119300696','Deyler','Cambronero','Mendez'),
	('120260877','Mathias','Chacon','Lopez'),
	('120880278','Esteban','Chaves','Quesada'),
	('120280345','Arturo','Chaves','Ramirez'),
	('121370122','Isaac','Elizondo','Picado'),
	('119700766','Gabriel','Galan','Rodriguez'),
	('112050998','Aydam','Gonzalez','Carvajal'),
	('121030949','Dylan','Guillen','Calvo'),
	('121260216','Mathias','Hernandez','Mora'),
	('119540445','Andres','Leal','Duran'),
	('120760451','Mathias','Leon','Chacon'),
	('121070225','Jeykel','Loria','Vargas'),
	('120810834','Josue','Marin','Vargas'),
	('121410727','Sairam','Monterrosa','Alvarez'),
	('121260812','Arturo','Muñoz','Vargas'),
	('120320638','Ryu','Obando','Otsuka'),
	('119730338','Neythant','Ortiz','Marenco'),
	/*Encargados*/
	('111111110','Kendall','Alpizar',NULL),
	('111111111','Julio','Badilla',NULL),
	('111111112','Isaias','Bejarano',NULL),
	('111111113','Yulima','Bermudez',NULL),
	('111111114','Rebeca','Zuñiga',NULL),
	('111111115','Luis','Cambronero',NULL),
	('111111116','Cristian','Chacon',NULL),
	('111111117','Cristina','Quesada',NULL),
	('111111118','Arturo','Chaves',NULL),
	('111111119','Francini','Picado',NULL),
	('111111120','Jorge','Galan',NULL),
	('111111121','Pamela','Carvajal',NULL),
	('111111122','Leonardo','Guillen',NULL),
	('111111123','Salvador','Hernandez',NULL),
	('111111124','Henry','Leal',NULL),
	('111111125','Jorge','Leon',NULL),
	('111111126','Oliden','Vargas',NULL),
	('111111127','Jorge','Marin',NULL),
	('111111128','Sharlin','Alvarez',NULL),
	('111111129','Alicia','Vargas',NULL),
	('111111130','Johan','Obando',NULL),
	('111111131','Cesar','Ortiz',NULL);
	
INSERT INTO Encargado Values
	('111111110'),
	('111111111'),
	('111111112'),
	('111111113'),
	('111111114'),
	('111111115'),
	('111111116'),
	('111111117'),
	('111111118'),
	('111111119'),
	('111111120'),
	('111111121'),
	('111111122'),
	('111111123'),
	('111111124'),
	('111111125'),
	('111111126'),
	('111111127'),
	('111111128'),
	('111111129'),
	('111111130'),
	('111111131');
	
INSERT INTO Jugador VALUES
	('118970385', 14, 'm', '2004-03-01', '111111110'),
	('121110544', 7, 'm', '2011-03-23', '111111111'),
	('119240631', 13, 'm', '2004-12-30', '111111112'),
	('119850549', 11, 'm', '2007-01-24', '111111113'),
	('120620453', 8, 'm', '2009-08-05', '111111114'),
	('119300696', 13, 'm', '2005-03-05', '111111115'),
	('120260877', 10, 'm', '2008-05-02', '111111116'),
	('120880278', 8, 'm', '2010-06-03', '111111117'),
	('120280345', 10, 'm', '2008-06-18', '111111118'),
	('121370122', 6, 'm', '2012-02-03', '111111119'),
	('119700766', 11, 'm', '2006-11-10', '111111120'),
	('112050998', 10, 'm', '2007-10-12', '111111121'),
	('121030949', 7, 'm', '2010-12-21', '111111122'),
	('121260216', 6, 'm', '2011-08-05', '111111123'),
	('119540445', 12, 'm', '2005-12-28', '111111124'),
	('120760451', 8, 'm', '2010-01-16', '111111125'),
	('121070225', 7, 'm', '2011-01-27', '111111126'),
	('120810834', 8, 'm', '2010-03-20', '111111127'),
	('121410727', 6, 'm', '2012-03-30', '111111128'),
	('121260812', 6, 'm', '2011-10-08', '111111129'),
	('120320638', 9, 'm', '2008-08-21', '111111130'),
	('119730338', 11, 'm', '2006-08-22', '111111131');
	
/*
	Escuela de Aserri
*/
INSERT INTO Persona VALUES
	/*Jugadores*/
	('118560165','Fabian','Alfaro','Monge'),
	('120510375','Dani Santiago','Alizaga','Chaves'),
	('120670913','Ryan','Alizaga','Mora'),
	('119950586','Alexis Josue','Arias','Hernandez'),
	('120180902','Cristopher','Arias','Molina'),
	('121710909','Sebastian','Arias','Molina'),
	('119970870','Emmanuel','Arias','Prado'),
	('118870467','Kyvan','Astua','Gonzalez'),
	('118380352','Jose','Barboza','Fallas'),
	('121580342','Sebastian','Bermudez','Ledezma'),
	('120950829','Yoaf Josue','Calderon','Arias'),
	('120330078','Caleb','Campos','Perez'),
	('121160438','Ezequiel','Campos','Perez'),
	('119530198','Adrian','Chaves','Herrera'),
	('121210471','Ian Joel','Diaz','Fernandez'),
	('119970661','Gerson','Duran','Reyes'),
	('119880297','Daniel','Fallas','Chinchilla'),
	('121370206','Byron','Fallas','Mora'),
	('120870828','Jose Julian','Fallas','Mora'),
	('120090315','Eithel','Galan','Monge'),
	('119170222','Dilan','Jarquin','Segura'),
	('121760378','Caleb','Lopez','Molina'),
	/*Encargados*/
	('111111132', 'Manuel', 'Alfaro', NULL),
	('111111133', 'Santiago', 'Alizaga', NULL), /* 2 hijos */
	('111111135', 'Efren', 'Arias', NULL),
	('111111136', 'Nancy', 'Molina', NULL),  /* 2 hijos */
	('111111138', 'Heather', 'Prado', NULL),
	('111111139', 'Vanesa', 'Gonzalez', NULL),
	('111111140', 'Laura', 'Fallas', NULL),
	('111111141', 'Vivian', 'Ledezma', NULL),
	('111111142', 'Sulay', 'Arias', NULL),
	('111111143', 'Angelina', 'Perez', NULL), /* 2 hijos*/
	('111111145', 'David', 'Chaves', NULL),
	('111111146', 'Andrea', 'Fernandez', NULL),
	('111111147', 'Nelson', 'Duran', NULL),
	('111111148', 'Marlen', 'Chinchilla', NULL),
	('111111149', 'Jaqueline', 'Mora', NULL),
	('111111150', 'Jose', 'Fallas', NULL),
	('111111151', 'Kimberly', 'Monge', NULL),
	('111111152', 'Blanca', 'Segura', NULL),
	('111111153', 'Steven', 'Lopez', NULL);
	
INSERT INTO Encargado Values
	('111111132'),
	('111111133'), /* 2 hijos */
	('111111135'),
	('111111136'),  /* 2 hijos */
	('111111138'),
	('111111139'),
	('111111140'),
	('111111141'),
	('111111142'),
	('111111143'), /* 2 hijos*/
	('111111145'),
	('111111146'),
	('111111147'),
	('111111148'),
	('111111149'),
	('111111150'),
	('111111151'),
	('111111152'),
	('111111153');
	
INSERT INTO Jugador VALUES
	('118560165', 15, 'm', '2002-10-01', '111111132'),
	('120510375', 9, 'm', '2009-03-16', '111111133'),
	('120670913', 8, 'm', '2009-09-29', '111111133'),
	('119950586', 11, 'm', '2007-05-22', '111111135'),
	('120180902', 10, 'm', '2008-04-10', '111111136'),
	('121710909', 5, 'm', '2013-05-12', '111111136'),
	('119970870', 11, 'm', '2007-06-22', '111111138'),
	('118870467', 14, 'm', '2003-10-07', '111111139'),
	('118380352', 16, 'm', '2002-04-02', '111111140'),
	('121580342', 5, 'm', '2012-11-08', '111111141'),
	('120950829', 7, 'm', '2010-09-06', '111111142'),
	('120330078', 9, 'm', '2008-09-16', '111111143'),
	('121160438', 7, 'm', '2011-06-02', '111111143'),
	('119530198', 12, 'm', '2005-11-19', '111111145'),
	('121210471', 6, 'm', '2011-07-31', '111111146'),
	('119970661', 11, 'm', '2007-06-18', '111111147'),
	('119880297', 11, 'm', '2007-02-09', '111111148'),
	('121370206', 6, 'm', '2012-02-12', '111111149'),
	('120870828', 8, 'm', '2010-05-16', '111111150'),
	('120090315', 10, 'm', '2007-11-05', '111111151'),
	('119170222', 13, 'm', '2004-09-28', '111111152'),
	('121760378', 4, 'm', '2013-07-02', '111111153');
	
/*
	Escuela de Desamparados
*/
INSERT INTO Persona VALUES
	/*Jugadores*/
	('119520227','Josue','Aguilar','Monge'),
	('120830480','Gabriel','Bonilla','Martinez'),
	('118590602','Christopher','Cadena','Calvo'),
	('118750197','Andre','Calvo','Flores'),
	('119910019','Sebastian','Carballo','Guerrero'),
	('120230211','Gabriel','Carballo','Guerrero'),
	('119610413','Nicolas','Cespedes','Quintana'),
	('120200571','Jose','Garcia','Moreno'),
	('119910017','Fabian','Gomez','Arce'),
	('119080374','Emerson','Gomez','Badilla'),
	('120730209','Jose Daniel','Monge','Carballo'),
	('121490728','Ismael','Mora','Arce'),
	('118920041','Victor Samuel','Mora','Gonzalez'),
	('120290918','Alejandro','Moya','Abarca'),
	('120410031','Carlos Andres','Muñoz','Saenz'),
	('119320122','Samuel','Porras','Sanchez'),
	('120840558','Cristian','Quiros','Flores'),
	('120640273','Santiago','Ramirez','Carpio'),
	('121080016','Sebastian','Reyes','Ugalde'),
	('119080095','Yeikol','Segura','Quiros'),
	('118370307','Jose Daniel','Serrano','Lopez'),
	('120050263','Sebastian','Villalobos','Mora'),
	/*Encargados*/
	('111111154', 'Eduardo', 'Aguilar',NULL),
	('111111155', 'Cristian', 'Bonilla',NULL),
	('111111156', 'Angela', 'Calvo',NULL),
	('111111157', 'Alexandra', 'Flores',NULL),
	('111111158', 'Marco', 'Carballo',NULL), /* 2 hijos */
	('111111160', 'Mauricio', 'Cespedes',NULL),
	('111111161', 'Noelvin', 'Garcia',NULL),
	('111111162', 'Melissa', 'Arce',NULL),
	('111111163', 'Maritza', 'Badilla',NULL),
	('111111164', 'Viviana', 'Carballo',NULL),
	('111111166', 'Kenneth', 'Mora',NULL),
	('111111167', 'Michael', 'Mora',NULL),
	('111111168', 'Jose', 'Moya',NULL),
	('111111169', 'Andrea', 'Saenz',NULL),
	('111111170', 'Linsay', 'Sanchez',NULL),
	('111111171', 'Cristian', 'Quiros',NULL),
	('111111172', 'Jorge', 'Ramirez',NULL),
	('111111173', 'Jesenia', 'Ugalde',NULL),
	('111111174', 'Marisol', 'Quiros',NULL),
	('111111175', 'Juan Rafael', 'Serrano',NULL),
	('111111176', 'Evelyn', 'Mora',NULL);
	
INSERT INTO Encargado VALUES
	('111111154'),
	('111111155'),
	('111111156'),
	('111111157'),
	('111111158'), /* 2 hijos */
	('111111160'),
	('111111161'),
	('111111162'),
	('111111163'),
	('111111164'),
	('111111166'),
	('111111167'),
	('111111168'),
	('111111169'),
	('111111170'),
	('111111171'),
	('111111172'),
	('111111173'),
	('111111174'),
	('111111175'),
	('111111176');

INSERT INTO Jugador VALUES
	('119520227', 13, 'm', '2005-06-12', '111111154'),
	('120830480', 8, 'm', '2010-04-13', '111111155'),
	('118590602', 15, 'm', '2002-11-19', '111111156'),
	('118750197', 15, 'm', '2003-05-23', '111111157'),
	('119910019', 11, 'm', '2007-03-31', '111111158'),
	('120230211', 10, 'm', '2008-06-17', '111111158'),
	('119610413', 12, 'm', '2006-04-02', '111111160'),
	('120200571', 10, 'm', '2008-04-08', '111111161'),
	('119910017', 11, 'm', '2007-03-30', '111111162'),
	('119080374', 14, 'm', '2004-06-15', '111111163'),
	('120730209', 8, 'm', '2009-11-26', '111111164'),
	('121490728', 5, 'm', '2012-08-09', '111111166'),
	('118920041', 14, 'm', '2003-11-26', '111111167'),
	('120290918', 9, 'm', '2008-07-19', '111111168'),
	('120410031', 9, 'm', '2008-11-20', '111111169'),
	('119320122', 13, 'm', '2005-03-24', '111111170'),
	('120840558', 8, 'm', '2010-04-15', '111111171'),
	('120640273', 8, 'm', '2009-08-03', '111111172'),
	('121080016', 7, 'm', '2011-02-03', '111111173'),
	('119080095', 14, 'm', '2004-06-06', '111111174'),
	('118370307', 16, 'm', '2001-09-29', '111111175'),
	('120050263', 10, 'm', '2007-09-24', '111111176');
/*
	Escuela de Goicoechea
*/
INSERT INTO Persona VALUES
	/*Jugadores*/
	('119190117','Brandon','Arguedas','Castro'),
	('118920964','Jarafat','Arroyo','Mena'),
	('120140114','David','Cardenas','Montero'),
	('120180569','Gabriel','Cordoba','Morales'),
	('119730005','David','Garro','Baltodano'),
	('119720698','Josue David','Gonzalez','Mora'),
	('118980618','Jose Pablo','Marin','Hernandez'),
	('901250638','Carlos Andres','Olivarez','Jimenez'),
	('121290298','Felipe','Perdomo','Araya'),
	('120790617','Sebastian','Picado','Araya'),
	('119160950','Luis Guillermo','Quiros','Cardenas'),
	('703190015','Keyshmer','Sanchez','Grant'),
	('703470514','Keljeyshmel','Sanchez','Grant'),
	('119790996','Shakur','Scott','Winter'),
	('120680332','Denzel Andre','Solano','Avila'),
	('120630557','Gabriel','Ureña','Solano'),
	('120920268','Raydell','Urtecho','Sanchez'),
	('120190159','Antony','Vargas','Mendez'),
	/*Encargados*/
	('111111177', 'Rodrigo', 'Arguedas', NULL),
	('111111178', 'Keren', 'Mena', NULL),
	('111111179', 'Jenny', 'Montero', NULL),
	('111111180', 'Kimberly', 'Morales', NULL),
	('111111181', 'Karla', 'Baltodano', NULL),
	('111111182', 'Ana Yorlen', 'Mora', NULL),
	('111111183', 'Juan', 'Marin', NULL),
	('111111184', 'Maria Paula', 'Jimenez', NULL),
	('111111185', 'Miguel', 'Perdomo', NULL),
	('111111186', 'Catalina', 'Araya', NULL),
	('111111187', 'Marylem', 'Cardenas', NULL),
	('111111188', 'Odisha', 'Grant', NULL), 	/*2 hijos*/
	('111111189', 'Devannie', 'Winter', NULL),
	('111111190', 'Jeimy', 'Solano', NULL),
	('111111191', 'Wendy', 'Ureña', NULL),
	('111111192', 'Raymond', 'Urtecho', NULL),
	('111111193', 'Fabian', 'Vargas', NULL);
	
INSERT INTO Encargado Values
	('111111177'),
	('111111178'),
	('111111179'),
	('111111180'),
	('111111181'),
	('111111182'),
	('111111183'),
	('111111184'),
	('111111185'),
	('111111186'),
	('111111187'),
	('111111188'), 	/*2 hijos*/
	('111111189'),
	('111111190'),
	('111111191'),
	('111111192'),
	('111111193');

INSERT INTO Jugador VALUES
	('119190117', 13, 'm', '2004-10-16', '111111177'),
	('118920964', 14, 'm', '2003-12-06', '111111178'),
	('120140114', 10, 'm', '2007-12-16', '111111179'),
	('120180569', 10, 'm', '2008-02-26', '111111180'),
	('119730005', 11, 'm', '2006-09-16', '111111181'),
	('119720698', 11, 'm', '2006-09-27', '111111182'),
	('118980618', 14, 'm', '2004-02-18', '111111183'),
	('901250638', 11, 'm', '2006-11-01', '111111184'),
	('121290298', 6, 'm', '2011-11-04', '111111185'),
	('120790617', 8, 'm', '2010-02-25', '111111186'),
	('119160950', 13, 'm', '2004-09-23', '111111187'),
	('703190015', 12, 'm', '2005-09-16', '111111188'),
	('703470514', 8, 'm', '2009-08-03', '111111188'),
	('119790996', 11, 'm', '2006-11-29', '111111189'),
	('120680332', 8, 'm', '2009-10-04', '111111190'),
	('120630557', 8, 'm', '2009-08-15', '111111191'),
	('120920268', 7, 'm', '2010-08-11', '111111192'),
	('120190159', 10, 'm', '2008-02-29', '111111193');
	
INSERT INTO Escuela VALUES
	('Saprissa Barrio Socorro', 'Santo Domingo', NULL),
	('Saprissa Aserri', 'Aserri', NULL),
	('Saprissa San Antonio', 'San Antonio', NULL),
	('Saprissa Goicoechea', 'San Francisco', NULL);
	
INSERT INTO TelefonoE VALUES
	('Saprissa Barrio Socorro', '87471134'),
	('Saprissa Aserri', '88320007'),
	('Saprissa San Antonio', '88320007'),
	('Saprissa Goicoechea', '88320007');
	
INSERT INTO Nivel VALUES
	(1, 4, 7),
	(2, 8, 10),
	(3, 11, 13),
	(4, 14, 16);

INSERT INTO Tiene VALUES
	('Saprissa Barrio Socorro', 1),
	('Saprissa Barrio Socorro', 2),
	('Saprissa Barrio Socorro', 3),
	('Saprissa Barrio Socorro', 4),
	('Saprissa Aserri', 1),
	('Saprissa Aserri', 2),
	('Saprissa Aserri', 3),
	('Saprissa Aserri', 4),
	('Saprissa San Antonio', 1),
	('Saprissa San Antonio', 2),
	('Saprissa San Antonio', 3),
	('Saprissa San Antonio', 4),
	('Saprissa Goicoechea', 1),
	('Saprissa Goicoechea', 2),
	('Saprissa Goicoechea', 3),
	('Saprissa Goicoechea', 4);

/* Asignar jug a escuelas y niveles */

/* Socorro */
INSERT INTO Esta_En VALUES
	('118970385', 'Saprissa Barrio Socorro', 4),
	('121110544', 'Saprissa Barrio Socorro', 1),
	('119240631', 'Saprissa Barrio Socorro', 3),
	('119850549', 'Saprissa Barrio Socorro', 3),
	('120620453', 'Saprissa Barrio Socorro', 2),
	('119300696', 'Saprissa Barrio Socorro', 3),
	('120260877', 'Saprissa Barrio Socorro', 2),
	('120880278', 'Saprissa Barrio Socorro', 2),
	('120280345', 'Saprissa Barrio Socorro', 2),
	('121370122', 'Saprissa Barrio Socorro', 1),
	('119700766', 'Saprissa Barrio Socorro', 3),
	('112050998', 'Saprissa Barrio Socorro', 2),
	('121030949', 'Saprissa Barrio Socorro', 1),
	('121260216', 'Saprissa Barrio Socorro', 1),
	('119540445', 'Saprissa Barrio Socorro', 3),
	('120760451', 'Saprissa Barrio Socorro', 2),
	('121070225', 'Saprissa Barrio Socorro', 1),
	('120810834', 'Saprissa Barrio Socorro', 2),
	('121410727', 'Saprissa Barrio Socorro', 1),
	('121260812', 'Saprissa Barrio Socorro', 1),
	('120320638', 'Saprissa Barrio Socorro', 2),
	('119730338', 'Saprissa Barrio Socorro', 3);
	
/* Aserri */
INSERT INTO Esta_En VALUES
	('118560165', 'Saprissa Aserri', 4),
	('120510375', 'Saprissa Aserri', 2),
	('120670913', 'Saprissa Aserri', 2),
	('119950586', 'Saprissa Aserri', 3),
	('120180902', 'Saprissa Aserri', 3),
	('121710909', 'Saprissa Aserri', 1),
	('119970870', 'Saprissa Aserri', 3),
	('118870467', 'Saprissa Aserri', 4),
	('118380352', 'Saprissa Aserri', 4),
	('121580342', 'Saprissa Aserri', 1),
	('120950829', 'Saprissa Aserri', 1),
	('120330078', 'Saprissa Aserri', 2),
	('121160438', 'Saprissa Aserri', 1),
	('119530198', 'Saprissa Aserri', 3),
	('121210471', 'Saprissa Aserri', 1),
	('119970661', 'Saprissa Aserri', 3),
	('119880297', 'Saprissa Aserri', 3),
	('121370206', 'Saprissa Aserri', 1),
	('120870828', 'Saprissa Aserri', 2),
	('120090315', 'Saprissa Aserri', 2),
	('119170222', 'Saprissa Aserri', 3),
	('121760378', 'Saprissa Aserri', 1);

/* San Antonio */
INSERT INTO Esta_En VALUES
	('119520227', 'Saprissa San Antonio', 3),
	('120830480', 'Saprissa San Antonio', 2),
	('118590602', 'Saprissa San Antonio', 4),
	('118750197', 'Saprissa San Antonio', 4),
	('119910019', 'Saprissa San Antonio', 3),
	('120230211', 'Saprissa San Antonio', 2),
	('119610413', 'Saprissa San Antonio', 3),
	('120200571', 'Saprissa San Antonio', 2),
	('119910017', 'Saprissa San Antonio', 3),
	('119080374', 'Saprissa San Antonio', 4),
	('120730209', 'Saprissa San Antonio', 2),
	('121490728', 'Saprissa San Antonio', 1),
	('118920041', 'Saprissa San Antonio', 4),
	('120290918', 'Saprissa San Antonio', 2),
	('120410031', 'Saprissa San Antonio', 2),
	('119320122', 'Saprissa San Antonio', 3),
	('120840558', 'Saprissa San Antonio', 2),
	('120640273', 'Saprissa San Antonio', 2),
	('121080016', 'Saprissa San Antonio', 1),
	('119080095', 'Saprissa San Antonio', 4),
	('118370307', 'Saprissa San Antonio', 4),
	('120050263', 'Saprissa San Antonio', 2);

/* Goicoechea */
INSERT INTO Esta_En VALUES
	('119190117', 'Saprissa Goicoechea', 3),
	('118920964', 'Saprissa Goicoechea', 4),
	('120140114', 'Saprissa Goicoechea', 2),
	('120180569', 'Saprissa Goicoechea', 2),
	('119730005', 'Saprissa Goicoechea', 3),
	('119720698', 'Saprissa Goicoechea', 3),
	('118980618', 'Saprissa Goicoechea', 4),
	('901250638', 'Saprissa Goicoechea', 3),
	('121290298', 'Saprissa Goicoechea', 1),
	('120790617', 'Saprissa Goicoechea', 2),
	('119160950', 'Saprissa Goicoechea', 3),
	('703190015', 'Saprissa Goicoechea', 3),
	('703470514', 'Saprissa Goicoechea', 2),
	('119790996', 'Saprissa Goicoechea', 3),
	('120680332', 'Saprissa Goicoechea', 2),
	('120630557', 'Saprissa Goicoechea', 2),
	('120920268', 'Saprissa Goicoechea', 1),
	('120190159', 'Saprissa Goicoechea', 2);

INSERT INTO Entrenamiento VALUES
	('2018-06-16', '08:00:00'),
	('2018-06-23', '08:00:00');

INSERT INTO Asiste VALUES
	('118970385', '2018-06-16'),
	('119240631', '2018-06-16'),
	('119850549', '2018-06-16'),
	('120620453', '2018-06-16'),
	('120280345', '2018-06-16'),
	('121370122', '2018-06-16'),
	('119700766', '2018-06-16'),
	('112050998', '2018-06-16'),
	('121030949', '2018-06-16'),
	('121260216', '2018-06-16'),
	('119540445', '2018-06-16'),
	('120760451', '2018-06-16'),
	('121070225', '2018-06-16'),
	('121030949', '2018-06-23'),
	('121260216', '2018-06-23'),
	('119540445', '2018-06-23'),
	('120760451', '2018-06-23'),
	('121070225', '2018-06-23'),
	('120810834', '2018-06-23'),
	('121410727', '2018-06-23'),
	('121260812', '2018-06-23');

INSERT INTO Asiste VALUES
	('118560165', '2018-06-16'),
	('120510375', '2018-06-16'),
	('120670913', '2018-06-16'),
	('119950586', '2018-06-16'),
	('120180902', '2018-06-16'),
	('121710909', '2018-06-16'),
	('119970870', '2018-06-16'),
	('118870467', '2018-06-16'),
	('118380352', '2018-06-16'),
	('118560165', '2018-06-23'),
	('120510375', '2018-06-23'),
	('120670913', '2018-06-23'),
	('119950586', '2018-06-23'),
	('120180902', '2018-06-23'),
	('121710909', '2018-06-23'),
	('119970870', '2018-06-23'),
	('118870467', '2018-06-23'),
	('118380352', '2018-06-23'),
	('121580342', '2018-06-23'),
	('120950829', '2018-06-23');

INSERT INTO Asiste VALUES
	('119520227', '2018-06-16'),
	('120830480', '2018-06-16'),
	('118590602', '2018-06-16'),
	('118750197', '2018-06-16'),
	('119910019', '2018-06-16'),
	('120230211', '2018-06-16'),
	('119610413', '2018-06-16'),
	('120200571', '2018-06-16'),
	('119910017', '2018-06-16'),
	('119910017', '2018-06-23'),
	('119080374', '2018-06-23'),
	('120730209', '2018-06-23'),
	('121490728', '2018-06-23'),
	('118920041', '2018-06-23'),
	('120290918', '2018-06-23'),
	('120410031', '2018-06-23'),
	('119320122', '2018-06-23'),
	('120840558', '2018-06-23'),
	('120640273', '2018-06-23');

INSERT INTO Asiste VALUES
	('119190117', '2018-06-16'),
	('118920964', '2018-06-16'),
	('901250638', '2018-06-16'),
	('121290298', '2018-06-16'),
	('120790617', '2018-06-16'),
	('119160950', '2018-06-16'),
	('703190015', '2018-06-16'),
	('703470514', '2018-06-16'),
	('120920268', '2018-06-16'),
	('120190159', '2018-06-16'),
	('703190015', '2018-06-23'),
	('703470514', '2018-06-23'),
	('119790996', '2018-06-23'),
	('120680332', '2018-06-23'),
	('120630557', '2018-06-23'),
	('120920268', '2018-06-23'),
	('120190159', '2018-06-23');

INSERT INTO PagosDeJugador VALUES
	('Saprissa Barrio Socorro', '0001', '2018-06-23', 11000, 'Pago de Matricula', '118970385'),
	('Saprissa Barrio Socorro', '0002', '2018-06-23', 11000, 'Pago de Matricula', '121110544'),
	('Saprissa Barrio Socorro', '0003', '2018-06-23', 24000, 'Pago de 2 meses', '121110544'),
	('Saprissa Barrio Socorro', '0004', '2018-06-23', 12000, NULL, '119240631'),
	('Saprissa Barrio Socorro', '0005', '2018-06-23', 23000, 'Pago matricula y mensualidad', '119850549'),
	('Saprissa Barrio Socorro', '0006', '2018-06-23', 12000, NULL, '120620453'),
	('Saprissa Barrio Socorro', '0007', '2018-06-23', 12000, NULL, '119300696'),
	('Saprissa Barrio Socorro', '0008', '2018-06-23', 11000, NULL, '120260877');

INSERT INTO PagoMatricula VALUES
	('Saprissa Barrio Socorro', '0001'),
	('Saprissa Barrio Socorro', '0002'),
	('Saprissa Barrio Socorro', '0005'),
	('Saprissa Barrio Socorro', '0008');

INSERT INTO PagoMensualidad VALUES
	('Saprissa Barrio Socorro', '0003'),
	('Saprissa Barrio Socorro', '0004'),
	('Saprissa Barrio Socorro', '0005'),
	('Saprissa Barrio Socorro', '0006'),
	('Saprissa Barrio Socorro', '0007');

INSERT INTO Mes VALUES
	('Saprissa Barrio Socorro', '0003', 'MAY', '2018'),
	('Saprissa Barrio Socorro', '0003', 'JUN', '2018'),
	('Saprissa Barrio Socorro', '0004', 'JUN', '2018'),
	('Saprissa Barrio Socorro', '0005', 'JUN', '2018'),
	('Saprissa Barrio Socorro', '0006', 'MAY', '2018'),
	('Saprissa Barrio Socorro', '0007', 'JUN', '2018');

/* ---------------------- Falta Ejecutar ----------------*/

INSERT INTO Instalacion(Direccion) VALUES
	('Santo Domingo, Heredia'),
	('Aserri, San Jose'),
	('Desamparados, San Jose'),
	('Goicoechea, San Jose');

UPDATE Escuela SET DireccionInst = 'Santo Domingo, Heredia' WHERE Nombre = 'Saprissa Barrio Socorro';
UPDATE Escuela SET DireccionInst = 'Aserri, San Jose' WHERE Nombre = 'Saprissa Aserri';
UPDATE Escuela SET DireccionInst = 'Desamparados, San Jose' WHERE Nombre = 'Saprissa San Antonio';
UPDATE Escuela SET DireccionInst = 'Goicoechea, San Jose' WHERE Nombre = 'Saprissa Goicoechea';

INSERT INTO PagosDeJugador VALUES
	('Saprissa Aserri', '0009', '2018-06-23', 23000, 'Mat y 1 Mes', '118560165'),
	('Saprissa Aserri', '0010', '2018-06-23', 36000, '3 Meses', '120510375'),
	('Saprissa Aserri', '0011', '2018-06-23', 11000, NULL, '120670913'),
	('Saprissa Aserri', '0012', '2018-06-23', 12000, NULL, '119950586'),
	('Saprissa Aserri', '0013', '2018-06-23', 11000, NULL, '120180902'),
	('Saprissa Aserri', '0014', '2018-06-23', 24000, NULL, '121710909'),
	('Saprissa Aserri', '0015', '2018-06-23', 23000, 'Mat y 1 Mes', '119970870'),
	('Saprissa Aserri', '0016', '2018-06-23', 12000, NULL, '118870467'),
	('Saprissa Aserri', '0017', '2018-06-23', 11000, NULL, '118380352'),
	('Saprissa Aserri', '0018', '2018-06-23', 23000, 'Mat y 1 Mes', '121580342');

INSERT INTO PagoMatricula VALUES
	('Saprissa Aserri', '0009'),
	('Saprissa Aserri', '0011'),
	('Saprissa Aserri', '0013'),
	('Saprissa Aserri', '0015'),
	('Saprissa Aserri', '0017'),
	('Saprissa Aserri', '0018');

INSERT INTO PagoMensualidad VALUES
	('Saprissa Aserri', '0009'),
	('Saprissa Aserri', '0010'),
	('Saprissa Aserri', '0012'),
	('Saprissa Aserri', '0014'),
	('Saprissa Aserri', '0015'),
	('Saprissa Aserri', '0016'),
	('Saprissa Aserri', '0018');

INSERT INTO Mes VALUES
	('Saprissa Aserri', '0009', 'JUN', '2018'),
	('Saprissa Aserri', '0010', 'JUN', '2018'),
	('Saprissa Aserri', '0010', 'JUL', '2018'),
	('Saprissa Aserri', '0010', 'AGO', '2018'),
	('Saprissa Aserri', '0012', 'MAY', '2018'),
	('Saprissa Aserri', '0014', 'MAY', '2018'),
	('Saprissa Aserri', '0014', 'JUN', '2018'),
	('Saprissa Aserri', '0015', 'JUN', '2018'),
	('Saprissa Aserri', '0016', 'MAY', '2018'),
	('Saprissa Aserri', '0018', 'JUN', '2018');

INSERT INTO PagosDeJugador VALUES
	('Saprissa San Antonio', '0019', '2018-06-23', 12000, NULL, '118750197'),
	('Saprissa San Antonio', '0020', '2018-06-23', 12000, NULL, '119910019'),
	('Saprissa San Antonio', '0021', '2018-06-23', 12000, NULL, '120230211'),
	('Saprissa San Antonio', '0022', '2018-06-23', 12000, NULL, '119610413'),
	('Saprissa San Antonio', '0023', '2018-06-23', 11000, NULL, '120200571'),
	('Saprissa San Antonio', '0024', '2018-06-23', 12000, NULL, '119910017'),
	('Saprissa San Antonio', '0025', '2018-06-23', 11000, NULL, '119080374'),
	('Saprissa San Antonio', '0026', '2018-06-23', 12000, NULL, '120730209'),
	('Saprissa San Antonio', '0027', '2018-06-23', 24000, NULL, '121490728'),
	('Saprissa San Antonio', '0028', '2018-06-23', 12000, NULL, '118920041');

INSERT INTO PagoMatricula VALUES
	('Saprissa San Antonio', '0023'),
	('Saprissa San Antonio', '0025');

INSERT INTO PagoMensualidad VALUES
	('Saprissa San Antonio', '0019'),
	('Saprissa San Antonio', '0020'),
	('Saprissa San Antonio', '0021'),
	('Saprissa San Antonio', '0022'),
	('Saprissa San Antonio', '0024'),
	('Saprissa San Antonio', '0026'),
	('Saprissa San Antonio', '0027'),
	('Saprissa San Antonio', '0028');

INSERT INTO Mes VALUES
	('Saprissa San Antonio', '0019', 'JUL', '2018'),
	('Saprissa San Antonio', '0020', 'MAY', '2018'),
	('Saprissa San Antonio', '0021', 'JUN', '2018'),
	('Saprissa San Antonio', '0022', 'JUN', '2018'),
	('Saprissa San Antonio', '0024', 'MAY', '2018'),
	('Saprissa San Antonio', '0026', 'JUN', '2018'),
	('Saprissa San Antonio', '0027', 'MAY', '2018'),
	('Saprissa San Antonio', '0027', 'JUN', '2018'),
	('Saprissa San Antonio', '0028', 'JUN', '2018');

INSERT INTO PagosDeJugador VALUES
	('Saprissa Goicoechea', '0029', '2018-06-23', 23000, NULL, '119190117'),
	('Saprissa Goicoechea', '0030', '2018-06-23', 12000, NULL, '118920964'),
	('Saprissa Goicoechea', '0031', '2018-06-23', 11000, NULL, '120140114'),
	('Saprissa Goicoechea', '0032', '2018-06-23', 12000, NULL, '120180569'),
	('Saprissa Goicoechea', '0033', '2018-06-23', 12000, NULL, '119730005'),
	('Saprissa Goicoechea', '0034', '2018-06-23', 12000, NULL, '119720698'),
	('Saprissa Goicoechea', '0035', '2018-06-23', 24000, NULL, '118980618');

INSERT INTO PagoMatricula VALUES
	('Saprissa Goicoechea', '0029'),
	('Saprissa Goicoechea', '0031');

INSERT INTO PagoMensualidad VALUES
	('Saprissa Goicoechea', '0029'),
	('Saprissa Goicoechea', '0030'),
	('Saprissa Goicoechea', '0032'),
	('Saprissa Goicoechea', '0033'),
	('Saprissa Goicoechea', '0034'),
	('Saprissa Goicoechea', '0035');

INSERT INTO Mes VALUES
	('Saprissa Goicoechea', '0029', 'JUN', '2018'),
	('Saprissa Goicoechea', '0030', 'JUN', '2018'),
	('Saprissa Goicoechea', '0032', 'JUN', '2018'),
	('Saprissa Goicoechea', '0033', 'MAY', '2018'),
	('Saprissa Goicoechea', '0034', 'JUL', '2018'),
	('Saprissa Goicoechea', '0035', 'JUN', '2018'),
	('Saprissa Goicoechea', '0035', 'JUN', '2018');

INSERT INTO TelefonoP VALUES
	('118970385','83390385'),
	('121110544','70654395'),
	('121110544','22584039'),
	('119240631','60717769'),
	('119240631','86470935'),
	('119850549','88784235'),
	('120620453','83287507'),
	('119300696','88740990'),
	('120260877','57102210'),
	('120880278','83780581'),
	('120280345','88214478'),
	('121370122','89622899'),
	('119700766','88231656'),
	('112050998','87959139'),
	('121030949','88656004'),
	('121260216','88190638'),
	('119540445','88890228'),
	('120760451','83420327'),
	('121070225','89189324'),
	('120810834','60575548'),
	('121410727','83111388'),
	('121260812','60778090'),
	('120320638','88233355'),
	('119730338','89684003');

INSERT INTO TelefonoP VALUES
	('118560165','72401006'),
	('118560165','83843615'),
	('120510375','50161055'),
	('120510375','89891742'),
	('120670913','50161055'),
	('119950586','85457335'),
	('120180902','88854749'),
	('121710909','88854749'),
	('119970870','83944111'),
	('118870467','83263229'),
	('118380352','87294151'),
	('121580342','83473737'),
	('120950829','85354885'),
	('120330078','86265369'),
	('121160438','86265369'),
	('119530198','70708481'),
	('121210471','72933372'),
	('119970661','86410641'),
	('119880297','83806682'),
	('121370206','84779392'),
	('120870828','83530099'),
	('120090315','87593018'),
	('119170222','71813890'),
	('121760378','87013039');

INSERT INTO TelefonoP VALUES
	('119520227','88436799'),
	('120830480','83206550'),
	('120830480','22515035'),
	('118590602','60492596'),
	('118750197','88162175'),
	('119910019','84728261'),
	('120230211','84728261'),
	('119610413','88148741'),
	('120200571','89679316'),
	('119910017','88996847'),
	('119080374','86435833'),
	('120730209','88085856'),
	('121490728','86212445'),
	('118920041','88621141'),
	('120290918','72885952'),
	('120410031','85216479'),
	('119320122','70391121'),
	('120840558','89154347'),
	('120640273','83399992'),
	('121080016','88349017'),
	('119080095','89843180'),
	('118370307','89166564'),
	('120050263','88158804');

INSERT INTO TelefonoP VALUES
	('119190117','61637185'),
	('119190117','84721726'),
	('118920964','60351521'),
	('120140114','83102251'),
	('120180569','87075743'),
	('119730005','83126756'),
	('119720698','87742398'),
	('118980618','83166277'),
	('118980618','71318619'),
	('901250638','89400840'),
	('121290298','70571310'),
	('120790617','70181903'),
	('119160950','89429145'),
	('703190015','22974661'),
	('703190015','88509541'),
	('703470514','22974661'),
	('703470514','88509541'),
	('119790996','72800651'),
	('120680332','85083997'),
	('120630557','83829992'),
	('120920268','70245309'),
	('120190159','88554490');