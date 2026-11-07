-- Baza za prodavnicu meda "sace".
-- Pokretanje: otvori phpMyAdmin, izaberi Import i ucitaj ovaj fajl.

CREATE DATABASE IF NOT EXISTS sace CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE sace;

CREATE TABLE IF NOT EXISTS korisnici (
    id INT AUTO_INCREMENT PRIMARY KEY,
    korisnicko_ime VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    lozinka VARCHAR(255) NOT NULL,
    uloga ENUM('admin', 'korisnik') NOT NULL DEFAULT 'korisnik',
    datum_registracije TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- Admin nalog za razvoj. Korisnicko ime: admin, lozinka: admin123
-- U tabeli se cuva samo hash lozinke.
INSERT IGNORE INTO korisnici (korisnicko_ime, email, lozinka, uloga)
VALUES ('admin', 'admin@sace.local', '$2a$11$SzL235HbARQ3sqQlqhmBsu./WHO7SDU9fAPSzY2Wic4HY92YwdfZ.', 'admin');
