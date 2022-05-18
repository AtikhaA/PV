-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2022 at 07:11 AM
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
-- Database: `tugaspert8`
--

-- --------------------------------------------------------

--
-- Table structure for table `kasir1`
--

CREATE TABLE `kasir1` (
  `KodeBarang` varchar(6) NOT NULL,
  `NamaBarang` varchar(50) NOT NULL,
  `HargaBeli` int(20) NOT NULL,
  `HargaJual` int(20) NOT NULL,
  `Jumlahbarang` int(20) NOT NULL,
  `SatuanBarang` enum('Unit','Pcs','Kg','gram','7000') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kasir1`
--

INSERT INTO `kasir1` (`KodeBarang`, `NamaBarang`, `HargaBeli`, `HargaJual`, `Jumlahbarang`, `SatuanBarang`) VALUES
('BRG001', 'Photocard', 700000, 1200000, 1, 'Pcs');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
