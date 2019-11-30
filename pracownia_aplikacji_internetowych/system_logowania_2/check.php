<?php
  session_start();
  if (!empty($_POST['login']) && !empty($_POST['pass'])) {
    echo "ok pola wypelnione";
  }else {
    $_SESSION['error'] = "Wypełnij wszystkie pola!";
    header('location: ./index.php');
  }
 ?>
