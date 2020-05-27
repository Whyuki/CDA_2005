class Employee {
  constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {
    this.id = _id;
    this.lastname = _lastname;
    this.firstname = _firstname;
    this.email =
      _firstname.toLowerCase().substr(0, 1) +
      _lastname.toLowerCase() +
      "@email.fr";
    this.role = _role;
    this.salary = _salary;
    this.hiredate = _hiredate;
  }

  getMonthlySalary() {
    return Math.round((this.salary / 12) * 0.75);
  }

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
  /* TEST autre méthode : moins précise ?
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
  "Meowdiateur",
  152000,
  new Date("2002-06-28")
);

var employee3 = new Employee(
  3,
  "Torrenti",
  "Sylvain",
  "hackeur",
  84000,
  new Date("2005-01-28")
);

var employee4 = new Employee(
  4,
  "Crouzet",
  "Gabriel",
  "débugueur",
  83000,
  new Date("2008-02-22")
);

var employee5 = new Employee(
  5,
  "Boudier",
  "Aurélien",
  "CTO",
  81000,
  new Date("2019-11-12")
);

employees.push(employee2, employee3, employee4, employee5);
console.log(employees);

function afficherCollection(_collection) {
  console.log("Liste des salariés : \n");
  for (let i = 0; i < _collection.length; i++) {
    console.log("Nom : " + _collection[i].lastname);
    console.log("Prénom : " + _collection[i].firstname);
    console.log("Email : " + _collection[i].email);
    console.log("Ancienneté : " + _collection[i].getSeniority());
    console.log("Salaire Mensuel NET : " + _collection[i].getMonthlySalary());
    /* date d'embauche au format YYYY-MM-DD
    console.log(
      "Date embauche : " + _collection[i].hiredate.toLocaleDateString()
    );
    */
    console.log("\n");
  }
}

function afficherSalaire(_collection) {
  let diff = 0;
  // trie le tableau par salaire ordre coissant
  employees.sort(function (a, b) {
    return a.salary - b.salary;
  });
  let hautePaie = _collection[_collection.length - 1];
  let bassePaie = _collection[0];
  console.log(
    "L'employé au plus haut salaire : " +
      hautePaie.lastname +
      " " +
      hautePaie.firstname
  );
  console.log(
    "L'employé au plus bas salaire : " +
      bassePaie.lastname +
      " " +
      bassePaie.firstname
  );
  diff = hautePaie.salary - bassePaie.salary;
  console.log(
    "Il y un différence de " +
      diff +
      " €/BRUT ANNUEL" +
      " (soit : " +
      Math.round((diff / 12) * 0.75) +
      "€/NET MENSUEL)" +
      "\n"
  );
}

let dateOk = employees.filter(function (employee) {
  return employee.hiredate < new Date();
});

function afficherAnciennete(_collection) {
  //filtre les employés avec une date d'embauche antérieure à la date actuelle
  let dateOk = _collection.filter(function (employee) {
    return employee.hiredate < new Date();
  });
  // trie le tableau par date d'embauche de la plus récente à la plus ancienne
  dateOk.sort(function (a, b) {
    return b.hiredate - a.hiredate;
  });
  let junior = dateOk[0];
  let senior = dateOk[dateOk.length - 1];

  console.log(
    "L'employé ayant le plus d'ancienneté est : " +
      senior.lastname +
      " " +
      senior.firstname
  );
  console.log(
    "L'employé ayant le moins d'ancienneté est : " +
      junior.lastname +
      " " +
      junior.firstname +
      "\n"
  );
}
console.log("Il y a " + employees.length + " employé(e)s."); // doit afficher "Il y a 5 employé(e)s."

afficherCollection(employees);

afficherAnciennete(employees);

afficherSalaire(employees);
