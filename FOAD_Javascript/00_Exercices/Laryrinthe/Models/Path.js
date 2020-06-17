const Point = require("./Point");
/**
 * La classe "Path" représente les coordonnées d'un point "spécial" //?présence du joueur/nb de passages ??
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
   * @param Bool _player Présence du joueur ?
   * @param int _nbPasses Nombre de passages
   */
  constructor(_x, _y, _player, _nbPasses) {
    super(_x, _y);
    this.#player = _player;
    this.#nbPasses = _nbPasses;
  }

  /**
   * Retourne la valeur de player
   * @returns Bool player
   */
  getPlayer() {
    return this.#player;
  }

  /**
   * Définit une nouvelle valeur pour player
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
