USE Papyrus;
create table fournisseurs
(
fournisseur_id int primary key,
fournisseur_nom varchar(50),
fournisseur_adresse varchar(100),
fournisseur_cp char(5),
fournisseur_ville varchar(50),
fournisseur_contact varchar(50),
fournisseur_satisfaction tinyint,
);
create table produits
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
create table commandes
(
commande_id int primary key,
commande_date DATE,
commande_commentaire varchar(100),
);
create table lignes_commandes
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
