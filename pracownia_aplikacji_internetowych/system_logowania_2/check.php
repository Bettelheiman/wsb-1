<?php
  if (!empty($_POST['login']) && !empty($_POST['pass'])) {
    echo "ok pola wypelnione";
  }else {
    header('location: ./index.php');
  }
 ?>
