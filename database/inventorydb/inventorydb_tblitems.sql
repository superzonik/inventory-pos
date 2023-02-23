-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: inventorydb
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `tblitems`
--

DROP TABLE IF EXISTS `tblitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblitems` (
  `itemid` int NOT NULL AUTO_INCREMENT,
  `category` varchar(100) DEFAULT NULL,
  `productname` varchar(255) DEFAULT NULL,
  `fxtype` varchar(10) DEFAULT NULL,
  `fxcapacity` varchar(50) DEFAULT NULL,
  `productdescription` varchar(255) DEFAULT NULL,
  `productstatus` varchar(10) DEFAULT NULL,
  `manufacturedate` date DEFAULT NULL,
  `productprice` double DEFAULT NULL,
  `isproductsold` varchar(6) DEFAULT NULL,
  `serialnumber` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`itemid`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblitems`
--

LOCK TABLES `tblitems` WRITE;
/*!40000 ALTER TABLE `tblitems` DISABLE KEYS */;
INSERT INTO `tblitems` VALUES (1,'Fire Extinguisher','Dry Chemical','Portable','10lbs','','Brand New','2023-02-06',1500,NULL,NULL),(2,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Brand New','2023-02-08',3000,NULL,NULL),(3,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',5000,NULL,NULL),(4,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',5000,NULL,NULL),(5,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',5000,NULL,NULL),(6,'Fire Extinguisher','Dry Chemical','Portable','20lbs','','Brand New','2023-02-09',1000,NULL,NULL),(7,'Fire Extinguisher','Dry Chemical','Portable','20lbs','','Brand New','2023-02-09',1000,NULL,NULL),(8,'Fire Extinguisher','Dry Chemical','Portable','20lbs','','Brand New','2023-02-09',1000,NULL,NULL),(9,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Refill','2023-02-09',2500,NULL,NULL),(10,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Refill','2023-02-09',2500,NULL,NULL),(11,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Refill','2023-02-09',2500,NULL,NULL),(12,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Refill','2023-02-09',2500,NULL,NULL),(13,'Fire Extinguisher','HCFC 123','Portable','10lbs','','Refill','2023-02-09',2500,NULL,NULL),(14,'Fire Extinguisher','Dry Chemical','Portable','3lbs','','Brand New','2023-02-09',1000,NULL,NULL),(15,'Fire Extinguisher','Dry Chemical','Portable','3lbs','','Brand New','2023-02-09',1000,NULL,NULL),(16,'Fire Extinguisher','HCFC 123','Portable','20lbs','','Brand New','2023-02-09',3000,NULL,NULL),(17,'Fire Extinguisher','HCFC 123','Portable','20lbs','','Brand New','2023-02-09',3000,NULL,NULL),(18,'Fire Extinguisher','Dry Chemical','Portable','10lbs','','Brand New','2023-02-09',1500,NULL,NULL),(19,'Fire Extinguisher','Dry Chemical','Portable','10lbs','','Brand New','2023-02-09',1500,NULL,NULL),(20,'Fire Extinguisher','HFC236FA','Portable','10lbs','','Brand New','2023-02-09',10000,NULL,NULL),(21,'Fire Extinguisher','HFC236FA','Portable','10lbs','','Brand New','2023-02-09',10000,NULL,NULL),(22,'Fire Extinguisher','HFC236FA','Portable','10lbs','','Brand New','2023-02-09',10000,NULL,NULL),(23,'Fire Extinguisher','HFC236FA','Portable','10lbs','','Brand New','2023-02-09',10000,NULL,NULL),(24,'Fire Extinguisher','Dry Chemical','Portable','10lbs','','Brand New','2023-02-09',2000,NULL,NULL),(25,'Fire Extinguisher','Dry Chemical','Portable','10lbs','','Brand New','2023-02-09',2000,NULL,NULL),(26,'Fire Extinguisher','HCFC 123','Portable','5lbs','','Brand New','2023-02-09',3500,NULL,NULL),(27,'Fire Extinguisher','HCFC 123','Portable','5lbs','','Brand New','2023-02-09',3500,NULL,NULL),(28,'Fire Extinguisher','HCFC 123','Portable','5lbs','','Brand New','2023-02-09',3500,NULL,NULL),(29,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',2500,NULL,NULL),(30,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',2500,NULL,NULL),(31,'Fire Extinguisher','AFFF','Portable','5lbs','','Brand New','2023-02-09',2500,NULL,NULL),(32,'FDAS','FIRE HOSE CABINET','','','TESTING FIRE HOSE CABINET DESCRIPTION','',NULL,6500,NULL,NULL),(33,'FDAS','FIRE HOSE CABINET','','','TESTED FIRE HOSE CABINET DESCRIPTION','',NULL,7500,NULL,NULL);
/*!40000 ALTER TABLE `tblitems` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-02-23 11:40:31
