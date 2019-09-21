<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>
    <?php
//heredoc
      // echo phpinfo();
      // PHP Version 7.2.11

      $name = 'Janusz';
      $city = 'Poznań';

      echo <<< E
        Twoje imię: $name<br>
        Miasto: $city<hr>
E;

      $text = <<< E
        Twoje imię: $name<br>
        Miasto: $city<hr>
E;

  echo $text;

//nowdoc

echo <<< 'E'
nowdoc<br>
  Twoje imię: $name<br>
  Miasto: $city<hr>
E;

#########################################

    $potega = 2 ** 10;
    echo $potega;

    $x = 10;
    $y = 100;
    $wynik = $x <=> $y;
    echo '<hr>',$wynik;

#########################################

// operatory bitowe: and &, or |, not ~, xor ^, >>, <<

  $x = 0b1010;
  $x = $x >> 1; //101(2) 5
  $x = $x << 2; //10100(2) 20
  echo $x;

  echo gettype($x); //integer

####### składnia alternatywna

  $x = 1;
  $y = 2;

  if ($x < $y) {
    echo 'x mniejsze od y';
  }else {
    echo 'x nie jest mniejsze od y';
  }

  if ($x < $y):
    echo 'x mniejsze od y';
  else:
    echo 'x nie jest mniejsze od y';
  endif;

  $tab = array(1 ,2, 3, 4, 5);

  foreach ($tab as $key => $value):
        echo "$tab[$key] = $value";
  endforeach;






     ?>
  </body>
</html>
