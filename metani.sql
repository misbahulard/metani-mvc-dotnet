-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 01 Jan 2019 pada 13.26
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

--
-- Dumping data untuk tabel `hasil_tani`
--

INSERT INTO `hasil_tani` (`id_hasil`, `id_jenistani`, `jumlah`, `id_lokasi`) VALUES
(11, 4, 45805, 5),
(12, 4, 78920, 6),
(13, 4, 49920, 7),
(14, 4, 58231, 8),
(15, 4, 98102, 9),
(16, 4, 12039, 10),
(17, 4, 62390, 11),
(18, 4, 59382, 12),
(19, 4, 70183, 13),
(20, 4, 92739, 14),
(21, 4, 89201, 15),
(22, 4, 83898, 16),
(23, 4, 82893, 17),
(24, 4, 91038, 18),
(25, 4, 94739, 19),
(26, 4, 94283, 20),
(27, 4, 52789, 21),
(28, 4, 92739, 22),
(29, 5, 12, 5),
(30, 5, 98, 6),
(31, 5, 23, 7),
(32, 5, 22, 8),
(33, 5, 12, 9),
(34, 5, 32, 10),
(35, 5, 21, 11),
(36, 5, 12, 12),
(37, 5, 14, 13),
(38, 5, 4, 14),
(39, 5, 23, 15),
(40, 5, 12, 16),
(41, 5, 14, 17),
(42, 5, 11, 18),
(43, 5, 10, 19),
(44, 5, 12, 20),
(45, 5, 9, 21),
(46, 5, 19, 22),
(47, 8, 560, 5),
(48, 8, 786, 6),
(49, 8, 552, 7),
(50, 8, 323, 8),
(51, 8, 121, 9),
(52, 8, 313, 10),
(53, 8, 342, 11),
(54, 8, 232, 12),
(55, 8, 343, 13),
(56, 8, 435, 14),
(57, 8, 643, 15),
(58, 8, 643, 16),
(59, 8, 232, 17),
(60, 8, 654, 18),
(61, 8, 655, 19),
(62, 8, 648, 20),
(63, 8, 223, 21),
(64, 8, 532, 22),
(65, 12, 121, 5),
(66, 12, 188, 6),
(67, 12, 121, 7),
(68, 12, 134, 8),
(69, 12, 153, 9),
(70, 12, 13, 10),
(71, 12, 212, 11),
(72, 12, 232, 12),
(73, 12, 134, 13),
(74, 12, 152, 14),
(75, 12, 22, 15),
(76, 12, 56, 16),
(77, 12, 132, 17),
(78, 12, 174, 18),
(79, 12, 44, 19),
(80, 12, 175, 20),
(81, 12, 132, 21),
(82, 12, 128, 22),
(83, 13, 1213, 5),
(84, 13, 3443, 6),
(85, 13, 2124, 7),
(86, 13, 1122, 8),
(87, 13, 8493, 9),
(88, 13, 2122, 10),
(89, 13, 3212, 11),
(90, 13, 2132, 12),
(91, 13, 1213, 13),
(92, 13, 3832, 14),
(93, 13, 2123, 15),
(94, 13, 3453, 16),
(95, 13, 5323, 17),
(96, 13, 2321, 18),
(97, 13, 3432, 19),
(98, 13, 5333, 20),
(99, 13, 900, 21),
(100, 13, 3324, 22),
(101, 16, 934, 5),
(102, 16, 3209, 6),
(103, 16, 1233, 7),
(104, 16, 1300, 8),
(105, 16, 5340, 9),
(106, 16, 123, 10),
(107, 16, 3430, 11),
(108, 16, 2325, 12),
(109, 16, 2425, 13),
(110, 16, 845, 14),
(111, 16, 3249, 15),
(112, 16, 2340, 16),
(113, 16, 5859, 17),
(114, 16, 3495, 18),
(115, 16, 324, 19),
(116, 16, 2483, 20),
(117, 16, 324, 21),
(118, 16, 4359, 22),
(119, 19, 90, 5),
(120, 19, 120, 6),
(121, 19, 113, 7),
(122, 19, 119, 8),
(123, 19, 131, 9),
(124, 19, 139, 10),
(125, 19, 147, 11),
(126, 19, 155, 12),
(127, 19, 163, 13),
(128, 19, 171, 14),
(129, 19, 179, 15),
(130, 19, 187, 16),
(131, 19, 195, 17),
(132, 19, 203, 18),
(133, 19, 211, 19),
(134, 19, 219, 20),
(135, 19, 227, 21),
(136, 19, 235, 22),
(137, 20, 119, 5),
(138, 20, 348, 6),
(139, 20, 230, 7),
(140, 20, 185, 8),
(141, 20, 241, 9),
(142, 20, 249, 10),
(143, 20, 257, 11),
(144, 20, 265, 12),
(145, 20, 273, 13),
(146, 20, 281, 14),
(147, 20, 289, 15),
(148, 20, 297, 16),
(149, 20, 305, 17),
(150, 20, 313, 18),
(151, 20, 321, 19),
(152, 20, 329, 20),
(153, 20, 337, 21),
(154, 20, 345, 22),
(155, 22, 90, 5),
(156, 22, 57, 6),
(157, 22, 31, 7),
(158, 22, 34, 8),
(159, 22, 4, 9),
(160, 22, 23, 10),
(161, 22, 42, 11),
(162, 22, 8, 12),
(163, 22, 45, 13),
(164, 22, 11, 14),
(165, 22, 32, 15),
(166, 22, 13, 16),
(167, 22, 16, 17),
(168, 22, 14, 18),
(169, 22, 23, 19),
(170, 22, 53, 20),
(171, 22, 14, 21),
(172, 22, 23, 22),
(173, 23, 2, 5),
(174, 23, 4, 6),
(175, 23, 2, 7),
(176, 23, 6, 8),
(177, 23, 3, 9),
(178, 23, 6, 10),
(179, 23, 4, 11),
(180, 23, 3, 12),
(181, 23, 2, 13),
(182, 23, 6, 14),
(183, 23, 4, 15),
(184, 23, 6, 16),
(185, 23, 3, 17),
(186, 23, 2, 18),
(187, 23, 6, 19),
(188, 23, 3, 20),
(189, 23, 5, 21),
(190, 23, 5, 22),
(191, 24, 2, 5),
(192, 24, 2, 6),
(193, 24, 3, 7),
(194, 24, 8, 8),
(195, 24, 5, 9),
(196, 24, 3, 10),
(197, 24, 2, 11),
(198, 24, 6, 12),
(199, 24, 2, 13),
(200, 24, 7, 14),
(201, 24, 5, 15),
(202, 24, 6, 16),
(203, 24, 3, 17),
(204, 24, 7, 18),
(205, 24, 2, 19),
(206, 24, 7, 20),
(207, 24, 4, 21),
(208, 24, 3, 22),
(209, 25, 3, 5),
(210, 25, 9, 6),
(211, 25, 4, 7),
(212, 25, 5, 8),
(213, 25, 3, 9),
(214, 25, 6, 10),
(215, 25, 7, 11),
(216, 25, 5, 12),
(217, 25, 4, 13),
(218, 25, 3, 14),
(219, 25, 6, 15),
(220, 25, 2, 16),
(221, 25, 6, 17),
(222, 25, 6, 18),
(223, 25, 2, 19),
(224, 26, 7, 20),
(225, 26, 3, 21),
(226, 26, 4, 22),
(227, 26, 8, 5),
(228, 26, 12, 6),
(229, 26, 0, 7),
(230, 26, 0, 8),
(231, 26, 0, 9),
(232, 26, 0, 10),
(233, 26, 4, 11),
(234, 26, 3, 12),
(235, 26, 7, 13),
(236, 26, 2, 14),
(237, 26, 0, 15),
(238, 26, 0, 16),
(239, 26, 0, 17),
(240, 26, 8, 18),
(241, 26, 5, 19),
(242, 26, 2, 20),
(243, 26, 9, 21),
(244, 26, 6, 22),
(245, 27, 0, 5),
(246, 27, 0, 6),
(247, 27, 0, 7),
(248, 27, 0, 8),
(249, 27, 0, 9),
(250, 27, 0, 10),
(251, 27, 0, 11),
(252, 27, 0, 12),
(253, 27, 0, 13),
(254, 27, 0, 14),
(255, 27, 0, 15),
(256, 27, 0, 16),
(257, 27, 0, 17),
(258, 27, 0, 18),
(259, 28, 0, 19),
(260, 28, 0, 20),
(261, 28, 0, 21),
(262, 28, 0, 22),
(263, NULL, 0, NULL),
(264, 28, 4, 5),
(265, 28, 2, 6),
(266, 28, 4, 7),
(267, 28, 2, 8),
(268, 28, 0, 9),
(269, 28, 8, 10),
(270, 28, 5, 11),
(271, 28, 3, 12),
(272, 28, 2, 13),
(273, 28, 2, 14),
(274, 28, 6, 15),
(275, 28, 3, 16),
(276, 28, 7, 17),
(277, 28, 3, 18),
(278, 28, 7, 19),
(279, 28, 4, 20),
(280, 28, 2, 21),
(281, 28, 7, 22),
(282, 29, 3, 5),
(283, 29, 5, 6),
(284, 29, 6, 7),
(285, 29, 5, 8),
(286, 29, 1, 9),
(287, 29, 3, 10),
(288, 29, 4, 11),
(289, 29, 2, 12),
(290, 29, 3, 13),
(291, 29, 2, 14),
(292, 29, 1, 15),
(293, 29, 3, 16),
(294, 29, 4, 17),
(295, 29, 5, 18),
(296, 29, 3, 19),
(297, 29, 1, 20),
(298, 29, 5, 21),
(299, 29, 2, 22),
(300, 30, 2, 5),
(301, 30, 3, 6),
(302, 30, 3, 7),
(303, 30, 2, 8),
(304, 30, 1, 9),
(305, 30, 4, 10),
(306, 30, 4, 11),
(307, 30, 1, 12),
(308, 30, 2, 13),
(309, 30, 4, 14),
(310, 30, 1, 15),
(311, 30, 4, 16),
(312, 30, 2, 17),
(313, 30, 5, 18),
(314, 30, 2, 19),
(315, 30, 5, 20),
(316, 30, 2, 21),
(317, 30, 5, 22),
(318, 31, 3, 5),
(319, 31, 4, 6),
(320, 31, 2, 7),
(321, 31, 4, 8),
(322, 31, 2, 9),
(323, 31, 2, 10),
(324, 31, 5, 11),
(325, 31, 2, 12),
(326, 31, 4, 13),
(327, 31, 1, 14),
(328, 31, 3, 15),
(329, 31, 5, 16),
(330, 31, 2, 17),
(331, 31, 5, 18),
(332, 31, 2, 19),
(333, 31, 5, 20),
(334, 31, 4, 21),
(335, 31, 2, 22),
(336, 32, 2, 5),
(337, 32, 3, 6),
(338, 32, 2, 7),
(339, 32, 5, 8),
(340, 32, 3, 9),
(341, 32, 5, 10),
(342, 32, 1, 11),
(343, 32, 4, 12),
(344, 32, 2, 13),
(345, 32, 4, 14),
(346, 32, 2, 15),
(347, 32, 5, 16),
(348, 32, 2, 17),
(349, 32, 5, 18),
(350, 32, 2, 19),
(351, 32, 4, 20),
(352, 32, 2, 21),
(353, 32, 5, 22),
(354, 33, 0, 5),
(355, 33, 0, 6),
(356, 33, 0, 7),
(357, 33, 0, 8),
(358, 33, 0, 9),
(359, 33, 0, 10),
(360, 33, 0, 11),
(361, 33, 0, 12),
(362, 33, 0, 13),
(363, 33, 0, 14),
(364, 33, 0, 15),
(365, 33, 0, 16),
(366, 33, 0, 17),
(367, 33, 0, 18),
(368, 33, 0, 19),
(369, 33, 0, 20),
(370, 33, 0, 21),
(371, 33, 0, 22);

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_tanah`
--

CREATE TABLE `jenis_tanah` (
  `id_jenistanah` int(11) NOT NULL,
  `nama_jenistanah` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jenis_tanah`
--

INSERT INTO `jenis_tanah` (`id_jenistanah`, `nama_jenistanah`) VALUES
(2, 'Persawahan'),
(3, 'Perkebunan'),
(4, 'Tambak'),
(5, 'Non pertanian');

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
(4, 'Padi'),
(5, 'Jagung'),
(8, 'Kacang Hijau'),
(12, 'Kedelai'),
(13, 'Tebu'),
(16, 'Cabai'),
(19, 'Tomat'),
(20, 'Bayam'),
(22, 'Terung'),
(23, 'Kangkung'),
(24, 'Mentimun'),
(25, 'Kacang Panjang'),
(26, 'Sawo'),
(27, 'Alpukat'),
(28, 'Belimbing'),
(29, 'Jambu Air'),
(30, 'Jambu Biji'),
(31, 'Nangka'),
(32, 'Pepaya'),
(33, 'Jeruk Keprok'),
(34, 'Semangka'),
(35, 'Jeruk Siam'),
(36, 'Mangga'),
(37, 'Pisang'),
(38, 'Rambutan');

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

--
-- Dumping data untuk tabel `lokasi`
--

INSERT INTO `lokasi` (`id_lokasi`, `kecamatan`, `kabupaten`, `provinsi`, `kode_pos`, `latitude`, `longtitude`) VALUES
(5, 'Sidoarjo', 'Sidoarjo', 'Jawa Timur', 61212, '-7.449772', '112.701550'),
(6, 'Candi', 'Sidoarjo', 'Jawa Timur', 61271, '-7.484229', '112.733089'),
(7, 'Buduran', 'Sidoarjo', 'Jawa Timur', 61252, '-7.432460', '112.756924'),
(8, 'Gedangan', 'Sidoarjo', 'Jawa Timur', 61254, '-7.393381', '112.733089'),
(9, 'Tanggulangin', 'Sidoarjo', 'Jawa Timur', 61272, '-7.514540', '112.733089'),
(10, 'Waru', 'Sidoarjo', 'Jawa Timur', 61256, '-7.351144', '112.768842'),
(11, 'Porong', 'Sidoarjo', 'Jawa Timur', 61274, '-7.526590', '112.697336'),
(12, 'Taman', 'Sidoarjo', 'Jawa Timur', 61212, '-7.353607', '112.698825'),
(13, 'Krembung', 'Sidoarjo', 'Jawa Timur', 61275, '-7.519709', '112.637743'),
(14, 'Jabon', 'Sidoarjo', 'Jawa Timur', 61276, '-7.559056', '112.750966'),
(15, 'Tulangan', 'Sidoarjo', 'Jawa Timur', 61273, '-7.478628', '112.649662'),
(16, 'Krian', 'Sidoarjo', 'Jawa Timur', 61262, '-7.401005', '112.590067'),
(17, 'Balongbendo', 'Sidoarjo', 'Jawa Timur', 61263, '-7.409455', '112.549839'),
(18, 'Wonoayu', 'Sidoarjo', 'Jawa Timur', 61261, '-7.424027', '112.631784'),
(19, 'Tarik', 'Sidoarjo', 'Jawa Timur', 61265, '-7.459203', '112.517059'),
(20, 'Prambon', 'Sidoarjo', 'Jawa Timur', 61264, '-7.466990', '112.584108'),
(21, 'Sedati', 'Sidoarjo', 'Jawa Timur', 61253, '-7.394913', '112.798634'),
(22, 'Sukodono', 'Sidoarjo', 'Jawa Timur', 61216, '-7.394667', '112.673786');

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

--
-- Dumping data untuk tabel `tanah`
--

INSERT INTO `tanah` (`id_tanah`, `id_lokasi`, `id_jenistanah`, `luas_tanah`, `suhu`) VALUES
(1, 5, 2, 303, 24),
(2, 6, 2, 933, 24),
(3, 7, 2, 572, 24),
(4, 8, 2, 702, 24),
(5, 9, 2, 1703, 24),
(6, 10, 2, 70, 24),
(7, 11, 2, 797, 24),
(8, 12, 2, 736, 24),
(9, 13, 2, 820, 24),
(10, 14, 2, 1191, 24),
(11, 15, 2, 1082, 24),
(12, 16, 2, 1073, 24),
(13, 17, 2, 1094, 24),
(14, 18, 2, 14000, 24),
(15, 19, 2, 1597, 24),
(16, 20, 2, 1512, 24),
(17, 21, 2, 661, 24),
(18, 22, 2, 1490, 24),
(19, 5, 3, 293, 24),
(20, 6, 3, 389, 24),
(21, 7, 3, 520, 24),
(22, 8, 3, 489, 24),
(23, 9, 3, 981, 24),
(24, 10, 3, 189, 24),
(25, 11, 3, 231, 24),
(26, 12, 3, 201, 24),
(27, 13, 3, 311, 24),
(28, 14, 3, 320, 24),
(29, 15, 3, 789, 24),
(30, 16, 3, 980, 24),
(31, 17, 3, 921, 24),
(32, 18, 3, 781, 24),
(33, 19, 3, 981, 24),
(34, 20, 3, 873, 24),
(35, 21, 3, 231, 24),
(36, 22, 3, 789, 24),
(37, 5, 4, 90, 24),
(38, 6, 4, 127, 24),
(39, 7, 4, 91, 24),
(40, 8, 4, 78, 24),
(41, 9, 4, 8, 24),
(42, 10, 4, 78, 24),
(43, 11, 4, 30, 24),
(44, 12, 4, 12, 24),
(45, 13, 4, 43, 24),
(46, 14, 4, 23, 24),
(47, 15, 4, 20, 24),
(48, 16, 4, 31, 24),
(49, 17, 4, 30, 24),
(50, 18, 4, 20, 24),
(51, 19, 4, 21, 24),
(52, 20, 4, 11, 24),
(53, 21, 4, 189, 24),
(54, 22, 4, 10, 24),
(55, 5, 5, 218, 24),
(56, 6, 5, 187, 24),
(57, 7, 5, 78, 24),
(58, 8, 5, 90, 24),
(59, 9, 5, 290, 24),
(60, 10, 5, 56, 24),
(61, 11, 5, 123, 24),
(62, 12, 5, 221, 24),
(63, 13, 5, 423, 24),
(64, 14, 5, 234, 24),
(65, 15, 5, 384, 24),
(66, 16, 5, 220, 24),
(67, 17, 5, 300, 24),
(68, 18, 5, 429, 24),
(69, 19, 5, 403, 24),
(70, 20, 5, 592, 24),
(71, 21, 5, 110, 24),
(72, 22, 5, 500, 24);

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
  MODIFY `id_hasil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=372;
--
-- AUTO_INCREMENT for table `jenis_tanah`
--
ALTER TABLE `jenis_tanah`
  MODIFY `id_jenistanah` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `jenis_tani`
--
ALTER TABLE `jenis_tani`
  MODIFY `id_jenistani` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
--
-- AUTO_INCREMENT for table `lokasi`
--
ALTER TABLE `lokasi`
  MODIFY `id_lokasi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `tanah`
--
ALTER TABLE `tanah`
  MODIFY `id_tanah` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;
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
