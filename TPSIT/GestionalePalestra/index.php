<?php
include "header.html";
#tutto il bellissimo codice pazzesco qui
include "Scheda.php";
include "Cliente.php";
include "ServizioAggiuntivo.php";

$scheda = new Scheda("7", "6");
$scheda->AggiungiEsercizio("5");
$scheda->AggiungiOptional(new ServizioAggiuntivo("beelo", 6));
$cliente = new Cliente("Pinco", "Pallino", "69", "via via", "astronauta",$scheda);
#tutto il bellissimo codice pazzesco qui
include "footer.html";