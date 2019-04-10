CREATE DATABASE QLCC;

CREATE TABLE danh_sach_yeu_cau (
  `STT` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Tenyeucau` varchar(45) NOT NULL,
  `Bieumau` varchar(45) DEFAULT NULL,
  `Quydinh` varchar(45) DEFAULT NULL,
  `Ghichu` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`STT`),
  UNIQUE KEY `Tenyeucau_UNIQUE` (`Tenyeucau`),
  UNIQUE KEY `STT_UNIQUE` (`STT`)
);

CREATE TABLE Input1 #Bieu mau 1
(
  `Macay` int(10) unsigned NOT NULL,
  `Ten` varchar(45) NOT NULL,
  `Loaicay` varchar(45) DEFAULT NULL,
  `Vitri` varchar(45) DEFAULT NULL,
  `Ngaytrong` datetime NOT NULL,
  `Bieumau` varchar(3) default 'BM1',
  PRIMARY KEY (`Macay`),
  UNIQUE KEY `Macay_UNIQUE` (`Macay`),
  UNIQUE KEY `STT_UNIQUE` (`STT`),
  UNIQUE KEY `Ten_UNIQUE` (`Ten`),
  
  FOREIGN KEY (`Loaicay`) REFERENCES Species(`ID`),
  FOREIGN KEY (`Vitri`) REFERENCES Location(`ID`)
);

CREATE TABLE Species #loai cay canh (co 2 loai)
(
	`ID` int(1) unsigned NOT NULL AUTO_INCREMENT,
	`Loaicay` varchar(45) DEFAULT NULL,
    PRIMARY KEY (`ID`)
);
INSERT INTO Species(`Loaicay`) VALUES(`Can anh sang`);
INSERT INTO Species(`Loaicay`) VALUES(`Bong ram`);

CREATE TABLE Location #Vi tri cay canh (co 3 vi tri)
(
	`ID` int(1) unsigned NOT NULL,
    `Vitri` varchar(45) DEFAULT NULL,
    #`Socay` int(1) unsigned DEFAULT 0, #SO CAY 1 vi tri (max 4)
    PRIMARY KEY (`ID`)
);
INSERT INTO Location(`Vitri`) VALUES(`Ban cong`);
INSERT INTO Location(`Vitri`) VALUES(`Cua so`);
INSERT INTO Location(`Vitri`) VALUES(`Truoc cong`);



CREATE TABLE lich_cham_soc 
(
  `STT` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Caycanh` varchar(45) DEFAULT NULL,
  `Thoigian` datetime DEFAULT NULL,
  `Vattu` int(1) DEFAULT NULL,
  `Donvitinh` int(1) DEFAULT NULL,
  `Soluong` int(11) DEFAULT NULL,
  `Bieumau` varchar(45) DEFAULT 'BM2',
  PRIMARY KEY (`STT`),
  UNIQUE KEY `STT_UNIQUE` (`STT`),
  
  FOREIGN KEY (`Vattu`) REFERENCES Supplies(`ID`),
  FOREIGN KEY (`Donvitinh`) REFERENCES Unit(`ID`)
);

CREATE TABLE Supplies #Vat tu 
(
	`ID` int(1) unsigned NOT NULL AUTO_INCREMENT,
    `Vattu` varchar(10) DEFAULT NULL,
    PRIMARY KEY (`ID`)
);
INSERT INTO Supllies(`Vattu`) VALUES (`Nuoc`);
INSERT INTO Supllies(`Vattu`) VALUES (`Phan dam`);

CREATE TABLE Unit #Don vi tinh
(
	`ID` int(1) unsigned NOT NULL AUTO_INCREMENT,
    `Donvitinh` varchar(3) DEFAULT NULL,
    PRIMARY KEY (`ID`)
);
INSERT INTO Unit(`Donvitinh`) VALUES (`lit`);
INSERT INTO Unit(`Donvitinh`) VALUES (`gam`);



CREATE TABLE ListTree #danh sach cay canh
( 
    `STT` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    `Caycanh` VARCHAR(45) DEFAULT NULL,
    `Loai` VARCHAR(45) DEFAULT NULL,
    `Vitri` VARCHAR(45) DEFAULT NULL,
    `Tinhtrang` VARCHAR(45) DEFAULT NULL,
    `Bieumau` VARCHAR(4) DEFAULT 'BM3',
    PRIMARY KEY (`STT`),
    UNIQUE KEY `STT_UNIQUE` (`STT`)
);

CREATE TABLE phieu_mua_vat_tu (
	`STT` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    `Vattu` VARCHAR(45) DEFAULT NULL,
    `Diachimua` VARCHAR(45) DEFAULT NULL,
    `Ngaymua` DATETIME DEFAULT NULL,
    `Donvi` VARCHAR(45) DEFAULT NULL,
    `Soluong` INT(10) DEFAULT 0,
    `Sotien` INT(10) DEFAULT 0, #max 100.000VND
    `Bieumau` VARCHAR(4) DEFAULT 'BM4',
    PRIMARY KEY (`STT`),
    UNIQUE KEY `STT_UNIQUE` (`STT`)
);
    

CREATE TABLE bao_cao_chi_phi_cham_soc (
	`STT` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    `Thang` INT(10) DEFAULT NULL,
    `Vattu` VARCHAR(45) DEFAULT NULL,
    `Sophieumua` INT(10) DEFAULT 0,
    `Tonggiatri` INT(10) DEFAULT 0,
    `Tyle` INT(10) DEFAULT NULL,
    `Bieumau` VARCHAR(4) DEFAULT 'BM5',
    PRIMARY KEY (`STT`),
    UNIQUE KEY `STT_UNIQUE` (`STT`)
);

CREATE TABLE bao_cao_tinh_trang_cay_canh(
	`STT` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    `Thang` INT(10) DEFAULT NULL,
    `Caycanh` VARCHAR(45) DEFAULT NULL,
    `Loai` VARCHAR(45) DEFAULT NULL,
    `Caytrong` VARCHAR(45) DEFAULT NULL,
    `Tinhtrang` VARCHAR(45) DEFAULT NULL,
    `Bieumau` VARCHAR(4) DEFAULT 'BM5',
    PRIMARY KEY (`STT`),
    UNIQUE KEY `STT_UNIQUE` (`STT`)
);




