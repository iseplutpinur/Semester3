SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE TABLE IF NOT EXISTS `tbl_guru` (
  `id_guru` int(5) NOT NULL AUTO_INCREMENT,
  `nik` int(6) NOT NULL,
  `nama_guru` varchar(50) NOT NULL,
  `agama` enum('ISLAM','KRISTEN','KHATOLIK','HINDU','BUDHA','KONGHUCHU') NOT NULL,
  `jk` enum('LAKI-LAKI','PEREMPUAN') NOT NULL,
  `alamat` text NOT NULL,
  `telp` varchar(15) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id_guru`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

INSERT INTO `tbl_guru` (`id_guru`, `nik`, `nama_guru`, `agama`, `jk`, `alamat`, `telp`, `password`) VALUES
(1, 320100023, 'razan aiman nadir', 'ISLAM', 'LAKI-LAKI', 'Bandung', '0123', '123'),
(2, 320100021, 'Razfin turfa sandy', 'ISLAM', 'LAKI-LAKI', 'Tasikmalaya', '1230', '123'),
(3, 320100029, 'Tini fatmawati', 'ISLAM', 'PEREMPUAN', 'Garut', '0123', '123'),
(4, 320100022, 'Vakrun nisah', 'ISLAM', 'PEREMPUAN', 'Ciamis', '1230', '123');

CREATE TABLE IF NOT EXISTS `tbl_mp` (
  `id_mp` int(11) NOT NULL AUTO_INCREMENT,
  `nama_mp` varchar(50) NOT NULL,
  PRIMARY KEY (`id_mp`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

INSERT INTO `tbl_mp` (`id_mp`, `nama_mp`) VALUES
(1, 'Bahasa indonesia'),
(2, 'Bahasa inggris'),
(3, 'Matematika');

CREATE TABLE IF NOT EXISTS `tbl_nilai` (
  `id_nilai` int(11) NOT NULL AUTO_INCREMENT,
  `id_siswa` int(8) NOT NULL,
  `id_guru` int(5) NOT NULL,
  `id_mp` int(3) NOT NULL,
  `nilai` int(3) NOT NULL,
  PRIMARY KEY (`id_nilai`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;

INSERT INTO `tbl_nilai` (`id_nilai`, `id_siswa`, `id_guru`, `id_mp`, `nilai`) VALUES
(1, 1, 1, 1, 84),
(2, 1, 1, 2, 88),
(3, 1, 1, 3, 99),
(4, 2, 2, 1, 77),
(5, 2, 2, 2, 88),
(6, 2, 2, 3, 77),
(7, 3, 3, 1, 22),
(8, 3, 3, 2, 33),
(9, 3, 3, 3, 11),
(10, 4, 1, 1, 22),
(11, 4, 1, 2, 55),
(12, 4, 1, 3, 75),
(13, 4, 2, 1, 89),
(14, 4, 2, 2, 55),
(15, 4, 2, 3, 90),
(16, 4, 3, 1, 75),
(17, 4, 3, 2, 70),
(18, 4, 3, 3, 80),
(19, 5, 1, 1, 60),
(20, 5, 1, 2, 90);

CREATE TABLE IF NOT EXISTS `tbl_siswa` (
  `id_siswa` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(8) NOT NULL,
  `nama_siswa` varchar(50) NOT NULL,
  `jk` enum('LAKI-LAKI','PEREMPUAN') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `kota_lahir` text NOT NULL,
  `agama` enum('ISLAM','KRISTEN','KHATOLIK','HINDU','BUDHA','KONGHUCHU') NOT NULL,
  `foto` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `nama_ortu` varchar(40) NOT NULL,
  `telp_ortu` varchar(15) NOT NULL,
  `id_thn_akademik` int(3) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id_siswa`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

INSERT INTO `tbl_siswa` (`id_siswa`, `nis`, `nama_siswa`, `jk`, `tgl_lahir`, `kota_lahir`, `agama`, `foto`, `alamat`, `nama_ortu`, `telp_ortu`, `id_thn_akademik`, `password`) VALUES
(1, 1, 'Adistia ramadhani', 'PEREMPUAN', '2000-10-10', 'Bandung', 'ISLAM', 'foto.png', 'bandung', 'Ahmad rizal imaduddin', '0123', 1, '123'),
(2, 2, 'Akbar maulana m. tarumadoya', 'LAKI-LAKI', '2000-10-10', 'Ternate', 'ISLAM', 'foto.png', 'Ternate', 'Alam Nurzaman', '0123', 1, '123'),
(3, 3, 'Chika stefanby siswandi', 'PEREMPUAN', '2000-10-10', 'Karawang', 'ISLAM', 'foto.png', 'Karawang', 'Dara atria ferliandini', '20123', 1, '123'),
(4, 4, 'Deri Kurniawan', 'LAKI-LAKI', '2000-10-10', 'Bandung', 'ISLAM', 'foto.png', 'Bandung', '0123', 'Dewi febrima ra', 1, '123'),
(5, 5, 'Domingos doutel sarmento', 'LAKI-LAKI', '2000-10-10', 'Timor leste', 'KRISTEN', 'foto.png', 'Timor leste', 'Fachruly Al huziry', '0123', 1, '123'),
(6, 6, 'Farhan aziz', 'LAKI-LAKI', '2000-10-10', 'Padang', 'ISLAM', 'foto.png', 'Bandung', 'Fernanda dewa ndaru santoso', '0123', 1, '123'),
(7, 7, 'Iman faturahman', 'LAKI-LAKI', '2000-10-10', 'Karawang', 'ISLAM', 'foto.png', 'Karawang', 'Irfan ramdani', '0123', 1, '123'),
(8, 8, 'Joshua dehari butar butar', 'LAKI-LAKI', '2000-10-10', 'Ciberem', 'KRISTEN', 'foto.png', 'Bandung', 'M bayu ramadhani', '0123', 1, '123'),
(9, 9, 'Mochamad fajar ramdani', 'LAKI-LAKI', '2000-10-10', 'Bandung', 'ISLAM', 'foto.png', 'bandung', 'mochamad hilmi fauzi', '0123', 1, '123'),
(10, 10, 'Mochamad rafi algiphari', 'LAKI-LAKI', '2000-10-10', 'Bandung', 'ISLAM', 'foto.png', 'bandung', 'putri hainuri ar-rahman', '0123', 1, '123');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
