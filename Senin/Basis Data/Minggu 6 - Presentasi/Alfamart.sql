/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     26/11/2020 13.00.10                          */
/*==============================================================*/


drop table if exists barang_data;

drop table if exists barang_jenis;

drop table if exists jabatan;

drop table if exists pengadaan;

drop table if exists pengadaan_data;

drop table if exists penjualan;

drop table if exists penjualan_data;

drop table if exists suplier;

drop table if exists users;

/*==============================================================*/
/* Table: barang_data                                           */
/*==============================================================*/
create table barang_data
(
   id_barang_data       int not null,
   id_barang_jenis      int,
   id_suplier           int,
   barang__nama         varchar(200),
   barang_kode          varchar(50),
   barang_harga         bigint,
   barang_tanggal_kadaluarsa date,
   barang_stok          int,
   barang_diskon        int,
   primary key (id_barang_data)
);

/*==============================================================*/
/* Table: barang_jenis                                          */
/*==============================================================*/
create table barang_jenis
(
   id_barang_jenis      int not null,
   jenis_nama           varchar(50),
   primary key (id_barang_jenis)
);

/*==============================================================*/
/* Table: jabatan                                               */
/*==============================================================*/
create table jabatan
(
   id_jabatan           int not null,
   nama_jabatan         varchar(50),
   primary key (id_jabatan)
);

/*==============================================================*/
/* Table: pengadaan                                             */
/*==============================================================*/
create table pengadaan
(
   id_pengadaan         int not null,
   id_user              int,
   id_suplier           int,
   pengadaan_kode_transaksi varchar(50),
   pengadaan_waktu      datetime,
   primary key (id_pengadaan)
);

/*==============================================================*/
/* Table: pengadaan_data                                        */
/*==============================================================*/
create table pengadaan_data
(
   id_pengadaan_data    int not null,
   id_barang_data       int,
   id_pengadaan         int,
   pengadaan_data_jumlah int,
   primary key (id_pengadaan_data)
);

/*==============================================================*/
/* Table: penjualan                                             */
/*==============================================================*/
create table penjualan
(
   id_penjualan         int not null,
   id_user              int,
   penjualan_kode_transaksi char(25),
   penjualan_total_harga bigint,
   penjualan_waktu      datetime,
   primary key (id_penjualan)
);

/*==============================================================*/
/* Table: penjualan_data                                        */
/*==============================================================*/
create table penjualan_data
(
   id_penjualan_data    int not null,
   id_barang_data       int,
   id_penjualan         int,
   penjualan_jumlah     int,
   primary key (id_penjualan_data)
);

/*==============================================================*/
/* Table: suplier                                               */
/*==============================================================*/
create table suplier
(
   id_suplier           int not null,
   suplier_nama         varchar(50),
   suplier_alamat       text,
   suplier_no_telp      varchar(14),
   suplier_emali        varchar(50),
   suplier_tanggal_registrasi time,
   suplier_kode         varchar(50),
   primary key (id_suplier)
);

/*==============================================================*/
/* Table: users                                                 */
/*==============================================================*/
create table users
(
   id_user              int not null,
   id_jabatan           int,
   username             varchar(50),
   password             varchar(255),
   email                varchar(50),
   nama_lengkap         varchar(50),
   alamat               text,
   jenis_kelamin        varchar(10),
   tanggal_lahir        date,
   nik                  varchar(17),
   no_telepon           varchar(14),
   foto                 varchar(50),
   jabatan              varchar(20),
   primary key (id_user)
)
alter table users change id_user id_user int not null auto_increment;

alter table barang_data add constraint fk_detail_jenis foreign key (id_barang_jenis)
      references barang_jenis (id_barang_jenis) on delete restrict on update restrict;

alter table barang_data add constraint fk_detail_suplier_barang foreign key (id_suplier)
      references suplier (id_suplier) on delete restrict on update restrict;

alter table pengadaan add constraint fk_melakukan_pengadaan foreign key (id_user)
      references users (id_user) on delete restrict on update restrict;

alter table pengadaan add constraint fk_memenuhi_pengadaan foreign key (id_suplier)
      references suplier (id_suplier) on delete restrict on update restrict;

alter table pengadaan_data add constraint fk_detail_pengadaan_data foreign key (id_pengadaan)
      references pengadaan (id_pengadaan) on delete restrict on update restrict;

alter table pengadaan_data add constraint fk_detail_pengadaan_data_barang foreign key (id_barang_data)
      references barang_data (id_barang_data) on delete restrict on update restrict;

alter table penjualan add constraint fk_melakukan_penjualan foreign key (id_user)
      references users (id_user) on delete restrict on update restrict;

alter table penjualan_data add constraint fk_detail_penjualan_data foreign key (id_penjualan)
      references penjualan (id_penjualan) on delete restrict on update restrict;

alter table penjualan_data add constraint fk_detail_penjualan_data_barang foreign key (id_barang_data)
      references barang_data (id_barang_data) on delete restrict on update restrict;

alter table users add constraint fk_detail_jabatan foreign key (id_jabatan)
      references jabatan (id_jabatan) on delete restrict on update restrict;

