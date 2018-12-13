-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: metani
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hasil_tani`
--

DROP TABLE IF EXISTS `hasil_tani`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hasil_tani` (
  `id_hasil` int(11) NOT NULL AUTO_INCREMENT,
  `id_jenistani` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `id_lokasi` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_hasil`),
  KEY `id_jenistani` (`id_jenistani`),
  KEY `id_hasil` (`id_hasil`,`id_jenistani`,`jumlah`,`id_lokasi`),
  KEY `id_lokasi` (`id_lokasi`),
  CONSTRAINT `hasil_tani_ibfk_1` FOREIGN KEY (`id_jenistani`) REFERENCES `jenis_tani` (`id_jenistani`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `hasil_tani_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `lokasi` (`id_lokasi`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hasil_tani`
--

LOCK TABLES `hasil_tani` WRITE;
/*!40000 ALTER TABLE `hasil_tani` DISABLE KEYS */;
/*!40000 ALTER TABLE `hasil_tani` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jenis_tanah`
--

DROP TABLE IF EXISTS `jenis_tanah`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `jenis_tanah` (
  `id_jenistanah` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jenistanah` varchar(100) NOT NULL,
  PRIMARY KEY (`id_jenistanah`),
  KEY `id_jenistanah` (`id_jenistanah`,`nama_jenistanah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jenis_tanah`
--

LOCK TABLES `jenis_tanah` WRITE;
/*!40000 ALTER TABLE `jenis_tanah` DISABLE KEYS */;
/*!40000 ALTER TABLE `jenis_tanah` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jenis_tani`
--

DROP TABLE IF EXISTS `jenis_tani`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `jenis_tani` (
  `id_jenistani` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jenistani` varchar(100) NOT NULL,
  PRIMARY KEY (`id_jenistani`),
  KEY `id_jenistani` (`id_jenistani`,`nama_jenistani`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jenis_tani`
--

LOCK TABLES `jenis_tani` WRITE;
/*!40000 ALTER TABLE `jenis_tani` DISABLE KEYS */;
INSERT INTO `jenis_tani` VALUES (2,'kelapa'),(3,'jagung');
/*!40000 ALTER TABLE `jenis_tani` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lokasi`
--

DROP TABLE IF EXISTS `lokasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lokasi` (
  `id_lokasi` int(11) NOT NULL AUTO_INCREMENT,
  `kecamatan` varchar(100) NOT NULL,
  `kabupaten` varchar(100) NOT NULL,
  `provinsi` varchar(100) NOT NULL,
  `kode_pos` int(11) NOT NULL,
  `latitude` decimal(10,6) NOT NULL,
  `longtitude` decimal(10,6) NOT NULL,
  PRIMARY KEY (`id_lokasi`),
  KEY `id_lokasi` (`id_lokasi`,`kecamatan`,`kabupaten`,`provinsi`,`kode_pos`,`latitude`,`longtitude`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lokasi`
--

LOCK TABLES `lokasi` WRITE;
/*!40000 ALTER TABLE `lokasi` DISABLE KEYS */;
/*!40000 ALTER TABLE `lokasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tanah`
--

DROP TABLE IF EXISTS `tanah`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tanah` (
  `id_tanah` int(11) NOT NULL AUTO_INCREMENT,
  `id_lokasi` int(11) NOT NULL,
  `id_jenistanah` int(11) NOT NULL,
  `luas_tanah` int(11) NOT NULL,
  `suhu` int(11) NOT NULL,
  PRIMARY KEY (`id_tanah`),
  KEY `id_tanah` (`id_tanah`,`id_lokasi`,`id_jenistanah`,`luas_tanah`,`suhu`),
  KEY `id_lokasi` (`id_lokasi`),
  KEY `id_jenistanah` (`id_jenistanah`),
  CONSTRAINT `tanah_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `lokasi` (`id_lokasi`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tanah_ibfk_3` FOREIGN KEY (`id_jenistanah`) REFERENCES `jenis_tanah` (`id_jenistanah`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tanah`
--

LOCK TABLES `tanah` WRITE;
/*!40000 ALTER TABLE `tanah` DISABLE KEYS */;
/*!40000 ALTER TABLE `tanah` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-13 20:55:01
