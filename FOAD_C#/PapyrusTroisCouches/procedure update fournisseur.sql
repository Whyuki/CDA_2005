CREATE PROCEDURE UpdateFournisseur
	@nomFournisseur varchar(50),
	@adresseFournisseur varchar(100),
	@cpFournisseur char(5),
	@villeFournisseur varchar(50),
	@contactFournisseur varchar(50),
	@satisfactionFournisseur tinyint,
	@idFournisseur int
	AS
	UPDATE fournisseurs                         
	SET fournisseur_nom =@nomFournisseur,
	fournisseur_adresse=@adresseFournisseur,
	fournisseur_cp=@cpFournisseur,
	fournisseur_ville=@villeFournisseur,                         
	fournisseur_contact=@contactFournisseur,                         
	fournisseur_satisfaction=@satisfactionFournisseur                         
	WHERE fournisseur_id =@idFournisseur 