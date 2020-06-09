/**
 * @class Employee
 */

class Employee {
  /**
   * Initialize un employé
   * @param Object _employee Un objet quelconque.
   */
  constructor(_employee) {
    this.id = 0;
    this.lastname = "Doe";
    this.firstname = "John";
    this.role = "Unknown";
    this.salary = 0;
    this.hiredate = new Date();
    this.email = null;

    if (_employee !== undefined) {
      // si un objet est fourni en argument
      this.copy(_employee);
    }
  }

  /**
   * Analyse et copie les informations de l'objet fourni en argument
   * Seuls les valeurs des attributs nécessaires à l'objet actuel sont copiés.
   * @param Object _employee un objet quelconque à analyser et à copier
   */
  copy(_employee) {
    // si l'argument _employee n'est pas fourni, _employee = un objet litéral vide
    _employee = _employee || {};

    this.id = parseInt(_employee.id || 0);
    this.lastname = _employee.lastname || "Doe";
    this.firstname = _employee.firstname || "John";
    this.role = _employee.role || "Unknown";
    this.salary = parseInt(_employee.salary || 0);

    // Calcul de l'email
    this.email =
      (this.firstname[0] + this.lastname).toLowerCase() + "@email.fr";

    // Recréation de l'objet Date à partir de la date fournie
    if (_employee.hiredate !== undefined) {
      this.hiredate = new Date(_employee.hiredate);
    }
  }

  /**
   * Calcul le salaire mensuel "net"
   * @return int salaire mensuel de l'employé
   */
  getMonthlySalary() {
    return Math.round((this.salary / 12) * 0.75);
  }

  /**
   * Calcul l'ancienneté
   * @return string ancienneté
   */
  getSeniority() {
    //correction :
    let now = new Date();
    let y = now.getFullYear() - this.hiredate.getFullYear(); // années
    let m = now.getMonth() - this.hiredate.getMonth(); // mois
    let d = now.getDate() - this.hiredate.getDate(); // jours
    let result = "";

    if (m < 0) {
      // si le mois n'est pas encore passé
      y--; // soustraction d'une année
      m += 12; // répercussion sur les mois
    }

    if (d < 0) {
      // idem pour le jour
      m--;
      d = Math.floor(d + 365.25 / 12);
    }

    if (y > 0) {
      result += y + " année(s) ";
    }

    if (m > 0) {
      result += m + " mois ";
    }

    if (d > 0) {
      result += d + " jour(s) ";
    }

    return result;

    /*
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
    */
  }
}

module.exports = Employee;
