/**
 * @class Employee
 */

class Employee {
  /**
   * Constructeur
   */
  constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {
    this.id = _id;
    this.lastname = _lastname || "Un";
    this.firstname = _firstname || "Know";
    this.email =
      (this.firstname[0] + this.lastname).toLowerCase() + "@email.fr";
    this.role = _role || "Boulanger";
    this.salary = parseInt(_salary);
    this.hiredate = _hiredate;
  }

  /**
   * Calcul le salaire mensuel "net"
   * @return salaire mensuel de l'employé
   */
  getMonthlySalary() {
    return Math.round((this.salary / 12) * 0.75);
  }

  /**
   * Calcul l'ancienneté
   * @return ancienneté
   */
  getSeniority() {
    let maintenant = new Date();
    let dateEmbauche = this.hiredate;
    let duree = maintenant.getTime() - dateEmbauche.getTime();
    let annee = 0;
    let mois = 0;
    let jour = 0;

    if (duree < 0) {
      return "0 an, 0 mois et 0 jour";
      //Cet employé vient du futur ¯\\_(ツ)_/¯
    }

    if (duree >= 31557600000) {
      annee = Math.floor(duree / 31557600000);
      duree = duree - Math.floor(annee * 31557600000);
    }
    if (duree >= 2629800000) {
      mois = Math.floor(duree / 2629800000);
      duree = duree - Math.floor(mois * 2629800000);
    }
    if (duree >= 86400000) {
      jour = Math.floor(duree / 86400000);
    }

    return annee + " an(s), " + mois + " mois et " + jour + " jour(s)";
  }
}

module.exports = Employee;
