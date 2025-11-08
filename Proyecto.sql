CREATE DATABASE  IF NOT EXISTS `proyecto` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyecto`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `configuracion`
--

DROP TABLE IF EXISTS `configuracion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `configuracion` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre_parametro` varchar(50) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuracion`
--

LOCK TABLES `configuracion` WRITE;
/*!40000 ALTER TABLE `configuracion` DISABLE KEYS */;
INSERT INTO `configuracion` VALUES (1,'importe_cuota',20000.00);
/*!40000 ALTER TABLE `configuracion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuota`
--

DROP TABLE IF EXISTS `cuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuota` (
  `IdCuota` int NOT NULL AUTO_INCREMENT,
  `IdSocio` int NOT NULL,
  `FechaPagoCuota` date DEFAULT NULL,
  `FechaVencimientoCuota` date NOT NULL,
  `ImporteCuota` decimal(10,2) NOT NULL,
  `ImporteAdeudado` decimal(10,2) DEFAULT '0.00',
  `Documento` varchar(20) NOT NULL,
  PRIMARY KEY (`IdCuota`),
  KEY `IdSocio` (`IdSocio`),
  CONSTRAINT `cuota_ibfk_1` FOREIGN KEY (`IdSocio`) REFERENCES `socio` (`IdSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuota`
--

LOCK TABLES `cuota` WRITE;
/*!40000 ALTER TABLE `cuota` DISABLE KEYS */;
INSERT INTO `cuota` VALUES (1,49,NULL,'2025-12-07',20000.00,20000.00,'11223344'),(2,27,NULL,'2025-12-07',20000.00,20000.00,'12312312'),(3,32,NULL,'2025-12-07',20000.00,20000.00,'12451245'),(4,12,NULL,'2025-12-07',20000.00,20000.00,'14789632'),(5,10,NULL,'2025-12-07',20000.00,20000.00,'15995115'),(6,19,NULL,'2025-12-07',20000.00,20000.00,'22222222'),(7,6,NULL,'2025-12-07',20000.00,20000.00,'23232323'),(8,5,NULL,'2025-12-07',20000.00,20000.00,'23363636'),(9,36,NULL,'2025-12-07',20000.00,20000.00,'23598754'),(10,62,NULL,'2025-12-07',20000.00,20000.00,'25646464'),(11,11,NULL,'2025-12-07',20000.00,20000.00,'25852585'),(12,53,NULL,'2025-12-07',20000.00,20000.00,'25878925'),(13,42,NULL,'2025-12-07',20000.00,20000.00,'25888888'),(14,8,NULL,'2025-12-07',20000.00,20000.00,'25896325'),(15,4,NULL,'2025-12-07',20000.00,20000.00,'26262626'),(16,13,NULL,'2025-12-07',20000.00,20000.00,'32147896'),(17,54,NULL,'2025-12-07',20000.00,20000.00,'33221144'),(18,17,NULL,'2025-12-07',20000.00,20000.00,'33333333'),(19,26,NULL,'2025-12-07',20000.00,20000.00,'33333335'),(20,48,NULL,'2025-12-07',20000.00,20000.00,'33336666'),(21,20,NULL,'2025-12-07',20000.00,20000.00,'34444444'),(22,16,NULL,'2025-12-07',20000.00,20000.00,'35753575'),(23,58,NULL,'2025-12-07',20000.00,20000.00,'40000000'),(24,46,NULL,'2025-12-07',20000.00,20000.00,'42424242'),(25,51,NULL,'2025-12-07',20000.00,20000.00,'44441111'),(26,23,NULL,'2025-12-07',20000.00,20000.00,'44444441'),(27,39,NULL,'2025-12-07',20000.00,20000.00,'44444446'),(28,30,NULL,'2025-12-07',20000.00,20000.00,'44444447'),(29,3,NULL,'2025-12-07',20000.00,20000.00,'45454545'),(30,9,NULL,'2025-12-07',20000.00,20000.00,'45632145'),(31,31,NULL,'2025-12-07',20000.00,20000.00,'45645645'),(32,35,NULL,'2025-12-07',20000.00,20000.00,'465465468'),(33,18,NULL,'2025-12-07',20000.00,20000.00,'47348070'),(34,41,NULL,'2025-12-07',20000.00,20000.00,'48484847'),(35,45,NULL,'2025-12-07',20000.00,20000.00,'48484848'),(36,57,NULL,'2025-12-07',20000.00,20000.00,'50000000'),(37,28,NULL,'2025-12-07',20000.00,20000.00,'52525252'),(38,33,NULL,'2025-12-07',20000.00,20000.00,'54563258'),(39,14,NULL,'2025-12-07',20000.00,20000.00,'55555555'),(40,40,NULL,'2025-12-07',20000.00,20000.00,'55555564'),(41,7,NULL,'2025-12-07',20000.00,20000.00,'55558888'),(42,44,NULL,'2025-12-07',20000.00,20000.00,'59659659'),(43,56,NULL,'2025-12-07',20000.00,20000.00,'60000006'),(44,43,NULL,'2025-12-07',20000.00,20000.00,'62626262'),(45,15,NULL,'2025-12-07',20000.00,20000.00,'63636363'),(46,55,NULL,'2025-12-07',20000.00,20000.00,'66336633'),(47,38,NULL,'2025-12-07',20000.00,20000.00,'66666664'),(48,21,NULL,'2025-12-07',20000.00,20000.00,'66666665'),(49,29,NULL,'2025-12-07',20000.00,20000.00,'69696969'),(50,47,NULL,'2025-12-07',20000.00,20000.00,'75395155'),(51,24,NULL,'2025-12-07',20000.00,20000.00,'77777777'),(52,52,NULL,'2025-12-07',20000.00,20000.00,'77889966'),(53,2,'2025-11-07','2025-12-07',20000.00,0.00,'78787878'),(54,61,NULL,'2025-12-07',20000.00,20000.00,'87878787'),(55,22,NULL,'2025-12-07',20000.00,20000.00,'88888889'),(56,34,NULL,'2025-12-07',20000.00,20000.00,'89511598'),(57,50,NULL,'2025-12-07',20000.00,20000.00,'89658965'),(58,59,NULL,'2025-12-07',20000.00,20000.00,'90000000'),(59,60,NULL,'2025-12-07',20000.00,20000.00,'91919191'),(60,63,NULL,'2025-12-07',20000.00,20000.00,'93939393'),(61,1,NULL,'2025-12-07',20000.00,20000.00,'95195195'),(62,37,NULL,'2025-12-07',20000.00,20000.00,'99999995'),(63,25,NULL,'2025-12-07',20000.00,20000.00,'99999996'),(64,2,NULL,'2026-01-07',20000.00,20000.00,'78787878');
/*!40000 ALTER TABLE `cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocio`
--

DROP TABLE IF EXISTS `nosocio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocio` (
  `IdNoSocio` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Documento` varchar(20) NOT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `FechaInscripcion` date DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  `AptoFisico` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`IdNoSocio`),
  UNIQUE KEY `Documento` (`Documento`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocio`
--

LOCK TABLES `nosocio` WRITE;
/*!40000 ALTER TABLE `nosocio` DISABLE KEYS */;
INSERT INTO `nosocio` VALUES (1,'Zoe','Gutierrez','56565656','1156565656','1999-10-10','2025-10-10',1,1),(2,'Marco','Polo','12365478','1112365478','1997-03-07','2025-10-10',1,1),(3,'Maria','Martinez','25252526','1125252526','1989-04-03','2025-10-10',1,1),(4,'Hugo','Cartoon','25898989','1125898989','2000-10-10','2025-10-10',1,1),(5,'Julia','Diaz','32323232','1132323232','2000-09-27','2025-10-11',1,1),(6,'Candela','García','52255225','1152255225','1998-09-10','2025-11-04',1,1),(7,'Pablo','Druetta','30000000','1130000000','2001-01-10','2025-11-04',1,1),(8,'Gastón','Kleiben','20000000','1120000000','1986-11-01','2025-11-04',1,1);
/*!40000 ALTER TABLE `nosocio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `IdPago` int NOT NULL AUTO_INCREMENT,
  `IdSocio` int NOT NULL,
  `FechaPagoCuota` date NOT NULL,
  `MontoPago` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IdPago`),
  KEY `IdSocio` (`IdSocio`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`IdSocio`) REFERENCES `socio` (`IdSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,1,'2025-10-09',0.00),(2,2,'2025-10-09',0.00),(3,3,'2025-10-09',0.00),(4,4,'2025-10-10',0.00),(5,5,'2025-10-10',0.00),(6,6,'2025-10-10',0.00),(7,7,'2025-10-11',0.00),(8,8,'2025-10-16',0.00),(9,9,'2025-10-16',0.00),(10,10,'2025-10-16',0.00),(11,11,'2025-10-16',0.00),(12,12,'2025-09-04',0.00),(13,13,'2025-09-04',0.00),(14,14,'2025-10-16',0.00),(15,15,'2025-10-16',0.00),(16,16,'2025-10-16',0.00),(17,17,'2025-10-16',0.00),(18,18,'2025-10-17',0.00),(19,19,'2025-10-17',0.00),(20,20,'2025-10-17',0.00),(21,21,'2025-10-17',0.00),(22,22,'2025-10-17',0.00),(23,23,'2025-10-17',0.00),(24,24,'2025-10-17',0.00),(25,25,'2025-10-17',0.00),(26,26,'2025-10-17',0.00),(27,27,'2025-10-17',0.00),(28,28,'2025-10-17',0.00),(29,29,'2025-10-17',0.00),(30,30,'2025-10-17',0.00),(31,31,'2025-10-17',0.00),(32,32,'2025-10-17',0.00),(33,33,'2025-10-17',0.00),(34,34,'2025-10-17',0.00),(35,35,'2025-10-17',0.00),(36,36,'2025-10-17',0.00),(37,37,'2025-10-17',0.00),(38,38,'2025-10-17',0.00),(39,39,'2025-10-17',0.00),(40,40,'2025-10-17',0.00),(41,41,'2025-10-17',0.00),(42,42,'2025-10-17',0.00),(43,43,'2025-10-17',0.00),(44,44,'2025-10-17',0.00),(45,45,'2025-10-17',0.00),(46,46,'2025-11-04',0.00),(47,47,'2025-11-04',0.00),(48,48,'2025-11-04',0.00),(49,49,'2025-11-04',0.00),(50,50,'2025-11-04',0.00),(51,51,'2025-11-04',0.00),(52,52,'2025-11-04',0.00),(53,53,'2025-11-04',0.00),(54,54,'2025-11-04',0.00),(55,55,'2025-11-04',0.00),(56,56,'2025-11-04',0.00),(57,57,'2025-11-04',0.00),(58,58,'2025-11-04',0.00),(59,59,'2025-11-04',0.00);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `RolUsu` int NOT NULL,
  `NomRol` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RolUsu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (120,'Administrador'),(121,'Empleado');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socio`
--

DROP TABLE IF EXISTS `socio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socio` (
  `IdSocio` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Documento` varchar(20) NOT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `AptoFisico` tinyint(1) DEFAULT '0',
  `FechaInscripcion` date NOT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`IdSocio`),
  UNIQUE KEY `Documento` (`Documento`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socio`
--

LOCK TABLES `socio` WRITE;
/*!40000 ALTER TABLE `socio` DISABLE KEYS */;
INSERT INTO `socio` VALUES (1,'Juana','Luque','95195195','1195195195','1998-12-11',1,'2025-10-09',1),(2,'Ana','Perez','78787878','1178787878','1997-08-07',1,'2025-10-09',1),(3,'Juan','Florez','45454545','1145454545','2000-10-02',1,'2025-10-09',1),(4,'Pedro','Paez','26262626','1126262626','2000-09-27',1,'2025-10-10',1),(5,'Sabrina','Cooper','23363636','112336363636','2001-06-15',1,'2025-10-10',1),(6,'Jimena','Villafañe','23232323','1123232323','1981-01-01',1,'2025-10-10',1),(7,'Liah','Suarez','55558888','1155558888','2002-04-16',1,'2025-10-11',1),(8,'Paz','Suarez','25896325','1125896325','2000-12-10',1,'2025-10-16',1),(9,'María','Gonzalez','45632145','1145632145','1980-10-12',1,'2025-10-16',1),(10,'Zoe','Etcheún','15995115','1115995115','2002-01-01',1,'2025-10-16',1),(11,'Carolina','Sanchez','25852585','1125852585','1982-10-16',1,'2025-10-16',1),(12,'Oscar','Paez','14789632','1114789632','1978-03-08',1,'2025-09-04',1),(13,'Claudia','Benitez','32147896','1132147896','1977-02-18',1,'2025-09-04',1),(14,'Paula','Isasa','55555555','1155555555','2010-10-10',1,'2025-10-16',1),(15,'Noelia','Rubin','63636363','1163636363','1978-03-22',1,'2025-10-16',1),(16,'Paula','Castro','35753575','1135753575','1976-05-11',1,'2025-10-16',1),(17,'Dylan','Cooper','33333333','1133333333','2006-05-04',1,'2025-10-16',1),(18,'Luis','Contreras','47348070','1147348070','1977-10-17',1,'2025-10-17',1),(19,'Pablo','Leto','22222222','1122222222','1998-10-17',1,'2025-10-17',1),(20,'Jazmín','Juarez','34444444','1134444444','1994-10-17',1,'2025-10-17',1),(21,'Paula','Castro','66666665','1166666665','1975-11-17',1,'2025-10-17',1),(22,'Mario','Martinez','88888889','1188888889','2007-07-07',1,'2025-10-17',1),(23,'Diego','Gomez','44444441','1144444441','1996-12-12',1,'2025-10-17',1),(24,'Jose','Perales','77777777','1177777777','2000-10-17',1,'2025-10-17',1),(25,'Alejandra','Gimenez','99999996','1199999996','2001-10-17',1,'2025-10-17',1),(26,'Julio','Sarmiento','33333335','1133333335','1970-05-10',1,'2025-10-17',1),(27,'Marta','Mabel','12312312','1112312312','1993-09-12',1,'2025-10-17',1),(28,'Romina','Ramirez','52525252','1152525252','1986-07-08',1,'2025-10-17',1),(29,'Juanita','Perez','69696969','1169696969','1995-06-10',1,'2025-10-17',1),(30,'Graciela','Perez','44444447','1144444447','1974-09-02',1,'2025-10-17',1),(31,'Miguel','Paez','45645645','1145454545','2001-01-01',1,'2025-10-17',1),(32,'Candela','Gracía','12451245','1112451245','1975-06-30',1,'2025-10-17',1),(33,'Daniela','Torres','54563258','1154563258','1973-11-22',1,'2025-10-17',1),(34,'Julian','Lopez','89511598','1189511598','2000-10-17',1,'2025-10-17',1),(35,'Alicia','Muñoz','465465468','11456468','2006-06-06',1,'2025-10-17',1),(36,'Lautaro','Muñiz','23598754','1123598754','2003-10-10',1,'2025-10-17',1),(37,'Joaquin','Medina','99999995','1199999995','2001-07-10',1,'2025-10-17',1),(38,'Enrique','Closs','66666664','1166666664','1988-09-30',1,'2025-10-17',1),(39,'Lorena','Junco','44444446','1144444446','2002-02-20',1,'2025-10-17',1),(40,'Vilma','Picapiedra','55555564','1155555564','1995-11-11',1,'2025-10-17',1),(41,'Guillermo','Capria','48484847','1148484847','1987-09-21',1,'2025-10-17',1),(42,'Carla','Washington','25888888','1125888888','1998-11-20',1,'2025-10-17',1),(43,'Roberto','Alvarez','62626262','1162626262','1997-07-31',1,'2025-10-17',1),(44,'María','Martha','59659659','1159659659','1972-05-28',1,'2025-10-17',1),(45,'Ruben','Mendez','48484848','1148484848','2006-06-06',1,'2025-10-17',1),(46,'Agustina','Sanchez','42424242','1142424242','1999-09-29',1,'2025-11-04',1),(47,'Alejandro','Magno','75395155','1175395155','1982-12-31',1,'2025-11-04',1),(48,'Armando','Melchori','33336666','1133336666','1996-10-18',1,'2025-11-04',1),(49,'Juan José','Gallardo','11223344','1111223344','1999-10-08',1,'2025-11-04',1),(50,'Karina','Romano','89658965','1189658965','2000-04-25',1,'2025-11-04',1),(51,'Silvia','Castañares','44441111','1144441111','2001-02-21',1,'2025-11-04',1),(52,'JOrge','Macri','77889966','1177889966','1970-03-13',1,'2025-11-04',1),(53,'Karina','Romano','25878925','1125878925','1981-11-02',1,'2025-11-04',1),(54,'Cecilia','Pozas','33221144','1133221144','2004-04-04',1,'2025-11-04',1),(55,'Alejandro','Drogorub','66336633','1166336633','2000-03-02',1,'2025-11-04',1),(56,'Irena','Jankus','60000006','1160000006','1977-05-12',1,'2025-11-04',1),(57,'Natalia','Rodriguez','50000000','1150000000','1970-07-01',1,'2025-11-04',1),(58,'Juan','Calvette','40000000','1140000000','1981-12-22',1,'2025-11-04',1),(59,'Leonardo','Paez','90000000','1190000000','1987-10-23',1,'2025-11-04',1),(60,'Keyla','Florez','91919191','1191919191','1989-11-06',1,'2025-11-06',1),(61,'Emma','Torres','87878787','1187878787','1998-03-06',1,'2025-11-06',1),(62,'Luis','Gracía','25646464','1125646464','1977-12-07',1,'2025-11-07',1),(63,'Pedro','Marmol','93939393','1193939393','1974-05-15',1,'2025-11-07',1);
/*!40000 ALTER TABLE `socio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `CodUsu` int NOT NULL AUTO_INCREMENT,
  `NombreUsu` varchar(20) DEFAULT NULL,
  `PassUsu` varchar(15) DEFAULT NULL,
  `RolUsu` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`CodUsu`),
  KEY `fk_usuario` (`RolUsu`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (26,'Mari2023','123456',120,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'proyecto'
--

--
-- Dumping routines for database 'proyecto'
--
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
  SELECT NomRol
  FROM usuario u
  INNER JOIN roles r ON u.RolUsu = r.RolUsu
  WHERE NombreUsu = Usu AND PassUsu = Pass AND Activo = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-08 12:45:45
