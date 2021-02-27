<?php
include "header.html";

include "Prodotto.php";
$prodotto = new Prodotto("Telefono", "50", "resources/telefono.png");
$immagine = $prodotto->GetImmagine();
$nome = $prodotto->GetNome();
$prezzo = $prodotto->GetPrezzo();
echo "<label>$nome |</label><label> Costo: $prezzo</label><br>";
echo "<img src=$immagine/><br>";

include "footer.html";