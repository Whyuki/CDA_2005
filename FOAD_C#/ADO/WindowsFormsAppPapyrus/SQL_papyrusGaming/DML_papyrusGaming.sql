USE papyrusGaming;

INSERT INTO fournisseurs 
(fournisseur_nom,
fournisseur_adresse,
fournisseur_cp,
fournisseur_ville,
fournisseur_contact,
fournisseur_satisfaction)
VALUES ('TORRENTI','7 rue du poulpe','13400','Aubagne','Sylvain',5),
('CROUZET','18 rue de la fripouille','06000','Nice','Gabriel',5),
('SCHMITT','42 rue du chat','67330','Neuwiller','Joanna',5),
('BOUDIER','15 rue de la perfection','68000','Mulhouse','Aurelien',5),
('HAMZA','22 rue du rire','74000','Annecy','Reda',5),
('BROWN','5 rue de Barcelone','21234','Beaunes','Tim',5),
('THOUVENOT','24 rue de la lune','88000','Epinal','Nicolas',5);

INSERT INTO produits 
(
produit_id,
produit_label,
produit_stock_reel,
produit_stock_critique,
produit_qt_annuel,
produit_mesure,
fournisseur_id
)
VALUES (101,'Cyberpunk',90000,100,500000,'piece',1),
(302,'World of Warcraft',50000,75,250000,'piece',2),
(523,'Overwatch',70000,150,250000,'piece',3),
(404,'Watch Dogs',70000,250,9000,'piece',4),
(542,'Sims city',2000,25,8000,'piece',5),
(426,'League of legends',12000,200,120000,'piece',6),
(274,'Star Citizen',45000,200,15000,'piece',7);

INSERT INTO commandes 
(
commande_date,
commande_commentaire
)
VALUES ('20201204','fragile'),
('20201127','black friday'),
('20201010','zevent'),
('20201204','soldes noel'),
('20201130','cyber monday'),
('20201010','vide grenier'),
('20201001','braderie'),
('20201002','promo'),
('20201003','liquidation'),
('20201004','halloween'),
('20201005','vacances scolaires'),
('20201006','confinement'),
('20201215',''),
('20201217','soldes 2021');

INSERT INTO lignes_commandes 
(
produit_id,
commande_id,
ligne_commande_quantite,
ligne_commande_date)
VALUES 
(101,1,75,'20201201'),
(101,7,75,'20201101'),
(302,2,75,'20201202'),
(302,8,75,'20201102'),
(523,3,75,'20201203'),
(523,9,75,'20201103'),
(404,4,75,'20201204'),
(404,10,75,'20201204'),
(542,5,125,'20201205'),
(542,11,125,'20201105'),
(426,6,75,'20201206'),
(426,12,75,'20201106'),
(274,13,55,'20201215'),
(274,14,42,'20201217');