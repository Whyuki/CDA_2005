CREATE PROCEDURE GetCommandesParFournisseur
(@nomFournisseur varchar(50))
AS
SET NOCOUNT ON;
Select * from commandes 
INNER JOIN lignes_commandes
ON commandes.commande_id = lignes_commandes.commande_id
INNER JOIN produits 
ON lignes_commandes.produit_id = produits.produit_id 
INNER JOIN fournisseurs 
ON produits.fournisseur_id = fournisseurs.fournisseur_id 
where fournisseur_nom =@nomFournisseur