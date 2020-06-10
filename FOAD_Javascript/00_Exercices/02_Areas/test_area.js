const Point = require("./Point.js");
const Area = require("./Area.js");

/* Implémenter le programme suivant :
 *      a) Créer 2 "Area"
 *          a.1) Area 1 : 4 lignes x 4 colonnes
 *          a.2) Area 2 : 8 lignes x 6 colonnes
 *      b) Dans la 1ère "Area", ajouter 8 "Point" (coordonnées au choix, 5 dans les limites de la zone et 3 hors limites)
 *      c) Dans la 2nde "Area", ajouter 6 "Point" (coordonnées au choix, tous en dehors des limites)
 *      d) Créer ensuite 2 "Point" distincts ayant les mêmes coordonnées
 *      e) Les ajouter dans chacune des zones (1 "Point" par zone)
 *      f) Pour chaque zone :
 *          - Afficher tous les points qui se trouvent hors des limites de la zone
 *          - Exécuter la méthode "needAllInside"
 *          - Afficher tous les points
 *          - Afficher le nombre d'emplacements libres
 */

// 1ere zone
const area1 = new Area(4, 4);
// 2eme zone
const area2 = new Area(8, 6);

// Ajout des 8 points dans la zone 1
[
  new Point(0, 2),
  new Point(3, 3),
  new Point(2, 1),
  new Point(2, 3),
  new Point(3, 1),
  new Point(8, 7),
  new Point(19, 42),
  new Point(0, 8),
].forEach((p) => area1.addPoint(p));

// ajout des 6 points dans la zone 2
[
  new Point(25, 12),
  new Point(5, 83),
  new Point(77, 1),
  new Point(22, 4),
  new Point(2, 112),
  new Point(-337, 7),
].forEach((p) => area2.addPoint(p));

// création des 2 points aux mêmes coordonnées
let p1 = new Point(8, 6);
let p2 = p1.duplicate();

// ajout des 2 points dans leur zone respective
area1.addPoint(p1);
area2.addPoint(p2);

//area1
console.log("\nZone 1 :");
console.log(
  "Points hors limites : ",
  area1.outArea() //Affiche tous les points qui se trouvent hors des limites de la zone
);
console.log(area1.needAllInside() + " points déplacés."); //Exécute la méthode "needAllInside" et affiche le nombre de points déplacés
console.log("Tous les points : ", area1.area); //affiche tous les points
console.log("Nombre d'emplacements libres : " + area1.freeEmplacement()); //affiche le nombre d'emplacements libres

//area2
console.log("\nZone 2 :");
console.log(
  "Points hors limites : ",
  area2.outArea() //Affiche tous les points qui se trouvent hors des limites de la zone
); //Affiche tous les points qui se trouvent hors des limites de la zone
console.log(area2.needAllInside() + " points déplacés."); //Exécute la méthode "needAllInside" et affiche le nombre de points déplacés
console.log("Tous les points : ", area2.area); //affiche tous les points
console.log("Nombre d'emplacements libres : " + area2.freeEmplacement()); //affiche le nombre d'emplacements libres
