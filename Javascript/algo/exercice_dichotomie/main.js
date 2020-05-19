const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

{
  let inception = function () {
    rl.question(
      "\n" + "Saisir un prénom :" + "\n" + "[ end pour quitter ]" + "\n",
      (answer) => {
        if (answer == "end") return rl.close();
        min = 0;
        max = collection.length - 1;
        mid = (min + max) / 2;
        present = false;
        prenom = answer;

        while (present == false && min <= max) {
          if (prenom.localeCompare(collection[mid]) == 0) {
            //trouvé
            present = true;
          } else if (prenom.localeCompare(collection[mid]) < 0) {
            //avant
            max = mid - 1;
          } else {
            //après
            min = mid + 1;
          }
          mid = (min + max) / 2;
        }

        if (present == true) {
          console.log(
            "Prénom " + prenom + " trouvé à la case n ° " + (mid + 1) + "\n"
          );
        } else {
          console.log("Prénom non trouvé " + "\n");
        }

        inception();
      }
    );
  };

  let collection = [
    "agathe",
    "berthe",
    "chloé",
    "cunégonde",
    "olga",
    "raymonde",
    "sidonie",
  ];

  let present = false;

  let min = 0;
  let max = collection.length - 1;
  let mid = (min + max) / 2;
  let prenom = "nom";

  inception();
}
