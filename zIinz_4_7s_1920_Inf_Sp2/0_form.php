<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" href="./css/1_form.css">
  </head>
  <body>
    <form method="post">
      <input type="text" name="name" placeholder="Imię"><br><br>
      <input type="number" name="age" placeholder="Wiek"><br><br>
      <input type="submit" name="button" value="Wyślij"><hr>
    </form>
    <?php
      if (!empty($_POST['name']) && $_POST['age'] >= 1 && $_POST['age'] <= 140) {
        $name = $_POST['name'];
        $age = $_POST['age'];
        $lp = 1;
        $nameSize = strlen($name);

        echo "Dane przed poprawą: imię: $name, wiek: $age, długość imienia: $nameSize<br>";

        $name = ucfirst(strtolower(substr(trim($name), 0, 10)));
        $nameSize = strlen($name);
        echo "Dane przed poprawą: imię: $name, wiek: $age, długość imienia: $nameSize";
        ?>
          <table>
            <tr>
              <th>lp.</th>
              <th>imię</th>
              <th>Wiek</th>
            </tr>
            <tr>
              <td><?php echo $lp; ?></td>
              <td><?php echo $name; ?></td>
              <td><?php echo $age; ?></td>
            </tr>
          </table>
      <?php
      }
     ?>
  </body>
</html>
