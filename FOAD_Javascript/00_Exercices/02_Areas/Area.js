const Point = require("./Point.js");

/**
 * Class Area
 * Un "Point" est un objet représentant des coordonnées (x,y) dans un espace à 2 dimensions
 * Une "Area" est un objet représentant une zone à 2 dimensions (coïncidence?)
 * Une "Area" est obligatoirement définie par une largeur (nombre de colonnes) et une hauteur (nombre de lignes) pour former une grille.
 * On peut ajouter, déplacer et supprimer des "Point" à l'intérieur d'une Area (1 seul "Point" par coordonnée).
 * Une "Area" ne peut contenir plus de "Point" que de coordonnées disponibles dans la zone.
 * (une zone 4x4 est limitée à 16 points)
 * Les "Point" ajoutés peuvent se situer en dehors des limites de la zone (la limite du nombre de point par zone ne peut pas être dépassée !).
 *
 * Le "Point" d'origine (0,0) d'une "Area" est situé au coin supérieur gauche
 * Le "Point" d'origine existe toujours (créé dans le constructeur) et ne peut être supprimé
 * A partir du "Point" d'origine, la zone s'étend vers la droite pour les abscisses et vers le bas pour les ordonnées
 *
 *
 * ALGORITHME AJOUTER/DEPLACER UN POINT DANS UNE AREA:
 *
 * 1) En cas d'ajout, si la zone (Area) est pleine (Toutes les coordonnées "dans les limites" sont occupées par un "Point")
 *    1.1) Ajout impossible, renvoyer false
 *
 * 2) Si un "Point" existe déjà aux mêmes coordonnées:
 *    2.1) Rechercher la position libre la plus proche du "Point" d'origine (0,0)
 *    2.2) Si 2 positions son éligibles (distance égale), celle la plus proche du bord supérieur de la zone est privilégiée
 *
 * 3) Enregistrer le "Point" dans la zone
 *
 * 4) Renvoyer true
 */
class Area {
  /**
   * Constructeur: Initialise une nouvelle instance de la classe "Area"
   * La largeur et la hauteur définissent respectivement le nombre de colonnes et de lignes.
   * @param int _width largeur de la zone
   * @param int _height hauteur de la zone
   */
  constructor(_width, _height) {
    this.width = _width;
    this.height = _height;
    this.maxRange = this.width * this.height;
    this.area = [];
    const originPoint = new Point(0, 0);
    this.area[(0, 0)] = originPoint;
  }

  /**
   * Valide un objet Point
   * @param Point _point
   * @returns Boolean true: L'objet est de type Point et les données sont valides | false : l'objet n'est pas un Point valide
   * @todo Ajouter les contrôles des données de l'objet
   */
  isValid(_point) {
    if (!(_point instanceof Point)) {
      return false;
    }
    /** @todo Ajouter ici les contrôles de données de l'objet _point */

    return true; // Valide
  }

  /**
   * Ajoute un "Point" dans la zone
   * Le "Point" peut se trouver hors des limites de la zone
   * @param Point _point
   * @returns Boolean true en cas de succès, false si l'ajout est impossible
   */
  addPoint(_point) {
    if (!this.isValid(_point)) {
      return false;
    }

    if (this.area.length >= this.maxRange) {
      return false;
    }

    this.area.push(_point);
    return true;
  }

  /**
   * Déplace un point existant dans la zone vers de nouvelles coordonnées
   * Les nouvelles coordonnées peuvent se trouver hors limites
   * @param Point _point
   * @param _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   * @returns Boolean true en cas de succès, false en cas d'échec
   */
  movePoint(_point, _x, _y) {
    // verification point valide
    if (!this.isValid(_point)) {
      return false;
    }
    // verification point existant
    let exists = this.area.find((p) => p.x === _point.x && p.y === _point.y);

    //verification coordonnées déjà utilisées
    let alreadyUsed = this.area.find((p) => p.x === _x && p.y === _y);

    // si nouvelles coordonnées déjà utilisées : recherche position plus proche point origine
    if (alreadyUsed !== undefined) {
      let i, j;

      for (i = 0; i < this.width; i++) {
        for (j = 0; j < this.height; j++) {
          let notFree = this.area.find((p) => p.x === i && p.y === j);
          if (notFree === undefined) {
            _point.move(i, j);
            return true;
          }
        }
      }
    }

    if (exists !== undefined && alreadyUsed === undefined) {
      //point existant et nouvelles coordonnées non utilisées
      _point.move(_x, _y);
      return true;
    }
    
  }

  /**
   * Vérifie la position de chaque "Point" existant dans la zone
   * Chaque Point hors des limites est automatiquement déplacé dans les limites vers la position libre la plus proche
   * @returns int le nombre de points déplacés
   */
  needAllInside(/* déterminer les paramètres */) {
    // implémenter la méthode
    this.area.forEach((p) => {
      if (p.x > this.width || p.y > this.height) {
        p.inside = false;
      } else {
        p.inside = true;
      }
    });
  }
}

module.exports = Area;
