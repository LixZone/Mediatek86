-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 14 mai 2025 à 13:24
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek
--
CREATE DATABASE mediatek;
CREATE USER 'mediatek'@'localhost' IDENTIFIED BY 'mediatek';
GRANT ALL PRIVILEGES ON mediatek.* TO 'mediatek'@'localhost';
FLUSH PRIVILEGES;
USE mediatek;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(3, '2024-01-05 00:00:00', '2024-01-10 00:00:00', 1),
(8, '2024-02-12 00:00:00', '2024-02-15 00:00:00', 2),
(2, '2024-03-01 00:00:00', '2024-03-05 00:00:00', 3),
(5, '2024-03-20 00:00:00', '2024-03-22 00:00:00', 4),
(11, '2024-04-05 00:00:00', '2024-04-08 00:00:00', 1),
(14, '2024-04-15 00:00:00', '2024-04-18 00:00:00', 2),
(7, '2024-05-01 00:00:00', '2024-05-04 00:00:00', 3),
(6, '2024-05-10 00:00:00', '2024-05-14 00:00:00', 4),
(9, '2024-06-01 00:00:00', '2024-06-06 00:00:00', 1),
(13, '2024-06-10 00:00:00', '2024-06-15 00:00:00', 2),
(1, '2024-07-03 00:00:00', '2024-07-07 00:00:00', 3),
(10, '2024-07-15 00:00:00', '2024-07-20 00:00:00', 4),
(4, '2024-08-01 00:00:00', '2024-08-05 00:00:00', 1),
(12, '2024-08-12 00:00:00', '2024-08-14 00:00:00', 2),
(15, '2024-09-01 00:00:00', '2024-09-03 00:00:00', 3),
(5, '2024-09-10 00:00:00', '2024-09-12 00:00:00', 4),
(8, '2024-10-01 00:00:00', '2024-10-05 00:00:00', 1),
(2, '2024-10-15 00:00:00', '2024-10-18 00:00:00', 2),
(14, '2024-11-01 00:00:00', '2024-11-04 00:00:00', 3),
(9, '2024-11-12 00:00:00', '2024-11-15 00:00:00', 4),
(1, '2024-12-01 00:00:00', '2024-12-03 00:00:00', 1),
(3, '2024-12-10 00:00:00', '2024-12-14 00:00:00', 2),
(6, '2024-12-20 00:00:00', '2024-12-24 00:00:00', 3),
(11, '2025-01-05 00:00:00', '2025-01-08 00:00:00', 4),
(7, '2025-01-15 00:00:00', '2025-01-19 00:00:00', 1),
(13, '2025-02-01 00:00:00', '2025-02-05 00:00:00', 2),
(10, '2025-02-10 00:00:00', '2025-02-12 00:00:00', 3),
(4, '2025-02-20 00:00:00', '2025-02-25 00:00:00', 4),
(12, '2025-03-01 00:00:00', '2025-03-03 00:00:00', 1),
(15, '2025-03-10 00:00:00', '2025-03-15 00:00:00', 2),
(8, '2025-03-20 00:00:00', '2025-03-25 00:00:00', 3),
(2, '2025-04-01 00:00:00', '2025-04-06 00:00:00', 4),
(6, '2025-04-12 00:00:00', '2025-04-14 00:00:00', 1),
(5, '2025-04-20 00:00:00', '2025-04-22 00:00:00', 2),
(9, '2025-05-01 00:00:00', '2025-05-05 00:00:00', 3),
(14, '2025-05-10 00:00:00', '2025-05-14 00:00:00', 4),
(3, '2025-05-20 00:00:00', '2025-05-22 00:00:00', 1),
(7, '2025-06-01 00:00:00', '2025-06-04 00:00:00', 2),
(1, '2025-06-10 00:00:00', '2025-06-12 00:00:00', 3),
(11, '2025-06-20 00:00:00', '2025-06-24 00:00:00', 4),
(13, '2025-07-01 00:00:00', '2025-07-03 00:00:00', 1),
(10, '2025-07-10 00:00:00', '2025-07-14 00:00:00', 2),
(4, '2025-07-20 00:00:00', '2025-07-25 00:00:00', 3),
(12, '2025-08-01 00:00:00', '2025-08-05 00:00:00', 4),
(15, '2025-08-10 00:00:00', '2025-08-14 00:00:00', 1),
(9, '2025-08-20 00:00:00', '2025-08-22 00:00:00', 2),
(6, '2025-09-01 00:00:00', '2025-09-04 00:00:00', 3),
(2, '2025-09-10 00:00:00', '2025-09-13 00:00:00', 4),
(5, '2025-09-20 00:00:00', '2025-09-22 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Mcdonald', 'Mufutau', '03 02 33 67 78', 'sem.pellentesque@icloud.ca', 0),
(2, 'Maynard', 'Whilemina', '06 73 62 46 13', 'egestas.a.dui@aol.net', 0),
(3, 'Castro', 'Audrey', '04 65 26 61 68', 'sapien@yahoo.org', 0),
(4, 'Steele', 'Catherine', '05 08 84 47 28', 'nullam.ut@hotmail.com', 0),
(5, 'Hurst', 'Amy', '04 29 38 55 87', 'convallis.dolor@icloud.edu', 0),
(6, 'Snow', 'Barry', '07 35 23 56 85', 'nunc.interdum@google.com', 0),
(7, 'Hardy', 'Macy', '04 68 56 89 34', 'suspendisse.ac@protonmail.couk', 0),
(8, 'Williams', 'Jemima', '09 08 73 61 79', 'quis.pede@outlook.ca', 0),
(9, 'Craft', 'Wyoming', '03 37 75 08 45', 'fringilla.purus@aol.ca', 0),
(10, 'Foreman', 'Jordan', '06 48 84 37 79', 'nec.tempus.scelerisque@protonmail.edu', 0),
(11, 'Johnston', 'Chantale', '05 63 78 56 54', 'pede.ac.urna@google.net', 0),
(12, 'Wilcox', 'Stewart', '07 15 42 68 36', 'erat.etiam.vestibulum@google.ca', 0),
(13, 'Chambers', 'Garth', '06 73 12 16 12', 'varius@hotmail.org', 0),
(14, 'Roberts', 'Keefe', '02 81 07 84 42', 'nunc.risus@icloud.couk', 0),
(15, 'Valencia', 'Brooke', '06 41 48 32 75', 'eu.tellus.eu@outlook.net', 0);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('mediatek', '7ae9124bce80884731d3baf1be2861c8966000ce089a517e401b7994766acf0a');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY idmotif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY idservice (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
