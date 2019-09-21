<?php
  class Uzytkownik{
    public $name, $surname;

    public function setName($x){
      $this->name = $x;
    }

    public function setSurname($x){
      $this->surname = $x;
    }

    public function getName(){
      return $this->name;
    }

    public function getSurname(){
      return $this->surname;
    }
  }

  $x = new Uzytkownik();

  $x->name = 'Jan';

  $x->setName('Janusz');
  echo $x->getName();


 ?>
