const Point = require("./Point");
/**
 * La classe "Path" représente les coordonnées d'un chemin 
 */
class Path extends Point {
  /**@var Bool player */
  #player;
  /**@var int nombre de passage */
  #nbPasses;

  /**
   * Constructeur: Initialise une nouvelle instance de la classe "Path"
   * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
   * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
   */
  constructor(_x, _y) {
    super(_x, _y);
    this.#player = false; 
    this.#nbPasses = 0;
  }

  /**
   * Retourne la valeur de player //affiche true si le joueur est présent à ces coordonnées
   * @returns Bool player
   */
  getPlayer() {
    return this.#player;
  }

  /**
   * Définit une nouvelle valeur pour player //indique la présence ou non du joueur à ces coordonnées
   * @param Bool _player nouvelle valeur de player
   */
  setPlayer(_player) {
    this.#player = _player;
  }

  /**
   * Retourne la valeur de nbPasses
   * @returns int nbPasses Nombre de passages
   */
  getNbPasses() {
    return this.#nbPasses;
  }

  /**
   * Définit une nouvelle valeur pour nbPasses
   * @param int _nbPasses nouvelle valeur de nbPasses
   */
  setNbPasses(_nbPasses) {
    this.#nbPasses = _nbPasses;
  }
}

module.exports = Path;
