const DataSource = JSON.parse(`{
    "admin": [
        {
            "ID_ADMIN": "AD001",
            "USERNAME": "admin",
            "PASSWORD": "21232f297a57a5a743894a0e4a801fc3",
            "LAST_LOGIN": "28-12-2020 14:31:39",
            "ROLE": "superadmin",
            "FULLNAME": "Isep Lutpi Nur",
            "JENKEL": "L",
            "NO_TELP": "085798132505",
            "ALAMAT": "Cianjur",
            "PHOTO": "me_face.jpg",
            "DTE_CREATED": "2020-06-14"
        },
        {
            "ID_ADMIN": "AD002",
            "USERNAME": "joshua",
            "PASSWORD": "21232f297a57a5a743894a0e4a801fc3",
            "LAST_LOGIN": "28-12-2020 15:56:26",
            "ROLE": "admin",
            "FULLNAME": "Joshua Dehary Butar butar",
            "JENKEL": null,
            "NO_TELP": null,
            "ALAMAT": null,
            "PHOTO": "huga.jpg",
            "DTE_CREATED": "2020-06-16"
        },
        {
            "ID_ADMIN": "AD003",
            "USERNAME": "deri",
            "PASSWORD": "d094c0a6c7ec4f01f75837ace20925fa",
            "LAST_LOGIN": "16-07-2020 08:47:03",
            "ROLE": "superadmin",
            "FULLNAME": "Deri Kurniawan",
            "JENKEL": "L",
            "NO_TELP": "088788899",
            "ALAMAT": "Jl semeru",
            "PHOTO": "Image_2d6d9b2.jpg",
            "DTE_CREATED": "2020-06-16"
        },
        {
            "ID_ADMIN": "AD004",
            "USERNAME": "mtali",
            "PASSWORD": "977dca586aea0eac2674a89793e252ec",
            "LAST_LOGIN": "26-06-2020 18:12:38",
            "ROLE": "admin",
            "FULLNAME": "M. T. Ali Syech ahmad",
            "JENKEL": null,
            "NO_TELP": null,
            "ALAMAT": null,
            "PHOTO": "default.png",
            "DTE_CREATED": "2020-06-20"
        },
        {
            "ID_ADMIN": "AD005",
            "USERNAME": "ravi",
            "PASSWORD": "63dd3e154ca6d948fc380fa576343ba6",
            "LAST_LOGIN": "24-06-2020 11:46:32",
            "ROLE": "admin",
            "FULLNAME": "Rafi Algippari",
            "JENKEL": null,
            "NO_TELP": null,
            "ALAMAT": null,
            "PHOTO": "default.png",
            "DTE_CREATED": "2020-06-21"
        },
        {
            "ID_ADMIN": "AD006",
            "USERNAME": "supriatna",
            "PASSWORD": "8625d1c13eaf0a75068d3cf2cdde43f6",
            "LAST_LOGIN": "16-07-2020 14:46:29",
            "ROLE": "admin",
            "FULLNAME": "Cece Supriatna",
            "JENKEL": "L",
            "NO_TELP": "0897789088",
            "ALAMAT": "Jl Jalan id",
            "PHOTO": "stdmp.png",
            "DTE_CREATED": "2020-06-24"
        },
        {
            "ID_ADMIN": "AD007",
            "USERNAME": "adistia",
            "PASSWORD": "25f423bce283a8d0cbb66252da5d3cdd",
            "LAST_LOGIN": "11-07-2020 07:26:51",
            "ROLE": "superadmin",
            "FULLNAME": "Adistia Ramadhani",
            "JENKEL": null,
            "NO_TELP": null,
            "ALAMAT": null,
            "PHOTO": "default.png",
            "DTE_CREATED": "2020-07-11"
        },
        {
            "ID_ADMIN": "AD008",
            "USERNAME": "dara",
            "PASSWORD": "c5a42d9667c760e1b7c064e25536e570",
            "LAST_LOGIN": "12-07-2020 03:36:15",
            "ROLE": "superadmin",
            "FULLNAME": "Dara atria ferliandini",
            "JENKEL": null,
            "NO_TELP": null,
            "ALAMAT": null,
            "PHOTO": "default.png",
            "DTE_CREATED": "2020-07-12"
        }
    ],
    "anggota": [
        {
            "ID_ANGGOTA": "AGT001",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Adistia Ramadhani",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "02\/20\/2000",
            "ALAMAT": "Jl Jendral ahmad yani",
            "GENDER": "P",
            "TELP": "085733573529",
            "FOTO": "20__Multazam_A_3.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT002",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Ahmad rizal imaddudin",
            "TMP_LAHIR": "Kabupaten bandung",
            "TGL_LAHIR": "06\/16\/2020",
            "ALAMAT": "Bandung",
            "GENDER": "L",
            "TELP": "0897786788954",
            "FOTO": "12__GALBIE_ELINOUR1.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT003",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Akbar Maulana M. Tarumadoya",
            "TMP_LAHIR": "Ternate",
            "TGL_LAHIR": "10\/13\/1998",
            "ALAMAT": "Ternate",
            "GENDER": "L",
            "TELP": "087669887654",
            "FOTO": "2__Alfan_Cahyo_.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT004",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Alam Nurzaman",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "03\/08\/1999",
            "ALAMAT": "Perum. Aspol 443, Kota Bandung",
            "GENDER": "L",
            "TELP": "0818897546788",
            "FOTO": "30__Sasna_S_.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT005",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Chika stefanny siswandi",
            "TMP_LAHIR": "Karawang",
            "TGL_LAHIR": "02\/19\/2000",
            "ALAMAT": "Perum. Grand Emerald ZU3, Karawang",
            "GENDER": "P",
            "TELP": "093889765643",
            "FOTO": "31__Riski_Ananda.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT006",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Dara atria ferliandini",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "08\/18\/2000",
            "ALAMAT": "Gg. Pattimura 89",
            "GENDER": "P",
            "TELP": "085389755644",
            "FOTO": "2__Anddyanisa_M_.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT007",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Deri Kurniawan",
            "TMP_LAHIR": "Malang",
            "TGL_LAHIR": "06\/16\/1999",
            "ALAMAT": "Sulfat Indah 89",
            "GENDER": "L",
            "TELP": "08267599432",
            "FOTO": "28__Prsetya_Ananta.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT008",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Dewi febrima raifu",
            "TMP_LAHIR": "Jayapura",
            "TGL_LAHIR": "08\/12\/1999",
            "ALAMAT": "Ds. Sambungrejo RT. 4 RW. 7 Kec. Welasasih, Jayapura",
            "GENDER": "P",
            "TELP": "0876654897765",
            "FOTO": "14__Irvina_F_.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT009",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Domingous doutel sarmento",
            "TMP_LAHIR": "Timor Leste",
            "TGL_LAHIR": "04\/01\/2001",
            "ALAMAT": "Mburine cito",
            "GENDER": "L",
            "TELP": "089776598334",
            "FOTO": "29__RIDHWAN_ROFIANTO.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT010",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Fachruly Al-Huzairy",
            "TMP_LAHIR": "Garut",
            "TGL_LAHIR": "04\/05\/2000",
            "ALAMAT": "Ds. Sumoharjo, RT. 5 RW. 9",
            "GENDER": "L",
            "TELP": "08677564987",
            "FOTO": "18__Muh__Iqbal.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT011",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Vakrun Nisah",
            "TMP_LAHIR": "Ciamis",
            "TGL_LAHIR": "03\/08\/2000",
            "ALAMAT": "Pamarican, Ciamis",
            "GENDER": "P",
            "TELP": "084876835267",
            "FOTO": "28__Nabila_Hanggana_Raras.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT012",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Fernanda Ndaru Santoso",
            "TMP_LAHIR": "Sidoarjo",
            "TGL_LAHIR": "08\/04\/2000",
            "ALAMAT": "Perum. Bumi Citra Fajar A76, Sekardangan, Sidoarjo",
            "GENDER": "L",
            "TELP": "08567498256",
            "FOTO": "9__Erika_P_.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT013",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Iman Faturahman",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "04\/02\/2000",
            "ALAMAT": "Jl. Sironggo Ajoh Kav. 4, Bandung",
            "GENDER": "L",
            "TELP": "089765689645",
            "FOTO": "24__Nico_Ardian.JPG",
            "D_CREATED": "2020-06-16"
        },
        {
            "ID_ANGGOTA": "AGT014",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Irfan Ramdani",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "06\/29\/2000",
            "ALAMAT": "Perum. Siswa Taman AG65, Bandung",
            "GENDER": "L",
            "TELP": "087995764839",
            "FOTO": "2__Ad_Reana.JPG",
            "D_CREATED": "2020-06-29"
        },
        {
            "ID_ANGGOTA": "AGT015",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "Joshua Dehary butar-butar",
            "TMP_LAHIR": "Bandung",
            "TGL_LAHIR": "06\/10\/2000",
            "ALAMAT": "Jl. Utama Kota gg. 6, Ciberem",
            "GENDER": "L",
            "TELP": "088786368495",
            "FOTO": "34__VEJRYN_SHAVIERO.JPG",
            "D_CREATED": "2020-06-29"
        },
        {
            "ID_ANGGOTA": "AGT016",
            "ID_ADMIN": "AD001",
            "FULL_NAME": "M Bayu ramadhani",
            "TMP_LAHIR": "Karawang",
            "TGL_LAHIR": "07\/09\/1998",
            "ALAMAT": "Jl. Alun alun kota",
            "GENDER": "L",
            "TELP": "08766754345",
            "FOTO": "19__Muh__Ridjal.JPG",
            "D_CREATED": "2020-07-09"
        }
    ],
    "buku": [
        {
            "ID_BUKU": "BKO004",
            "ID_ADMIN": "AD003",
            "TITLE": "Mikrotik Kung Fu : Kitab 1",
            "AUTHOR": "Rendra Towidjojo",
            "PUBLISHER": "Jasakom",
            "YEAR": "2016",
            "QTY": "2",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO005",
            "ID_ADMIN": "AD001",
            "TITLE": "Windows 10 : Panduan Lengkap",
            "AUTHOR": "Indra Susanto",
            "PUBLISHER": "Jasakom",
            "YEAR": "2013",
            "QTY": "4",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO006",
            "ID_ADMIN": "AD001",
            "TITLE": "Bisnis Online Revolution",
            "AUTHOR": "Iwan Kenrianto",
            "PUBLISHER": "Gramedia",
            "YEAR": "2015",
            "QTY": "2",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO007",
            "ID_ADMIN": "AD001",
            "TITLE": "3 Tools Facebook Graph Gratisan",
            "AUTHOR": "Suryadin Laoddang",
            "PUBLISHER": "Dosen Jualan",
            "YEAR": "2015",
            "QTY": "1",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO008",
            "ID_ADMIN": "AD001",
            "TITLE": "Mengolah Database Excel",
            "AUTHOR": "Sumonggo Surya",
            "PUBLISHER": "Andi Publisher",
            "YEAR": "2001",
            "QTY": "1",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO009",
            "ID_ADMIN": "AD001",
            "TITLE": "Mahir Corel Draw Dalam 4 Hari",
            "AUTHOR": "Yuli Kristanto S",
            "PUBLISHER": "Izuka Komp",
            "YEAR": "2008",
            "QTY": "1",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO010",
            "ID_ADMIN": "AD001",
            "TITLE": "The Magic of Photoshop",
            "AUTHOR": "Hendri Hendratama",
            "PUBLISHER": "Informatika",
            "YEAR": "2013",
            "QTY": "4",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO011",
            "ID_ADMIN": "AD001",
            "TITLE": "Teknik Profesional Photoshop CS3",
            "AUTHOR": "Rahmat Widiyanto",
            "PUBLISHER": "Elex Media Computindo",
            "YEAR": "2009",
            "QTY": "3",
            "KELUAR": "3"
        },
        {
            "ID_BUKU": "BKO012",
            "ID_ADMIN": "AD001",
            "TITLE": "Jago SEO",
            "AUTHOR": "Hidayat Rahmad",
            "PUBLISHER": "Elex Media Computindo",
            "YEAR": "2011",
            "QTY": "1",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO013",
            "ID_ADMIN": "AD001",
            "TITLE": "Hacking Wireless Network",
            "AUTHOR": "Suryatama Udin",
            "PUBLISHER": "Jasakom",
            "YEAR": "2014",
            "QTY": "7",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO014",
            "ID_ADMIN": "AD001",
            "TITLE": "Blender 3D Modelling",
            "AUTHOR": "Hendri Hendratama",
            "PUBLISHER": "Informatika",
            "YEAR": "2015",
            "QTY": "1",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO015",
            "ID_ADMIN": "AD001",
            "TITLE": "Aplikasi Berbasis Android",
            "AUTHOR": "Hyua Hendra La",
            "PUBLISHER": "Moklet Publisher",
            "YEAR": "2019",
            "QTY": "3",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO016",
            "ID_ADMIN": "AD001",
            "TITLE": "Membangun Aplikasi ASP",
            "AUTHOR": "Hendro SPd",
            "PUBLISHER": "Moklet Publisher",
            "YEAR": "2020",
            "QTY": "2",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO017",
            "ID_ADMIN": "AD001",
            "TITLE": "Basis Data Kebun Binatang",
            "AUTHOR": "Ifa Khoirunnisa",
            "PUBLISHER": "Moklet Publisher",
            "YEAR": "2018",
            "QTY": "3",
            "KELUAR": "0"
        },
        {
            "ID_BUKU": "BKO018",
            "ID_ADMIN": "AD001",
            "TITLE": "Buku Panduan ASUS",
            "AUTHOR": "Herman Dzumavo",
            "PUBLISHER": "Samsara",
            "YEAR": "2008",
            "QTY": "3",
            "KELUAR": "0"
        },
        {
            "ID_BUKU": "BKO019",
            "ID_ADMIN": "AD001",
            "TITLE": "The Power of Microsoft Edge",
            "AUTHOR": "Steven Reward",
            "PUBLISHER": "Duston Magz",
            "YEAR": "2020",
            "QTY": "5",
            "KELUAR": "1"
        },
        {
            "ID_BUKU": "BKO020",
            "ID_ADMIN": "AD001",
            "TITLE": "MySQL Dasar dan Implementasi",
            "AUTHOR": "Supratman Efendi",
            "PUBLISHER": "Ilmukom",
            "YEAR": "2014",
            "QTY": "3",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO021",
            "ID_ADMIN": "AD001",
            "TITLE": "Nippon Against World",
            "AUTHOR": "Hasirama Tadashi",
            "PUBLISHER": "Sung Yang",
            "YEAR": "2009",
            "QTY": "0",
            "KELUAR": "2"
        },
        {
            "ID_BUKU": "BKO022",
            "ID_ADMIN": "AD001",
            "TITLE": "Konfigursi Router Cisco",
            "AUTHOR": "Solikin",
            "PUBLISHER": "Safari pub",
            "YEAR": "2019",
            "QTY": "3",
            "KELUAR": "0"
        },
        {
            "ID_BUKU": "BKO023",
            "ID_ADMIN": "AD001",
            "TITLE": "Fashion Paris",
            "AUTHOR": "Amire Melaine",
            "PUBLISHER": "FranceTime",
            "YEAR": "2018",
            "QTY": "2",
            "KELUAR": "0"
        },
        {
            "ID_BUKU": "BKO024",
            "ID_ADMIN": "AD001",
            "TITLE": "Unreleashed Journal",
            "AUTHOR": "Timothy Law",
            "PUBLISHER": "Askars",
            "YEAR": "2020",
            "QTY": "4",
            "KELUAR": "0"
        }
    ],
    "detail_pinjam": [
        {
            "ID_DIPINJAM": "13",
            "ID_PINJAM": "P170623001",
            "ID_BUKU": "BKO005",
            "TGL_KEMBALI": "2020-06-25",
            "DENDA": "0",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "14",
            "ID_PINJAM": "P170623001",
            "ID_BUKU": "BKO008",
            "TGL_KEMBALI": "2020-12-23",
            "DENDA": "636000",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "15",
            "ID_PINJAM": "P170623001",
            "ID_BUKU": "BKO013",
            "TGL_KEMBALI": "2020-12-23",
            "DENDA": "636000",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "16",
            "ID_PINJAM": "P170623002",
            "ID_BUKU": "BKO008",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "17",
            "ID_PINJAM": "P170624001",
            "ID_BUKU": "BKO013",
            "TGL_KEMBALI": "2020-07-09",
            "DENDA": "4000",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "18",
            "ID_PINJAM": "P170624001",
            "ID_BUKU": "BKO007",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "19",
            "ID_PINJAM": "P170624001",
            "ID_BUKU": "BKO011",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "20",
            "ID_PINJAM": "P170624002",
            "ID_BUKU": "BKO004",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "21",
            "ID_PINJAM": "P170624002",
            "ID_BUKU": "BKO005",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "22",
            "ID_PINJAM": "P170624002",
            "ID_BUKU": "BKO007",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "23",
            "ID_PINJAM": "P170624003",
            "ID_BUKU": "BKO011",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "24",
            "ID_PINJAM": "P170624003",
            "ID_BUKU": "BKO004",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "25",
            "ID_PINJAM": "P170624003",
            "ID_BUKU": "BKO015",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "26",
            "ID_PINJAM": "P170624004",
            "ID_BUKU": "BKO017",
            "TGL_KEMBALI": "2020-06-25",
            "DENDA": "0",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "27",
            "ID_PINJAM": "P170624005",
            "ID_BUKU": "BKO013",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "28",
            "ID_PINJAM": "P170624005",
            "ID_BUKU": "BKO006",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "29",
            "ID_PINJAM": "P170624006",
            "ID_BUKU": "BKO011",
            "TGL_KEMBALI": "2020-06-25",
            "DENDA": "0",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "30",
            "ID_PINJAM": "P170624006",
            "ID_BUKU": "BKO018",
            "TGL_KEMBALI": "2020-07-10",
            "DENDA": "4500",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "31",
            "ID_PINJAM": "P170625001",
            "ID_BUKU": "BKO019",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "32",
            "ID_PINJAM": "P170625001",
            "ID_BUKU": "BKO020",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "33",
            "ID_PINJAM": "P170625001",
            "ID_BUKU": "BKO021",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "34",
            "ID_PINJAM": "P170625002",
            "ID_BUKU": "BKO010",
            "TGL_KEMBALI": "2020-07-09",
            "DENDA": "3500",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "35",
            "ID_PINJAM": "P170625002",
            "ID_BUKU": "BKO016",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "36",
            "ID_PINJAM": "P170626001",
            "ID_BUKU": "BKO012",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "37",
            "ID_PINJAM": "P170626001",
            "ID_BUKU": "BKO009",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "38",
            "ID_PINJAM": "P170626001",
            "ID_BUKU": "BKO014",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "39",
            "ID_PINJAM": "P170626002",
            "ID_BUKU": "BKO014",
            "TGL_KEMBALI": "2020-12-23",
            "DENDA": "634500",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "40",
            "ID_PINJAM": "P170626002",
            "ID_BUKU": "BKO010",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "41",
            "ID_PINJAM": "P170629001",
            "ID_BUKU": "BKO013",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "42",
            "ID_PINJAM": "P170629001",
            "ID_BUKU": "BKO009",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "43",
            "ID_PINJAM": "P170629002",
            "ID_BUKU": "BKO010",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "44",
            "ID_PINJAM": "P170629002",
            "ID_BUKU": "BKO016",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "45",
            "ID_PINJAM": "P170629002",
            "ID_BUKU": "BKO012",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "46",
            "ID_PINJAM": "P170709001",
            "ID_BUKU": "BKO020",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "47",
            "ID_PINJAM": "P170709001",
            "ID_BUKU": "BKO011",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "48",
            "ID_PINJAM": "P170709002",
            "ID_BUKU": "BKO022",
            "TGL_KEMBALI": "2020-12-23",
            "DENDA": "628000",
            "STATUS": "Sudah Kembali"
        },
        {
            "ID_DIPINJAM": "49",
            "ID_PINJAM": "P170709002",
            "ID_BUKU": "BKO021",
            "TGL_KEMBALI": null,
            "DENDA": "0",
            "STATUS": "Belum Kembali"
        },
        {
            "ID_DIPINJAM": "50",
            "ID_PINJAM": "P201223001",
            "ID_BUKU": "BKO022",
            "TGL_KEMBALI": "2020-12-23",
            "DENDA": "0",
            "STATUS": "Sudah Kembali"
        }
    ],
    "notif": [
        {
            "ID_NOTIF": "2",
            "ID_ADMIN": "AD003",
            "JUDUL": "Fokus target",
            "ISI": "Kejar sesuai kemampuan, open book",
            "DT": "2020-07-03"
        },
        {
            "ID_NOTIF": "5",
            "ID_ADMIN": "AD003",
            "JUDUL": "Hahha",
            "ISI": "hehee",
            "DT": "2020-07-03"
        },
        {
            "ID_NOTIF": "6",
            "ID_ADMIN": "AD003",
            "JUDUL": "THR Turun",
            "ISI": "silahkan antri di ruang bendahara jam 12.00",
            "DT": "2020-07-09"
        },
        {
            "ID_NOTIF": "7",
            "ID_ADMIN": "AD007",
            "JUDUL": "Selamat siang",
            "ISI": "jangan lupa sholat dhuhr, cekno tenang atine",
            "DT": "2020-07-11"
        },
        {
            "ID_NOTIF": "8",
            "ID_ADMIN": "AD008",
            "JUDUL": "Attitude is everything",
            "ISI": "semangat pagii, pagi pagi pagi",
            "DT": "2020-07-12"
        },
        {
            "ID_NOTIF": "10",
            "ID_ADMIN": "AD001",
            "JUDUL": "Hallo",
            "ISI": "test halo",
            "DT": "2020-07-13"
        }
    ],
    "peminjaman": [
        {
            "ID_PINJAM": "P170623001",
            "ID_ANGGOTA": "AGT002",
            "ID_ADMIN": "AD004",
            "TGL_PINJAM": "2020-06-23",
            "JML_BUKU": "3",
            "STATS": "Sudah Kembali"
        },
        {
            "ID_PINJAM": "P170623002",
            "ID_ANGGOTA": "AGT003",
            "ID_ADMIN": "AD005",
            "TGL_PINJAM": "2020-06-23",
            "JML_BUKU": "1",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170624001",
            "ID_ANGGOTA": "AGT007",
            "ID_ADMIN": "AD005",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170624002",
            "ID_ANGGOTA": "AGT008",
            "ID_ADMIN": "AD005",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170624003",
            "ID_ANGGOTA": "AGT004",
            "ID_ADMIN": "AD005",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170624004",
            "ID_ANGGOTA": "AGT001",
            "ID_ADMIN": "AD004",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "1",
            "STATS": "Sudah Kembali"
        },
        {
            "ID_PINJAM": "P170624005",
            "ID_ANGGOTA": "AGT007",
            "ID_ADMIN": "AD004",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170624006",
            "ID_ANGGOTA": "AGT003",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-06-24",
            "JML_BUKU": "2",
            "STATS": "Sudah Kembali"
        },
        {
            "ID_PINJAM": "P170625001",
            "ID_ANGGOTA": "AGT013",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-06-25",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170625002",
            "ID_ANGGOTA": "AGT010",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-06-25",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170626001",
            "ID_ANGGOTA": "AGT006",
            "ID_ADMIN": "AD004",
            "TGL_PINJAM": "2020-06-26",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170626002",
            "ID_ANGGOTA": "AGT012",
            "ID_ADMIN": "AD004",
            "TGL_PINJAM": "2020-06-26",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170629001",
            "ID_ANGGOTA": "AGT014",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-06-29",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170629002",
            "ID_ANGGOTA": "AGT015",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-06-29",
            "JML_BUKU": "3",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170709001",
            "ID_ANGGOTA": "AGT011",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-07-09",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P170709002",
            "ID_ANGGOTA": "AGT016",
            "ID_ADMIN": "AD006",
            "TGL_PINJAM": "2020-07-09",
            "JML_BUKU": "2",
            "STATS": "Belum Kembali"
        },
        {
            "ID_PINJAM": "P201223001",
            "ID_ANGGOTA": "AGT011",
            "ID_ADMIN": "AD002",
            "TGL_PINJAM": "2020-12-23",
            "JML_BUKU": "1",
            "STATS": "Sudah Kembali"
        }
    ],
    "perpus": [
        {
            "ID_PERPUS": "3",
            "NAMA_P": "Perpus pojok baca",
            "ALAMAT_P": "Cianjur",
            "ABOUT": "Aplikasi pengelolaan perpustakaan"
        }
    ]
}`);

console.log(DataSource);
function getBukuById(id = false) {
    let result = null;
    if (id) {
        DataSource.buku.forEach(element => {
            if (element.ID_BUKU == id) result = element;
        });
    }
    return result;
}

function getAnggotaById(id = false) {
    let result = null;
    if (id) {
        DataSource.anggota.forEach(element => {
            if (element.ID_ANGGOTA == id) result = element;
        });
    }
    return result;
}

function getBukuById(id = false) {
    let result = null;
    if (id) {
        DataSource.buku.forEach(element => {
            if (element.ID_BUKU == id) result = element;
        });
    }
    return result;
}

function getAdminById(id = false) {
    let result = null;
    if (id) {
        DataSource.admin.forEach(element => {
            if (element.ID_ADMIN == id) result = element;
        });
    }
    return result;
}

function getIddDtailPinjam(ID_DIPINJAM = null) {
    let result = null;
    let counter = 0;
    if (ID_DIPINJAM) {
        DataSource.detail_pinjam.forEach(e => {
            if (e.ID_DIPINJAM == ID_DIPINJAM) {
                result = counter;
            }
            counter++;
        });
    }
    return result;
}