USE master;
DROP DATABASE IF EXISTS papyrusGaming;
GO
CREATE DATABASE papyrusGaming;
GO
USE papyrusGaming;
GO

DROP TABLE IF EXISTS lignes_commandes;
DROP TABLE IF EXISTS commandes;
DROP TABLE IF EXISTS produits;
DROP TABLE IF EXISTS fournisseurs;


CREATE TABLE fournisseurs
(
fournisseur_id int primary key IDENTITY,
fournisseur_nom varchar(50) CHECK (DATALENGTH(fournisseur_nom) > 0),
fournisseur_adresse varchar(100),
fournisseur_cp char(5),
fournisseur_ville varchar(50),
fournisseur_contact varchar(50),
fournisseur_satisfaction tinyint,
);
CREATE TABLE produits
(
produit_id int primary key,
produit_label varchar(50),
produit_stock_reel int,
produit_stock_critique int,
produit_qt_annuel int,
produit_mesure varchar(10),
fournisseur_id int,
CONSTRAINT fk_fournisseur_produit FOREIGN KEY (fournisseur_id)
        REFERENCES fournisseurs (fournisseur_id)
);
CREATE TABLE commandes
(
commande_id int primary key IDENTITY,
commande_date DATE,
commande_commentaire varchar(100),
);
CREATE TABLE lignes_commandes
(
produit_id int,
commande_id int unique,
ligne_commande_quantite int,
ligne_commande_date DATE,
CONSTRAINT pk_commande_produit PRIMARY KEY (commande_id , produit_id),
CONSTRAINT fk_commande FOREIGN KEY (commande_id)
        REFERENCES commandes (commande_id),
CONSTRAINT fk_produit FOREIGN KEY (produit_id)
        REFERENCES produits (produit_id)
);
