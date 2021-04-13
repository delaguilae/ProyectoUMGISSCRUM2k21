-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: dbcvierp
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `apartado`
--

DROP TABLE IF EXISTS `apartado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apartado` (
  `pkIdApartado` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fkIdCliente` int NOT NULL,
  `fechaApartado` varchar(15) NOT NULL,
  `totalApartado` float(10,2) NOT NULL,
  `estadoApartado` int DEFAULT NULL,
  PRIMARY KEY (`pkIdApartado`),
  KEY `fk_apartado_empresa` (`fkIdEmpresa`),
  KEY `fk_apartado_sucursal` (`fkIdSucursal`),
  KEY `fk_apartado_cliente` (`fkIdCliente`),
  CONSTRAINT `fk_apartado_cliente` FOREIGN KEY (`fkIdCliente`) REFERENCES `cliente` (`pkIdCliente`),
  CONSTRAINT `fk_apartado_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_apartado_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apartado`
--

LOCK TABLES `apartado` WRITE;
/*!40000 ALTER TABLE `apartado` DISABLE KEYS */;
/*!40000 ALTER TABLE `apartado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `apartadodetalle`
--

DROP TABLE IF EXISTS `apartadodetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apartadodetalle` (
  `pkApartadoDetalle` int NOT NULL AUTO_INCREMENT,
  `fkIdApartado` int NOT NULL,
  `fkIdProducto` int NOT NULL,
  `cantidadApartada` int NOT NULL,
  `costoApartado` float(10,2) NOT NULL,
  `precioApartado` float(10,2) NOT NULL,
  `fkIdBodega` int DEFAULT NULL,
  PRIMARY KEY (`pkApartadoDetalle`),
  KEY `fk_adetalle_apartado` (`fkIdApartado`),
  KEY `fk_adetalle_producto` (`fkIdProducto`),
  KEY `fk_adetalle_bodega` (`fkIdBodega`),
  CONSTRAINT `fk_adetalle_apartado` FOREIGN KEY (`fkIdApartado`) REFERENCES `apartado` (`pkIdApartado`),
  CONSTRAINT `fk_adetalle_bodega` FOREIGN KEY (`fkIdBodega`) REFERENCES `bodega` (`pkIdBodega`),
  CONSTRAINT `fk_adetalle_producto` FOREIGN KEY (`fkIdProducto`) REFERENCES `producto` (`pkIdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apartadodetalle`
--

LOCK TABLES `apartadodetalle` WRITE;
/*!40000 ALTER TABLE `apartadodetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `apartadodetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int NOT NULL AUTO_INCREMENT,
  `fk_id_modulo` int NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int NOT NULL,
  PRIMARY KEY (`pk_id_aplicacion`),
  KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  KEY `fk_aplicacion_modulo` (`fk_id_modulo`),
  CONSTRAINT `fk_aplicacion_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=313 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (1,1,'Login','Ventana de Ingreso',1),(2,1,'Mantenimiento Usuario','Mantenimientos de usuario',1),(3,1,'Mantenimiento Aplicacion','ABC de las Aplicaciones',1),(4,1,'Mantenimiento Perfil','ABC de perfiles',1),(5,1,'Asignacion de Aplicaciones a Perfil','Asignacion Aplicacion y perfil',1),(6,1,'Asignacaion de Aplicaciones','Asignacion especificas a un usuario',1),(7,1,'Consulta Aplicacion','Mantenimiento de Aplicaciones',1),(8,1,'Agregar Modulo','Mantenimientos de Modulos',1),(9,1,'Consultar Perfil','Consultas de perfiles disponibles',1),(10,1,'Permisos','Asignar permisos a perfiles y aplicaciones',1),(11,1,'Cambio de Contraseña','Cambia las contraseñas',1),(12,1,'Reporte De Bitacora','Reporte de bitacora',1),(301,4,'Mantenimiento Linea','Mantenimiento de Linea',1),(302,4,'Mantenimineto Marca','Mantenimiento Marca',1),(303,4,'Mantenimiento Producto','Mantenimiento Producto',1),(304,4,'Mantenimiento Bodegas','Mantenimiento Bodegas',1),(305,4,'Existencias','Verificar las existencias en bodega',1),(306,4,'Verificar Cita','Proceso para la verifiacacion de Citas',1),(307,4,'Modificar Cita','Proceso para la modificacion de citas',1),(308,4,'Proceso Verificacion de datos','Para nuevos y renovacion de pasaporte',1),(309,4,'Proceso Primer pasaporte','Proceso para renovar o nuevo pasaporte',1),(310,4,'Impresion de pasaporte','Impresion de pasaporte',1),(311,4,'Reporte De Citas','Reporte De Citas',1),(312,4,'Reporte De Pasaportes','Reporte De Pasaportes',1);
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacion_perfil`
--

DROP TABLE IF EXISTS `aplicacion_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int NOT NULL AUTO_INCREMENT,
  `fk_idaplicacion_aplicacion_perfil` int DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`),
  CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion_perfil`
--

LOCK TABLES `aplicacion_perfil` WRITE;
/*!40000 ALTER TABLE `aplicacion_perfil` DISABLE KEYS */;
INSERT INTO `aplicacion_perfil` VALUES (1,1,1,1),(2,2,1,2),(3,3,1,3),(4,4,1,4),(5,5,1,5),(6,6,1,6),(7,7,1,7),(8,8,1,8),(9,9,1,9),(10,10,1,10),(11,11,1,11),(12,12,1,12);
/*!40000 ALTER TABLE `aplicacion_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacion_usuario`
--

DROP TABLE IF EXISTS `aplicacion_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int NOT NULL AUTO_INCREMENT,
  `fk_idlogin_aplicacion_usuario` int DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`),
  CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion_usuario`
--

LOCK TABLES `aplicacion_usuario` WRITE;
/*!40000 ALTER TABLE `aplicacion_usuario` DISABLE KEYS */;
INSERT INTO `aplicacion_usuario` VALUES (1,1,1,13),(2,1,2,14),(3,1,3,15),(4,1,4,16),(5,1,5,17),(6,1,6,18),(7,1,7,19),(8,1,8,20),(9,1,9,21),(10,1,10,22),(11,1,11,23),(12,1,12,24),(13,1,301,25),(14,1,302,26),(15,1,303,27),(16,1,304,28),(17,1,305,29),(18,1,306,30),(19,1,307,31),(20,1,308,32),(21,1,309,33),(22,1,310,34),(23,1,311,35),(24,1,312,36);
/*!40000 ALTER TABLE `aplicacion_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bitacora` (
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_idusuario_bitacora` int DEFAULT NULL,
  `fk_idaplicacion_bitacora` int DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_login_bitacora` (`fk_idusuario_bitacora`),
  KEY `fk_aplicacion_bitacora` (`fk_idaplicacion_bitacora`),
  CONSTRAINT `fk_aplicacion_bitacora` FOREIGN KEY (`fk_idaplicacion_bitacora`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_login_bitacora` FOREIGN KEY (`fk_idusuario_bitacora`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,1,1,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(2,1,3,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(3,1,3,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(4,1,301,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO pais VALUES ( 1,  Guatemala,  Guatemala,  1) '),(5,1,3,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(6,1,301,'13/04/2021 14:08:22','192.168.0.19','DESKTOP-MQ0UNFV','Cancelar'),(7,1,1,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(8,1,3,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(9,1,301,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Cancelar'),(10,1,3,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(11,1,3,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(12,1,3,'13/04/2021 15:10:46','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(13,1,1,'13/04/2021 15:11:50','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(14,1,3,'13/04/2021 15:11:50','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(15,1,1,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(16,1,3,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(17,1,301,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO proveedor VALUES ( 1,  1,  guatemala,  12345,  54689270,  bjsican@gmail.com,  1) '),(18,1,3,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(19,1,301,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO pais VALUES ( 2,  Mexico,  DF,  1) '),(20,1,3,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(21,1,301,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO departamento VALUES ( 1,  Guatemala,  Ciudad de guatemala,  1) '),(22,1,3,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(23,1,301,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO municipio VALUES ( 1,  1,  Mixco,  1,  Municipalidad de mixco) '),(24,1,301,'13/04/2021 15:17:25','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO municipio VALUES ( 1,  1,  mixco,  1,  mixco) '),(25,1,1,'13/04/2021 15:20:53','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(26,1,3,'13/04/2021 15:20:53','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(27,1,1,'13/04/2021 15:29:39','192.168.0.19','DESKTOP-MQ0UNFV','Logeo Exitoso'),(28,1,3,'13/04/2021 15:29:39','192.168.0.19','DESKTOP-MQ0UNFV','Ingreso A Mantenimiento Aplicaciones'),(29,1,301,'13/04/2021 15:29:39','192.168.0.19','DESKTOP-MQ0UNFV',' INSERT INTO municipio VALUES ( 2,  1,  San Juan,  San Juan Sacatepequez,  1) '),(30,1,301,'13/04/2021 15:29:39','192.168.0.19','DESKTOP-MQ0UNFV','Salir de la aplicacion');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `pkIdBodega` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `fkIdSucursal` int DEFAULT NULL,
  `fkIdDepar` int DEFAULT NULL,
  `fkIdMuni` int NOT NULL,
  `descripcionBodega` varchar(250) NOT NULL,
  `direccionBodega` varchar(45) NOT NULL,
  `telefonoBodega` int NOT NULL,
  `estadoBodega` int NOT NULL,
  PRIMARY KEY (`pkIdBodega`),
  KEY `fk_bodega_empresa` (`fkIdEmpresa`),
  KEY `fk_bodega_sucursal` (`fkIdSucursal`),
  KEY `fk_bodega_departamento` (`fkIdDepar`),
  KEY `fk_bodega_municipio` (`fkIdMuni`),
  CONSTRAINT `fk_bodega_departamento` FOREIGN KEY (`fkIdDepar`) REFERENCES `departamento` (`pkIdDepar`),
  CONSTRAINT `fk_bodega_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_bodega_municipio` FOREIGN KEY (`fkIdMuni`) REFERENCES `municipio` (`pkIdMuni`),
  CONSTRAINT `fk_bodega_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `pkIdCliente` int NOT NULL AUTO_INCREMENT,
  `nombreCliente` varchar(30) DEFAULT NULL,
  `apellidoCliente` varchar(30) DEFAULT NULL,
  `direccionCliente` varchar(60) DEFAULT NULL,
  `fkIdDepar` int DEFAULT NULL,
  `fkIdMuni` int DEFAULT NULL,
  `codigoPostal` varchar(5) DEFAULT NULL,
  `nitCliente` varchar(20) DEFAULT NULL,
  `telCliente` varchar(50) DEFAULT NULL,
  `estadoCliente` int DEFAULT NULL,
  PRIMARY KEY (`pkIdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cobro`
--

DROP TABLE IF EXISTS `cobro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cobro` (
  `pkNoRegistroCobro` int NOT NULL AUTO_INCREMENT,
  `fkIdRegistroCuenta` int NOT NULL,
  `fkIdEmpleado` int NOT NULL,
  `descripcionCobro` int NOT NULL,
  `fechaPago` varchar(15) NOT NULL,
  `fkIdMetodoPago` int NOT NULL,
  `montoAbonado` float(10,2) NOT NULL,
  PRIMARY KEY (`pkNoRegistroCobro`),
  KEY `fk_cobro_cuentas` (`fkIdRegistroCuenta`),
  KEY `fk_cobro_empleado` (`fkIdEmpleado`),
  KEY `fk_cobro_metodopago` (`fkIdMetodoPago`),
  CONSTRAINT `fk_cobro_cuentas` FOREIGN KEY (`fkIdRegistroCuenta`) REFERENCES `cuentas` (`pkIdRegistroCuentas`),
  CONSTRAINT `fk_cobro_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_cobro_metodopago` FOREIGN KEY (`fkIdMetodoPago`) REFERENCES `metodopago` (`pkIdMetodoPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cobro`
--

LOCK TABLES `cobro` WRITE;
/*!40000 ALTER TABLE `cobro` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compradetalle`
--

DROP TABLE IF EXISTS `compradetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compradetalle` (
  `pkIdCompraDetalle` int NOT NULL,
  `fkNoDocumentoEnca` int NOT NULL,
  `fkIdPro` int NOT NULL,
  `cantidadCompraDe` int NOT NULL,
  `costoCompraDe` double(8,2) NOT NULL,
  `fkIdBodega` int NOT NULL,
  PRIMARY KEY (`pkIdCompraDetalle`,`fkNoDocumentoEnca`,`fkIdPro`),
  KEY `fk_compra_detalle_encabezado` (`fkNoDocumentoEnca`),
  KEY `fk_compra_producto` (`fkIdPro`),
  KEY `fk_compra_bodega` (`fkIdBodega`),
  CONSTRAINT `fk_compra_bodega` FOREIGN KEY (`fkIdBodega`) REFERENCES `bodega` (`pkIdBodega`),
  CONSTRAINT `fk_compra_detalle_encabezado` FOREIGN KEY (`fkNoDocumentoEnca`) REFERENCES `compraencabezado` (`pkNoDocumentoEnca`),
  CONSTRAINT `fk_compra_producto` FOREIGN KEY (`fkIdPro`) REFERENCES `producto` (`pkIdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compradetalle`
--

LOCK TABLES `compradetalle` WRITE;
/*!40000 ALTER TABLE `compradetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `compradetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compraencabezado`
--

DROP TABLE IF EXISTS `compraencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compraencabezado` (
  `pkNoDocumentoEnca` int NOT NULL AUTO_INCREMENT,
  `fkIdProv` int NOT NULL,
  `fkIdEmpleado` int NOT NULL,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fechaCompra` date NOT NULL,
  `totalCompra` double(12,2) NOT NULL,
  `estadoCompra` int NOT NULL,
  PRIMARY KEY (`pkNoDocumentoEnca`),
  KEY `fk_compra_empresa` (`fkIdEmpresa`),
  KEY `fk_compra_sucursal` (`fkIdSucursal`),
  KEY `fk_compra_empleado` (`fkIdEmpleado`),
  KEY `fk_compra_proveedor` (`fkIdProv`),
  CONSTRAINT `fk_compra_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_compra_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_compra_proveedor` FOREIGN KEY (`fkIdProv`) REFERENCES `proveedor` (`pkIdProv`),
  CONSTRAINT `fk_compra_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compraencabezado`
--

LOCK TABLES `compraencabezado` WRITE;
/*!40000 ALTER TABLE `compraencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `compraencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotizadetalle`
--

DROP TABLE IF EXISTS `cotizadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cotizadetalle` (
  `pkIdCotizaDetalle` int NOT NULL AUTO_INCREMENT,
  `fkDocumentoCotizaEnca` int DEFAULT NULL,
  `fkIdPro` int DEFAULT NULL,
  `cantidadCotizar` int DEFAULT NULL,
  `precioCotiza` float(10,2) DEFAULT NULL,
  PRIMARY KEY (`pkIdCotizaDetalle`),
  KEY `fk_cotiza_encabezado` (`fkDocumentoCotizaEnca`),
  KEY `fk_cotiza_producto` (`fkIdPro`),
  CONSTRAINT `fk_cotiza_encabezado` FOREIGN KEY (`fkDocumentoCotizaEnca`) REFERENCES `cotizaencabezado` (`pkDocumentoCotizaEnca`),
  CONSTRAINT `fk_cotiza_producto` FOREIGN KEY (`fkIdPro`) REFERENCES `producto` (`pkIdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizadetalle`
--

LOCK TABLES `cotizadetalle` WRITE;
/*!40000 ALTER TABLE `cotizadetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotizadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotizaencabezado`
--

DROP TABLE IF EXISTS `cotizaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cotizaencabezado` (
  `pkDocumentoCotizaEnca` int NOT NULL AUTO_INCREMENT,
  `fkIdCliente` int NOT NULL,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fkIdEmpleado` int NOT NULL,
  `fechaRequerida` varchar(15) NOT NULL,
  `fechaEnvio` varchar(15) NOT NULL,
  `vigenciaCotizacion` varchar(15) NOT NULL,
  `totalCotizacion` float(10,2) NOT NULL,
  `estadoCotizacion` int DEFAULT NULL,
  PRIMARY KEY (`pkDocumentoCotizaEnca`),
  KEY `fk_cotiza_empresa` (`fkIdEmpresa`),
  KEY `fk_cotiza_sucursal` (`fkIdSucursal`),
  KEY `fk_cotiza_empleado` (`fkIdEmpleado`),
  KEY `fk_cotiza_cliente` (`fkIdCliente`),
  CONSTRAINT `fk_cotiza_cliente` FOREIGN KEY (`fkIdCliente`) REFERENCES `cliente` (`pkIdCliente`),
  CONSTRAINT `fk_cotiza_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_cotiza_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_cotiza_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizaencabezado`
--

LOCK TABLES `cotizaencabezado` WRITE;
/*!40000 ALTER TABLE `cotizaencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotizaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas`
--

DROP TABLE IF EXISTS `cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuentas` (
  `pkIdRegistroCuentas` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `NoDocumento` int NOT NULL,
  `tipoCuenta` int NOT NULL,
  `fkIdEmpleado` int NOT NULL,
  `fechaRealizada` varchar(15) NOT NULL,
  `tiempoDeCredito` int NOT NULL,
  `montoPagado` float(10,2) NOT NULL,
  `montoPendiente` float(10,2) NOT NULL,
  `montoTotal` float(10,2) NOT NULL,
  PRIMARY KEY (`pkIdRegistroCuentas`),
  KEY `fk_cuentas_empresa` (`fkIdEmpresa`),
  KEY `fk_cuentas_sucursal` (`fkIdSucursal`),
  KEY `fk_cuentas_empleado` (`fkIdEmpleado`),
  CONSTRAINT `fk_cuentas_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_cuentas_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_cuentas_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas`
--

LOCK TABLES `cuentas` WRITE;
/*!40000 ALTER TABLE `cuentas` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `pkIdDepar` int NOT NULL AUTO_INCREMENT,
  `nombreDepar` varchar(30) DEFAULT NULL,
  `descripcionDepar` varchar(45) DEFAULT NULL,
  `estadoDepar` int DEFAULT NULL,
  PRIMARY KEY (`pkIdDepar`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Guatemala','Ciudad de guatemala',1);
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_bitacora`
--

DROP TABLE IF EXISTS `detalle_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_bitacora` (
  `pk_id_detalle_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_idbitacora_detalle_bitacora` int DEFAULT NULL,
  `querryantigua_detalle_bitacora` varchar(50) DEFAULT NULL,
  `querrynueva_detalle_bitacora` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`pk_id_detalle_bitacora`),
  KEY `fk_bitacora_detallebitacora` (`fk_idbitacora_detalle_bitacora`),
  CONSTRAINT `fk_bitacora_detallebitacora` FOREIGN KEY (`fk_idbitacora_detalle_bitacora`) REFERENCES `bitacora` (`pk_id_bitacora`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_bitacora`
--

LOCK TABLES `detalle_bitacora` WRITE;
/*!40000 ALTER TABLE `detalle_bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallepedido`
--

DROP TABLE IF EXISTS `detallepedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallepedido` (
  `pkIdDetallePedido` int NOT NULL AUTO_INCREMENT,
  `fkIdPedido` int NOT NULL,
  `fkIdProducto` int NOT NULL,
  `cantidadDetalle` int NOT NULL,
  `costoDetalle` float(10,2) NOT NULL,
  `precioDetalle` float(10,2) NOT NULL,
  PRIMARY KEY (`pkIdDetallePedido`),
  KEY `fk_detalle_pedido` (`fkIdPedido`),
  KEY `fk_detalle_producto` (`fkIdProducto`),
  CONSTRAINT `fk_detalle_pedido` FOREIGN KEY (`fkIdPedido`) REFERENCES `pedido` (`pkIdPedido`),
  CONSTRAINT `fk_detalle_producto` FOREIGN KEY (`fkIdProducto`) REFERENCES `producto` (`pkIdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallepedido`
--

LOCK TABLES `detallepedido` WRITE;
/*!40000 ALTER TABLE `detallepedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallepedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pkIdEmpleado` int NOT NULL AUTO_INCREMENT,
  `idManager` int DEFAULT NULL,
  `fkIdEmpresa` int DEFAULT NULL,
  `fkIdSucursal` int DEFAULT NULL,
  `fkIdPuesto` int DEFAULT NULL,
  `nombreEmpleado` varchar(30) DEFAULT NULL,
  `apellidoEmpleado` varchar(30) DEFAULT NULL,
  `cuiEmpleado` varchar(15) DEFAULT NULL,
  `telefonoEmpleado` varchar(15) DEFAULT NULL,
  `emailEmpleado` varchar(30) DEFAULT NULL,
  `estadoEmpleado` int DEFAULT NULL,
  PRIMARY KEY (`pkIdEmpleado`),
  KEY `idManager` (`idManager`),
  KEY `fk_empleado_empresa` (`fkIdEmpresa`),
  KEY `fk_empleado_sucursal` (`fkIdSucursal`),
  KEY `fk_empleado_puesto` (`fkIdPuesto`),
  CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`idManager`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_empleado_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_empleado_puesto` FOREIGN KEY (`fkIdPuesto`) REFERENCES `puesto` (`pkIdPuesto`),
  CONSTRAINT `fk_empleado_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresa` (
  `pkIdEmpresa` int NOT NULL AUTO_INCREMENT,
  `nombreEmpresa` varchar(100) DEFAULT NULL,
  `fkIdPais` int DEFAULT NULL,
  `direccionDeLugar` varchar(50) DEFAULT NULL,
  `fkIdDepar` int DEFAULT NULL,
  `fkIdMuni` int DEFAULT NULL,
  `estadoEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`pkIdEmpresa`),
  KEY `fk_empresa_pais` (`fkIdPais`),
  KEY `fk_empresa_departamento` (`fkIdDepar`),
  KEY `fk_empresa_municipio` (`fkIdMuni`),
  CONSTRAINT `fk_empresa_departamento` FOREIGN KEY (`fkIdDepar`) REFERENCES `departamento` (`pkIdDepar`),
  CONSTRAINT `fk_empresa_municipio` FOREIGN KEY (`fkIdMuni`) REFERENCES `municipio` (`pkIdMuni`),
  CONSTRAINT `fk_empresa_pais` FOREIGN KEY (`fkIdPais`) REFERENCES `pais` (`pkIdPais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `existencia`
--

DROP TABLE IF EXISTS `existencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `existencia` (
  `pkIdExis` int NOT NULL,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fkIdBodega` int NOT NULL,
  `fkIdPro` int NOT NULL,
  `cantidad_existencia` int NOT NULL,
  `estado_existencia` int NOT NULL,
  PRIMARY KEY (`pkIdExis`,`fkIdEmpresa`,`fkIdSucursal`,`fkIdBodega`,`fkIdPro`),
  KEY `fk_existencia_empresa` (`fkIdEmpresa`),
  KEY `fk_existencia_sucursal` (`fkIdSucursal`),
  KEY `fk_existencia_producto` (`fkIdBodega`),
  KEY `fk_existencia_bodega` (`fkIdPro`),
  CONSTRAINT `fk_existencia_bodega` FOREIGN KEY (`fkIdPro`) REFERENCES `bodega` (`pkIdBodega`),
  CONSTRAINT `fk_existencia_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_existencia_producto` FOREIGN KEY (`fkIdBodega`) REFERENCES `producto` (`pkIdProducto`),
  CONSTRAINT `fk_existencia_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `existencia`
--

LOCK TABLES `existencia` WRITE;
/*!40000 ALTER TABLE `existencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `existencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lineaproducto`
--

DROP TABLE IF EXISTS `lineaproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lineaproducto` (
  `pkIdLineaPro` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `nombreLineaPro` varchar(25) NOT NULL,
  `descripcionLineaPro` varchar(50) NOT NULL,
  `estadoLineaPro` int NOT NULL,
  PRIMARY KEY (`pkIdLineaPro`),
  KEY `fk_linea_empresa` (`fkIdEmpresa`),
  CONSTRAINT `fk_linea_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineaproducto`
--

LOCK TABLES `lineaproducto` WRITE;
/*!40000 ALTER TABLE `lineaproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `lineaproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `pk_id_login` int NOT NULL AUTO_INCREMENT,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_login`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,'sistema','bi0PL96rbxVRPKJQsLJJAg==','Usuario de prueba',1),(2,'admin','T+4Ai6O3CR0kJYxCgXy2jA==','Administrador',1),(3,'morataya','5g2jpUc7tYd0Q0iop9+lfA==','Julio Morataya',1);
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marcaproducto`
--

DROP TABLE IF EXISTS `marcaproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marcaproducto` (
  `pkIdMarcaPro` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `nombreMarcaPro` varchar(35) NOT NULL,
  `descripcionMarcaPro` varchar(60) NOT NULL,
  `estadoMarcaPro` int NOT NULL,
  PRIMARY KEY (`pkIdMarcaPro`),
  KEY `fk_marca_empresa` (`fkIdEmpresa`),
  CONSTRAINT `fk_marca_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcaproducto`
--

LOCK TABLES `marcaproducto` WRITE;
/*!40000 ALTER TABLE `marcaproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `marcaproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `metodopago`
--

DROP TABLE IF EXISTS `metodopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `metodopago` (
  `pkIdMetodoPago` int NOT NULL AUTO_INCREMENT,
  `descripcionMetodo` varchar(150) NOT NULL,
  `estadoMetodo` int DEFAULT NULL,
  PRIMARY KEY (`pkIdMetodoPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `metodopago`
--

LOCK TABLES `metodopago` WRITE;
/*!40000 ALTER TABLE `metodopago` DISABLE KEYS */;
/*!40000 ALTER TABLE `metodopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modulo` (
  `pk_id_modulo` int NOT NULL AUTO_INCREMENT,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int NOT NULL,
  PRIMARY KEY (`pk_id_modulo`),
  KEY `pk_id_modulo` (`pk_id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
INSERT INTO `modulo` VALUES (1,'Seguridad','Aplicaciones de seguridad',1),(2,'Consultas','Consultas Inteligentes',1),(3,'Reporteador','Aplicaciones de Reporteador',1),(4,'Inventarios','Sistema de Gestion Inventarios',1),(5,'Compras','Sistema De Gestion Compras',1),(6,'Ventas','Sistema de Gestion Ventas',1),(7,'Cobros','Sistema De Gestion Cobros',1);
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipio`
--

DROP TABLE IF EXISTS `municipio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `municipio` (
  `pkIdMuni` int NOT NULL AUTO_INCREMENT,
  `fkIdDepar` int NOT NULL,
  `nombreMuni` varchar(30) NOT NULL,
  `descripcionMuni` varchar(45) NOT NULL,
  `estadoMuni` int NOT NULL,
  PRIMARY KEY (`pkIdMuni`),
  KEY `fk_municipio_departamento` (`fkIdDepar`),
  CONSTRAINT `fk_municipio_departamento` FOREIGN KEY (`fkIdDepar`) REFERENCES `departamento` (`pkIdDepar`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipio`
--

LOCK TABLES `municipio` WRITE;
/*!40000 ALTER TABLE `municipio` DISABLE KEYS */;
INSERT INTO `municipio` VALUES (1,1,'Mixco','Mixco',1),(2,1,'San Juan','San Juan Sacatepequez',1);
/*!40000 ALTER TABLE `municipio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pais`
--

DROP TABLE IF EXISTS `pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pais` (
  `pkIdPais` int NOT NULL AUTO_INCREMENT,
  `nombrePais` varchar(40) NOT NULL,
  `capitalPais` varchar(40) NOT NULL,
  `estadoPais` int NOT NULL,
  PRIMARY KEY (`pkIdPais`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` VALUES (1,'Guatemala','Guatemala',1),(2,'Mexico','DF',1);
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `pkIdPedido` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fkIdCliente` int NOT NULL,
  `fechaRequerida` varchar(15) NOT NULL,
  `fechaEnvio` varchar(15) NOT NULL,
  `totalPedido` float(10,2) NOT NULL,
  `estadoPedido` int DEFAULT NULL,
  PRIMARY KEY (`pkIdPedido`),
  KEY `fk_pedido_empresa` (`fkIdEmpresa`),
  KEY `fk_pedido_sucursal` (`fkIdSucursal`),
  KEY `fk_pedido_cliente` (`fkIdCliente`),
  CONSTRAINT `fk_pedido_cliente` FOREIGN KEY (`fkIdCliente`) REFERENCES `cliente` (`pkIdCliente`),
  CONSTRAINT `fk_pedido_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_pedido_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES (1,'Admin','Administracion del programa',1);
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_usuario`
--

DROP TABLE IF EXISTS `perfil_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int NOT NULL AUTO_INCREMENT,
  `fk_idusuario_perfil_usuario` int DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_perfil_usuario`),
  KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`),
  CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_usuario`
--

LOCK TABLES `perfil_usuario` WRITE;
/*!40000 ALTER TABLE `perfil_usuario` DISABLE KEYS */;
INSERT INTO `perfil_usuario` VALUES (1,1,1),(2,2,1),(3,3,1);
/*!40000 ALTER TABLE `perfil_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permiso`
--

DROP TABLE IF EXISTS `permiso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permiso` (
  `pk_id_permiso` int NOT NULL AUTO_INCREMENT,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_id_permiso`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permiso`
--

LOCK TABLES `permiso` WRITE;
/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
INSERT INTO `permiso` VALUES (1,1,1,1,1,1),(2,1,1,1,1,1),(3,1,1,1,0,0),(4,1,1,1,1,1),(5,1,1,1,1,1),(6,1,1,1,1,1),(7,1,1,1,1,1),(8,1,0,1,1,1),(9,1,1,1,1,1),(10,1,1,1,1,1),(11,1,1,1,1,1),(12,1,1,1,1,1),(13,1,1,1,1,1),(14,1,1,1,1,1),(15,1,1,1,1,1),(16,1,1,1,1,1),(17,1,1,1,1,1),(18,1,1,1,1,1),(19,1,1,1,1,1),(20,1,1,1,1,1),(21,1,1,1,1,1),(22,1,1,1,1,1),(23,1,1,1,1,1),(24,1,1,1,1,1),(25,1,1,1,1,1),(26,1,1,1,1,1),(27,1,1,1,1,1),(28,1,1,1,1,1),(29,1,1,1,1,1),(30,1,1,1,1,1),(31,1,1,1,1,1),(32,1,1,1,1,1),(33,1,1,1,1,1),(34,1,1,1,1,1),(35,1,1,1,1,1),(36,1,1,1,1,1);
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personalbodega`
--

DROP TABLE IF EXISTS `personalbodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personalbodega` (
  `pkIdpersonal` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `fkIdSucursal` int DEFAULT NULL,
  `fkIdEmpleado` int NOT NULL,
  `fkIdBodega` int NOT NULL,
  `fkIdCargo` int NOT NULL,
  `estadoPerBodega` int DEFAULT NULL,
  PRIMARY KEY (`pkIdpersonal`),
  KEY `fk_personal_empleado` (`fkIdEmpleado`),
  KEY `fk_personal_empresa` (`fkIdEmpresa`),
  KEY `fk_personal_sucursal` (`fkIdSucursal`),
  KEY `fk_personal_bodega` (`fkIdBodega`),
  KEY `fk_personal_cargo` (`fkIdCargo`),
  CONSTRAINT `fk_personal_bodega` FOREIGN KEY (`fkIdBodega`) REFERENCES `bodega` (`pkIdBodega`),
  CONSTRAINT `fk_personal_cargo` FOREIGN KEY (`fkIdCargo`) REFERENCES `puesto` (`pkIdPuesto`),
  CONSTRAINT `fk_personal_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_personal_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_personal_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personalbodega`
--

LOCK TABLES `personalbodega` WRITE;
/*!40000 ALTER TABLE `personalbodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `personalbodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `pkIdProducto` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `fkIdLineaPro` int NOT NULL,
  `fkIdMarcaPro` int NOT NULL,
  `nombrePro` varchar(50) NOT NULL,
  `precioPro` double(12,2) NOT NULL,
  `descripcionPro` varchar(45) NOT NULL,
  `estadoPro` int NOT NULL,
  PRIMARY KEY (`pkIdProducto`),
  KEY `fk_producto_empresa` (`fkIdEmpresa`),
  KEY `fk_producto_lineaProducto` (`fkIdLineaPro`),
  KEY `fk_producto_categoriaProducto` (`fkIdMarcaPro`),
  CONSTRAINT `fk_producto_categoriaProducto` FOREIGN KEY (`fkIdMarcaPro`) REFERENCES `marcaproducto` (`pkIdMarcaPro`),
  CONSTRAINT `fk_producto_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_producto_lineaProducto` FOREIGN KEY (`fkIdLineaPro`) REFERENCES `lineaproducto` (`pkIdLineaPro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `pkIdProv` int NOT NULL AUTO_INCREMENT,
  `fkIdPais` int NOT NULL,
  `direccionProv` varchar(50) NOT NULL,
  `nitProv` varchar(20) NOT NULL,
  `telProv` int NOT NULL,
  `correoProv` varchar(30) NOT NULL,
  `estadoProv` int NOT NULL,
  PRIMARY KEY (`pkIdProv`),
  KEY `fk_proveedor_pais` (`fkIdPais`),
  CONSTRAINT `fk_proveedor_pais` FOREIGN KEY (`fkIdPais`) REFERENCES `pais` (`pkIdPais`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,1,'guatemala','12345',54689270,'bjsican@gmail.com',1);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `puesto` (
  `pkIdPuesto` int NOT NULL AUTO_INCREMENT,
  `nombrePuesto` varchar(50) NOT NULL,
  `descripcionPuesto` varchar(250) NOT NULL,
  `estadoPuesto` int NOT NULL,
  PRIMARY KEY (`pkIdPuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puesto`
--

LOCK TABLES `puesto` WRITE;
/*!40000 ALTER TABLE `puesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `pk_id_reporte` int NOT NULL AUTO_INCREMENT,
  `nombre_reporte` varchar(40) NOT NULL,
  `ruta_reporte` varchar(100) NOT NULL,
  `estado_reporte` int NOT NULL,
  PRIMARY KEY (`pk_id_reporte`),
  KEY `pk_id_reporte` (`pk_id_reporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte`
--

LOCK TABLES `reporte` WRITE;
/*!40000 ALTER TABLE `reporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_aplicativo`
--

DROP TABLE IF EXISTS `reporte_aplicativo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_aplicativo` (
  `fk_id_reporte` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_modulo` int NOT NULL,
  `estado_reporte_aplicativo` int NOT NULL,
  PRIMARY KEY (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  KEY `fk_reporte_aplicativo_modulo` (`fk_id_modulo`),
  KEY `fk_report_aplicativo` (`fk_id_aplicacion`),
  CONSTRAINT `fk_report_aplicativo` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `aplicacion` (`pk_id_aplicacion`),
  CONSTRAINT `fk_reporte_aplicativo_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`),
  CONSTRAINT `fk_reporte_aplicativo_reporte` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_aplicativo`
--

LOCK TABLES `reporte_aplicativo` WRITE;
/*!40000 ALTER TABLE `reporte_aplicativo` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte_aplicativo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_modulo`
--

DROP TABLE IF EXISTS `reporte_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_modulo` (
  `fk_id_reporte` int NOT NULL,
  `fk_id_modulo` int NOT NULL,
  `estado_reporte_modulo` int NOT NULL,
  PRIMARY KEY (`fk_id_reporte`,`fk_id_modulo`),
  KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_modulo`),
  KEY `fk_reporte_de_modulo_reportes` (`fk_id_modulo`),
  CONSTRAINT `fk_reporte_de_modulo` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`),
  CONSTRAINT `fk_reporte_de_modulo_reportes` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_modulo`
--

LOCK TABLES `reporte_modulo` WRITE;
/*!40000 ALTER TABLE `reporte_modulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `pkIdSucursal` int NOT NULL AUTO_INCREMENT,
  `fkIdEmpresa` int DEFAULT NULL,
  `nombreSucursal` varchar(50) DEFAULT NULL,
  `fkIdPais` int DEFAULT NULL,
  `direccionDeLugar` varchar(50) DEFAULT NULL,
  `fkIdDepar` int DEFAULT NULL,
  `fkIdMuni` int DEFAULT NULL,
  `estadoSucursal` int DEFAULT NULL,
  PRIMARY KEY (`pkIdSucursal`),
  KEY `fk_sucursal_empresa` (`fkIdEmpresa`),
  KEY `fk_sucursal_pais` (`fkIdPais`),
  KEY `fk_sucursal_departamento` (`fkIdDepar`),
  KEY `fk_sucursal_municipio` (`fkIdMuni`),
  CONSTRAINT `fk_sucursal_departamento` FOREIGN KEY (`fkIdDepar`) REFERENCES `departamento` (`pkIdDepar`),
  CONSTRAINT `fk_sucursal_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_sucursal_municipio` FOREIGN KEY (`fkIdMuni`) REFERENCES `municipio` (`pkIdMuni`),
  CONSTRAINT `fk_sucursal_pais` FOREIGN KEY (`fkIdPais`) REFERENCES `pais` (`pkIdPais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventadetalle`
--

DROP TABLE IF EXISTS `ventadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventadetalle` (
  `pkIdVentaDetalle` int NOT NULL,
  `fkDocumentoVentaEnca` int NOT NULL,
  `fkIdPro` int NOT NULL,
  `cantidadVenta` int DEFAULT NULL,
  `costoVenta` float(10,2) DEFAULT NULL,
  `precioVenta` float(10,2) DEFAULT NULL,
  `fkIdBodega` int DEFAULT NULL,
  PRIMARY KEY (`pkIdVentaDetalle`,`fkDocumentoVentaEnca`,`fkIdPro`),
  KEY `fk_venta_encabezado` (`fkDocumentoVentaEnca`),
  KEY `fk_venta_producto` (`fkIdPro`),
  KEY `fk_venta_bodega` (`fkIdBodega`),
  CONSTRAINT `fk_venta_bodega` FOREIGN KEY (`fkIdBodega`) REFERENCES `bodega` (`pkIdBodega`),
  CONSTRAINT `fk_venta_encabezado` FOREIGN KEY (`fkDocumentoVentaEnca`) REFERENCES `ventaencabezado` (`pkDocumentoVentaEnca`),
  CONSTRAINT `fk_venta_producto` FOREIGN KEY (`fkIdPro`) REFERENCES `producto` (`pkIdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventadetalle`
--

LOCK TABLES `ventadetalle` WRITE;
/*!40000 ALTER TABLE `ventadetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventaencabezado`
--

DROP TABLE IF EXISTS `ventaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventaencabezado` (
  `pkDocumentoVentaEnca` int NOT NULL AUTO_INCREMENT,
  `fkIdCliente` int NOT NULL,
  `fkIdEmpresa` int NOT NULL,
  `fkIdSucursal` int NOT NULL,
  `fkIdEmpleado` int NOT NULL,
  `fechaRequerida` varchar(15) NOT NULL,
  `fechaEnvio` varchar(15) NOT NULL,
  `totalVenta` float(10,2) NOT NULL,
  `estadoVentaEnca` int DEFAULT NULL,
  PRIMARY KEY (`pkDocumentoVentaEnca`),
  KEY `fk_venta_empresa` (`fkIdEmpresa`),
  KEY `fk_venta_sucursal` (`fkIdSucursal`),
  KEY `fk_venta_cliente` (`fkIdCliente`),
  KEY `fk_venta_empleado` (`fkIdEmpleado`),
  CONSTRAINT `fk_venta_cliente` FOREIGN KEY (`fkIdCliente`) REFERENCES `cliente` (`pkIdCliente`),
  CONSTRAINT `fk_venta_empleado` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_venta_empresa` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`pkIdEmpresa`),
  CONSTRAINT `fk_venta_sucursal` FOREIGN KEY (`fkIdSucursal`) REFERENCES `sucursal` (`pkIdSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventaencabezado`
--

LOCK TABLES `ventaencabezado` WRITE;
/*!40000 ALTER TABLE `ventaencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'dbcvierp'
--

--
-- Dumping routines for database 'dbcvierp'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-13 15:39:45
