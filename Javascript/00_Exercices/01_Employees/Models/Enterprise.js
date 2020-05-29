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
    // return this.employees; // read ALL ?? param _filter useless ?
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
      return idOk;
    } else {
      return "rip";
    }
  }

  /**
   * Met à jour un employé // ? role
   * @param Employee _employee
   * @param String _newRole
   *
   */
  update(_employee, _newRole) {
    _employee.role = _newRole;
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
   * Augmentation du salaire
   * @param Employee _employee
   * @param int _newSalary //nouveau salaire ou montant à ajouter ?
   */
  getHigherSalary(_employee, _newSalary) {
    if (_newSalary > _employee.salary) {
      _employee.salary = _newSalary;
    }
  }

  /**
   * Diminution du salaire (avec l'accord du salarié !)
   * @param Employee _employee
   * @param int _newSalary //nouveau salaire ou montant à déduire ?
   */
  getLowerSalary(_employee, _newSalary) {
    if (_newSalary < _employee.salary) {
      _employee.salary = _newSalary;
    }
  }

  /**
   * Ecart : de salaire entre deux employés ?
   * @param Employee _employeeA
   * @param Employee _employeeB
   */
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
}

module.exports = Enterprise;
