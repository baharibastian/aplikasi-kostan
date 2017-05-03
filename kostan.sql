-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 04, 2017 at 01:06 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kostan`
--

-- --------------------------------------------------------

--
-- Table structure for table `kamar`
--

CREATE TABLE `kamar` (
  `kode_kamar` int(11) NOT NULL,
  `nama_kamar` varchar(50) NOT NULL,
  `harga_kamar` int(11) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kamar`
--

INSERT INTO `kamar` (`kode_kamar`, `nama_kamar`, `harga_kamar`, `status`) VALUES
(1, 'Kamar 1', 550000, 'Berisi'),
(2, 'Kamar 2', 400000, 'Berisi'),
(3, 'Kamar 3', 500000, 'Kosong'),
(4, 'Kamar 4', 500000, 'Kosong'),
(5, 'Kamar 5', 500000, 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `penghuni`
--

CREATE TABLE `penghuni` (
  `kode_penghuni` varchar(10) NOT NULL,
  `nomor_identitas` int(20) NOT NULL,
  `nama_penghuni` varchar(50) NOT NULL,
  `alamat_asal` varchar(100) NOT NULL,
  `asal_kota` varchar(50) NOT NULL,
  `no_telepon` int(12) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `pekerjaan` varchar(50) NOT NULL,
  `alamat_pekerjaan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penghuni`
--

INSERT INTO `penghuni` (`kode_penghuni`, `nomor_identitas`, `nama_penghuni`, `alamat_asal`, `asal_kota`, `no_telepon`, `jenis_kelamin`, `tanggal_lahir`, `pekerjaan`, `alamat_pekerjaan`) VALUES
('P001', 2147483647, 'Bahari Bastian Lumbantoruan', 'Jalan Aceh Dusun X Bandar Setia Sumatera Utara', 'Medan Sumut', 2147483647, 'Laki-Laki', '1998-05-17', 'Mahasiswa', 'Sekip Juga'),
('P002', 1027108278, 'Ahmad Rijal', 'Bantul', 'DIY', 2147483647, 'Laki-Laki', '2017-05-02', 'Mahasiswa', 'Sleman'),
('P003', 2147483647, 'Rahmat Fikrizal', 'Medan', 'Medan', 2147483647, 'Laki-Laki', '2017-05-04', 'Mahasiswa', 'Sendowo'),
('P004', 128931783, 'Aan Haris P', 'Blitar', 'Blitar', 2147483647, 'Perempuan', '2017-05-04', 'Mahasiswas', 'Sekip Depok');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `kode_transaksi` varchar(10) NOT NULL,
  `kode_penghuni` varchar(10) NOT NULL,
  `kode_kamar` varchar(10) NOT NULL,
  `periode` int(5) NOT NULL,
  `total_harga` int(10) NOT NULL,
  `tanggal_masuk` date NOT NULL,
  `tanggal_keluar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`kode_transaksi`, `kode_penghuni`, `kode_kamar`, `periode`, `total_harga`, `tanggal_masuk`, `tanggal_keluar`) VALUES
('TR001', 'P001', '1', 1, 550000, '2017-05-02', '2017-06-02');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(5) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`) VALUES
(1, 'bastian', 'bastian');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
