const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

{
  let lecteur = function () {
    rl.question("\n" + "Saisir un âge :" + "\n", (answer) => {
      age = answer;

      if (age < 20) {
        compteurJeune += 1;
      } else if (age == 20) {
        compteur += 1;
      } else {
        compteurNonJeune += 1;
      }

      if (i < 19) {
        lecteur();
        i += 1;
      } else {
        if (compteur == 0 && compteurJeune == 0) {
          console.log('Il n y a que des vieux, pardon: "non jeunes" *');
        } else if (compteurNonJeune == 0 && compteurJeune == 0) {
          console.log("Il n'y a que des personnes de 20ans");
        } else if (compteur == 0 && compteurNonJeune == 0) {
          console.log("Il n'y a que des jeunes*");
        } else {
          console.log("Il y a " + compteur + " personnes de 20ans");
          console.log(
            "Il y a " + compteurJeune + " personnes de moins de 20ans"
          );
          console.log(
            "Il y a " + compteurNonJeune + " personnes de plus de 20ans"
          );
        }
        rl.close();
      }
    });
  };
  let i = 0;
  let compteur = 0;
  let compteurJeune = 0;
  let compteurNonJeune = 0;

  let age = 0;

  lecteur();
}
