const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

let lecteur = function () {
  rl.question(
    "\n" + "Saisir deux nombres séparés pas un espace :" + "\n",
    (answer) => {
      nb = answer.split(" ");
      nb[0] = parseFloat(nb[0]);
      nb[1] = parseFloat(nb[1]);
      moyenne = (nb[0] + nb[1]) / 2;

      console.log("La moyenne est de : " + moyenne);
      rl.question("\n" + "Again ? Y/N" + "\n", (again) => {
        if (again == "Y" || again == "y" ) {
          lecteur();
        } else {
          rl.close();
        }
      });
    }
  );
};

let nb, moyenne;
lecteur();