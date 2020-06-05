function showCollection(_collection) {
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

function showSalary(_collection) {
  let diff = 0;
  // trie le tableau par salaire ordre coissant
  _collection.sort(function (a, b) {
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
  //retrie par id
  _collection.sort(function (a, b) {
    return a.id - b.id;
  });
}

function showSeniority(_collection) {
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
  //retrie par id
  _collection.sort(function (a, b) {
    return a.id - b.id;
  });
}

module.exports = {
  showCollection,
  showSalary,
  showSeniority,
};
