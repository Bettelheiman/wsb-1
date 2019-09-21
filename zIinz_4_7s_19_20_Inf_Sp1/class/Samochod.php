<?php
  class Car{
    public $marka, $model, $produkcja;

    function __construct($kraj){
      $this->produkcja = $kraj;
      $this->ilosc_kol = 4;
    }

    public function ustawMarke($x){
      $this->marka = $x;
    }

    public function pobierzMarke(){
      return $this->marka;
    }

    public function ustawModel($x){
      $this->model = $x;
    }

    public function pobierzModel(){
      return $this->model;
    }

    public function wyswietl(){
      echo <<< E
      Marka: $this->marka<br>
      Model: $this->model<hr>
E;
    }

    public function wyswietlForeach(){
      echo "<ul>";
        foreach ($this as $key => $value) {
          echo "<li>$key: $value</li>";
        }
      echo "</ul>";
    }

  }

 ?>
