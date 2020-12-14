/*
SQLyog Enterprise - MySQL GUI v8.18 
MySQL - 5.0.27-community-nt 
*********************************************************************
*/
/*!40101 SET NAMES utf8 */;

create table `barang` (
	`kdbarang` varchar (18),
	`nmbarang` varchar (60),
	`suplier` varchar (75),
	`satuan` varchar (3),
	`harga` double 
); 
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000001','Frisian flag','MULYA UTAMA SEJAHTERA','X','90000');
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000002','Mama Lemon','PT. MAKMUR BERSAMA','X','10000');
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000003','Karpet ajaib','PT. ALIM UNTUNG','M','150000');
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000004','Pilus garuda','PT. MAKMUR BERSAMA','X','50000');
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000005','Super Pell','PT. INDAH MEKAR MULYA','L','50900');
insert into `barang` (`kdbarang`, `nmbarang`, `suplier`, `satuan`, `harga`) values('000006','Royco Ayam kaldu','PT. MAKMUR BERSAMA','X','20000');
