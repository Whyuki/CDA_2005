/**
 * JAVASCRIPT:  Exercices
 *
 * Définition d'un "Point"
 *
 *
 * CONSIGNES :
 * 1) Lisez la description et étudiez la classe "Point" ci-dessous (celle-ci est partiellement implémentée)
 * 2) Implémentez les méthodes suivantes:
 *  - move(int x, int y)    : définit de nouvelles coordonnées (x=abscisses, y=ordonnées)
 *  - duplicate()           : retourne une nouvelle instance de "Point" avec les mêmes coordonnées que l'instance actuelle
 *  - copy(Point _point)    : copie les coordonnées du "Point" fourni en argument dans l'instance actuelle
 *  - rabbit(Point _point)  : Les coordonnées de l'instance actuelle et du "Point" fourni en argument sont échangées
 *
 * RESTRICTIONS :
 *  - Le corps de la méthode "rabbit" ne peut contenir que 3 instructions au maximum et ne doit pas impliquer la création d'autres fonctions !
 *
 * Le petit programme qui suit la classe doit fonctionner en l'état (non modifié)
 */

/**
 * La classe "Point" représente les coordonnées d'un point dans une zone à 2 dimensions
 */
class Point {
  /**
   * Constructeur: Initialise une nouvelle instance de la classe "Point"
   * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   */
  constructor(_x, _y) {
    this.x = parseInt(_x || 0);
    this.y = parseInt(_y || 0);
  }

  /**
   * Retourne une représentation textuelle du Point
   * @return string Les coordonnées du Point
   */
  toString() {
    return "(" + this.x + "," + this.y + ")";
  }

  /**
   * définit de nouvelles coordonnées (x=abscisses, y=ordonnées)
   * @param _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   */
  move(_x, _y) {
    this.x = parseInt(_x);
    this.y = parseInt(_y);
  }

  /**
   * retourne une nouvelle instance de "Point" avec les mêmes coordonnées que l'instance actuelle
   * @return new Point avec les coordonnées du Point ciblé
   */
  duplicate() {
    return new Point(this.x, this.y);
  }

  /**
   * copie les coordonnées du "Point" fourni en argument dans l'instance actuelle
   * @param Point objet Point
   */
  copy(_point) {
    this.x = _point.x;
    this.y = _point.y;
  }

  /**
   * Les coordonnées de l'instance actuelle et du "Point" fourni en argument sont échangées
   * @param Point objet Point
   */
  rabbit(_point) {
    let p = _point.duplicate();
    _point.copy(this);
    this.copy(p);

    /* ou bien : 
    let p = this.duplicate();
    this.copy(_point);
    _point.copy(p);
    */
    /* ou encore (entre autres) :
    let p = _point.duplicate();
    _point.move(this.x, this.y);
    this.move(p.x, p.y);
    */
  }
}
module.exports = Point;

/**
 * Programme "Point"
 * test_point.js
 */
