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
  `Status` varchar(50) NOT NULL DEFAULT 'Pending',
  PRIMARY KEY (`Candidate ID`),
  UNIQUE KEY `Email` (`Email`),
  KEY `FK_candidates_position` (`Position`),
  CONSTRAINT `FK_candidates_position` FOREIGN KEY (`Position`) REFERENCES `position` (`Position ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `candidates` (`Candidate ID`, `First Name`, `Last Name`, `Gender`, `Email`, `Phone Number`, `Birth Date`, `Position`, `Status`) VALUES
	(9, 'Rendyl John', 'Carlos', 'Male', 'rendyljohncarlos540@gmail.com', '09663564939', '2004-07-03', 1, 'Approved'),
	(10, 'Bensi', 'Opaon', 'Male', 'Opaon@gmail.com', '09663564939', '2006-06-14', 1, 'Approved'),
	(12, 'Kyle', 'Boyonas', 'Male', 'Kyle@gmail.com', '09663564939', '1995-11-29', 1, 'Approved');

CREATE TABLE IF NOT EXISTS `election` (
  `Election ID` int(11) NOT NULL AUTO_INCREMENT,
  `Voter` int(11) NOT NULL DEFAULT 0,
  `Candidate` int(11) NOT NULL DEFAULT 0,
  `Position` int(11) NOT NULL DEFAULT 0,
  `Date Voted` date DEFAULT curdate(),
  PRIMARY KEY (`Election ID`),
  KEY `FK_election_election_position` (`Position`),
  KEY `FK_election_candidates` (`Candidate`),
  KEY `FK_election_voters` (`Voter`),
  CONSTRAINT `FK_election_candidates` FOREIGN KEY (`Candidate`) REFERENCES `candidates` (`Candidate ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_election_election_position` FOREIGN KEY (`Position`) REFERENCES `position` (`Position ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_election_voters` FOREIGN KEY (`Voter`) REFERENCES `voters` (`Voters ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `election` (`Election ID`, `Voter`, `Candidate`, `Position`, `Date Voted`) VALUES
	(8, 1, 9, 1, '2025-05-11'),
	(12, 4, 9, 1, '2025-05-15'),
	(16, 5, 9, 1, '2025-05-16');

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
  `User ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID Number` int(11) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `is_Logged` tinyint(1) NOT NULL DEFAULT 0,
  `Permission` varchar(20) DEFAULT 'Voter',
  PRIMARY KEY (`User ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `users` (`User ID`, `ID Number`, `Password`, `is_Logged`, `Permission`) VALUES
	(1, 1, 'admin', 0, 'Admin'),
	(2, 2, 'ipisano', 0, 'Employee'),
	(3, 3, 'voterpass', 0, 'Voter');

CREATE TABLE IF NOT EXISTS `voters` (
  `Voters ID` int(11) NOT NULL AUTO_INCREMENT,
  `First Name` varchar(50) NOT NULL,
  `Last Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone Number` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`Voters ID`) USING BTREE,
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `voters` (`Voters ID`, `First Name`, `Last Name`, `Email`, `Phone Number`) VALUES
	(1, 'Kolokoy', 'Karding', 'Karding@gmail.com', '09783456677'),
	(4, 'Kenz', 'Abarquez', 'abarquez@gmail.com', '09663564939'),
	(5, 'Toto', 'Augusto', 'Augusto@gmail.com', '09663564939');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
