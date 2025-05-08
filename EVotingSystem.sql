/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE IF NOT EXISTS `e_voting_system` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `e_voting_system`;

CREATE TABLE IF NOT EXISTS `candidates` (
  `Candidate ID` int(11) NOT NULL AUTO_INCREMENT,
  `First Name` varchar(50) NOT NULL DEFAULT '',
  `Last Name` varchar(50) NOT NULL DEFAULT '',
  `Gender` varchar(50) NOT NULL DEFAULT '',
  `Email` varchar(50) NOT NULL DEFAULT '',
  `Phone Number` varchar(50) NOT NULL DEFAULT '',
  `Birth Date` date NOT NULL,
  `Position` int(11) NOT NULL,
  `Status` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Candidate ID`),
  UNIQUE KEY `Email` (`Email`),
  KEY `FK_candidates_position` (`Position`),
  CONSTRAINT `FK_candidates_position` FOREIGN KEY (`Position`) REFERENCES `position` (`Position ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `candidates` (`Candidate ID`, `First Name`, `Last Name`, `Gender`, `Email`, `Phone Number`, `Birth Date`, `Position`, `Status`) VALUES
	(9, 'Rendyl John', 'Carlos', 'Male', 'rendyljohncarlos540@gmail.com', '09663564939', '2004-07-03', 1, '0'),
	(10, 'Bensi', 'Opaon', 'Male', 'Opaon@gmail.com', '09663564939', '2006-06-13', 1, '0');

CREATE TABLE IF NOT EXISTS `election` (
  `Election ID` int(11) NOT NULL AUTO_INCREMENT,
  `Voter` int(11) NOT NULL DEFAULT 0,
  `Candidate` int(11) NOT NULL DEFAULT 0,
  `Position` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Election ID`),
  KEY `FK_election_election_position` (`Position`),
  KEY `FK_election_candidates` (`Candidate`),
  KEY `FK_election_voters` (`Voter`),
  CONSTRAINT `FK_election_candidates` FOREIGN KEY (`Candidate`) REFERENCES `candidates` (`Candidate ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_election_election_position` FOREIGN KEY (`Position`) REFERENCES `position` (`Position ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_election_voters` FOREIGN KEY (`Voter`) REFERENCES `voters` (`Voters ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `election` (`Election ID`, `Voter`, `Candidate`, `Position`) VALUES
	(8, 1, 9, 1);

CREATE TABLE IF NOT EXISTS `position` (
  `Position ID` int(11) NOT NULL AUTO_INCREMENT,
  `Position` varchar(50) NOT NULL,
  PRIMARY KEY (`Position ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `position` (`Position ID`, `Position`) VALUES
	(1, 'President'),
	(2, 'Vice President'),
	(3, 'Senator'),
	(4, 'Governor'),
	(5, 'Mayor'),
	(6, 'Vice Mayor'),
	(7, 'Barangay Captain'),
	(8, 'Barangay Tanod'),
	(9, 'SK');

CREATE TABLE IF NOT EXISTS `users` (
  `userID` int(11) NOT NULL AUTO_INCREMENT,
  `ID Number` int(11) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `is_Logged` tinyint(1) NOT NULL DEFAULT 0,
  `Permission` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `users` (`userID`, `ID Number`, `Password`, `is_Logged`, `Permission`) VALUES
	(1, 1, 'admin', 0, 'admin'),
	(4, 20149410, 'ipisano', 0, '');

CREATE TABLE IF NOT EXISTS `voters` (
  `Voters ID` int(11) NOT NULL AUTO_INCREMENT,
  `First Name` varchar(50) NOT NULL,
  `Last Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone Number` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`Voters ID`) USING BTREE,
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `voters` (`Voters ID`, `First Name`, `Last Name`, `Email`, `Phone Number`) VALUES
	(1, 'James', 'Karding', 'Karding@gmail.com', '09783456677');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
