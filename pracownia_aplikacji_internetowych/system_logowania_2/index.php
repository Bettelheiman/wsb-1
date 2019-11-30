<?php
  session_start();
?>
<!DOCTYPE html>
<html lang="pl" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title>System logowania</title>
  </head>
  <form action="check.php" method="post">
    <input type="text" name="login" placeholder="Login"><br><br>
    <input type="password" name="pass" placeholder="Hasło"><br><br>
    <input type="submit" name="button" value="Zaloguj się">
  </form><hr>
  <?php
    if (isset($_SESSION['error'])) {
      echo $_SESSION['error'];
      unset($_SESSION['error']);
    }
   ?>

  <body>

  </body>
</html>
