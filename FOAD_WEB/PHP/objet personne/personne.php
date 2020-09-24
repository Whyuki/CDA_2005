
<?php 

class personne {

    private $nom;
    protected $prenom;
    protected $adresse;
    private $email;

    //constructeur
    public function __construct($nom, $prenom, $adresse, $email) {
        $this->nom = $nom;
        $this->prenom = $prenom;
        $this->adresse = $adresse;
        $this->email = $email;
    }

    //destructeur
    public function __destruct(){
        echo "<br />personne éliminée";
    }


    //getPersonne
    public function getPersonne(){
        return "Nom : ".$this->nom."<br />Prénom : ".$this->prenom."<br />Adresse : ".$this->adresse."<br />Email : ".$this->email."<br />";
    }

    //setAdresse
    public function setAdresse($adresse){
        $this->adresse = $adresse;
    }
    
    //setMail
    public function setMail($email){
        $this->email = $email;
    }



}

?>


