<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" href="./css/1_form.css">
  </head>
  <body>
    <form method="post">
      <?php
      if (!empty($_POST['color']) && !empty($_POST['name'])) {
        $color = $_POST['color'];
        $name = $_POST['name'];
        echo "Ulubione kolory $name: <br><br>";
        for ($i=0; $i < $color; $i++) {
          echo <<< INPUT
            <input type="text" name="color$i" placeholder="Kolor$i"><br><br>
INPUT;
        }

        echo <<< T
        <input type="hidden" name="count" value="$color">
        <input type="hidden" name="name" value="$name">
T;
        echo "<input type=\"submit\" name=\"button\" value=\"Wyślij\"><hr>";
      }

        //print_r($_POST);
       ?>

    </form>
    <?php
      if (isset($_POST['count'])) {
        $count = $_POST['count'];

//wypełnienie tablicy kolorami
        for ($i=0; $i < $count ; $i++) {
          $tab[$i] = $_POST["color$i"];
        }

          //print_r($tab);
          $name = $_POST['name'];
          echo "Ulubione kolory: $name<ol>";
          foreach ($tab as $value) {
            echo "<li>$value</li>";
          }
          echo "</ol>";

          $lp = 1;

          ?>
          <table>
            <tr>
              <th>lp.</th>
              <th>kolory</th>
            </tr>
            <?php
              foreach ($tab as $value) {
                echo "<tr>";
                  echo "<td>$lp</td>";
                  echo "<td>$value</td>";
                echo "</tr>";
                $lp++;
              }
             ?>
          </table>
    <?php
      }
     ?>
  </body>
</html>
