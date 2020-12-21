use papyrusGaming;
GO
CREATE PROCEDURE AjoutFournisseur
(@nomFournisseur varchar(50),
@adresseFournisseur varchar(100),
@cpFournisseur char(5),
@villeFournisseur varchar(50),
@contactFournisseur varchar(50),
@satisfactionFournisseur tinyint,
@idFournisseur int OUTPUT)
AS
INSERT INTO fournisseurs (fournisseur_nom, fournisseur_adresse, fournisseur_cp, fournisseur_ville, fournisseur_contact, fournisseur_satisfaction) VALUES(@nomFournisseur, @adresseFournisseur, @cpFournisseur, @villeFournisseur, @contactFournisseur, @satisfactionFournisseur) 
SET @idFournisseur =SCOPE_IDENTITY();
GO