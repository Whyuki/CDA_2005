const Employee = require("./Models/Employee.js");
const Enterprise = require("./Models/Enterprise.js");
const functions = require("./functions.js");

let ets = new Enterprise();

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

let employee3 = new Employee(
  3,
  "Torrenti",
  "Sylvain",
  "hackeur",
  84000,
  new Date("2005-01-28")
);

let employee4 = new Employee(
  4,
  "Crouzet",
  "Gabriel",
  "débugueur",
  83000,
  new Date("1999-05-27")
);

let employee5 = new Employee(
  5,
  "Boudier",
  "Aurélien",
  "CTO",
  81000,
  new Date("2019-03-18")
);

//tests methode Enterprise***************

//create
ets.create(employee1);
ets.create(employee2);
ets.create(employee3);
ets.create(employee4);
ets.create(employee5);

//readAll
let filtres = ets.readAll(emp => emp.hiredate < new Date());
console.log(filtres);


ets.getHighestSalary();
ets.getLowestSalary();
ets.getSalaryGap();

//tests fonctions****************

//affiche la liste des employés
functions.showCollection(ets.employees);
//affiche le plus haut et le plus bas salaire
functions.showSalary(ets.employees);
//affiche junior/senior (ancienneté)
functions.showSeniority(ets.employees);


//update
let update = ets.read(2);
update.role = "Nyagociateur";
ets.update(update);

console.log(update);
console.log(ets.employees[1]);

console.log(ets.employees);

//delete
ets.delete(3);
console.log(ets.employees);