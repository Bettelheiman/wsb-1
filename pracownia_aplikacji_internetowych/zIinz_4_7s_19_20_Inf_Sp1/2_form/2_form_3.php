<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      if (!empty($_POST['name']) && !empty($_POST['surname']) ){
        $name = $_POST['name'];
        $surname = $_POST['surname'];
        $countName = strlen($name);
        $countSurname = strlen($surname);

        echo "Dane pobrane od użytkownika:\nImię: $name:($countName), nazwisko: $surname:($countSurname)<br>";


          $correctName = ucfirst(strtolower(substr(trim($name), 0, 10)));
          $correctSurname = ucfirst(strtolower(substr(trim($surname), 0, 10)));


                    $countName = strlen($correctName);
                    $countSurname = strlen($correctSurname);

          echo "Dane poprawne od użytkownika:\nImię: $correctName:($countName), nazwisko: $correctSurname:($countSurname)<br>";
      }else{

        require('./form.php');
      }

         ?>

  </body>
</html>
