use tp_agence_voyages;


-- Créer les vues répondant aux demandes suivantes :


-- 1) Afficher les informations de toutes les villes (informations du pays incluses)

DROP VIEW IF EXISTS cities_information;

CREATE VIEW cities_information 
AS 
SELECT 
city_code,
city_name,
cities.country_code, 
country_name
FROM cities
JOIN countries ON cities.country_code = countries.country_code;

-- 2) Afficher les noms, prénoms, email de tous les clients qui ont réservé au moins 1 voyage. 
--    On a besoin de connaitre le titre du voyage ainsi que le pays de destination

DROP VIEW IF EXISTS clients_reservations;

CREATE VIEW clients_reservations
AS
SELECT 
client_lastname,
client_firstname,
client_email,
trip_title,
country_name
FROM orders 
JOIN clients ON orders.client_id = clients.client_id 
JOIN trips ON orders.trip_code = trips.trip_code
JOIN cities ON trips.city_code = cities.city_code
JOIN countries ON cities.country_code = countries.country_code
; 


-- 3) Créer la vue permettant d'afficher :
--     Toutes les informations d'un client (sauf son mot de passe)
--     Le  nom de son commercial associé
--     Le nombre de voyages qu'il a commandé ET payé
--     La destination de son dernier voyage (ville + pays)

-- pour tester plusieurs commandes pour un client : somme des quantités et dernier voyage selectionné en f° de la date de départ
INSERT INTO orders 
(client_id, trip_code, order_quantity, order_paid) 
VALUES 
(1, 3, 2, 1);


DROP VIEW IF EXISTS clients_details;

CREATE VIEW clients_details
AS
SELECT 
client_lastname,
client_firstname,
client_email,
client_phone,
client_added,
com_name,
(SELECT SUM(order_quantity) FROM orders WHERE orders.order_paid =1 AND clients.client_id = orders.client_id ) AS nb_trips_ordered_paid,
(SELECT city_name
FROM orders 
JOIN trips ON orders.trip_code = trips.trip_code 
JOIN cities ON trips.city_code = cities.city_code
WHERE trip_start <= '2021-09-30' AND orders.client_id = clients.client_id ORDER BY trip_start DESC LIMIT 1) AS last_trip_city,
(SELECT country_name
FROM orders 
INNER JOIN trips ON orders.trip_code = trips.trip_code 
INNER JOIN cities ON trips.city_code = cities.city_code
INNER JOIN countries ON cities.country_code = countries.country_code
WHERE trip_start <= '2021-09-30' AND orders.client_id = clients.client_id ORDER BY trip_start DESC LIMIT 1) AS last_trip_country

-- date 2021-09-30 à la place de now() pour test date dans le futur

-- // concat ville + pays
-- (SELECT CONCAT (city_name, ', ', country_name) AS RESULT
-- FROM orders 
-- INNER JOIN trips ON orders.trip_code = trips.trip_code 
-- INNER JOIN cities ON trips.city_code = cities.city_code
-- INNER JOIN countries ON cities.country_code = countries.country_code
-- WHERE trip_start <= '2021-09-30' AND orders.client_id = clients.client_id ORDER BY trip_start DESC LIMIT 1) AS last_trip

FROM clients 
JOIN sales ON clients.com_code = sales.com_code
GROUP BY clients.client_id
;

