<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>
    <?php
      echo "plik:<br>";
      require_once('./class/Samochod.php');
      //PHP Version 7.3.9
      // echo phpinfo();

      $car1 = new Car('Polska');
      $car1->marka = 'Audi';
      $car1->model = 'RS8';

      $car1->wyswietl();
      $car1->wyswietlForeach();
     ?>
  </body>
</html>
