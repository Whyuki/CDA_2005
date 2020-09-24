<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Php objet personne</title>
</head>
<body>
    <?php 
    require_once("personne.php");

    $personne1=new personne("truc", "bidule", "666 rue des enfers", "trucbidule@mail.fr");
    
    $personne2=new personne("machin","chose","46 avenue du calvair","machinchose@mail.fr");

    echo $personne1->getPersonne();
    $personne1->setAdresse("18 rue de Jean Peuplux...");
    $personne1->setMAIL("çanemangepasdepain@leriztourne.fr");
    echo "Après modifications :<br/>".$personne1->getPersonne();
    
    var_dump($personne2);
    

    ?>
</body>
</html>