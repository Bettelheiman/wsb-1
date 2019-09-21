<?php
  require_once('./class/Samochod.php');

  class Ciezarowy extends Car{
    public $ladownosc;

    public function wyswietl(){
      echo parent::wyswietl();
      echo "Ładowność: ",$this->ladownosc;
    }
  }

  $tir1 = new Ciezarowy('Polska');

  $tir1->ladownosc = 24000;
  $tir1->marka = 'DAF';
  $tir1->model = 'XF 95 480';

  echo $tir1->wyswietl(),'<br>';

  $tir2 = new Car('Polska');
  echo $tir2->ladownosc;

 ?>
