const Employee = require("./Models/Employee.js");
const Enterprise = require("./Models/Enterprise.js");
const functions = require("./functions.js");

let nya = new Enterprise();

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
nya.create(employee1);
nya.create(employee2);
nya.create(employee3);
nya.create(employee4);
nya.create(employee5);

//readAll
console.log(nya.readAll());

//read
console.log(nya.read(2));

//update
let update = nya.read(2);
update.role = "Nyagociateur";
nya.update(update);
console.log(nya.read(2));

//delete
nya.delete(3);
console.log(nya.employees);

nya.getHighestSalary();
nya.getLowestSalary();
nya.getSalaryGap();

//tests fonctions****************

//affiche la liste des employés
functions.showCollection(nya.employees);
//affiche le plus haut et le plus bas salaire
functions.showSalary(nya.employees);
//affiche junior/senior (ancienneté)
functions.showSeniority(nya.employees);
