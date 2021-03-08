<?php
if(isset($_POST["ricorda"])) {
    setcookie("nomeUtente", $_POST["nomeUtente"], time() + (60 * 60 * 24));
    setcookie("password", $_POST["password"],time() + (60 * 60 * 24));
} else {
    unset($_COOKIE['nomeUtente']);
    unset($_COOKIE['password']);
}

$nomeUtente = $_POST["nomeUtente"];
$password = $_POST["password"];

$file = fopen("database.csv", 'r');
$trovato = false;
while ($row = fgetcsv($file)) {
    if ($row[2] == $nomeUtente and $row[3] == $password) {
       $trovato = true;
       break;
    }
}
if($trovato) {
    echo "<script type=\"text/javascript\">
                window.alert(\"Entrato nel sito\");
                </script>";
} else {
    echo "<script type=\"text/javascript\">
            window.alert(\"Nome o utente o password sbagliati\");
            </script>";
}
fclose($file);