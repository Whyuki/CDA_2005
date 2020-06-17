const Wall = require("./Wall");

/**
 * La classe "Door" représente les coordonnées d'une porte dans une zone à 2 dimensions
 */
class Door extends Wall {
  /**@var Bool isOpen */
  #isOpen;
/**
 * Constructeur : Initialise une nouvelle instance de la classe "Door"
  * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   * @param String _material Matériel utilisé
 */
  constructor(_x, _y, _material) {
    super(_x, _y, _material);
    this.#isOpen = false;
  }

  /**
   * Retourne la valeur de isOpen
   * @returns Bool isOpen true si porte ouverte / false si fermée
   */
  getIsOpen() {
    return this.#isOpen;
  }

  /**
   * Modifie l'état de la porte : 
   * si fermée : ouverture
   * si ouverte : fermeture
   */
  openClose() {
    if (this.#isOpen === true) {
      this.#isOpen === false;
    } else {
      this.#isOpen === true;
    }
  }
}
module.exports = Door;
