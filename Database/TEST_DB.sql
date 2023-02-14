CREATE DATABASE  IF NOT EXISTS `hein_benutzerverwaltung` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_as_cs */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hein_benutzerverwaltung`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hein_benutzerverwaltung
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `personen`
--

DROP TABLE IF EXISTS `personen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personen` (
  `id_person` int NOT NULL AUTO_INCREMENT,
  `vorname` varchar(100) COLLATE utf8mb4_0900_as_cs NOT NULL,
  `nachname` varchar(100) COLLATE utf8mb4_0900_as_cs NOT NULL,
  `name` varchar(200) COLLATE utf8mb4_0900_as_cs GENERATED ALWAYS AS (concat_ws(_utf8mb4', ',`nachname`,`vorname`)) STORED,
  PRIMARY KEY (`id_person`),
  UNIQUE KEY `vorname_UNIQUE` (`vorname`),
  UNIQUE KEY `nachname_UNIQUE` (`nachname`),
  UNIQUE KEY `id_UNIQUE` (`id_person`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_as_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personen`
--

LOCK TABLES `personen` WRITE;
/*!40000 ALTER TABLE `personen` DISABLE KEYS */;
INSERT INTO `personen` (`id_person`, `vorname`, `nachname`) VALUES (1,'Gabriel','Roth'),(2,'Romy','Martz'),(3,'Fynn','Lenz');
/*!40000 ALTER TABLE `personen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requests`
--

DROP TABLE IF EXISTS `requests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requests` (
  `id_request` int NOT NULL AUTO_INCREMENT,
  `id_person` varchar(100) COLLATE utf8mb4_0900_as_cs NOT NULL,
  `id_rolle` varchar(100) COLLATE utf8mb4_0900_as_cs NOT NULL,
  `grund` varchar(300) COLLATE utf8mb4_0900_as_cs NOT NULL,
  PRIMARY KEY (`id_request`),
  UNIQUE KEY `id_requests_UNIQUE` (`id_request`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_as_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requests`
--

LOCK TABLES `requests` WRITE;
/*!40000 ALTER TABLE `requests` DISABLE KEYS */;
INSERT INTO `requests` VALUES (1,'2','1','TEST: Annehmen'),(2,'3','3','TEST: Ablehnen');
/*!40000 ALTER TABLE `requests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rollen`
--

DROP TABLE IF EXISTS `rollen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rollen` (
  `id_rolle` int NOT NULL AUTO_INCREMENT,
  `bezeichnung` varchar(100) COLLATE utf8mb4_0900_as_cs NOT NULL,
  PRIMARY KEY (`id_rolle`),
  UNIQUE KEY `idrollen_UNIQUE` (`id_rolle`),
  UNIQUE KEY `bezeichnung_UNIQUE` (`bezeichnung`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_as_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rollen`
--

LOCK TABLES `rollen` WRITE;
/*!40000 ALTER TABLE `rollen` DISABLE KEYS */;
INSERT INTO `rollen` VALUES (1,'Admin'),(2,'Lehrer'),(3,'Schüler');
/*!40000 ALTER TABLE `rollen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zuweisungen`
--

DROP TABLE IF EXISTS `zuweisungen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zuweisungen` (
  `id_zuweisung` int NOT NULL AUTO_INCREMENT,
  `id_person` int NOT NULL,
  `id_rolle` int NOT NULL,
  PRIMARY KEY (`id_zuweisung`),
  UNIQUE KEY `id_zuweisung_UNIQUE` (`id_zuweisung`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_cs_0900_as_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zuweisungen`
--

LOCK TABLES `zuweisungen` WRITE;
/*!40000 ALTER TABLE `zuweisungen` DISABLE KEYS */;
INSERT INTO `zuweisungen` VALUES (1,2,3),(2,1,1),(3,3,1),(4,1,3),(5,3,2);
/*!40000 ALTER TABLE `zuweisungen` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-02-12 15:47:12
