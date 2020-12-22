/*
SQLyog Enterprise - MySQL GUI v8.18 
MySQL - 5.0.27-community-nt 
*********************************************************************
*/
/*!40101 SET NAMES utf8 */;

create table `barang` (
	`kdbarang` varchar (18),
	`nmbarang` varchar (60),
	`supplier` varchar (75),
	`satuan` varchar (3),
	`harga` double 
); 
insert into `barang` (`kdbarang`, `nmbarang`, `supplier`, `satuan`, `harga`) values('000001','Optical mouse','CV. SUMBER UTAMA BERKAH','B','90000');
insert into `barang` (`kdbarang`, `nmbarang`, `supplier`, `satuan`, `harga`) values('000002','Ultra milk','PT. INDAH MEKAR MULYA','L','100000');
insert into `barang` (`kdbarang`, `nmbarang`, `supplier`, `satuan`, `harga`) values('000003','Buku pintar2','CV. SUMBER UTAMA BERKAH','D','100001');
