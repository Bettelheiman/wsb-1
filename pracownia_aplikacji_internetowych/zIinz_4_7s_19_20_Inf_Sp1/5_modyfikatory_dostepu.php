<?php
  class Liczby{
    public $wartosc1 = 1;
    protected $wartosc2 = 2;
    private $wartosc3 = 3;

    public function wyswietl(){
      echo "Wartość 1: ".$this->wartosc1.'<br>';
      echo "Wartość 2: ".$this->wartosc2.'<br>';
      echo "Wartość 3: ".$this->wartosc3.'<br>';
    }
  }

  class Rzeczywista extends Liczby{
    public function wyswietl(){
      echo "Wartość 1: ".$this->wartosc1.'<br>';
      echo "Wartość 2: ".$this->wartosc2.'<br>';
      echo "Wartość 3: ".$this->wartosc3.'<br>';
    }
  }

  $liczba1 = new Liczby();
  $liczba2 = new Rzeczywista();

  echo "Obiekt liczba 1 - wartosc 1: ".$liczba1->wartosc1,'<br>';
  // echo "Obiekt liczba 1 - wartosc 2: ".$liczba1->wartosc2,'<br>';
  // echo "Obiekt liczba 1 - wartosc 3: ".$liczba1->wartosc3,'<br>';

  $liczba1->wyswietl();
  echo '<hr>';

  echo $liczba2->wartosc1; //1
  // echo $liczba2->wartosc2; //fatal error
  echo $liczba2->wartosc3; //notice


 ?>
