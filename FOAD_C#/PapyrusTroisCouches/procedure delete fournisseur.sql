CREATE PROCEDURE DeleteFournisseur
	@idFournisseur int
AS
	DELETE from fournisseurs where fournisseur_id =@idFournisseur
