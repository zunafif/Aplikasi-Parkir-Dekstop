-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 12, 2020 at 05:44 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `parkir`
--

-- --------------------------------------------------------

--
-- Table structure for table `biaya`
--

CREATE TABLE `biaya` (
  `jenis` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `biaya`
--

INSERT INTO `biaya` (`jenis`, `harga`) VALUES
('RODA2', 1000),
('RODA4', 3000),
('RODA6', 5000);

-- --------------------------------------------------------

--
-- Table structure for table `keluar`
--

CREATE TABLE `keluar` (
  `id_keluar` int(11) NOT NULL,
  `id_petugas` int(11) NOT NULL,
  `plat` varchar(10) NOT NULL,
  `tgl_keluar` date NOT NULL,
  `jam_keluar` int(11) NOT NULL,
  `lama` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `keluar`
--

INSERT INTO `keluar` (`id_keluar`, `id_petugas`, `plat`, `tgl_keluar`, `jam_keluar`, `lama`, `total`) VALUES
(1, 2, 'AE3434W', '2020-07-04', 21, 1, 1000),
(2, 1, 'AE2525WW', '2020-07-05', 1, 4, 4000),
(6, 2, 'W2201AG', '2020-07-05', 21, 24, 24000),
(7, 1, 'AG12344WW', '2020-07-05', 20, 24, 24000),
(8, 2, 'AG123WW', '2020-07-05', 20, 24, 24000),
(9, 1, 'W4567G', '2020-07-07', 10, 2, 6000),
(10, 1, 'W4567G', '2020-07-08', 10, 26, 78000);

-- --------------------------------------------------------

--
-- Table structure for table `masuk`
--

CREATE TABLE `masuk` (
  `plat` varchar(10) NOT NULL,
  `jenis` varchar(50) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `jam_masuk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `masuk`
--

INSERT INTO `masuk` (`plat`, `jenis`, `tgl_masuk`, `jam_masuk`) VALUES
('AE2525WW', 'RODA2', '2020-07-04', 21),
('AE3434W', 'RODA2', '2020-07-04', 20),
('AG12344WW', 'RODA2', '2020-07-04', 20),
('AG123WW', 'RODA2', '2020-07-04', 20),
('W2201AG', 'RODA2', '2020-07-05', 21),
('W2343AA', 'RODA2', '2020-07-06', 21),
('W4567G', 'RODA4', '2020-07-07', 8),
('W4567GA', 'RODA4', '2020-07-07', 8);

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `id` int(11) NOT NULL,
  `Nama` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`id`, `Nama`) VALUES
(1, 'Parman'),
(2, 'Manto');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `biaya`
--
ALTER TABLE `biaya`
  ADD PRIMARY KEY (`jenis`);

--
-- Indexes for table `keluar`
--
ALTER TABLE `keluar`
  ADD PRIMARY KEY (`id_keluar`),
  ADD KEY `fk_petugas` (`id_petugas`),
  ADD KEY `fk_masuk` (`plat`);

--
-- Indexes for table `masuk`
--
ALTER TABLE `masuk`
  ADD PRIMARY KEY (`plat`),
  ADD KEY `fk_biaya` (`jenis`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `keluar`
--
ALTER TABLE `keluar`
  MODIFY `id_keluar` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `petugas`
--
ALTER TABLE `petugas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `keluar`
--
ALTER TABLE `keluar`
  ADD CONSTRAINT `fk_masuk` FOREIGN KEY (`plat`) REFERENCES `masuk` (`plat`),
  ADD CONSTRAINT `fk_petugas` FOREIGN KEY (`id_petugas`) REFERENCES `petugas` (`id`);

--
-- Constraints for table `masuk`
--
ALTER TABLE `masuk`
  ADD CONSTRAINT `fk_biaya` FOREIGN KEY (`jenis`) REFERENCES `biaya` (`jenis`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
