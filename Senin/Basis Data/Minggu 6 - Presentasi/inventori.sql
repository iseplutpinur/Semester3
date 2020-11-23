/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     23/11/2020 13.08.54                          */
/*==============================================================*/


drop table if exists BARANG_DATA;

drop table if exists BARANG_JENIS;

drop table if exists BARANG_PENGADAAN;

drop table if exists BARANG_PENGADAAN_DATA;

drop table if exists BARANG_PENJUALAN;

drop table if exists BARANG_PENJUALAN_DATA;

drop table if exists BARANG_SUPLIER;

drop table if exists USER;

/*==============================================================*/
/* Table: BARANG_DATA                                           */
/*==============================================================*/
create table BARANG_DATA
(
   ID_BARANG_DATA       int not null,
   ID_BARANG_JENIS      int,
   BARANG_DATA_NAMA     varchar(200),
   BARANG_DATA_KODE     varchar(50),
   BARANG_DATA_HARGA    bigint,
   BARANG_DATA_TANGGAL_KADALUARSA date,
   BARANG_DATA_STOK     int,
   BARANG_DATA_DISKON   int,
   primary key (ID_BARANG_DATA)
);

/*==============================================================*/
/* Table: BARANG_JENIS                                          */
/*==============================================================*/
create table BARANG_JENIS
(
   ID_BARANG_JENIS      int not null,
   BARANG_JENIS_NAMA    varchar(50),
   primary key (ID_BARANG_JENIS)
);

/*==============================================================*/
/* Table: BARANG_PENGADAAN                                      */
/*==============================================================*/
create table BARANG_PENGADAAN
(
   ID_BARANG_PENGADAAN  int not null,
   ID_USER              int,
   ID_BARANG_SUPLIER    int,
   BARANG_PENGADAAN_KODE_TRANSAKSI varchar(50),
   BARANG_PENGADAAN_WAKTU datetime,
   primary key (ID_BARANG_PENGADAAN)
);

/*==============================================================*/
/* Table: BARANG_PENGADAAN_DATA                                 */
/*==============================================================*/
create table BARANG_PENGADAAN_DATA
(
   ID_BARANG_PENGADAAN_DATA int not null,
   ID_BARANG_DATA       int,
   ID_BARANG_PENGADAAN  int,
   BARANG_PENGADAAN_DATA_JUMLAH int,
   primary key (ID_BARANG_PENGADAAN_DATA)
);

/*==============================================================*/
/* Table: BARANG_PENJUALAN                                      */
/*==============================================================*/
create table BARANG_PENJUALAN
(
   ID_BARANG_PENJUALAN  int not null,
   ID_USER              int,
   BARANG_PENJUALAN_KODE_TRANSAKSI char(25),
   BARANG_PENJUALAN_TOTAL_HARGA bigint,
   BARANG_PENJUALAN_WAKTU datetime,
   primary key (ID_BARANG_PENJUALAN)
);

/*==============================================================*/
/* Table: BARANG_PENJUALAN_DATA                                 */
/*==============================================================*/
create table BARANG_PENJUALAN_DATA
(
   ID_BARANG_PENJUALAN_DATA int not null,
   ID_BARANG_DATA       int,
   ID_BARANG_PENJUALAN  int,
   BARANG_PENJUALAN_DATA_DISKON int,
   BARANG_PENJUALAN_DATA_JUMLAH int,
   BARANG_PENJUALAN_DATA_HARGA bigint,
   primary key (ID_BARANG_PENJUALAN_DATA)
);

/*==============================================================*/
/* Table: BARANG_SUPLIER                                        */
/*==============================================================*/
create table BARANG_SUPLIER
(
   ID_BARANG_SUPLIER    int not null,
   BARANG_SUPLIER_NAMA  varchar(50),
   BARANG_SUPLIER_ALAMAT text,
   BARANG_SUPLIER_NO_TELP varchar(14),
   BARANG_SUPLIER_EMALI varchar(50),
   BARANG_SUPLIER_TANGGAL_REGISTRASI time,
   BARANG_SUPLIER_KODE  varchar(50),
   primary key (ID_BARANG_SUPLIER)
);

/*==============================================================*/
/* Table: USER                                                  */
/*==============================================================*/
create table USER
(
   ID_USER              int not null,
   USERNAME             varchar(50),
   PASSWORD             varchar(255),
   EMAIL                varchar(50),
   NAMA_LENGKAP         varchar(50),
   ALAMAT               text,
   JENIS_KELAMIN        varchar(10),
   TANGGAL_LAHIR        date,
   NIK                  varchar(17),
   NO_TELEPON           varchar(14),
   FOTO                 varchar(50),
   JABATAN              varchar(20),
   primary key (ID_USER)
);

alter table BARANG_DATA add constraint FK_DETAIL_JENIS foreign key (ID_BARANG_JENIS)
      references BARANG_JENIS (ID_BARANG_JENIS) on delete restrict on update restrict;

alter table BARANG_PENGADAAN add constraint FK_MELAKUKAN_PENGADAAN foreign key (ID_USER)
      references USER (ID_USER) on delete restrict on update restrict;

alter table BARANG_PENGADAAN add constraint FK_MEMENUHI_PENGADAAN foreign key (ID_BARANG_SUPLIER)
      references BARANG_SUPLIER (ID_BARANG_SUPLIER) on delete restrict on update restrict;

alter table BARANG_PENGADAAN_DATA add constraint FK_DETAIL_PENGADAAN_DATA foreign key (ID_BARANG_PENGADAAN)
      references BARANG_PENGADAAN (ID_BARANG_PENGADAAN) on delete restrict on update restrict;

alter table BARANG_PENGADAAN_DATA add constraint FK_DETAIL_PENGADAAN_DATA_BARANG foreign key (ID_BARANG_DATA)
      references BARANG_DATA (ID_BARANG_DATA) on delete restrict on update restrict;

alter table BARANG_PENJUALAN add constraint FK_MELAKUKAN_PENJUALAN foreign key (ID_USER)
      references USER (ID_USER) on delete restrict on update restrict;

alter table BARANG_PENJUALAN_DATA add constraint FK_DETAIL_PENJUALAN_DATA foreign key (ID_BARANG_PENJUALAN)
      references BARANG_PENJUALAN (ID_BARANG_PENJUALAN) on delete restrict on update restrict;

alter table BARANG_PENJUALAN_DATA add constraint FK_DETAIL_PENJUALAN_DATA_BARANG foreign key (ID_BARANG_DATA)
      references BARANG_DATA (ID_BARANG_DATA) on delete restrict on update restrict;

