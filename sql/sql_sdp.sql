-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sdp_datebase
-- ------------------------------------------------------
-- Server version	5.7.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attract_price`
--

DROP TABLE IF EXISTS `attract_price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attract_price` (
  `AttractName` varchar(45) NOT NULL,
  `Visitor` varchar(12) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  PRIMARY KEY (`AttractName`,`Visitor`),
  CONSTRAINT `fk_ap_attrName` FOREIGN KEY (`AttractName`) REFERENCES `attraction` (`AttractName`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attract_price`
--

LOCK TABLES `attract_price` WRITE;
/*!40000 ALTER TABLE `attract_price` DISABLE KEYS */;
INSERT INTO `attract_price` VALUES ('AdventureCove Waterpark','Adult',200.00),('AdventureCove Waterpark','Child',120.00),('BlueMountain Day Tour','Adult',1000.00),('BlueMountain Day Tour','Child',600.00),('BridgeClimb Experience','Adult',1300.00),('BridgeClimb Experience','Child',800.00),('Disneyland Admission','Adult',300.00),('Disneyland Admission','Child',200.00),('DisneySea Admission','Adult',400.00),('DisneySea Admission','Child',300.00),('MountFuji Lake Ashi','Adult',200.00),('MountFuji Lake Ashi','Child',130.00),('NightSafari Adventure','Adult',350.00),('NightSafari Adventure','Child',260.00),('OperaHouse Guided Working Tour','Adult',200.00),('OperaHouse Guided Working Tour','Child',100.00),('SEAAquarium','Adult',200.00),('SEAAquarium','Child',150.00),('ShrimpFishing Barbecue','Adult',600.00),('ShrimpFishing Barbecue','Child',600.00),('SingaporeZoee Adventure','Adult',300.00),('SingaporeZoee Adventure','Child',160.00),('TaipeiTea Culture Day','Adult',600.00),('TaipeiTea Culture Day','Child',300.00),('TokyoMorning Tour','Adult',350.00),('TokyoMorning Tour','Child',350.00),('TraditionalChinese Performing Arts','Adult',900.00),('TraditionalChinese Performing Arts','Child',900.00),('TraditionalJapanese Performing Arts','Adult',500.00),('TraditionalJapanese Performing Arts','Child',300.00),('UniversalStudios Singapore','Adult',400.00),('UniversalStudios Singapore','Child',300.00),('Yangmingshan National Park','Adult',600.00),('Yangmingshan National Park','Child',400.00);
/*!40000 ALTER TABLE `attract_price` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attraction`
--

DROP TABLE IF EXISTS `attraction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attraction` (
  `AttractName` varchar(45) NOT NULL,
  `Duration` varchar(12) NOT NULL,
  `Cancellation` varchar(12) NOT NULL,
  `AttractPhoto` varchar(25) DEFAULT NULL,
  `City` varchar(12) NOT NULL,
  PRIMARY KEY (`AttractName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attraction`
--

LOCK TABLES `attraction` WRITE;
/*!40000 ALTER TABLE `attraction` DISABLE KEYS */;
INSERT INTO `attraction` VALUES ('AdventureCove Waterpark','1d','Charged','SingaporeZoo','Singapore'),('BlueMountain Day Tour','9h','Free','BridgeClimb','Syndey'),('BridgeClimb Experience','3h30m','Free','AdventureCove','Syndey'),('Disneyland Admission','10h','Free','TokyoMorning','Tokyo'),('DisneySea Admission','10h','Free','TraditionalJapanese','Tokyo'),('MountFuji Lake Ashi','10h30m','Free','TraditionalChinese','Tokyo'),('NightSafari Adventure','4h30m','Free','ShrimpFishing','Singapore'),('OperaHouse Guided Working Tour','1h','Free','BlueMountain','Syndey'),('SEAAquarium','1d','Charged','SEAAquarium','Singapore'),('ShrimpFishing Barbecue','4h30m','Free','MountFuji','Taipei'),('SingaporeZoee Adventure','4h30m','Free','TaipeiTea','Singapore'),('TaipeiTea Culture Day','9h','Free','NightSafari','Taipei'),('TokyoMorning Tour','4h30m','Charged','UniversalStudios','Tokyo'),('TraditionalChinese Performing Arts','1h','Charged','DisneySea','Taipei'),('TraditionalJapanese Performing Arts','2h','Free','Yangmingshan','Tokyo'),('UniversalStudios Singapore','1d','Charged','OperaHouse','Singapore'),('Yangmingshan National Park','9h','Free','Disneyland','Taipei');
/*!40000 ALTER TABLE `attraction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attraction_order`
--

DROP TABLE IF EXISTS `attraction_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attraction_order` (
  `AttractionOrderID` varchar(12) NOT NULL,
  `AttractionName` varchar(45) NOT NULL,
  `AdultNum` int(11) NOT NULL,
  `ChildNum` int(11) NOT NULL,
  `AdultPrice` decimal(12,2) NOT NULL,
  `ChildPrice` decimal(12,2) NOT NULL,
  PRIMARY KEY (`AttractionOrderID`),
  KEY `fk_ao_attrName_idx` (`AttractionName`),
  CONSTRAINT `fk_ao_attrName` FOREIGN KEY (`AttractionName`) REFERENCES `attraction` (`AttractName`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attraction_order`
--

LOCK TABLES `attraction_order` WRITE;
/*!40000 ALTER TABLE `attraction_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `attraction_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrier`
--

DROP TABLE IF EXISTS `carrier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrier` (
  `CID` varchar(12) NOT NULL,
  `CarrierName` varchar(12) NOT NULL,
  `CarrLogo` varchar(25) NOT NULL,
  PRIMARY KEY (`CID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrier`
--

LOCK TABLES `carrier` WRITE;
/*!40000 ALTER TABLE `carrier` DISABLE KEYS */;
INSERT INTO `carrier` VALUES ('c01','中華航空','Carrier1.png'),('c02','長榮航空','Carrier2.png'),('c03','國泰航空','Carrier3.png'),('c04','香港航空','Carrier4.png'),('c05','港龍航空','Carrier5.png'),('c06','全日空航空','Carrier6.png'),('c07','日本航空','Carrier7.png'),('c08','中國東方航空','Carrier8.png'),('c09','新加坡航空','Carrier9.png'),('c10','美國聯合航空','Carrier10.png'),('c11','阿聯酋航空','Carrier11.png'),('c12','泰國國際航空','Carrier12.png');
/*!40000 ALTER TABLE `carrier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `corganizer`
--

DROP TABLE IF EXISTS `corganizer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `corganizer` (
  `OrganID` varchar(12) NOT NULL,
  `OrganizerE` varchar(12) NOT NULL,
  `OrganizerC` varchar(12) NOT NULL,
  PRIMARY KEY (`OrganID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corganizer`
--

LOCK TABLES `corganizer` WRITE;
/*!40000 ALTER TABLE `corganizer` DISABLE KEYS */;
INSERT INTO `corganizer` VALUES ('1','RCCI','皇家加勒比海國際郵輪'),('2','Costa','歌詩達郵輪'),('3','MSC','地中海郵輪'),('4','Star Cruise','麗星郵輪');
/*!40000 ALTER TABLE `corganizer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cruise`
--

DROP TABLE IF EXISTS `cruise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cruise` (
  `CruiseID` varchar(12) NOT NULL,
  `CruiseName` varchar(255) NOT NULL,
  `RefPrice` decimal(12,2) NOT NULL,
  `TourDay` int(11) NOT NULL,
  `OrganID` varchar(12) NOT NULL,
  `Info` varchar(255) DEFAULT NULL,
  `StartDate` datetime NOT NULL,
  PRIMARY KEY (`CruiseID`),
  KEY `fk_cruise_orID_idx` (`OrganID`),
  CONSTRAINT `fk_cruise_orID` FOREIGN KEY (`OrganID`) REFERENCES `corganizer` (`OrganID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cruise`
--

LOCK TABLES `cruise` WRITE;
/*!40000 ALTER TABLE `cruise` DISABLE KEYS */;
INSERT INTO `cruise` VALUES ('EMM10A','地中海郵輪集團~華麗號, 意大利(威尼斯、布林迪西)、, 希臘(卡塔科隆)、土耳其(伊茲密爾、伊斯坦堡)、克羅地亞, 10天豪華郵輪假期',14800.00,10,'3','EMM10A.pdf','2015-08-25 00:00:00'),('HCW85A','2015年全球首個香港啟航環球郵輪, 跨越18個國家及地區，28個目的地，85天環遊世界瑰麗假期',285899.00,85,'2','HCW85A.pdf','2015-08-25 00:00:00'),('HRO08A','香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、中國(廈門)、日本(長崎、沖繩), 8天豪華郵輪假期',8999.00,7,'2','HRO08A.pdf','2015-07-21 00:00:00'),('HRT04A','香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、台灣(高雄)4天豪華郵輪假期',2899.00,4,'1','HRT04A.pdf','2015-07-25 00:00:00'),('HRX06A','香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、中國(廈門)、日本(沖繩), 6天豪華郵輪假期',5999.00,6,'1','HRX06A.pdf','2015-07-19 00:00:00'),('HSC04A','麗星郵輪～處女星號, 香港、台灣(高雄、台中)4天郵輪假期, 【香港尖沙咀海運碼頭往返】',3988.00,4,'4','HSC04A.pdf','2015-06-26 00:00:00'),('HSG04A','麗星郵輪～處女星號, 香港、中國(三亞)、越南(下龍灣), 4天豪華郵輪假期, 【香港尖沙咀海運碼頭往返】',4999.00,4,'4','HSG04A.pdf','2015-07-18 00:00:00'),('HSH06A','麗星郵輪～處女星號, 香港、台灣(高雄、台中、基隆), 6天郵輪假期',6999.00,6,'4','HSH06A.pdf','2015-06-23 00:00:00'),('JPD07A','公主遊輪～鑽石公主號, 日本(東京、橫濱、長崎)、韓國(釜山), 7天深度日本豪華郵輪假期',13099.00,7,'3','JPD07A.pdf','2015-08-15 00:00:00'),('SSG06A','麗星郵輪~雙子星號, 新加坡(Gardens by the Bay、環球影城)、, 馬來西亞(檳城、浮羅交怡)6天豪華郵輪假期',5999.00,6,'4','SSG06A.pdf','2015-07-30 00:00:00'),('TSA06A','麗星郵輪～寶瓶星號, 台灣(台北、基隆)、日本(石垣島、沖繩島) 6天團',6999.00,6,'4','TSA06A.pdf','2015-07-30 00:00:00'),('URM12A','環遊海上世界亞洲段12天豪華郵輪假期',17999.00,12,'1','URM12A.pdf','2015-07-14 00:00:00');
/*!40000 ALTER TABLE `cruise` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cruise_order`
--

DROP TABLE IF EXISTS `cruise_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cruise_order` (
  `CruiseOrderID` varchar(12) NOT NULL,
  `CruiseID` varchar(12) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `CustNum` int(11) NOT NULL,
  PRIMARY KEY (`CruiseOrderID`),
  KEY `fk_co_cruiseID_idx` (`CruiseID`),
  CONSTRAINT `fk_co_cruiseID` FOREIGN KEY (`CruiseID`) REFERENCES `cruise` (`CruiseID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cruise_order`
--

LOCK TABLES `cruise_order` WRITE;
/*!40000 ALTER TABLE `cruise_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `cruise_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `CustID` varchar(5) NOT NULL,
  `Surname` varchar(12) NOT NULL,
  `GivenName` varchar(12) NOT NULL,
  `DateOfBirth` datetime NOT NULL,
  `Gender` varchar(5) NOT NULL,
  `Passport` varchar(12) NOT NULL,
  `Contact` varchar(8) NOT NULL,
  `Nationality` varchar(12) NOT NULL,
  PRIMARY KEY (`CustID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('C001','Chan','Chi Ming','1982-03-15 00:00:00','M','F1842154','95215852','test'),('C002','Wong','Chun Tin','1991-03-31 00:00:00','F','G6645132','96254685','Chinese'),('C003','Tang','Tai Chi','1979-09-24 00:00:00','M','T2165158','91254854','Chinese'),('C004','Man','Chi Kuen','1952-01-18 00:00:00','M','G2514144','92548475','Chinese'),('C005','Lee','Man Tao','1983-04-16 00:00:00','M','A1254855','92165845','Chinese'),('C006','Leung','Shun Yee','1991-02-19 00:00:00','F','B1215485','91236545','Chinese'),('C007','Lee','Ka Man','1998-06-05 00:00:00','F','R2315845','92548548','Chinese'),('C008','Lung','Chi Kin','1985-12-06 00:00:00','M','R1254856','97584254','Chinese'),('C009','Chan','Siu Dong','1973-08-19 00:00:00','M','G6584251','94652514','Chinese'),('C010','Cheung','Tai Tim','1978-08-17 00:00:00','M','J56698452','94521575','Chinese'),('C011','Fung','Chi Tak','1977-02-15 00:00:00','M','T15515155','96251675','Chinese'),('C012','Chan','Man Sheung','1976-06-18 00:00:00','F','F21251515','95462415','Chinese');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `driver_roster`
--

DROP TABLE IF EXISTS `driver_roster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `driver_roster` (
  `StaffID` varchar(12) NOT NULL,
  `weekdayTS` int(11) NOT NULL,
  `weekendTS` int(11) NOT NULL,
  PRIMARY KEY (`StaffID`),
  CONSTRAINT `fk_roster_staffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `driver_roster`
--

LOCK TABLES `driver_roster` WRITE;
/*!40000 ALTER TABLE `driver_roster` DISABLE KEYS */;
INSERT INTO `driver_roster` VALUES ('ho1',5,5),('kwong1',4,9),('lam1',8,9),('lam2',6,5),('law1',3,8),('wu1',1,1);
/*!40000 ALTER TABLE `driver_roster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipment` (
  `EquipID` varchar(5) NOT NULL,
  `Equipment` varchar(25) NOT NULL,
  `Suitable` varchar(5) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `Photo` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`EquipID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment`
--

LOCK TABLES `equipment` WRITE;
/*!40000 ALTER TABLE `equipment` DISABLE KEYS */;
INSERT INTO `equipment` VALUES ('e01','Booster seat','car',28.60,'e01.png'),('e02','Additional driver','car',71.60,'e02.png'),('e03','Baby seat','car',78.80,'e03.png'),('e04','GPS','car',100.30,'e04.png'),('e05','Drinking water','cocah',20.00,'e05.png');
/*!40000 ALTER TABLE `equipment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipmentlist`
--

DROP TABLE IF EXISTS `equipmentlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipmentlist` (
  `VehicleBookingID` varchar(12) NOT NULL,
  `EquipID` varchar(12) NOT NULL,
  `EquipBookPrice` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`VehicleBookingID`,`EquipID`),
  KEY `fk_elist_eID_idx` (`EquipID`),
  CONSTRAINT `dk_elist_vID` FOREIGN KEY (`VehicleBookingID`) REFERENCES `vehiclebooking` (`VehicleOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_elist_eID` FOREIGN KEY (`EquipID`) REFERENCES `equipment` (`EquipID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipmentlist`
--

LOCK TABLES `equipmentlist` WRITE;
/*!40000 ALTER TABLE `equipmentlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipmentlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `feedback` (
  `FeedBackID` varchar(12) NOT NULL,
  `CustomerID` varchar(12) DEFAULT NULL,
  `Date` date NOT NULL,
  `Mark` int(11) NOT NULL,
  `Content` varchar(255) NOT NULL,
  PRIMARY KEY (`FeedBackID`),
  KEY `fk_fd_custID_idx` (`CustomerID`),
  CONSTRAINT `fk_fd_custID` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flight_booking`
--

DROP TABLE IF EXISTS `flight_booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flight_booking` (
  `FlightOrderID` varchar(12) NOT NULL,
  `FlightID` varchar(12) NOT NULL,
  `FlightClassID` varchar(12) NOT NULL,
  `AdultPrice` decimal(12,2) NOT NULL,
  `ChildPrice` decimal(12,2) NOT NULL,
  `InfantPrice` decimal(12,2) NOT NULL,
  `AdultNum` int(11) NOT NULL,
  `ChildNum` int(11) NOT NULL,
  `InfantNum` int(11) NOT NULL,
  `totalPrice` decimal(12,2) NOT NULL,
  `idReturn` char(1) NOT NULL COMMENT '0 = one  way,\n1 = return',
  PRIMARY KEY (`FlightOrderID`),
  KEY `fk_flightOrder_flightID_idx` (`FlightID`),
  KEY `fk_flightOrder_classID_idx` (`FlightClassID`),
  CONSTRAINT `fk_fb_classID` FOREIGN KEY (`FlightClassID`) REFERENCES `flightclass` (`flightclass_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_fb_flightID` FOREIGN KEY (`FlightID`) REFERENCES `flightschedule` (`FlightID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flight_booking`
--

LOCK TABLES `flight_booking` WRITE;
/*!40000 ALTER TABLE `flight_booking` DISABLE KEYS */;
/*!40000 ALTER TABLE `flight_booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flightclass`
--

DROP TABLE IF EXISTS `flightclass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flightclass` (
  `flightclass_id` varchar(12) NOT NULL,
  `FlightNo` varchar(12) NOT NULL,
  `Class` varchar(12) NOT NULL,
  `Price_Adult` decimal(12,2) NOT NULL,
  `Price_Children` decimal(12,2) NOT NULL,
  `Price_Infant` decimal(12,2) NOT NULL,
  `Tax` decimal(12,2) NOT NULL,
  PRIMARY KEY (`flightclass_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightclass`
--

LOCK TABLES `flightclass` WRITE;
/*!40000 ALTER TABLE `flightclass` DISABLE KEYS */;
INSERT INTO `flightclass` VALUES ('1','CI602','Business',2999.00,2999.00,500.00,0.00),('10','CX406','Econ',1544.00,1155.00,740.00,0.00),('11','CX564','Econ',1305.00,1174.00,760.00,0.00),('12','CX510','Econ',1554.00,1115.00,740.00,0.00),('13','CX400','Econ',1490.00,1090.00,740.00,0.00),('14','HX284','Business',2499.00,2499.00,530.00,0.00),('15','HX284','Econ',1584.00,1160.00,530.00,0.00),('16','HX282','Econ',1584.00,1152.00,500.00,0.00),('17','HX264','Econ',1584.00,1152.00,500.00,0.00),('18','HX252','Econ',1584.00,1152.00,500.00,0.00),('19','KA482','Econ',1699.00,1140.00,670.00,0.00),('2','CI602','Econ',999.00,746.00,500.00,0.00),('20','KA499','Econ',1699.00,1162.00,970.00,0.00),('21','KA565','Econ',1069.00,1254.00,670.00,0.00),('22','MU724','Econ',1762.00,1145.00,800.00,0.00),('23','MU722','Econ',1893.00,1140.00,800.00,0.00),('24','MU502','Econ',1990.00,1190.00,900.00,0.00),('25','MU702','Econ',1990.00,1190.00,800.00,0.00),('26','JL7050','Business',11000.00,7111.00,800.00,0.00),('27','JL7050','Econ',7111.00,5400.00,600.00,0.00),('28','JL7060','Business',11000.00,7111.00,800.00,0.00),('29','JL7060','Econ',7111.00,5400.00,750.00,0.00),('3','CI680','Business',2977.00,2977.00,500.00,0.00),('30','JL7054','Econ',7111.00,5400.00,750.00,0.00),('31','MU728','Econ',1458.00,1140.00,400.00,0.00),('32','MU503','Econ',1688.00,1550.00,400.00,0.00),('33','MU509','Econ',1658.00,1550.00,400.00,0.00),('34','CX715','Econ',1880.00,1880.00,800.00,0.00),('35','CX715','Business',3500.00,3500.00,800.00,0.00),('36','CX659','Econ',1760.00,1760.00,800.00,0.00),('37','CX659','Business',3500.00,3500.00,800.00,0.00),('38','CX715','Econ',1880.00,1880.00,800.00,0.00),('39','CX715','Business',3500.00,3500.00,800.00,0.00),('4','CI680','Econ',1098.00,792.00,500.00,0.00),('40','CX735','Econ',1880.00,1880.00,800.00,0.00),('41','SQ871','Econ',3000.00,3050.00,800.00,0.00),('42','SQ861','Econ',3000.00,3050.00,800.00,0.00),('43','SQ861','Business',6500.00,6500.00,800.00,0.00),('44','SQ865','Econ',3050.00,3050.00,800.00,0.00),('45','SQ865','Business',6500.00,6500.00,800.00,0.00),('46','SQ857','Econ',2950.00,2950.00,800.00,0.00),('47','SQ891','Econ',3010.00,3010.00,800.00,0.00),('48','EK385','Econ',2200.00,1652.00,600.00,0.00),('49','EK385','Econ',2200.00,1652.00,600.00,0.00),('5','CI614','Econ',931.00,694.00,500.00,0.00),('50','EK386','Econ',2200.00,1652.00,600.00,0.00),('51','EK395','Econ',2200.00,1652.00,600.00,0.00),('52','TG639','Econ',2400.00,1850.00,1000.00,0.00),('53','TG639','Business',5600.00,5600.00,1200.00,0.00),('54','TG607','Econ',2400.00,1850.00,1000.00,0.00),('55','TG601','Econ',2400.00,1850.00,1000.00,0.00),('56','TG601','Business',5600.00,5600.00,1200.00,0.00),('57','TG603','Econ',2400.00,1850.00,1000.00,0.00),('58','CX713','Econ',4300.00,3100.00,1300.00,0.00),('59','CX713','Business',7500.00,7500.00,2000.00,0.00),('6','BR856','Econ',1023.00,774.00,596.00,0.00),('60','CX703','Econ',4300.00,3100.00,1300.00,0.00),('61','CX617','Econ',4300.00,3100.00,1300.00,0.00),('62','MU724','Econ',2690.00,2400.00,1000.00,0.00),('63','MU502','Econ',2690.00,2400.00,1000.00,0.00),('64','MU702','Econ',2690.00,2400.00,1000.00,0.00),('65','HX246','Econ',2850.00,1800.00,1200.00,0.00),('66','HX246','Business',5600.00,5600.00,3000.00,0.00),('67','HX234','Econ',2850.00,1800.00,1200.00,0.00),('68','HX232','Econ',2850.00,1800.00,1200.00,0.00),('69','HX232','Business',5600.00,5600.00,3000.00,0.00),('7','BR858','Econ',1023.00,774.00,596.00,0.00),('70','HX236','Econ',27850.00,1800.00,1200.00,0.00),('71','CX364','Econ',3990.00,2990.00,1500.00,0.00),('72','CX364','Business',6500.00,6500.00,2000.00,0.00),('73','CX360','Econ',3990.00,2990.00,1500.00,0.00),('74','CX360','Business',6500.00,6500.00,2000.00,0.00),('75','KA876','Econ',4100.00,3050.00,1000.00,0.00),('76','KA802','Econ',4100.00,3050.00,1000.00,0.00),('77','KA802','Business',8000.00,7900.00,1200.00,0.00),('78','KA864','Econ',4100.00,3050.00,1000.00,0.00),('79','KA864','Econ',4100.00,3050.00,1000.00,0.00),('8','BR858','Business',3088.00,3088.00,3088.00,0.00),('80','KA858','Business',8050.00,7900.00,1200.00,0.00),('9','BR872','Econ',1023.00,774.00,596.00,0.00);
/*!40000 ALTER TABLE `flightclass` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flightschedule`
--

DROP TABLE IF EXISTS `flightschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flightschedule` (
  `FlightID` varchar(12) NOT NULL,
  `FlightNo` varchar(12) NOT NULL,
  `Carrier` varchar(12) NOT NULL,
  `EDD` datetime NOT NULL,
  `EDA` datetime NOT NULL,
  `ETD` varchar(12) NOT NULL,
  `ETA` varchar(12) NOT NULL,
  `Origin` varchar(5) NOT NULL,
  `Dest` varchar(5) NOT NULL,
  `Aircraft` varchar(12) NOT NULL,
  `TravelTime` varchar(12) NOT NULL,
  `FlightType` varchar(12) NOT NULL,
  PRIMARY KEY (`FlightID`),
  KEY `fk_fc_airline_idx` (`Carrier`),
  CONSTRAINT `fk_fc_airline` FOREIGN KEY (`Carrier`) REFERENCES `carrier` (`CID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightschedule`
--

LOCK TABLES `flightschedule` WRITE;
/*!40000 ALTER TABLE `flightschedule` DISABLE KEYS */;
INSERT INTO `flightschedule` VALUES ('F001','CI602','c01','2015-06-20 00:00:00','2015-06-20 00:00:00','10:15:00','11:55:00','HKG','TPE','747-400','1h40m','Direct'),('F002','CI680','c01','2015-06-20 00:00:00','2015-06-20 00:00:00','13:25:00','15:05:00','HKG','TPE','A330-300','1h40m','Direct'),('F003','CI614','c01','2015-06-20 00:00:00','2015-06-20 00:00:00','17:35:00','19:15:00','HKG','TPE','A330-300','1h40m','Direct'),('F004','BR856','c02','2015-06-22 00:00:00','2015-06-22 00:00:00','17:00:00','18:45:00','HKG','TPE','A330-300','1h45m','Direct'),('F005','BR858','c02','2015-06-22 00:00:00','2015-06-22 00:00:00','20:55:00','22:40:00','HKG','TPE','A330-300','1h45m','Direct'),('F006','BR872','c02','2015-06-23 00:00:00','2015-06-23 00:00:00','19:25:00','21:10:00','HKG','TPE','A330-300','1h45m','Direct'),('F007','CX406','c03','2015-06-20 00:00:00','2015-06-20 00:00:00','12:15:00','14:15:00','HKG','TPE','A330-300','2h','Direct'),('F008','CX564','c03','2015-06-20 00:00:00','2015-06-20 00:00:00','13:10:00','15:05:00','HKG','TPE','A330-300','1h55m','Direct'),('F009','CX510','c03','2015-06-22 00:00:00','2015-06-22 00:00:00','14:55:00','16:45:00','HKG','TPE','A330-300','1h50m','Direct'),('F010','CX400','c03','2015-06-22 00:00:00','2015-06-22 00:00:00','16:25:00','18:15:00','HKG','TPE','A330-300','1h50m','Direct'),('F011','HX284','c04','2015-06-22 00:00:00','2015-06-24 00:00:00','22:50:00','00:40:00','HKG','TPE','A330-300','1h50m','Direct'),('F012','HX282','c04','2015-06-20 00:00:00','2015-06-20 00:00:00','17:40:00','19:30:00','HKG','TPE','A330-300','1h50m','Direct'),('F013','HX264','c04','2015-06-20 00:00:00','2015-06-20 00:00:00','12:10:00','13:50:00','HKG','TPE','A330-300','1h40m','Direct'),('F014','HX252','c04','2015-06-21 00:00:00','2015-06-21 00:00:00','09:30:00','11:25:00','HKG','TPE','A330-300','1h55m','Direct'),('F015','KA482','c05','2015-06-20 00:00:00','2015-06-20 00:00:00','18:25:00','20:15:00','HKG','TPE','A330-300','1h55m','Direct'),('F016','KA499','c05','2015-06-21 00:00:00','2015-06-21 00:00:00','14:55:00','16:45:00','HKG','TPE','A330-300','1h50m','Direct'),('F017','KA565','c05','2015-06-24 00:00:00','2015-06-24 00:00:00','17:00:00','18:45:00','HKG','TPE','A330-300','1h45m','Direct'),('F018','MU724','c06','2015-06-18 00:00:00','2015-06-19 00:00:00','09:35:00','13:15:00','HKG','KIX','A320','26h35m','Indirect'),('F019','MU722','c06','2015-06-18 00:00:00','2015-06-19 00:00:00','12:05:00','13:10:00','HKG','KIX','A321','24h5m','Indirect'),('F020','MU502','c06','2015-06-24 00:00:00','2015-06-25 00:00:00','12:50:00','13:10:00','HKG','KIX','A321','24h5m','Indirect'),('F021','MU702','c06','2015-06-25 00:00:00','2015-06-26 00:00:00','12:50:00','21:30:00','HKG','KIX','A321','7h40m','Indirect'),('F022','JL7050','c07','2015-06-23 00:00:00','2015-06-23 00:00:00','01:45:00','06:25:00','HKG','KIX','A320','3h40m','Direct'),('F023','JL7060','c07','2015-06-23 00:00:00','2015-06-23 00:00:00','07:55:00','12:45:00','HKG','KIX','A320','3h50m','Direct'),('F024','JL7054','c07','2015-06-25 00:00:00','2015-06-25 00:00:00','13:10:00','20:00:00','HKG','KIX','A320','5h50m','Direct'),('F025','MU728','c08','2015-06-19 00:00:00','2015-06-20 00:00:00','09:35:00','13:10:00','HKG','KIX','A330-300','24h5m','Indirect'),('F026','MU503','c08','2015-06-19 00:00:00','2015-06-20 00:00:00','12:05:00','13:10:00','HKG','KIX','A330-300','24h5m','Indirect'),('F027','MU509','c08','2015-06-19 00:00:00','2015-06-20 00:00:00','12:50:00','13:10:00','HKG','KIX','A330-300','23h20m','Indirect'),('F028','CX715','c03','2015-07-28 00:00:00','2015-07-28 00:00:00','20:25:00','00:15:00','HKG','SIN','777-300','3h50m','Direct'),('F029','CX659','c03','2015-07-28 00:00:00','2015-07-28 00:00:00','01:45:00','05:25:00','HKG','SIN','A330-300','3h40m','Direct'),('F030','CX735','c03','2015-07-30 00:00:00','2015-07-30 00:00:00','14:30:00','18:20:00','HKG','SIN','A340-300','3h50m','Direct'),('F031','SQ871','c09','2015-07-26 00:00:00','2015-07-26 00:00:00','19:55:00','23:40:00','HKG','SIN','777-200','3h45m','Direct'),('F032','SQ861','c09','2015-07-26 00:00:00','2015-07-26 00:00:00','15:20:00','19:10:00','HKG','SIN','A380-800','3h50m','Direct'),('F033','SQ865','c09','2015-07-26 00:00:00','2015-07-26 00:00:00','18:50:00','22:35:00','HKG','SIN','777-300','3h45m','Direct'),('F034','SQ857','c09','2015-07-28 00:00:00','2015-07-28 00:00:00','09:05:00','12:50:00','HKG','SIN','777-300','3h45m','Direct'),('F035','SQ891','c09','2015-07-30 00:00:00','2015-07-30 00:00:00','12:30:00','16:15:00','HKG','SIN','A380-800','3h45m','Direct'),('F036','UA895','c10','2015-07-22 00:00:00','2015-07-23 00:00:00','20:25:00','00:20:00','HKG','SIN','777-300','3h55m','Direct'),('F037','UA895','c10','2015-07-23 00:00:00','2015-07-24 00:00:00','20:25:00','00:20:00','HKG','SIN','777-300','3h55m','Direct'),('F038','UA895','c10','2015-07-24 00:00:00','2015-07-25 00:00:00','20:25:00','00:20:00','HKG','SIN','777-300','3h55m','Direct'),('F039','EK385','c11','2015-07-22 00:00:00','2015-07-22 00:00:00','21:50:00','23:45:00','HKG','BKK','A380-800','2h55m','Direct'),('F040','EK385','c11','2015-07-23 00:00:00','2015-07-23 00:00:00','21:50:00','23:45:00','HKG','BKK','A380-800','2h55m','Direct'),('F041','EK386','c11','2015-07-24 00:00:00','2015-07-24 00:00:00','19:50:00','21:45:00','HKG','BKK','A380-800','2h55m','Direct'),('F042','EK395','c11','2015-07-25 00:00:00','2015-07-25 00:00:00','17:50:00','19:45:00','HKG','BKK','A380-800','2h55m','Direct'),('F043','TG639','c12','2015-07-22 00:00:00','2015-07-22 00:00:00','19:05:00','20:45:00','HKG','BKK','A330-300','2h40m','Direct'),('F044','TG607','c12','2015-07-22 00:00:00','2015-07-22 00:00:00','20:45:00','22:25:00','HKG','BKK','747-400','2h40m','Direct'),('F045','TG601','c12','2015-07-24 00:00:00','2015-07-24 00:00:00','13:25:00','15:05:00','HKG','BKK','A380-800','2h40m','Direct'),('F046','TG603','c12','2015-07-25 00:00:00','2015-07-25 00:00:00','07:45:00','09:25:00','HKG','BKK','A330-300','2h40m','Direct'),('F047','CX713','c03','2015-07-22 00:00:00','2015-07-22 00:00:00','08:50:00','10:40:00','HKG','BKK','A330-300','2h50m','Direct'),('F048','CX703','c03','2015-07-23 00:00:00','2015-07-23 00:00:00','17:05:00','19:00:00','HKG','BKK','A330-300','2h50m','Direct'),('F049','CX617','c03','2015-07-24 00:00:00','2015-07-24 00:00:00','21:20:00','23:10:00','HKG','BKK','777-300','2h55m','Direct'),('F050','MU724','c08','2015-06-25 00:00:00','2015-06-25 00:00:00','09:35:00','11:45:00','HKG','PVG','A321','2h10m','Direct'),('F051','MU502','c08','2015-06-25 00:00:00','2015-06-25 00:00:00','12:50:00','15:25:00','HKG','PVG','A321','2h35m','Direct'),('F052','MU702','c08','2015-06-26 00:00:00','2015-06-26 00:00:00','13:55:00','16:25:00','HKG','PVG','A320','2h30m','Direct'),('F053','HX246','c04','2015-06-28 00:00:00','2015-06-28 00:00:00','13:15:00','15:45:00','HKG','PVG','A330-200','2h30m','Direct'),('F054','HX234','c04','2015-06-29 00:00:00','2015-06-29 00:00:00','21:00:00','23:25:00','HKG','PVG','A330-200','2h25m','Direct'),('F055','HX232','c04','2015-06-29 00:00:00','2015-06-29 00:00:00','17:25:00','19:55:00','HKG','PVG','A330-200','2h30m','Direct'),('F056','HX236','c04','2015-06-30 00:00:00','2015-06-30 00:00:00','08:15:00','10:50:00','HKG','PVG','A330-200','2h35m','Direct'),('F057','CX364','c03','2015-06-24 00:00:00','2015-06-24 00:00:00','17:35:00','20:10:00','HKG','PVG','777-300','2h30m','Direct'),('F058','CX360','c03','2015-06-25 00:00:00','2015-06-25 00:00:00','13:55:00','16:25:00','HKG','PVG','A330-200','2h30m','Direct'),('F059','KA876','c05','2015-06-22 00:00:00','2015-06-22 00:00:00','09:55:00','12:30:00','HKG','PVG','A321','2h35m','Direct'),('F060','KA802','c05','2015-06-24 00:00:00','2015-06-24 00:00:00','08:00:00','10:30:00','HKG','PVG','A330-200','2h30m','Direct'),('F061','KA864','c05','2015-07-15 00:00:00','2015-07-15 00:00:00','09:25:00','12:00:00','HKG','SHA','A330-200','2h35m','Direct'),('F062','KA858','c05','2015-09-30 00:00:00','2015-09-30 00:00:00','10:00:00','12:20:00','HKG','SHA','A330-200','2h20m','Direct'),('F063','CI680','c06','2015-06-25 00:00:00','2015-06-25 00:00:00','18:00:00','19:45:00','TPE','HKG','A330-300','1h45m','Direct'),('F064','KA858','c05','2015-06-22 00:00:00','2015-06-22 00:00:00','15:55:00','17:45:00','TPE','HKG','A330-300','1h50m','Direct');
/*!40000 ALTER TABLE `flightschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hotel`
--

DROP TABLE IF EXISTS `hotel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hotel` (
  `HotelID` varchar(5) NOT NULL,
  `Hotel_chi_name` varchar(12) NOT NULL,
  `Hotel_en_name` varchar(45) NOT NULL,
  `Star` decimal(12,1) NOT NULL,
  `Rating` decimal(12,1) NOT NULL,
  `Region` varchar(25) NOT NULL,
  `address` varchar(255) NOT NULL,
  `tel` varchar(8) DEFAULT NULL,
  `dest` varchar(5) NOT NULL,
  PRIMARY KEY (`HotelID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotel`
--

LOCK TABLES `hotel` WRITE;
/*!40000 ALTER TABLE `hotel` DISABLE KEYS */;
INSERT INTO `hotel` VALUES ('CN01','上海虹橋元一希爾頓酒店','Hilton Shanghai Hongqiao',5.0,4.2,'Shanghai(Minhang)','No.1116 Hong Song East Road Minhang Shanghai 201103 中國',NULL,'中國'),('CN02','和平飯店','Fairmont Peace Hotel',5.0,4.7,'Shanghai(黃浦 - 外灘)','20 Nanjing Road East, Huang Pu District Shanghai Shanghai 200002 中國',NULL,'中國'),('CN03','上海世茂皇家艾美酒店','Le Royal Meridien Shanghai',5.0,4.3,'Shanghai(黃浦 - 外灘)','789 Nanjing Road East Shanghai Shanghai 200001 中國 ',NULL,'中國'),('CN04','華亨賓館','Jin Jiang Hua Ting Hotel & Towers',4.0,3.6,'Shanghai(徐匯)','1200 Cao Xi Bei Road Shanghai Shanghai 200030 中國',NULL,'中國'),('CN05','上海靜安香格里拉大酒店','Jing An Shangri-La, West Shanghai',4.5,4.7,'Shanghai(長寧)','1218 Middle Yan\'an Road Jing An Kerry Centre, West Nanjing Shanghai Shanghai 200040 中國',NULL,'中國'),('JP01','黑部觀光酒店','Kurobe Kanko Hotel',3.0,3.9,'Japan(Omachi)','2822 Taira Omachi Nagano-ken 398-0001 日本 ','30774857','日本'),('JP02','落葉松莊酒店','Hotel Karamatsuso',3.0,3.0,'Japan(Omachi)','2884-109 Taira Omachi Nagano-ken 398-0001 日本 ','30774857','日本 '),('JP03','東根拉雪酒店','Hotel La Neige Higashi-kan',5.0,4.5,'Japan(Hakuba)','Happo Wadanonomori Hakuba Nagano-ken 399-9301 日本','30774857','日本 '),('JP04','松本多米酒店','Dormy Inn Matsumoto',4.0,4.6,'Japan(Matsumoto)','2-2-1 Fukashi Matsumoto Nagano-ken 390-0815 日本 ','30774857','日本 '),('SP01','新加坡唐購物中心萬豪酒店','Singapore Marriott Tang Plaza Hotel',5.0,4.4,'Singapore(烏節路)','320 Orchard Road Singapore 238865 新加坡',NULL,'新加坡'),('SP02','新加坡瑞士史丹福酒店','Swissotel The Stamford, Singapore',5.0,4.3,'Singapore(殖民區 - 美芝路)','2 Stamford Road Singapore 178882 新加坡 ',NULL,'新加坡'),('SP03','克萊蒙梭公園大道酒店','Park Avenue Clemenceau',4.0,3.8,'Singapore(新加坡河)','81A Clemenceau Avenue # 05 - 18 UE Square Singapore 239918 新加坡',NULL,'新加坡'),('SP04','新加坡國敦河畔大酒店','Grand Copthorne Waterfront Hotel Singapore',4.0,4.1,'Singapore(新加坡河)','392 Havelock Road Singapore 169663 新加坡',NULL,'新加坡'),('TL01','聖里吉斯曼谷酒店','The St. Regis Bangkok',5.0,4.6,'Bangkok(市中心 - 暹邏廣場)','159 Rajadamri Road Bangkok Bangkok 10330 泰國',NULL,'泰國'),('TL02','帕色哇公主飯店','Pathumwan Princess Hotel',4.5,4.5,'Bangkok(市中心 - 暹邏廣場)','444 MBK Center, Phayathai Rd., Wangmai Pathumwan Bangkok Bangkok 10330 泰國',NULL,'泰國'),('TL03','曼谷悅榕莊','Banyan Tree Bangkok',5.0,4.6,'Bangkok(是隆路 - 沙吞)','21/100 South Sathon Road Bangkok Bangkok 10120 泰國 ',NULL,'泰國'),('TL04','D&D 旅館','D&D Inn',3.0,4.1,'Bangkok(舊城)','68-70 Khaosan Road, Pranakorn Bangkok 10200 泰國 ',NULL,'泰國'),('TL05','曼谷東方公寓','Oriental Residence Bangkok',5.0,4.7,'Bangkok(素坤逸路)','110 Wireless Road, Lumpini, Pathumwan Bangkok Bangkok 10330 泰國 ',NULL,'泰國'),('TW01','台北君悅酒店','Grand Hyatt Taipei',4.5,4.3,'Taipei(信義)','2 SongShou Road Taipei 11051 台灣 ','30774857','台灣'),('TW02','台北凱撒大飯店','Caesar Park Taipei',4.0,3.9,'Taipei(中正)','38 Chung Hsiao West Road Section 1 Zhongzheng Taipei 100 台灣','30774857','台灣'),('TW03','台北福華大飯店','The Howard Plaza Hotel Taipei',4.0,3.9,'Taipei(大安)','160, Sec.3, Ren Ai Rd Taipei 10657 台灣 ','30774857','台灣'),('TW04','台北中山意舍酒店','amba Taipei Zhongshan',3.5,4.0,'Taipei(中山)','57-1 Zhongshan North Road Section 2 Taipei 10412 台灣 ','30774857','台灣'),('TW05','台北晶華酒店','Regent Taipei',5.0,4.4,'Taipei(中山)','No 3, Lane 39, Section 2 ZhongShan North, Road Taipei 104 台灣 ','30774857','台灣'),('TW06','台北西華飯店','The Sherwood Taipei',4.5,4.5,'Taipei(松山)','111 Min Sheng East Road Taipei 104 台灣 ','30774857','台灣');
/*!40000 ALTER TABLE `hotel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hotel_room`
--

DROP TABLE IF EXISTS `hotel_room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hotel_room` (
  `HotelRoomID` varchar(5) NOT NULL,
  `HotelID` varchar(5) NOT NULL,
  `Hotel_chi_name` varchar(25) NOT NULL,
  `Hotel_room_name` varchar(45) NOT NULL,
  `Hotel__room_size` varchar(12) NOT NULL,
  `max_audults` int(11) NOT NULL,
  `max_child` int(11) NOT NULL,
  `Hotel_room_description` varchar(25) NOT NULL,
  `Fare` decimal(12,2) NOT NULL,
  PRIMARY KEY (`HotelRoomID`),
  KEY `fk_hotel_hotelID_idx` (`HotelID`),
  CONSTRAINT `fk_hotel_hotelID` FOREIGN KEY (`HotelID`) REFERENCES `hotel` (`HotelID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotel_room`
--

LOCK TABLES `hotel_room` WRITE;
/*!40000 ALTER TABLE `hotel_room` DISABLE KEYS */;
INSERT INTO `hotel_room` VALUES ('R001','TW01','台北君悅酒店','君悅客房 - 一大床','24 平方米',3,2,'1 張特大雙人床',2343.61),('R002','TW01','台北君悅酒店','頂級標準客房','36 平方米',3,2,'2 張單人床',2343.61),('R003','TW01','台北君悅酒店','君悅豪華客房','40 平方米',3,2,'1 張特大雙人床',2493.20),('R004','TW01','台北君悅酒店','君悅豪華客房 - 二小床','40 平方米',3,2,'2 張單人床',2493.20),('R005','TW01','台北君悅酒店','嘉賓軒客房 一大床','56 平方米',3,2,'1 張特大雙人床',3241.16),('R006','TW01','台北君悅酒店','君悅行政套房 - 一大床','70 平方米',3,2,'1 張特大雙人床',5485.04),('R007','TW01','台北君悅酒店','頂級套房, 1 張特大雙人床','80 平方米',3,2,'1 張特大雙人床',3989.12),('R008','TW02','台北凱撒大飯店','高級客房','30 平方米',3,2,'1 張雙人床',947.97),('R009','TW02','台北凱撒大飯店','高級雙人房','30 平方米',3,2,'2 張單人床',1007.22),('R010','TW02','台北凱撒大飯店','Metro Room','30 平方米',2,2,'1 張雙人床',1141.75),('R011','TW02','台北凱撒大飯店','四人房','45 平方米',4,2,'2 張床',1655.20),('R012','TW02','台北凱撒大飯店','套房','30 平方米',3,2,'1 張雙人床',1363.90),('R013','TW03','台北福華大飯店','豪華雙人房','32 平方米',3,2,'1 張雙人床',905.98),('R014','TW03','台北福華大飯店','標準單人房','23 平方米',2,1,'1 張單人床',990.92),('R015','TW03','台北福華大飯店','尊爵高級雙人單床房','26 平方米',3,2,'1 張特大雙人床',1392.11),('R016','TW03','台北福華大飯店','尊爵高級套房','26 平方米',3,2,'1 張特大雙人床',1397.99),('R017','TW04','台北中山意舍酒店','中房一中床','34 平方米',3,2,'1 張加大雙人床',758.46),('R018','TW04','台北中山意舍酒店','酷景房一中床','35 平方米',3,2,'1 張加大雙人床',970.70),('R019','TW04','台北中山意舍酒店','陽台房二單床','35 平方米',3,2,'2 張單人床',1112.26),('R020','TW04','台北中山意舍酒店','標準客房','35 平方米',3,2,'1 張特大雙人床',1645.50),('R021','TW05','台北晶華酒店','高級客房','45 平方米',3,2,'1 張特大雙人床',1634.83),('R022','TW05','台北晶華酒店','豪華客房一特大床客房','55 平方米',3,2,'1 張特大雙人床',1747.02),('R023','TW05','台北晶華酒店','寰宇客房一大床','60 平方米',3,2,'1 張特大雙人床',2016.28),('R024','TW05','台北晶華酒店','精緻套房','60 平方米',3,2,'1 張特大雙人床',3747.28),('R025','TW06','台北西華飯店','豪華標準客房','70 平方米',3,2,'1 張特大雙人床',1221.02),('R026','TW06','台北西華飯店','豪華雙人房','30 平方米',3,2,'2 張單人床',1259.18),('R027','TW06','台北西華飯店','豪華三人房','39 平方米',4,2,'3 張單人床',1459.50),('R028','TW06','台北西華飯店','行政標準客房','60 平方米',3,2,'1 張特大雙人床',1602.59),('R029','TW06','台北西華飯店','普通套房','25 平方米',3,2,'1 張特大雙人床',1907.84),('R030','JP01','黑部觀光酒店','傳統客房 (8 Tatami mat)','30 平方米',3,2,'1 張日式床墊',706.03),('R031','JP01','黑部觀光酒店','傳統客房','30 平方米',3,2,'1 張日式床墊',724.28),('R032','JP02','落葉松莊酒店','傳統客房 (Japanese Style Room)','60 平方米',6,2,'4 張日式床墊',917.52),('R033','JP02','落葉松莊酒店','傳統客房 (Run of the House Japanese Style Room)','35 平方米',3,2,'1 張日式床墊',965.40),('R034','JP03','東根拉雪酒店','豪華標準客房, 非吸煙房 (A Type)','50 平方米',3,2,'2 張單人床',2658.16),('R035','JP03','東根拉雪酒店','普通套房, 非吸煙房 (B Type)','50 平方米',3,2,'2 張單人床',3175.24),('R036','JP03','東根拉雪酒店','豪華標準客房, 非吸煙房, 轉角','50 平方米',3,2,'2 張單人床',3521.50),('R037','JP03','東根拉雪酒店','標準小木屋, 非吸煙房','70 平方米',6,2,'4 張床',3685.50),('R038','JP04','松本多米酒店','雙人房, 1 張雙人床, 非吸煙房','16 平方米',2,1,'1 張雙人床',680.41),('R039','JP04','松本多米酒店','雙人房, 2 張單人床, 非吸煙房','22 平方米',3,1,'2 張單人床',780.77),('R040','SP01','新加坡唐購物中心萬豪酒店','豪華標準客房','56 平方米',3,2,'1 張特大雙人床 或 2 張單人床',2079.24),('R041','SP01','新加坡唐購物中心萬豪酒店','開放式客房','60 平方米',3,2,'1 張特大雙人床',2858.96),('R042','SP01','新加坡唐購物中心萬豪酒店','行政標準客房','60 平方米',3,2,'1 張特大雙人床 或 2 張單人床',3089.98),('R043','SP01','新加坡唐購物中心萬豪酒店','標準客房, 露台','60 平方米',3,2,'1 張特大雙人床',4452.24),('R044','SP02','新加坡瑞士史丹福酒店','經典標準客房','61 平方米',3,2,'1 張特大雙人床 或 2 張單人床',1423.70),('R045','SP02','新加坡瑞士史丹福酒店','標準客房 (Swiss Advantage)','366 平方呎',3,2,'1 張雙人床或 1 張單人床',1570.98),('R046','SP02','新加坡瑞士史丹福酒店','頂級標準客房, 1 張特大雙人床','50 平方米',3,2,'1 張特大雙人床',1865.54),('R047','SP02','新加坡瑞士史丹福酒店','Swiss, 行政標準客房','34 平方米',3,2,'1 張特大雙人床 或 2 張單人床',1914.63),('R048','SP03','克萊蒙梭公園大道酒店','公寓, 1 間臥室, 廚房','43 平方米',3,2,'1 張加大雙人床',1328.40),('R049','SP03','克萊蒙梭公園大道酒店','公寓, 2 間臥室, 廚房','57 平方米',3,2,'1 張加大雙人床 或 1 張單人床',1732.70),('R050','SP04','新加坡國敦河畔大酒店','高級客房, 海灣景','32 平方米',3,2,'1 張特大雙人床',1181.54),('R051','SP04','新加坡國敦河畔大酒店','豪華標準客房','28 平方米',3,2,'1 張特大雙人床 或 2 張單人床',1273.95),('R052','SP04','新加坡國敦河畔大酒店','俱樂部標準客房','28 平方米',3,2,'1 張特大雙人床 或 2 張單人床',2285.49),('R053','SP04','新加坡國敦河畔大酒店','行政套房, 1 張特大雙人床','55 平方米',3,2,'1 張特大雙人床',2633.71),('R054','TL01','聖里吉斯曼谷酒店','豪華標準客房, 1 張特大雙人床','45 平方米',3,2,'1 張特大雙人床',1545.54),('R055','TL01','聖里吉斯曼谷酒店','頂級標準客房, 1 張特大雙人床','55 平方米',3,2,'1 張特大雙人床',1897.69),('R056','TL01','聖里吉斯曼谷酒店','St. Regis Suite, 1 King Bed','100 平方米',3,2,'1 張特大雙人床',2882.78),('R057','TL01','聖里吉斯曼谷酒店','Caroline Astor Suite, 1 King bed','90 平方米',3,2,'1 張特大雙人床',4732.14),('R058','TL02','帕色哇公主飯店','高級雙人房','34 平方米',3,2,'1 張雙人床 或 2 張單人床',705.28),('R059','TL02','帕色哇公主飯店','Execuplus Suite, 1 Double or 2 Single Beds','64 平方米',3,2,'1 張雙人床 或 2 張單人床',1136.84),('R060','TL02','帕色哇公主飯店','高級單人房','34 平方米',3,2,'1 張雙人床 或 2 張單人床',767.90),('R061','TL03','曼谷悅榕莊','豪華標準客房, 1 張特大雙人床','48 平方米',3,2,'1 張特大雙人床',1006.14),('R062','TL03','曼谷悅榕莊','套房, 1 間臥室','59 平方米',3,2,'1 張特大雙人床',1280.69),('R063','TL03','曼谷悅榕莊','尊貴標準客房, 1 張特大雙人床','48 平方米',3,2,'1 張特大雙人床',2120.00),('R064','TL03','曼谷悅榕莊','套房, 2 間臥室','119 平方米',3,2,'2 張特大雙人床',2870.46),('R065','TL04','D&D 旅館','豪華標準客房, 1 張單人床','19 平方米',1,1,'1 張單人床',176.00),('R066','TL04','D&D 旅館','標準客房, 2 張單人床','21 平方米',2,2,'2 張單人床',195.55),('R067','TL04','D&D 旅館','豪華標準客房, 1 張雙人床','23 平方米',2,1,'1 張雙人床',244.44),('R068','TL04','D&D 旅館','Family with Balcony','28 平方米',4,2,'2 張雙人床',371.54),('R069','TL04','D&D 旅館','豪華標準客房, 3 張單人床','26 平方米',4,2,'3 張單人床',303.10),('R070','TL05','曼谷東方公寓','Grand Deluxe','40 平方米',3,2,'1 張特大雙人床 或 2 張單人床',939.06),('R071','TL05','曼谷東方公寓','套房','120 平方米',3,2,'1 張特大雙人床及 1 張加大雙人床',2504.17),('R072','TL05','曼谷東方公寓','套房, 2 間臥室','120 平方米',3,2,'1 張特大雙人床及 2 張單人床',3452.44),('R073','CN01','上海虹橋元一希爾頓酒店','二單人床客房','46 平方米',2,1,'2 張單人床',1163.50),('R074','CN01','上海虹橋元一希爾頓酒店','一特大床客房','46 平方米',3,2,'1 張特大雙人床',1163.50),('R075','CN01','上海虹橋元一希爾頓酒店','豪華標準客房','46 平方米',3,2,'1 張特大雙人床',2684.55),('R076','CN01','上海虹橋元一希爾頓酒店','一樓客房','86 平方米',3,2,'1 張特大雙人床',3302.66),('R077','CN02','和平飯店','費爾蒙房','49 平方米',3,2,'1 張特大雙人床 或 2 張加大雙人床',1872.94),('R078','CN02','和平飯店','費爾蒙金尊客房','49 平方米',3,2,'1 張特大雙人床',2110.18),('R079','CN02','和平飯店','一卧室套房','89 平方米',3,2,'1 張特大雙人床',3277.64),('R080','CN02','和平飯店','特色江景套房','178 平方米',3,2,'1 張特大雙人床',5618.82),('R081','CN03','上海世茂皇家艾美酒店','豪華客房','38 平方米',3,2,'1 張特大雙人床 或 2 張單人床',1153.37),('R082','CN03','上海世茂皇家艾美酒店','高級豪華房','38 平方米',3,2,'1 張特大雙人床 或 2 張單人床',1278.23),('R083','CN03','上海世茂皇家艾美酒店','纯净客房','38 平方米',3,2,'1 張特大雙人床',1340.66),('R084','CN03','上海世茂皇家艾美酒店','艾美房','48 平方米',3,2,'1 張特大雙人床',1403.09),('R085','CN03','上海世茂皇家艾美酒店','帝皇套房','72 平方米',3,2,'1 張特大雙人床',11035.36),('R086','CN03','上海世茂皇家艾美酒店','皇家套房','92 平方米',4,2,'1 張特大雙人床',48494.17),('R087','CN04','華亨賓館','豪華大床房','28 平方米',3,2,'1 張特大雙人床',637.81),('R088','CN04','華亨賓館','行政標準客房','30 平方米',3,2,'1 張特大雙人床 或 2 張單人床',910.69),('R089','CN04','華亨賓館','行政豪华房','45 平方米',3,2,'1 張特大雙人床',1041.06),('R090','CN05','上海靜安香格里拉大酒店','標準客房','28 平方米',3,2,'2 張單人床',2731.73),('R091','CN05','上海靜安香格里拉大酒店','豪華套房, 1 張特大雙人床','45 平方米',3,2,'1 張特大雙人床',5343.59),('R092','CN05','上海靜安香格里拉大酒店','尊貴套房','45 平方米',3,2,'1 張特大雙人床',5343.59);
/*!40000 ALTER TABLE `hotel_room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hotelbooking`
--

DROP TABLE IF EXISTS `hotelbooking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hotelbooking` (
  `HotelOrderID` varchar(12) NOT NULL,
  `NumNight` int(11) NOT NULL,
  `HotelRoomID` varchar(12) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `Checkin` date NOT NULL,
  `Checkout` date NOT NULL,
  `OrderID` varchar(12) NOT NULL,
  PRIMARY KEY (`HotelOrderID`),
  KEY `fk_hb_roomID_idx` (`HotelRoomID`),
  CONSTRAINT `fk_hb_roomID` FOREIGN KEY (`HotelRoomID`) REFERENCES `hotel_room` (`HotelRoomID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotelbooking`
--

LOCK TABLES `hotelbooking` WRITE;
/*!40000 ALTER TABLE `hotelbooking` DISABLE KEYS */;
/*!40000 ALTER TABLE `hotelbooking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `indirect`
--

DROP TABLE IF EXISTS `indirect`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `indirect` (
  `FlightNo` varchar(12) NOT NULL,
  `StopNo` int(11) NOT NULL,
  `Stop` varchar(5) NOT NULL,
  `DateTime` datetime NOT NULL,
  PRIMARY KEY (`FlightNo`,`Stop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `indirect`
--

LOCK TABLES `indirect` WRITE;
/*!40000 ALTER TABLE `indirect` DISABLE KEYS */;
INSERT INTO `indirect` VALUES ('MU502',1,'KIX','2015-06-25 13:10:00'),('MU502',1,'PVG','2015-06-24 15:25:00'),('MU503',1,'KIX','2015-06-20 13:10:00'),('MU503',1,'SHA','2015-06-19 15:25:00'),('MU509',1,'KIX','2015-06-20 13:10:00'),('MU509',1,'PVG','2015-06-19 14:40:00'),('MU702',1,'KIX','2015-06-25 13:10:00'),('MU702',1,'PVG','2015-06-24 16:25:00'),('MU722',1,'PVG','2015-06-19 13:10:00'),('MU722',1,'SHA','2015-06-18 14:40:00'),('MU724',1,'KIX','2015-06-19 13:10:00'),('MU724',1,'PVG','2015-06-18 11:45:00'),('MU728',1,'KIX','2015-06-20 13:10:00'),('MU728',1,'PVG','2015-06-19 11:45:00');
/*!40000 ALTER TABLE `indirect` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order` (
  `OrderID` varchar(12) NOT NULL,
  `CustID` varchar(12) DEFAULT NULL,
  `StaffID` varchar(12) DEFAULT NULL,
  `OrderDate` datetime NOT NULL,
  `FlightOrderID` varchar(12) DEFAULT NULL,
  `HotelOrderID` varchar(12) DEFAULT NULL,
  `AttractionOrderID` varchar(12) DEFAULT NULL,
  `CruiseOrderID` varchar(12) DEFAULT NULL,
  `TransportOrderID` varchar(12) DEFAULT NULL,
  `isTemp` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  UNIQUE KEY `FlightOrderID_UNIQUE` (`FlightOrderID`),
  UNIQUE KEY `HotelOrderID_UNIQUE` (`HotelOrderID`),
  UNIQUE KEY `AttractionOrderID_UNIQUE` (`AttractionOrderID`),
  UNIQUE KEY `CruiseOrderID_UNIQUE` (`CruiseOrderID`),
  UNIQUE KEY `TransportOrderID_UNIQUE` (`TransportOrderID`),
  KEY `fk_order_custID_idx` (`CustID`),
  KEY `fk_order_staffID_idx` (`StaffID`),
  KEY `fk_order_flightID_idx` (`FlightOrderID`),
  KEY `fk_order_hotelID_idx` (`HotelOrderID`),
  KEY `fk_order_cruiseID_idx` (`CruiseOrderID`),
  KEY `fk_order_attrID_idx` (`AttractionOrderID`),
  KEY `fk_order_tranID_idx` (`TransportOrderID`),
  CONSTRAINT `fk_order_attrID` FOREIGN KEY (`AttractionOrderID`) REFERENCES `attraction_order` (`AttractionOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_cruiseID` FOREIGN KEY (`CruiseOrderID`) REFERENCES `cruise_order` (`CruiseOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_custID` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_flightID` FOREIGN KEY (`FlightOrderID`) REFERENCES `flight_booking` (`FlightOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_hotelID` FOREIGN KEY (`HotelOrderID`) REFERENCES `hotelbooking` (`HotelOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_staffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_tranID` FOREIGN KEY (`TransportOrderID`) REFERENCES `vehiclebooking` (`VehicleOrderID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `StaffID` varchar(12) NOT NULL,
  `StaffName` varchar(25) NOT NULL,
  `Gender` varchar(1) NOT NULL,
  `Center` varchar(5) NOT NULL,
  `Email` varchar(25) NOT NULL,
  `Pass` varchar(12) NOT NULL,
  `Position` varchar(25) NOT NULL,
  `Salary` int(11) NOT NULL,
  `Ctype` varchar(12) NOT NULL,
  `Late` int(11) NOT NULL,
  `photo` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`StaffID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES ('cheong1','Lam Sin Cheong','M','B','cheong@tt.com','123456','Customer Service Officer',13500,'Officer',3,'Cheong.jpg'),('fai1','Siu Yao Fai','M','A','fai@tt.com','123456','Customer Service Officer',18800,'Officer',5,'Fai.jpg'),('fan1','Tang Cheuk Fan','M','A','fan@tt.com','123456','Customer Service Officer',23000,'Officer',20,'Fan.jpg'),('han1','Chan Yuen Han','F','C','han@tt.com','123456','Customer Service Officer',22500,'Officer',3,'Han.jpg'),('ho1','Ho Yin','M','HQ','ho@tt.com','123456','Driver',900,'Driver',5,NULL),('kam1','Yuk Siu Kam','F','A','kam@tt.com','123456','Center Manager',29000,'Officer',5,'Kam.jpg'),('kuen1','Leung Siu Kuen','M','B','kuen@tt.com','123456','Center Manager',30000,'Officer',5,'Kuen.jpg'),('kwong1','Kwong Johnny','M','HQ','kwong@tt.com','123456','Driver',800,'Driver',1,NULL),('lam1','Lam Sze Kit','M','HQ','lam@tt.com','123456','Driver',750,'Driver',0,NULL),('lam2','Lam Chris','M','HQ','chris@tt.com','123456','Driver',650,'Driver',1,NULL),('law1','Law Ming Fai','M','HQ','law@tt.com','123456','Driver',800,'Driver',2,NULL),('lung1','Kam Hiu Lung','M','C','lung@tt.com','123456','Customer Service Officer',16600,'Officer',8,'Lung.jpg'),('ming1','Cheung Ming','M','B','ming@tt.com','123456','Customer Service Officer',12500,'Officer',10,'Ming.jpg'),('ning1','Leung Chin Ning','F','B','ning@tt.com','123456','Customer Service Officer',18200,'Officer',25,'Ning.jpg'),('on1','Lam Hin On','M','C','on@tt.com','123456','Center Manager',28500,'Officer',4,'On.jpg'),('shun1','Chan Tai Shun','M','A','shun@tt.com','123456','Customer Service Officer',22000,'Officer',6,'Shun.jpg'),('tak1','Au Siu Tak','M','C','tak@tt.com','123456','Customer Service Officer',12800,'Officer',6,'Tak.jpg'),('wu1','Wu Richard','M','HQ','weu@tt.com','123456','Driver',850,'Driver',0,NULL),('yum1','Chan See Yum','F','A','yum@tt.com','123456','Customer Service Officer',14000,'Officer',2,'Yum.jpg');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle` (
  `VehicleID` varchar(5) NOT NULL,
  `VehicleName` varchar(45) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `VehicleType` varchar(5) NOT NULL,
  `Capacity` int(11) NOT NULL,
  `Gear` varchar(5) NOT NULL,
  `Color` varchar(25) NOT NULL,
  `Photo` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`VehicleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES ('car01','Mini (Manual)',450.50,'car',4,'AT','blue','car01.png'),('car02','Economy (Manual)',742.00,'car',4,'AT','blue','car02.png'),('car03','Compact',879.90,'car',4,'AT/MT','blue','car03.png'),('car04','Midsize (Manual)',842.00,'car',4,'MT','red','car04.png'),('car05','Midsize SUV',819.60,'car',5,'MT','silver','car05.png'),('car06','Standard Wagon',852.80,'car',5,'AT/MT','silver','car06.png'),('car07','Airport Shuttle Bus',917.90,'coach',49,'AT','pink, orange, white','car07.jpg'),('car08','Coach Bus',1079.60,'coach',60,'AT/MT','white','car08.jpg'),('car09','23 Seaters Deluxe Shuttle Bus',1425.20,'coach',23,'AT','green, white','car09.jpg'),('car10','29 Seaters Shuttle Bus',1482.00,'coach',29,'MT','green, white','car10.jpg'),('car11','49 Seaters Shuttle Bus',1131.60,'coach',49,'AT/MT','green, white','car11.jpg'),('car12','20-28 Seaters Shuttle Bus',1236.80,'coach',28,'AT','green, white','car12.jpg');
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiclebooking`
--

DROP TABLE IF EXISTS `vehiclebooking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehiclebooking` (
  `VehicleOrderID` varchar(12) NOT NULL,
  `VehicleID` varchar(12) NOT NULL,
  `PickupDate` date NOT NULL,
  `DropoffDate` date NOT NULL,
  `VehicleBookPrice` decimal(12,2) NOT NULL,
  PRIMARY KEY (`VehicleOrderID`),
  KEY `fk_vb_vID_idx` (`VehicleID`),
  CONSTRAINT `fk_vb_vID` FOREIGN KEY (`VehicleID`) REFERENCES `vehicle` (`VehicleID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiclebooking`
--

LOCK TABLES `vehiclebooking` WRITE;
/*!40000 ALTER TABLE `vehiclebooking` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiclebooking` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-29 22:55:02
