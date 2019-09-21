<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="./css/style.css">
    <title></title>
  </head>
  <body>
    <?php
      require_once('./class/Samochod.php');
      $auta = array();

      for ($i=0; $i < 5 ; $i++) {
        $auta[$i] = new Car('Polska');
      }

      $auta[0]->marka = 'Opel';
      $auta[0]->model = 'Tigra';

      $auta[1]->marka = 'Fiat';
      $auta[1]->model = '126p';

      echo "Obiekty: <br>";

      /*echo "<pre>";
        print_r($auta);
      echo "</pre>";*/
     ?>

     <table>
       <tr>
         <th>Marka</th><th>Model</th><th>Produkcja</th><th>Ilość kół</th>
       </tr>
        <?php
          foreach ($auta as $auto) {
              if (!empty($auto->marka) && !empty($auto->model)) {
                echo "<tr>";
                  echo "<td>$auto->marka</td>";
                  echo "<td>$auto->model</td>";
                  echo "<td>$auto->produkcja</td>";
                  echo "<td>$auto->ilosc_kol</td>";
                echo "</tr>";
              }
          }
         ?>
     </table>
  </body>
</html>
