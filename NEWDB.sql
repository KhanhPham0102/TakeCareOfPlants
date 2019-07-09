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
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caycanh`
--

LOCK TABLES `caycanh` WRITE;
/*!40000 ALTER TABLE `caycanh` DISABLE KEYS */;
INSERT INTO `caycanh` VALUES (34,'12412412412',2,2,'2019-05-16'),(35,'12412412412',2,2,'2019-05-14'),(36,'12412412412',2,2,'2019-05-30');
/*!40000 ALTER TABLE `caycanh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caycanh_lich`
--

DROP TABLE IF EXISTS `caycanh_lich`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `caycanh_lich` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IDLich` int(10) unsigned NOT NULL,
  `IDCayCanh` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CC_LCS_ID_idx` (`IDLich`),
  KEY `LCS_CC_ID_idx` (`IDCayCanh`),
  CONSTRAINT `CC_LCS_ID` FOREIGN KEY (`IDLich`) REFERENCES `lich` (`ID`),
  CONSTRAINT `LCS_CC_ID` FOREIGN KEY (`IDCayCanh`) REFERENCES `caycanh` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caycanh_lich`
--

LOCK TABLES `caycanh_lich` WRITE;
/*!40000 ALTER TABLE `caycanh_lich` DISABLE KEYS */;
/*!40000 ALTER TABLE `caycanh_lich` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caycanh_vitri`
--

LOCK TABLES `caycanh_vitri` WRITE;
/*!40000 ALTER TABLE `caycanh_vitri` DISABLE KEYS */;
INSERT INTO `caycanh_vitri` VALUES (61,34,1),(62,35,1),(63,36,1);
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donvi`
--

LOCK TABLES `donvi` WRITE;
/*!40000 ALTER TABLE `donvi` DISABLE KEYS */;
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
  `ThoiGian` datetime NOT NULL,
  `GhiChu` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lich`
--

LOCK TABLES `lich` WRITE;
/*!40000 ALTER TABLE `lich` DISABLE KEYS */;
INSERT INTO `lich` VALUES (1,'0000-00-00','0000-00-00 00:00:00',NULL),(2,'0000-00-00','0000-00-00 00:00:00',NULL),(3,'0000-00-00','0000-00-00 00:00:00',NULL),(4,'0000-00-00','0000-00-00 00:00:00',NULL),(5,'0000-00-00','0000-00-00 00:00:00',NULL);
/*!40000 ALTER TABLE `lich` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lich_vattu`
--

DROP TABLE IF EXISTS `lich_vattu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lich_vattu` (
  `ID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `IDLich` int(11) unsigned NOT NULL,
  `IDVatTu` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `LCS_VT_ID_idx` (`IDLich`),
  KEY `VT_LCS_ID_idx` (`IDVatTu`),
  CONSTRAINT `LCS_VT_ID` FOREIGN KEY (`IDLich`) REFERENCES `lich` (`ID`),
  CONSTRAINT `VT_LCS_ID` FOREIGN KEY (`IDVatTu`) REFERENCES `vattu` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lich_vattu`
--

LOCK TABLES `lich_vattu` WRITE;
/*!40000 ALTER TABLE `lich_vattu` DISABLE KEYS */;
/*!40000 ALTER TABLE `lich_vattu` ENABLE KEYS */;
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
  `MatKhau_Salt` varchar(1000) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `STT` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (7,'Khanh123','lTillURIr0kjWnDxhQ2bcQ==','QRUC5Q2GE/X9vc/e6SNUh/NSEnrZXlH2GnQxk9VqRLYUXyDz4qPDhvzHPFuf+HwWDeA8ZKmgiv36vUYJz0nkT93RuztNmN40b4QucfmOCP4YC2CGbuFfdXxKuGpllEsnQUWw6Q=='),(9,'Khanhahahah','0nrsCHoijLZDM3xW5mEiVA==','ABlCkETjUcWKVITC32JvWRu8OAEllR5BBse70Hcmq98Rn33muTLgedgz3AlfxCB83GMxIVpwSObRKS50WaVRUwC1igr1+hloNEVUqZVLeV4xvwA9QJWMJByBh3BbtgK8vEAjMA=='),(10,'Khanh123+','fWvBBzUWLdGfI3TBSGdOsQ==','aoyLPGkm9xVWcK590m2lW8S3jwtQydouabuQXvZsNb7n60VJm/TwHbFBOK0RqsHl5v2PoCxeKz1/3oCFAbBpmqWREmLMr6o7QTV85wwmIBIHxMfVRakUbtMCMhRkm4U257ZDwg=='),(11,'Khanh1234','zfRgNuK9OLT/7pEotuxSog==','QLiX4c7vJBVkIPcyli6ivGXLlJuLoWHWpuFvdhlIcJg6qQSFUoxhlf91lRKyEYEqDGdqYRVdlPu9eim7/HDSJ/tGdVxRsKANy+6da5L2+NS7wmwPchvYtIm7XA/xlUvFeZSDIw==');
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
  `SoLuong` int(10) DEFAULT '0',
  `SoTien` int(10) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `muavattu`
--

LOCK TABLES `muavattu` WRITE;
/*!40000 ALTER TABLE `muavattu` DISABLE KEYS */;
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
  `SoCayToiDa` int(10) NOT NULL DEFAULT '4',
  `SoLoaiVatTu` int(100) NOT NULL DEFAULT '2',
  `SoTienToiDa` bigint(1) NOT NULL DEFAULT '100000',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `STT` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quydinh`
--

LOCK TABLES `quydinh` WRITE;
/*!40000 ALTER TABLE `quydinh` DISABLE KEYS */;
INSERT INTO `quydinh` VALUES (1,4,2,100000),(5,5,3,150000),(6,7,6,300000);
/*!40000 ALTER TABLE `quydinh` ENABLE KEYS */;
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
  `SoLuong` int(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `VT_DV_ID_idx` (`IDDonVi`),
  CONSTRAINT `VT_DV_ID` FOREIGN KEY (`IDDonVi`) REFERENCES `donvi` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vattu`
--

LOCK TABLES `vattu` WRITE;
/*!40000 ALTER TABLE `vattu` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  KEY `VT_MVT_ID_idx` (`IDVatTu`),
  KEY `MVT_VT_ID_idx` (`IDMuaVatTu`),
  CONSTRAINT `MVT_VT_ID` FOREIGN KEY (`IDMuaVatTu`) REFERENCES `muavattu` (`ID`),
  CONSTRAINT `VT_MVT_ID` FOREIGN KEY (`IDVatTu`) REFERENCES `vattu` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vattu_muavattu`
--

LOCK TABLES `vattu_muavattu` WRITE;
/*!40000 ALTER TABLE `vattu_muavattu` DISABLE KEYS */;
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vitri`
--

LOCK TABLES `vitri` WRITE;
/*!40000 ALTER TABLE `vitri` DISABLE KEYS */;
INSERT INTO `vitri` VALUES (1,'Ban Công'),(2,'Cửu Sổ'),(3,'Trước Cổng');
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

-- Dump completed on 2019-06-06  3:56:22
