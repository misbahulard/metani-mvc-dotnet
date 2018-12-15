-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 15 Des 2018 pada 11.40
-- Versi Server: 10.1.26-MariaDB
-- PHP Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `metani`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `hasil_tani`
--

CREATE TABLE `hasil_tani` (
  `id_hasil` int(11) NOT NULL,
  `id_jenistani` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `id_lokasi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_tanah`
--

CREATE TABLE `jenis_tanah` (
  `id_jenistanah` int(11) NOT NULL,
  `nama_jenistanah` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_tani`
--

CREATE TABLE `jenis_tani` (
  `id_jenistani` int(11) NOT NULL,
  `nama_jenistani` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jenis_tani`
--

INSERT INTO `jenis_tani` (`id_jenistani`, `nama_jenistani`) VALUES
(2, 'kelapa'),
(3, 'jagung');

-- --------------------------------------------------------

--
-- Struktur dari tabel `lokasi`
--

CREATE TABLE `lokasi` (
  `id_lokasi` int(11) NOT NULL,
  `kecamatan` varchar(100) NOT NULL,
  `kabupaten` varchar(100) NOT NULL,
  `provinsi` varchar(100) NOT NULL,
  `kode_pos` int(11) NOT NULL,
  `latitude` decimal(10,6) NOT NULL,
  `longtitude` decimal(10,6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tanah`
--

CREATE TABLE `tanah` (
  `id_tanah` int(11) NOT NULL,
  `id_lokasi` int(11) NOT NULL,
  `id_jenistanah` int(11) NOT NULL,
  `luas_tanah` int(11) NOT NULL,
  `suhu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `hasil_tani`
--
ALTER TABLE `hasil_tani`
  ADD PRIMARY KEY (`id_hasil`),
  ADD KEY `id_jenistani` (`id_jenistani`),
  ADD KEY `id_hasil` (`id_hasil`,`id_jenistani`,`jumlah`,`id_lokasi`),
  ADD KEY `id_lokasi` (`id_lokasi`);

--
-- Indexes for table `jenis_tanah`
--
ALTER TABLE `jenis_tanah`
  ADD PRIMARY KEY (`id_jenistanah`),
  ADD KEY `id_jenistanah` (`id_jenistanah`,`nama_jenistanah`);

--
-- Indexes for table `jenis_tani`
--
ALTER TABLE `jenis_tani`
  ADD PRIMARY KEY (`id_jenistani`),
  ADD KEY `id_jenistani` (`id_jenistani`,`nama_jenistani`);

--
-- Indexes for table `lokasi`
--
ALTER TABLE `lokasi`
  ADD PRIMARY KEY (`id_lokasi`),
  ADD KEY `id_lokasi` (`id_lokasi`,`kecamatan`,`kabupaten`,`provinsi`,`kode_pos`,`latitude`,`longtitude`);

--
-- Indexes for table `tanah`
--
ALTER TABLE `tanah`
  ADD PRIMARY KEY (`id_tanah`),
  ADD KEY `id_tanah` (`id_tanah`,`id_lokasi`,`id_jenistanah`,`luas_tanah`,`suhu`),
  ADD KEY `id_lokasi` (`id_lokasi`),
  ADD KEY `id_jenistanah` (`id_jenistanah`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hasil_tani`
--
ALTER TABLE `hasil_tani`
  MODIFY `id_hasil` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `jenis_tanah`
--
ALTER TABLE `jenis_tanah`
  MODIFY `id_jenistanah` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `jenis_tani`
--
ALTER TABLE `jenis_tani`
  MODIFY `id_jenistani` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `lokasi`
--
ALTER TABLE `lokasi`
  MODIFY `id_lokasi` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tanah`
--
ALTER TABLE `tanah`
  MODIFY `id_tanah` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `hasil_tani`
--
ALTER TABLE `hasil_tani`
  ADD CONSTRAINT `hasil_tani_ibfk_1` FOREIGN KEY (`id_jenistani`) REFERENCES `jenis_tani` (`id_jenistani`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `hasil_tani_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `lokasi` (`id_lokasi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tanah`
--
ALTER TABLE `tanah`
  ADD CONSTRAINT `tanah_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `lokasi` (`id_lokasi`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tanah_ibfk_3` FOREIGN KEY (`id_jenistanah`) REFERENCES `jenis_tanah` (`id_jenistanah`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
