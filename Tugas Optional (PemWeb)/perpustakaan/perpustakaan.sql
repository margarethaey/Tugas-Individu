--
-- Table buku
--
CREATE TABLE buku (
  id INT NOT NULL AUTO_INCREMENT,
  judul VARCHAR(100) NOT NULL,
  pengarang VARCHAR(100) NOT NULL,
  tahun SMALLINT UNSIGNED NOT NULL DEFAULT 0,
  penerbit VARCHAR(100) NOT NULL,
  kategori VARCHAR(100),
  PRIMARY KEY (id)
);

INSERT INTO buku (judul, pengarang, tahun, penerbit, kategori) VALUES
('Bumi Manusia', 'Pramoedya Ananta Toer', 2005, 'Lentera Dipantara', NULL),
('5 cm', 'Donny Dhirgantoro', 2005, 'Grasindo', NULL),
('Sang Pemimpi', 'Andrea Hirata', 2006, 'Bentang Pustaka', NULL),
('Laskar Pelangi', 'Andrea Hirata', 2008, 'Bentang Pustaka', NULL),
('Perahu Kertas', 'Dee Lestari', 2009, 'Bentang Pustaka', NULL);


--
-- Table anggota
--
CREATE TABLE anggota (
  id INT NOT NULL AUTO_INCREMENT,
  username VARCHAR(100) NOT NULL,
  password VARCHAR(255) NOT NULL,
  nama VARCHAR(100) NOT NULL,
  status TINYINT(1) NOT NULL DEFAULT 0,
  alamat VARCHAR(255) NULL,
  PRIMARY KEY (id)
);

INSERT INTO anggota (username, password, nama, status, alamat) VALUES
('margaretha', 'margaretha', 'Margaretha Yobella', 1, 'Sidoarjo'),
('admin', 'admin', 'Contoh Member', 0, 'Surabaya'),
('andrei', 'andrei', 'Andrei Daniel', 0, 'Malang'),
('shani', 'shani', 'Shani Indira ', 0, 'Yogyakarta');

CREATE TABLE pinjam (
  id INT NOT NULL AUTO_INCREMENT,
  id_anggota INT NOT NULL,
  id_buku INT NOT NULL,
  tanggal TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (id),
  FOREIGN KEY (id_anggota) REFERENCES anggota(id),
  FOREIGN KEY (id_buku) REFERENCES buku(id)
);