const Point = require("./Point");
/**
 * La classe "Wall" représente les coordonnées d'un mur dans une zone à 2 dimensions
 */

class Wall extends Point {
  /**@var String material */
  #material;

  /** Constructeur : Initialise une nouvelle instance de la classe "Wall"
   * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   * @param String _material Matériel utilisé
   */
  constructor(_x, _y, _material) {
    super(_x, _y);
    this.#material = _material;
  }

  /**
   * Retourne la valeur de material
   * @returns String material
   */
  getMaterial() {
    return this.#material;
  }
}

module.exports = Wall;
