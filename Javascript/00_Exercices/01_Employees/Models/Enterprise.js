const Employee = require("./Employee.js");

/**
 * Gestion d'employés
 */
class Enterprise {
  constructor() {
    this.employees = [];
  }

  /**
   * Valide un objet Employee
   * @param Employee _employee
   */
  isValid(_employee) {
    if (!(_employee instanceof Employee)) {
      return false;
    }
    return true;

    /**
     * methode typeof return object ??
        if (typeof _employee !== "Employee") {
        }
    */
  }

  /**
   * Récupère une liste d'employés selon un ou plusieurs filtres
   * @param  _filter le(s) filtre(s) à appliquer
   * @returns Employee[] La liste des employés trouvés ou une liste vide si aucune correspondance
   */
  readAll(_filter) {
    return this.employees.filter(_filter);
  }

  /**
   * Créer un employé (valide les données de l'employé et l'ajoute à la collection)
   * @param Employee _employee
   * @returns Employee L'objet Employee ajouté
   */
  create(_employee) {
    if (this.isValid(_employee)) {
      // TO DO : gestion automatique des identifiants
      this.employees.push(_employee);
    }
    return _employee;
  }

  /**
   * Recherche un employé par son identifiant
   * @param int _id
   * @returns Employee l'employé correspondant ou undefined si non trouvé
   */
  read(_id) {
    let emp = this.employees.find((emp) => emp.id === parseInt(_id));

    if (emp !== undefined) {
      let copie = Object.assign(new Employee(), emp);
      return copie;
    }

    return undefined;
  }

  /**
   * Valide les données et met à jour un employé de la collection
   * @param Employee _employee
   */
  update(_employee) {
    if (!this.isValid(_employee)) {
      return _employee;
    }

    if (_employee.id < 1 && _employee.id !== NaN) {
      return _employee;
    }

    let exists = this.read(_employee.id);
    if (exists !== undefined && exists === _employee) {
      return _employee;
    }

    let emp = this.employees.find((emp) => emp.id === parseInt(_employee.id));
    Object.assign(emp, _employee);
    return emp;
  }

  /**
   * Supprime un employé identifié par "_id" de la collection
   * @param int _id
   * @returns bool true en cas de succès sinon, false
   */
  delete(_id) {
    let indOfId = this.employees.findIndex((emp) => emp.id === parseInt(_id));

    this.employees.splice(indOfId, 1);
  }

  /**
   * Recherche l'employé ayant le salaire le plus élevé
   * @returns Employee
   */
  getHighestSalary() {
    this.employees.sort(function (a, b) {
      return b.salary - a.salary;
    });
    let hautePaie = this.employees[0];

    console.log(
      "L'employé au plus haut salaire : " +
        hautePaie.lastname +
        " " +
        hautePaie.firstname
    );
  }

  /**
   * Recherche l'employé ayant le salaire le plus bas
   * @returns Employee
   */
  getLowestSalary() {
    this.employees.sort(function (a, b) {
      return a.salary - b.salary;
    });

    let bassePaie = this.employees[0];
    console.log(
      "L'employé au plus bas salaire : " +
        bassePaie.lastname +
        " " +
        bassePaie.firstname
    );
  }

  /**
   * Retrouve la différence entre le salaire le plus elevé et le salaire le plus bas
   * @returns int
   */
  getSalaryGap() {
    this.employees.sort(function (a, b) {
      return a.salary - b.salary;
    });
    let hautePaie = this.employees[this.employees.length - 1];
    let bassePaie = this.employees[0];
    let diff = hautePaie.salary - bassePaie.salary;
    console.log(
      "Il y un différence de " +
        diff +
        " €/BRUT ANNUEL" +
        " (soit : " +
        Math.round((diff / 12) * 0.75) +
        "€/NET MENSUEL) entre " +
        hautePaie.lastname +
        " " +
        hautePaie.firstname +
        " et " +
        bassePaie.lastname +
        " " +
        bassePaie.firstname +
        "\n"
    );
  }
}

module.exports = Enterprise;
