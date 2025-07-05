-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 03 jan. 2025 à 17:18
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `hotelmanagement`
--

-- --------------------------------------------------------

--
-- Structure de la table `checkin`
--

DROP TABLE IF EXISTS `checkin`;
CREATE TABLE IF NOT EXISTS `checkin` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `DateDebut` date NOT NULL,
  `DateFin` date NOT NULL,
  `NumberRoom` int NOT NULL,
  `CheckedOut` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `checkin`
--

INSERT INTO `checkin` (`ID`, `Name`, `Email`, `Phone`, `DateDebut`, `DateFin`, `NumberRoom`, `CheckedOut`) VALUES
(63, 'Oualid', 'oualid@test.com', '07xxxx', '2025-01-02', '2025-01-04', 111, 0),
(62, 'Saad', 'Saad@test.com', '06xxxxxxx', '2025-01-02', '2025-01-05', 111, 1);

-- --------------------------------------------------------

--
-- Structure de la table `checkout`
--

DROP TABLE IF EXISTS `checkout`;
CREATE TABLE IF NOT EXISTS `checkout` (
  `ID` int NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `DateDebut` date NOT NULL,
  `DateFin` date NOT NULL,
  `NumberRoom` int NOT NULL,
  `Amount` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `checkout`
--

INSERT INTO `checkout` (`ID`, `Name`, `Email`, `Phone`, `DateDebut`, `DateFin`, `NumberRoom`, `Amount`) VALUES
(62, 'Saad', 'Saad@test.com', '06xxxxxxx', '2025-01-02', '2025-01-05', 111, 600);

-- --------------------------------------------------------

--
-- Structure de la table `customers`
--

DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `Nationality` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=113 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `customers`
--

INSERT INTO `customers` (`id`, `Name`, `Email`, `Phone`, `Nationality`) VALUES
(112, 'Oualid', 'oualid@test.com', '07xxxx', 'Marocaine'),
(111, 'Saad', 'Saad@test.com', '06xxxxxxx', 'Marocaine');

-- --------------------------------------------------------

--
-- Structure de la table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
CREATE TABLE IF NOT EXISTS `rooms` (
  `id` int NOT NULL AUTO_INCREMENT,
  `number` int NOT NULL,
  `type` varchar(50) NOT NULL,
  `bed` varchar(10) DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `availability` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `number` (`number`)
) ENGINE=MyISAM AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `rooms`
--

INSERT INTO `rooms` (`id`, `number`, `type`, `bed`, `price`, `availability`) VALUES
(13, 103, 'Double', 'Double', 80.00, 1),
(14, 104, 'Suite', 'Double', 200.00, 1),
(15, 105, 'Deluxe', 'Double', 120.00, 1),
(16, 106, 'Single', 'Single', 45.00, 1),
(17, 107, 'Double', 'Double', 85.00, 1),
(18, 108, 'Suite', 'Single', 180.00, 1),
(19, 109, 'Deluxe', 'Single', 110.00, 1),
(20, 110, 'Single', 'Single', 55.00, 1),
(21, 111, 'Single', 'Double', 300.00, 0),
(25, 120, 'Deluxe', 'Double', 456.00, 1),
(23, 121, 'Deluxe', 'Double', 120.00, 1),
(26, 155, 'Deluxe', 'Single', 299.00, 1),
(29, 200, 'Single', 'Single', 50.00, 1),
(30, 201, 'Single', 'Double', 55.00, 1),
(31, 202, 'Double', 'Single', 80.00, 1),
(32, 203, 'Double', 'Double', 85.00, 1),
(33, 204, 'Suite', 'Single', 150.00, 1),
(34, 205, 'Suite', 'Double', 160.00, 1),
(35, 206, 'Deluxe', 'Single', 200.00, 1),
(36, 207, 'Deluxe', 'Double', 220.00, 1),
(37, 208, 'Single', 'Single', 60.00, 1),
(38, 209, 'Single', 'Double', 65.00, 1),
(39, 210, 'Double', 'Single', 90.00, 1),
(40, 211, 'Double', 'Double', 95.00, 1),
(41, 212, 'Suite', 'Single', 170.00, 1),
(42, 213, 'Suite', 'Double', 180.00, 1),
(43, 214, 'Deluxe', 'Single', 210.00, 1),
(44, 215, 'Deluxe', 'Double', 230.00, 1);

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `City` varchar(100) DEFAULT NULL,
  `Profession` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Email` (`Email`),
  UNIQUE KEY `Phone` (`Phone`),
  KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=131 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `Name`, `Email`, `Phone`, `City`, `Profession`) VALUES
(130, 'Jane Austen', 'jane.austen@example.com', '02xxxxxxxxxxx', 'Orlando', 'Spa Therapist'),
(129, 'Ian McKellen', 'ian.mckellen@example.com', '9012345678', 'Atlanta', 'Room Service Attendant'),
(128, 'Hannah Montana', 'hannah.montana@example.com', '8901234567', 'Seattle', 'Valet'),
(127, 'George Clooney', 'george.clooney@example.com', '7890123456', 'Boston', 'Bartender'),
(126, 'Fiona Gallagher', 'fiona.gallagher@example.com', '6789012345', 'Las Vegas', 'Event Coordinator'),
(125, 'Ethan Hunt', 'ethan.hunt@example.com', '5678901234', 'Miami', 'Chef'),
(124, 'Diana Prince', 'diana.prince@example.com', '4567890123', 'San Francisco', 'Housekeeping Supervisor'),
(123, 'Charlie Brown', 'charlie.brown@example.com', '3456789012', 'Chicago', 'Concierge'),
(121, 'Alice Johnson', 'alice.johnson@example.com', '1234567', 'New York', 'Hotel Manager'),
(122, 'Bob Smith', 'bob.smith@example.com', '2345678901', 'Los Angeles', 'Front Desk Clerk');

-- --------------------------------------------------------

--
-- Structure de la table `webclients`
--

DROP TABLE IF EXISTS `webclients`;
CREATE TABLE IF NOT EXISTS `webclients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `RoomType` varchar(20) NOT NULL,
  `BedType` varchar(20) NOT NULL,
  `DateDebut` date NOT NULL,
  `DateFin` date NOT NULL,
  `nationality` varchar(50) NOT NULL,
  `status` varchar(50) DEFAULT 'in progress',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `webclients`
--

INSERT INTO `webclients` (`id`, `Name`, `Phone`, `Email`, `RoomType`, `BedType`, `DateDebut`, `DateFin`, `nationality`, `status`) VALUES
(1, 'John Doe', '1234567890', 'john.doe@example.com', 'Single', 'Single', '2025-01-01', '2025-01-05', 'American', 'Refused'),
(2, 'Jane Smith', '9876543210', 'jane.smith@example.com', 'Double', 'Double', '2025-01-02', '2025-01-06', 'British', 'in progress'),
(3, 'Saadtest', '5432167890', 'ahmed.ali@example.com', 'Suite', 'Single', '2025-01-03', '2025-01-07', 'Egyptian', 'in progress'),
(4, 'Maria Garcia', '6543219870', 'maria.garcia@example.com', 'Deluxe', 'Double', '2025-01-04', '2025-01-08', 'Spanish', 'Accepted'),
(5, 'Li Wei', '1230984567', 'oualidmansour16@gmail.com', 'Single', 'Single', '2025-01-05', '2025-01-09', 'Chinese', 'in progress'),
(6, 'Emily Brown', '9873216540', 'emily.brown@example.com', 'Double', 'Double', '2025-01-06', '2025-01-10', 'Canadian', 'Accepted'),
(7, 'Mohammed Khan', '7896541230', 'mohammed.khan@example.com', 'Deluxe', 'Single', '2025-01-07', '2025-01-11', 'Pakistani', 'in progress'),
(8, 'Sofia Rossi', '3214569870', 'sofia.rossi@example.com', 'Suite', 'Double', '2025-01-08', '2025-01-12', 'Italian', 'in progress'),
(9, 'James Lee', '6549873210', 'james.lee@example.com', 'Single', 'Single', '2025-01-09', '2025-01-13', 'Australian', 'in progress'),
(10, 'Hana Tanaka', '7891236540', 'hana.tanaka@example.com', 'Double', 'Double', '2025-01-10', '2025-01-14', 'Japanese', 'Accepted');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
