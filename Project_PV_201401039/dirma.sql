-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2022 at 02:46 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectpv`
--

-- --------------------------------------------------------

--
-- Table structure for table `dirma`
--

CREATE TABLE `dirma` (
  `nama` varchar(50) NOT NULL,
  `nim` varchar(9) NOT NULL,
  `email` varchar(50) NOT NULL,
  `angkatan` varchar(4) NOT NULL,
  `fakultas` varchar(50) NOT NULL,
  `jurusan` varchar(50) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL,
  `ips1` double NOT NULL,
  `ips2` double NOT NULL,
  `ips3` double NOT NULL,
  `ipk` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dirma`
--

INSERT INTO `dirma` (`nama`, `nim`, `email`, `angkatan`, `fakultas`, `jurusan`, `status`, `ips1`, `ips2`, `ips3`, `ipk`) VALUES
('Benedict Cumberbatch', '201000001', 'bencumber@gmail.com', '2020', 'FIB', 'Sastra Inggris', 'Aktif', 3.98, 3.99, 4, 3.99),
('Oscar Issac', '201000002', 'OscarIsSac@gmail.com', '2020', 'FH', 'Ilmu Hukum', 'Aktif', 3.96, 3.98, 3.97, 3.98),
('Martin Freeman', '201000003', 'martinfree@gmail.com', '2020', 'FISIP', 'Ilmu Politik', 'Aktif', 3.97, 3.98, 3.99, 3.98);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
