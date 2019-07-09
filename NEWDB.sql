-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: dbqlcc
-- ------------------------------------------------------
-- Server version	8.0.16

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
-- Table structure for table `caycanh`
--

DROP TABLE IF EXISTS `caycanh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `caycanh` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TenCay` varchar(45) NOT NULL,
  `IDLoai` int(10) unsigned NOT NULL,
  `IDTinhTrang` int(10) unsigned NOT NULL,
  `NgayTrong` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CC_LC_ID_idx` (`IDLoai`),
  KEY `CC_TT_ID_idx` (`IDTinhTrang`),
  CONSTRAINT `CC_LC_ID` FOREIGN KEY (`IDLoai`) REFERENCES `loaicaycanh` (`ID`),
  CONSTRAINT `CC_TT_ID` FOREIGN KEY (`IDTinhTrang`) REFERENCES `tinhtrang` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caycanh`
--

LOCK TABLES `caycanh` WRITE;
/*!40000 ALTER TABLE `caycanh` DISABLE KEYS */;
INSERT INTO `caycanh` VALUES (34,'12412412412',2,2,'2019-05-16'),(35,'12412412412',2,2,'2019-05-14'),(36,'12412412412',2,2,'2019-05-30'),(50,'sfsafa',1,3,'2019-05-22'),(55,'213131',1,3,'2019-05-21'),(57,'21421412',1,3,'2019-05-21'),(58,'hfdhdfh',1,3,'2019-07-02'),(59,'fhdhdfh',1,1,'2019-07-02'),(60,'fgjgfjfj',2,3,'2019-07-02'),(61,'gdgdg',1,2,'2019-07-02'),(62,'gjgj',2,3,'2019-07-02'),(63,'jgkfgkfgk',2,1,'2019-07-02'),(64,'bzxzxb',1,2,'2019-07-02'),(65,'asgasg',1,3,'2019-07-02'),(66,'sgasg',2,3,'2019-07-04'),(67,'dsgsdgdsg',2,1,'2019-07-04'),(68,'safasfsaf',1,2,'2019-07-04'),(69,'asfaf',2,2,'2019-07-04'),(70,'kkhanahanah',2,2,'2019-07-06'),(71,'jkbkjv',1,3,'2019-07-06'),(72,'sdgsdg',2,4,'2019-07-06'),(73,'dafas',1,3,'2019-07-06'),(74,'sfafasf',2,3,'2019-07-06'),(75,'zvxvzxv',1,2,'2019-07-06'),(76,'svsdvds',2,2,'2019-07-06'),(77,'phuong',1,1,'2019-07-06'),(78,'hoe',2,1,'2019-07-06'),(80,'asfas',1,2,'2019-07-06'),(82,'asfsalkfjaslk',1,2,'2019-07-06'),(83,'asfsalkfjaslk',1,2,'2019-07-06'),(84,'asfsalkfjaslk',1,2,'2019-07-06'),(85,'asfsalkfjaslk',1,2,'2019-07-06'),(86,'asfsalkfjaslk',1,2,'2019-07-06'),(87,'asfsalkfjaslk',1,2,'2019-07-06');
/*!40000 ALTER TABLE `caycanh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caycanh_vitri`
--

DROP TABLE IF EXISTS `caycanh_vitri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `caycanh_vitri` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IDCayCanh` int(10) unsigned NOT NULL,
  `IDViTri` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `VT_CC_ID_idx` (`IDViTri`),
  KEY `CC_VT_ID_idx` (`IDCayCanh`),
  CONSTRAINT `CC_VT_ID` FOREIGN KEY (`IDCayCanh`) REFERENCES `caycanh` (`ID`),
  CONSTRAINT `VT_CC_ID` FOREIGN KEY (`IDViTri`) REFERENCES `vitri` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caycanh_vitri`
--

LOCK TABLES `caycanh_vitri` WRITE;
/*!40000 ALTER TABLE `caycanh_vitri` DISABLE KEYS */;
INSERT INTO `caycanh_vitri` VALUES (61,34,1),(62,35,1),(63,36,1),(65,50,2),(66,55,2),(67,57,1),(75,67,2),(76,68,3),(77,69,2),(78,70,2),(79,71,2),(80,72,3),(81,73,3),(82,74,2),(83,75,3),(84,76,3),(85,77,3),(86,78,3),(88,80,1),(90,82,3),(91,83,3),(92,84,3),(93,85,3),(94,86,3),(95,87,3);
/*!40000 ALTER TABLE `caycanh_vitri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donvi`
--

DROP TABLE IF EXISTS `donvi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `donvi` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `DonVi` varchar(45) NOT NULL DEFAULT 'lit',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donvi`
--

LOCK TABLES `donvi` WRITE;
/*!40000 ALTER TABLE `donvi` DISABLE KEYS */;
INSERT INTO `donvi` VALUES (1,'Lit'),(2,'Gram'),(3,'sdf');
/*!40000 ALTER TABLE `donvi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lich`
--

DROP TABLE IF EXISTS `lich`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lich` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NgayLapLich` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lich`
--

LOCK TABLES `lich` WRITE;
/*!40000 ALTER TABLE `lich` DISABLE KEYS */;
INSERT INTO `lich` VALUES (22,'2017-06-15'),(23,'2017-06-16'),(24,'2017-06-17'),(25,'2017-06-18'),(27,'2017-06-22'),(28,'2019-07-05'),(29,'2019-07-06');
/*!40000 ALTER TABLE `lich` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lich_thoigian_caycanh`
--

DROP TABLE IF EXISTS `lich_thoigian_caycanh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lich_thoigian_caycanh` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IDLich` int(10) unsigned NOT NULL,
  `IDThoiGian` int(10) unsigned NOT NULL,
  `IDCayCanh` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `LCS_CC_ID_idx` (`IDCayCanh`),
  KEY `CC_TG_ID_idx` (`IDThoiGian`),
  KEY `TG_CC_L_ID_idx` (`IDLich`),
  CONSTRAINT `CC_TG_ID` FOREIGN KEY (`IDThoiGian`) REFERENCES `thoigian` (`ID`),
  CONSTRAINT `TG_CC_ID` FOREIGN KEY (`IDCayCanh`) REFERENCES `caycanh` (`ID`),
  CONSTRAINT `TG_CC_L_ID` FOREIGN KEY (`IDLich`) REFERENCES `lich` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lich_thoigian_caycanh`
--

LOCK TABLES `lich_thoigian_caycanh` WRITE;
/*!40000 ALTER TABLE `lich_thoigian_caycanh` DISABLE KEYS */;
INSERT INTO `lich_thoigian_caycanh` VALUES (36,22,1,34),(37,22,3,35),(38,23,4,60),(39,23,3,55),(40,23,1,58),(41,24,4,64),(42,24,2,55),(43,25,1,60),(44,25,2,34),(45,25,3,36),(47,28,9,34),(48,28,9,36),(49,29,12,50),(50,29,12,55),(51,29,12,34),(52,29,12,35),(53,29,12,50),(54,29,12,50),(55,29,12,55),(56,29,12,55),(57,29,12,57),(58,29,13,34),(59,29,13,35),(60,29,13,35),(61,29,13,50),(62,29,13,50),(63,29,13,55),(64,29,13,55),(65,29,13,57),(66,29,14,34),(67,29,14,36),(68,29,14,50),(69,29,15,78),(70,29,16,34),(71,29,16,50),(72,29,16,57),(73,29,16,68),(74,29,16,72),(75,29,16,75);
/*!40000 ALTER TABLE `lich_thoigian_caycanh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lich_thoigian_vattu`
--

DROP TABLE IF EXISTS `lich_thoigian_vattu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lich_thoigian_vattu` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IDLich` int(11) unsigned NOT NULL,
  `IDThoiGian` int(11) unsigned NOT NULL,
  `IDVatTu` int(10) unsigned NOT NULL,
  `SoLuong` int(11) NOT NULL,
  `GhiChu` varchar(1000) DEFAULT '',
  PRIMARY KEY (`ID`),
  KEY `L_TG_ID_idx` (`IDThoiGian`),
  KEY `TG_L_ID_idx` (`IDLich`),
  KEY `VT_VT_ID_idx` (`IDVatTu`),
  CONSTRAINT `L_L_ID` FOREIGN KEY (`IDLich`) REFERENCES `lich` (`ID`),
  CONSTRAINT `TG_TG_ID` FOREIGN KEY (`IDThoiGian`) REFERENCES `thoigian` (`ID`),
  CONSTRAINT `VT_VT_ID` FOREIGN KEY (`IDVatTu`) REFERENCES `vattu` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lich_thoigian_vattu`
--

LOCK TABLES `lich_thoigian_vattu` WRITE;
/*!40000 ALTER TABLE `lich_thoigian_vattu` DISABLE KEYS */;
INSERT INTO `lich_thoigian_vattu` VALUES (13,22,1,3,2,''),(14,22,1,4,3,''),(15,22,2,3,5,''),(16,22,2,4,4,''),(17,23,1,3,6,''),(18,24,2,3,5,''),(19,25,1,3,1,''),(20,28,9,3,123,''),(21,28,9,4,153153,''),(22,29,10,3,123123,''),(23,29,10,4,21312,''),(24,29,12,3,12313,''),(25,29,12,4,213123,''),(26,29,12,3,222,'safasfasfaf'),(27,29,12,4,2222,'safasfasfaf'),(28,29,13,4,2,''),(29,29,14,3,53,''),(30,29,14,4,34,''),(31,29,15,3,6,'13142341234wdfadfsdf'),(32,29,15,4,6,'13142341234wdfadfsdf'),(33,29,16,3,20,''),(34,29,16,4,30,'');
/*!40000 ALTER TABLE `lich_thoigian_vattu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loaicaycanh`
--

DROP TABLE IF EXISTS `loaicaycanh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `loaicaycanh` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Loai` varchar(45) DEFAULT 'Anh Sang',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loaicaycanh`
--

LOCK TABLES `loaicaycanh` WRITE;
/*!40000 ALTER TABLE `loaicaycanh` DISABLE KEYS */;
INSERT INTO `loaicaycanh` VALUES (1,'Ánh Sáng'),(2,'Bóng Râm');
/*!40000 ALTER TABLE `loaicaycanh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `login` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TaiKhoan` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `MatKhau_Hash` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `MatKhau_Salt` varchar(1000) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `STT` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (7,'Khanh123','lTillURIr0kjWnDxhQ2bcQ==','QRUC5Q2GE/X9vc/e6SNUh/NSEnrZXlH2GnQxk9VqRLYUXyDz4qPDhvzHPFuf+HwWDeA8ZKmgiv36vUYJz0nkT93RuztNmN40b4QucfmOCP4YC2CGbuFfdXxKuGpllEsnQUWw6Q=='),(10,'Khanh123+','fWvBBzUWLdGfI3TBSGdOsQ==','aoyLPGkm9xVWcK590m2lW8S3jwtQydouabuQXvZsNb7n60VJm/TwHbFBOK0RqsHl5v2PoCxeKz1/3oCFAbBpmqWREmLMr6o7QTV85wwmIBIHxMfVRakUbtMCMhRkm4U257ZDwg=='),(15,'Kanahha','saupsUDK62fY5qeXLUgROQ==','gPKXXRXiD3VTr+d7lqU1K0xfyy+3A97UcQ6UyWExW618iXwrUL+mFP1kUWC/K4ncmxBSqejjz8Y4WCJU8QLwZ0Gop/Rt/q+Vs980cFDAo1BezqALYrwefNaTGyV6QHgNkEKxRA==');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `muavattu`
--

DROP TABLE IF EXISTS `muavattu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `muavattu` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `DiaChi` varchar(45) NOT NULL,
  `NgayMua` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `muavattu`
--

LOCK TABLES `muavattu` WRITE;
/*!40000 ALTER TABLE `muavattu` DISABLE KEYS */;
INSERT INTO `muavattu` VALUES (1,'23 Võ Văn Ngân','2018-05-15'),(2,'90 Hoàng Văn Thụ','2017-06-15'),(3,'23 Võ Văn Ngân','2017-06-01'),(4,'2 Trường Chinh','2019-08-28'),(5,'22/2 Lê Quý Đôn','2017-03-04'),(6,'23 Võ Văn Ngân','2017-03-01'),(7,'22/2 Lê Quý Đôn','2017-05-04'),(8,'90 Hoàng Văn Thụ','2017-06-09'),(9,'2 Trường Chinh','2017-12-09');
/*!40000 ALTER TABLE `muavattu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quydinh`
--

DROP TABLE IF EXISTS `quydinh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `quydinh` (
  `ID` int(1) unsigned NOT NULL AUTO_INCREMENT,
  `SoLoaiVatTu` int(100) NOT NULL DEFAULT '2',
  `SoTienToiDa` bigint(1) NOT NULL DEFAULT '100000',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `STT` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quydinh`
--

LOCK TABLES `quydinh` WRITE;
/*!40000 ALTER TABLE `quydinh` DISABLE KEYS */;
INSERT INTO `quydinh` VALUES (1,2,100000),(2,4,100000);
/*!40000 ALTER TABLE `quydinh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thoigian`
--

DROP TABLE IF EXISTS `thoigian`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `thoigian` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ThoiGian` time NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thoigian`
--

LOCK TABLES `thoigian` WRITE;
/*!40000 ALTER TABLE `thoigian` DISABLE KEYS */;
INSERT INTO `thoigian` VALUES (1,'09:34:21'),(2,'09:35:21'),(3,'09:36:21'),(4,'09:37:21'),(5,'07:04:21'),(6,'07:05:59'),(7,'07:08:05'),(8,'07:09:21'),(9,'07:12:41'),(10,'11:02:12'),(11,'11:03:23'),(12,'11:05:47'),(13,'15:06:31'),(14,'14:27:58'),(15,'15:47:30'),(16,'15:30:23');
/*!40000 ALTER TABLE `thoigian` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tinhtrang`
--

DROP TABLE IF EXISTS `tinhtrang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tinhtrang` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TinhTrang` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tinhtrang`
--

LOCK TABLES `tinhtrang` WRITE;
/*!40000 ALTER TABLE `tinhtrang` DISABLE KEYS */;
INSERT INTO `tinhtrang` VALUES (1,'Mới'),(2,'Cũ'),(3,'Thiếu Nước'),(4,'Thiếu Phân');
/*!40000 ALTER TABLE `tinhtrang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vattu`
--

DROP TABLE IF EXISTS `vattu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vattu` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `VatTu` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `IDDonVi` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `VT_DV_ID_idx` (`IDDonVi`),
  CONSTRAINT `VT_DV_ID` FOREIGN KEY (`IDDonVi`) REFERENCES `donvi` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vattu`
--

LOCK TABLES `vattu` WRITE;
/*!40000 ALTER TABLE `vattu` DISABLE KEYS */;
INSERT INTO `vattu` VALUES (3,'Phan',2),(4,'Nuoc',1);
/*!40000 ALTER TABLE `vattu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vattu_muavattu`
--

DROP TABLE IF EXISTS `vattu_muavattu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vattu_muavattu` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IDVatTu` int(10) unsigned NOT NULL,
  `IDMuaVatTu` int(10) unsigned NOT NULL,
  `SoLuong` int(11) NOT NULL DEFAULT '0',
  `SoTien` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `VT_MVT_ID_idx` (`IDVatTu`),
  KEY `MVT_VT_ID_idx` (`IDMuaVatTu`),
  CONSTRAINT `MVT_VT_ID` FOREIGN KEY (`IDMuaVatTu`) REFERENCES `muavattu` (`ID`),
  CONSTRAINT `VT_MVT_ID` FOREIGN KEY (`IDVatTu`) REFERENCES `vattu` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vattu_muavattu`
--

LOCK TABLES `vattu_muavattu` WRITE;
/*!40000 ALTER TABLE `vattu_muavattu` DISABLE KEYS */;
INSERT INTO `vattu_muavattu` VALUES (1,3,1,20,20000),(2,4,1,23,230000),(3,3,2,10,500000),(4,4,4,15,300000),(5,4,3,15,280000),(6,3,5,30,90000),(7,3,6,100,150000),(8,4,7,50,400000),(9,3,8,10,40000),(10,4,8,10,100000),(11,4,9,5,45000);
/*!40000 ALTER TABLE `vattu_muavattu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vitri`
--

DROP TABLE IF EXISTS `vitri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vitri` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TenViTri` varchar(50) NOT NULL,
  `SoCayToiDa` int(10) NOT NULL DEFAULT '4',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vitri`
--

LOCK TABLES `vitri` WRITE;
/*!40000 ALTER TABLE `vitri` DISABLE KEYS */;
INSERT INTO `vitri` VALUES (1,'Ban Công',10),(2,'Cửu Sổ',7),(3,'Trước Cổng',30);
/*!40000 ALTER TABLE `vitri` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-07-10  1:53:13
