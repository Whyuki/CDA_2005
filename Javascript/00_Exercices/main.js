class Employee {
  constructor(_id, _nom, _prenom, _role, _salaire, _embauche) {
    this.id = _id;
    this.nom = _nom;
    this.prenom = _prenom;
    this.email =
      _prenom.toLowerCase().substr(0, 1) + _nom.toLowerCase() + "@email.fr";
    this.role = _role;
    this.salaire = _salaire;
    this.embauche = _embauche.toLocaleDateString();
  }

  getMonthlySalary() {
    return Math.round((this.salaire / 12) * 0.75);
  }

  getSeniority() {
    let maintenant = new Date();
    let dateEmbauche = new Date(this.embauche);
    let duree = maintenant.getTime() - dateEmbauche.getTime();
    let annee = 0;
    let mois = 0;
    let jour = 0;

    if (duree < 0) {
      return "Cet employé vient du futur ¯\\_(ツ)_/¯ ";
    }

    if (duree >= 31536000000) {
      annee = Math.floor(duree / 31536000000);
      duree = duree - Math.floor(annee * 31536000000);
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
  /*
  getAnciennete() {
    let maintenant = new Date();
    let dateEmbauche = new Date(this.embauche);
    let duree = new Date(maintenant.getTime() - dateEmbauche.getTime());
    let annee = duree.getUTCFullYear()-1970;
    let mois = duree.getUTCMonth();
    let jour = duree.getUTCDate()-1; 
    
    return annee + " an(s), " + mois + " mois et " + jour + " jour(s)";
  }
  */
}

/** DÉBUT ZONE NON EDITABLE (Ne pas modifier les lignes suivantes) */

/** @var Employee employee1 */
var employee1 = new Employee(
  1,
  "Doe",
  "John",
  "manager",
  82000,
  new Date("2020-12-28")
); // création d'un nouvel employé

/** @var array employees */
const employees = [employee1]; // tableau contenant les employés

console.log(employee1); // doit afficher l'objet "employee1"
console.log("Il y a " + employees.length + " employé(e)s."); // doit afficher "Il y a 5 employé(e)s."
console.log(employees); // export des employés dans la console

/** FIN ZONE NON EDITABLE (Ne pas modifier les lignes précédentes) */

// Écrivez votre code à partir de la ligne suivante...
console.log("\n \n \nBonjour ! \n");
var employee2 = new Employee(
  2,
  "Schmitt",
  "Joanna",
  "chat",
  424242,
  new Date("2002-06-28")
);

var employee3 = new Employee(
  3,
  "Torrenti",
  "Sylvain",
  "hackeur",
  101010,
  new Date("2005-01-28")
);

var employee4 = new Employee(
  4,
  "Crouzet",
  "Gabriel",
  "débugueur",
  101010,
  new Date("2008-02-28")
);

var employee5 = new Employee(
  5,
  "Boudier",
  "Aurélien",
  "CTO",
  101010,
  new Date("2019-11-12")
);

employees.push(employee2, employee3, employee4, employee5);
//console.log(employees);

function afficherCollection(_collection) {
  console.log("Liste des salariés : \n");
  for (let i = 0; i < _collection.length; i++) {
    console.log("Nom : " + _collection[i].nom);
    console.log("Prénom : " + _collection[i].prenom);
    console.log("Email : " + _collection[i].email);
    console.log("Ancienneté : " + _collection[i].getSeniority());
    // console.log("Ancienneté TEST : " + _collection[i].getAnciennete());
    console.log("Salaire Mensuel NET : " + _collection[i].getMonthlySalary());
    console.log("\n");
  }
}

afficherCollection(employees);
