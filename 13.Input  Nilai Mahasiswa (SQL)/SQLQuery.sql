/*
CREATE TABLE mahasiswa
(
NIM varchar (10) NOT NULL,
Nama varchar (50),
Jurusan varchar (50),
Jenis_Kelamin int,
Tempat_Lahir varchar (50),
Tanggal_Lahir datetime,

CONSTRAINT PK_NIM PRIMARY KEY
(NIM)
)
*/

CREATE TABLE nilaimahasiswa2
(
NIM varchar (10) NOT NULL,
Kode_Matkul varchar (5),
Semester int,
Nilai_Formatif numeric (18,2),
Nilai_Tugas numeric (18,2),
Nilai_UTS numeric (18,2),
Nilai_UAS numeric (18,2),

CONSTRAINT PK_NIM3 PRIMARY KEY (NIM,Kode_Matkul,Semester)
)