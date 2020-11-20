## Business Process atau Activity Diagram Aplikasi Perpustakaan

Kita mulai dengan Business Process atau Activity Diagram. Menggambarkan business process bisa banyak cara. Mungkin secara sederhana saya bisa gambarkan Business Process Model dari Aplikasi Perpustakaan sebagai berikut:

<img src="D:/Kampus/Semester 3/Selasa/Pemodelan Sistem Berorentasi Objek/Rancangan Aplikasi Perpustakaan/assets/ActivityDiagram-AplikasiPerpustakaan-Sugih.png">

Diagram di atas menggambarkan 3 Activity utama di dalam perpustakaan,yaitu:

1. Menambah anggota/member perpustakaan.
2. Anggota meminjam buku.
3. Anggota mengembalikan buku.

walaupun mungkin masih banyak activity-activity lain yang terkait dengan perpustakaan tetapi bukan merupakan business process yang utama dari perpustakaan.

Jika kita lihat diagram diatas, yang berhubungan langsung dengan aplikasi adalah pustakawan

Maka untuk tahap selanjutnya, yaitu pembuatan Use Case Diagram, Pustakawan adalah Actor nya.


## Use Case Diagram Aplikasi Perpustakaan

Use Case Diagram menggambarkan apa saja yang bisa user lakukan di dalam sistem/aplikasi

- atau in english nya Use Case Diagram defines what user can do to the system.

Adapun Use Case Diagram Aplikasi Perpustakaan sederhana bisa digambarkan sebagai berikut:<img src="assets/<img src="D:/Kampus/Semester 3/Selasa/Pemodelan Sistem Berorentasi Objek/Rancangan Aplikasi Perpustakaan/assets/UseCaseDiagram-AplikasiPerpustakaan-Sugih.png">

Gambar di atas menggambarkan Aplikasi mempunyai satu Actor/user yaitu Pustakawan dan 7 use case. Hal ini menjelaskan bahwa dalam aplikasi, pustakawan bisa Menambah Anggota, Mencetak Kartu Anggota, Menambah Buku, Mencetak Stiker Kode Buku, Melihat Katalog, Meminjam Buku, dan Mengembalikan Buku.

Mungkin ada kebingungan, mengapa yang meminjam dan mengembalikan buku adalah Pustakawan, bukan anggota perpustakaan.

Kalau kita lihat lagi postingan sebelumnya <a href="01 Activity Diagram.md">Business Process atau Activity Diagram</a> , di situ terlihat bahwa yang berinteraksi langsung dengan aplikasi adalah Pustakawan, bukan anggota. Anggota meminjam dan mengembalikan buku kepada Pustakawan, selanjutnya Pustakawan lah yang menginput ke aplikasi.

Dan kalaupun dimungkinkan Anggota bisa melakukan proses peminjaman dan pengembalian buku langsung terhadap aplikasi, hal ini akan membahayakan. Bisa-bisa Anggota menginput proses pengembalian buku padahal secara fisik bukunya tidak dikembalikan. Lama-lama rak-rak buku perpustakaan akan menjadi kosong tidak ada bukunya sedangkan di aplikasi tercatat buku sudah dikembalikan ke perpustakaan.



## Sequence Diagram Aplikasi Perpustakaan 

Sequence Diagram menggambarkan urutan interaksi antar objek ketika satu Use Case dieksekusi/dilakukan, sehingga Sequence Diagram harus sebanyak Use Case nya.

Dalam membuat Sequence Diagram ini saya memakai metode programming MVC (Model-View-Controller) atau dalam istilah lain Model=Entity, View=Boundary, dan Controller=Control. View/Boundary adalah class yang berinteraksi langsung dengan Actor. Controller/Control adalah class interaksi perantara antara View/Boundary dan Mode/Entity. sedang Model/Entity adalah class yang menyimpan data.

Sequence Diagram untuk Use Case Menambah Anggota Perpustakaan adalah sbb:
<img src="D:/Kampus/Semester 3/Selasa/Pemodelan Sistem Berorentasi Objek/Rancangan Aplikasi Perpustakaan/assets/SequenceDiagram-MenambahAnggota-AplikasiPerpustakaan-Sugih.png">

Dimana ada dua class Boundary yaitu MenuUtama dan FormPendaftaran Anggota, satu class Control yaitu ProsesPendaftaranAnggota, dan satu class Entity yaitu Member.

Adapun Sequence Diagram untuk MencetakKartuAnggota adalah sbb:
<img src="D:/Kampus/Semester 3/Selasa/Pemodelan Sistem Berorentasi Objek/Rancangan Aplikasi Perpustakaan/assets/SequenceDiagram-MencetakKartuAnggota-AplikasiPerpustakaan-Sugih.png">

Selanjutnya saya tampilkan Sequence Diagram untuk Use Case Menambah Buku:
<img src="D:/Kampus/Semester 3/Selasa/Pemodelan Sistem Berorentasi Objek/Rancangan Aplikasi Perpustakaan/assets/SequenceDiagram-ManambahBuku-AplikasiPerpustakaan-Sugih.png">

Dalam kasus ini saya hanya memberikan atribut-atribut utama saja untuk Class entity Buku, kita bisa menambahkan atribut pelengkap lain. Sedikit penjelasan, atribut CopyNumber berguna untuk membedakan buku yang berjudul sama tetapi mempunyai beberapa kopi.

Selanjutnya Sequence Digram untuk Use Case Mencetak Stiker Kode Buku adalah sbb:
<img src="assets\SequenceDiagram-MencetakStikerKodeBuku-AplikasiPerpustakaan-Sugih.png">