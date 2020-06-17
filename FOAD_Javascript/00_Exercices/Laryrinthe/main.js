const Point = require("./Models/Point");
const Wall = require("./Models/Wall");
const Door = require("./Models/Door");
const Path = require("./Models/Path");
const Goal = require("./Models/Goal");

let point = new Point(1,1);
console.log(point);
console.log(point.getX());
console.log(point.getY());

let mur = new Wall (2,6,"brique");
console.log(mur);
console.log(mur.getX());
console.log(mur.getY());
console.log(mur.getMaterial());

let porte = new Door (4,7,"bois");
console.log(porte);
console.log(porte.getX());
console.log(porte.getY());
console.log(porte.getMaterial());
console.log(porte.getIsOpen());

let chemin = new Path (3,5, true, 1);
console.log(chemin);
console.log(chemin.getX());
console.log(chemin.getY());
console.log(chemin.getPlayer());
console.log(chemin.getNbPasses());

let arrivee = new Goal (9,9);
console.log(arrivee);
console.log(arrivee.getX());
console.log(arrivee.getY());
console.log(arrivee.getSucces());

console.log(typeof point);
console.log(point instanceof Point);
console.log(typeof mur);
console.log(mur instanceof Wall);
console.log(typeof porte);
console.log(porte instanceof Door);
console.log(typeof chemin);
console.log(chemin instanceof Path);
console.log(typeof arrivee);
console.log(arrivee instanceof Goal);
