--CREATE DATABASE mahasiswa

/*
CREATE TABLE mahasiswa
(
	nim varchar (10),
	nama varchar (50),
	jurusan varchar (50),
	jenis_kelamin int,
	tempat_lahir varchar (50),
	tanggal_lahir datetime,
	CONSTRAINT pk_nim PRIMARY KEY
	(nim)
)
*/

/*
CREATE TABLE nilai

(
	nim varchar (10),
	kode_matkul varchar (5),
	semester int,
	nilai_formatif numeric (18,2),
	nilai_tugas numeric (18,2),
	nilai_uts numeric (18,2),
	nilai_uas numeric (18,2),
	CONSTRAINT pk PRIMARY KEY
	(nim,kode_matkul,semester)
)
*/

/*
CREATE TABLE matakuliah

(
	kode_matkul varchar (5),
	nama_matkul varchar (50),
	bobot_formatif int,
	bobot_tugas int,
	bobot_uts int,
	bobot_uas int,
	CONSTRAINT pk_kode_matkul PRIMARY KEY
	(kode_matkul)
)
*/

alter table nilai alter column
nilai_formatif int

alter table nilai alter column
ni