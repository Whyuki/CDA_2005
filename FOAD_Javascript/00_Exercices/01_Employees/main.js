const Employee = require("./Models/Employee.js");
const Enterprise = require("./Models/Enterprise.js");
const functions = require("./functions.js");

let ets = new Enterprise("Nyantreprise");

let employee1 = new Employee(
  1,
  "Schmitt",
  "Joanna",
  "Quetsche",
  452000,
  new Date("2002-06-28")
);
let employee2 = new Employee(
  2,
  "Grumpy",
  "Cat",
  "Meowdiateur",
  453000,
  new Date("2002-06-28")
);


//tests methode Enterprise***************

//create
ets.create(employee1);
ets.create(employee2);

ets.save();


//tests fonctions****************

//affiche la liste des employés
functions.showCollection(ets.employees);
//affiche le plus haut et le plus bas salaire
functions.showSalary(ets.employees);
//affiche junior/senior (ancienneté)
functions.showSeniority(ets.employees);

//test méthodes class Enterprise
console.log("L'employée au plus bas salaire : "+ets.getLowestSalary());
console.log("L'employée au plus haut salaire : "+ets.getHighestSalary());
console.log("La différence entre les deux : "+ets.getSalaryGap());

//update
let update = ets.read(2); // récupère une copie de l'employé 2
update.role = "Nyagociateur";
ets.update(update);
ets.save();

//delete
ets.delete(3);
console.log(ets.employees);
