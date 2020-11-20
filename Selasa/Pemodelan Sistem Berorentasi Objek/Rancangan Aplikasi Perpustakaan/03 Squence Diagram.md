## Sequence Diagram Aplikasi Perpustakaan 

Sequence Diagram menggambarkan urutan interaksi antar objek ketika satu Use Case dieksekusi/dilakukan, sehingga Sequence Diagram harus sebanyak Use Case nya.

Dalam membuat Sequence Diagram ini saya memakai metode programming MVC (Model-View-Controller) atau dalam istilah lain Model=Entity, View=Boundary, dan Controller=Control. View/Boundary adalah class yang berinteraksi langsung dengan Actor. Controller/Control adalah class interaksi perantara antara View/Boundary dan Mode/Entity. sedang Model/Entity adalah class yang menyimpan data.

Sequence Diagram untuk Use Case Menambah Anggota Perpustakaan adalah sbb:
<img src="assets\SequenceDiagram-MenambahAnggota-AplikasiPerpustakaan-Sugih.png">

Dimana ada dua class Boundary yaitu MenuUtama dan FormPendaftaran Anggota, satu class Control yaitu ProsesPendaftaranAnggota, dan satu class Entity yaitu Member.

Adapun Sequence Diagram untuk MencetakKartuAnggota adalah sbb:
<img src="assets\SequenceDiagram-MencetakKartuAnggota-AplikasiPerpustakaan-Sugih.png">

Selanjutnya saya tampilkan Sequence Diagram untuk Use Case Menambah Buku:
<img src="assets\SequenceDiagram-ManambahBuku-AplikasiPerpustakaan-Sugih.png">

Dalam kasus ini saya hanya memberikan atribut-atribut utama saja untuk Class entity Buku, kita bisa menambahkan atribut pelengkap lain. Sedikit penjelasan, atribut CopyNumber berguna untuk membedakan buku yang berjudul sama tetapi mempunyai beberapa kopi.

Selanjutnya Sequence Digram untuk Use Case Mencetak Stiker Kode Buku adalah sbb:
<img src="assets\SequenceDiagram-MencetakStikerKodeBuku-AplikasiPerpustakaan-Sugih.png">