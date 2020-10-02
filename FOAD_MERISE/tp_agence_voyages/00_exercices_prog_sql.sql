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

DROP PROCEDURE IF EXISTS update_client_password;

DELIMITER $$

CREATE PROCEDURE update_client_password
(
	IN client_id_in INT,
	IN client_current_password CHAR(60), 
	IN client_new_password CHAR(60),
	IN client_new_password_confirmed CHAR(60)
)
BEGIN 
	
    DECLARE client_password_check CHAR(60);
    
    SELECT client_password INTO client_password_check FROM clients WHERE client_id=client_id_in;
    
	
    IF client_new_password <> client_new_password_confirmed 
    THEN 
		SIGNAL SQLSTATE '45000' 
		SET MESSAGE_TEXT = "Mise à jour impossible : Nouveau mot de passe et confirmation différents";
    END IF;
	
    IF client_current_password <> client_password_check
    THEN 
		SIGNAL SQLSTATE '45000' 
		SET MESSAGE_TEXT = "Mise à jour impossible : Mot de passe actuel incorrect ";
    END IF;
 
	UPDATE clients
	SET client_password = client_new_password
	WHERE client_id=client_id_in;
    
END$$

DELIMITER ;

-- test

CALL update_client_password(1,'','lol','lol');
CALL update_client_password(1,'lol','mdr','mrd');
CALL update_client_password(1,'lal','mdr','mdr');


-- 3) si une étape est ajoutée à un voyage, vérifier que la ville étape n'est pas identique à la ville de départ du voyage.


-- 4) Un service ne peut pas porter le même nom qu'un thème et inversement.


-- 5) Lors de l'ajout ou la modification d'un voyage, le prix doit etre supérieur à 50 et la date de départ doit être inférieure à la date de retour


