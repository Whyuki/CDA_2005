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
  452000,
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
  new Date("1520-05-27")
);

let employee5 = new Employee(
  5,
  "Boudier",
  "Aurélien",
  "CTO",
  81000,
  new Date("2019-03-18")
);

nya.create(employee1);
nya.create(employee2);
nya.create(employee3);
nya.create(employee4);
nya.create(employee5);

nya.update(employee2, "Myrtille");

console.log(nya.read(2));

console.log(nya.getSalaryGap(employee1, employee2));

console.log(nya.readAll());

functions.showCollection(nya.employees);
functions.showSalary(nya.employees);
functions.showSeniority(nya.employees);

nya.delete(3);
console.log(nya.readAll());

let update = nya.read(2);
update.role = "Nyagociateur";
nya.update(update);

console.log(nya.read(2));
