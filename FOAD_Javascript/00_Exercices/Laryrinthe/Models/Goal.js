const Point = require("./Point");
/**
 * La classe "Goal" représente les coordonnées du point d'arrivée du labyrinthe
 */
class Goal extends Point {
  /**@var Bool succes  */
  #succes;

  /**
   * Constructeur: Initialise une nouvelle instance de la classe "Goal"
   * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   */
  constructor(_x, _y) {
    super(_x, _y);
    this.#succes = true;
  }

  /**
   * Retourne la valeur de succes
   * @return Bool succes
   */
  getSucces() {
    return this.#succes;
  }
}
module.exports = Goal;
