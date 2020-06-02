const Employee = require("./Employee.js");

/**
 * Gestion d'employés
 */
class Enterprise {
  constructor() {
    this.employees = [];
  }

  /**
   * Retourne tous les employés
   * @param  _filter
   */
  readAll(_filter) {
    return this.employees.filter(function (employee) {
      return employee;
    });
  }

  /**
   * Ajoute un employé à l'entreprise
   * @param Employee _employee
   */
  create(_employee) {
    this.employees.push(_employee);
  }

  /**
   * Retourne l'employé à l'id en parametre
   * @param int _id
   */
  read(_id) {
    let idOk = this.employees.filter(function (employee) {
      return employee.id == _id;
    });
    if (idOk.length == 1) {
      return idOk[0];
    } else {
      return "rip";
    }
  }

  /**
   * Met à jour un employé //
   * @param Employee _employee
   */
  update(_employee) {
    for (let i = 0; i < this.employees.length; i++) {
      if (this.employees[i].id == _employee.id) {
        Object.assign(this.employees[i], _employee);
      }
    }
  }

  /**
   * Supprime un employé
   * @param int _id
   */
  delete(_id) {
    let index;
    for (let i = 0; i < this.employees.length; i++) {
      if (this.employees[i].id == _id) {
        index = i;
        break;
      }
    }
    this.employees.splice(index, 1);
  }

  /**
   * Salaire le plus élevé
   *
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
   * Salaire le plus bas
   *
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
   * Différence entre salaire le plus élevé et le plus bas
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

  /**higher/lower OR highest/lowest ???
  /**
   * Augmentation du salaire
   * @param Employee _employee
   * @param int _newSalary //nouveau salaire ou montant à ajouter ?
   
  getHigherSalary(_employee, _newSalary) {
    if (_newSalary > _employee.salary) {
      _employee.salary = _newSalary;
    }
  }

  /**
   * Diminution du salaire (avec l'accord du salarié !)
   * @param Employee _employee
   * @param int _newSalary //nouveau salaire ou montant à déduire ?
  
  getLowerSalary(_employee, _newSalary) {
    if (_newSalary < _employee.salary) {
      _employee.salary = _newSalary;
    }
  }

  /**
   * Ecart : de salaire entre deux employés ?
   * @param Employee _employeeA
   * @param Employee _employeeB
  
  getSalaryGap(_employeeA, _employeeB) {
    let diff;
    if (_employeeA.salary == _employeeB.salary) {
      return "Ces deux employés perçoivent le même salaire";
    }
    if (_employeeA.salary > _employeeB.salary) {
      diff = _employeeA.salary - _employeeB.salary;
      return (
        _employeeA.firstname +
        " perçoit " +
        diff +
        "€/an de plus que " +
        _employeeB.firstname
      );
    }
    if (_employeeB.salary > _employeeA.salary) {
      diff = _employeeB.salary - _employeeA.salary;
      return (
        _employeeB.firstname +
        " perçoit " +
        diff +
        "€/an de plus que " +
        _employeeA.firstname
      );
    }
  }
  */
}

module.exports = Enterprise;
