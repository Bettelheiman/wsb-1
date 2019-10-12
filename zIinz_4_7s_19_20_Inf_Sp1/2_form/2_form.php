<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>
    <form method="post">
      <input type="text" name="name" placeholder="Imię" autofocus autocomplete="off"><br><br>
      <input type="text" name="surname" placeholder="Nawisko"><br><br>
      <input type="submit" name="button" value="Zatwierdź">
    </form>

    <?php
      if (!empty($_POST['name']) && !empty($_POST['surname']) ){
        $name = $_POST['name'];
        $surname = $_POST['surname'];
        $countName = strlen($name);
        $countSurname = strlen($surname);

        echo "Dane pobrane od użytkownika:\nImię: $name:($countName), nazwisko: $surname:($countSurname)<br>";
/*
        //białe znaki
          $correctName  = trim($name);
          $correctSurname  = trim($surname);

        //ograniczenie do 10 znaków
          $correctName  = substr($correctName, 0, 10);
          $correctSurname  = substr($correctSurname, 0, 10);

        //małe znaki
          $correctName = strtolower($correctName);
          $correctSurname = strtolower($correctSurname);



        //pierwsza litera duża
          $correctName = ucfirst($correctName);
          $correctSurname = ucfirst($correctSurname);
*/


          $correctName = ucfirst(strtolower(substr(trim($name), 0, 10)));
          $correctSurname = ucfirst(strtolower(substr(trim($surname), 0, 10)));


                    $countName = strlen($correctName);
                    $countSurname = strlen($correctSurname);

          echo "Dane poprawne od użytkownika:\nImię: $correctName:($countName), nazwisko: $correctSurname:($countSurname)<br>";
      }














     ?>
  </body>
</html>
