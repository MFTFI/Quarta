<?php
$file = fopen("database.csv", 'r');

$nomeUtente = $_POST["nomeUtente"];
$nome = $_POST["nome"];
$cognome = $_POST["cognome"];
$password = $_POST["password"];
    if(ControllaDuplicazione($nomeUtente, $file)) {
        echo "<script type=\"text/javascript\">
            window.alert(\"Nome utente già registrato!\");
            </script>";
        fclose($file);
        include "registra.html";
    } else {
        fclose($file);
        AggiungiUtente(fopen("database.csv", 'a'));
        include "index.php";
    }

function ControllaDuplicazione($nomeUtente, $file)
{
    while ($row = fgetcsv($file))
        if ($row[2] == $nomeUtente)
            return true;
    return false;
}

function AggiungiUtente($file)
{
    fputcsv($file, $_POST, ',');
    fclose($file);
}