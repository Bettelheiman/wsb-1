<?php
  $name = 'Janusz';
  $surname = 'Nowak';
//heredoc

  echo <<< ETYKIETA
    <hr>
    Imię: $name<br>
    Nazwisko: $surname
    <hr>
ETYKIETA;
 ?>
