use tp_agence_voyages;


-- Créer les procédures et/ou déclencheurs répondant aux cas suivants :

-- 1) Modifier les informations d'un client :
-- 		Le mot de passe ainsi que la date d'ajout du client ne peuvent pas être modifiés sur cette procédure

DROP PROCEDURE IF EXISTS update_client;

DELIMITER $$

CREATE PROCEDURE update_client
(
	IN client_id_in INT,
	IN client_lastname_in VARCHAR(32),
    IN client_firstname_in VARCHAR(32),
    IN client_email_in VARCHAR(128),
    IN client_phone_in CHAR(16)
)
BEGIN 

	UPDATE clients
	SET client_lastname = client_lastname_in,
    client_firstname = client_firstname_in,
    client_email = client_email_in,
    client_phone = client_phone_in
	WHERE client_id=client_id_in;
    
END$$

DELIMITER ;

-- test

CALL update_client(1,'jean','bon','jeanbon@nomnomnom.fr','');

-- 2) Modifier le mot de passe d'un client (sans chiffrement pour l'exercice)
-- 		La procédure accepte 3 paramètres :  Le mot de passe actuel | Le nouveau mot de passe | Le nouveau mot de passe (pour confirmation)
-- 		Gérer les cas d'erreur



-- 3) si une étape est ajoutée à un voyage, vérifier que la ville étape n'est pas identique à la ville de départ du voyage.


-- 4) Un service ne peut pas porter le même nom qu'un thème et inversement.


-- 5) Lors de l'ajout ou la modification d'un voyage, le prix doit etre supérieur à 50 et la date de départ doit être inférieure à la date de retour


