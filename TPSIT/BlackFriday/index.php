<?php
$prodotti = array();
$carrello = array();
include "header.html";

CreaCarrello();
include "Prodotto.php";
$telefono = new Prodotto("Telefono", "50", "resources/telefono.jpg");
$scatola = new Prodotto("Scatola", "43", "resources/scatola.png");
$libro = new Prodotto("Libro", "58", "resources/libro.jpg");
$maschera = new Prodotto("Maschera Pagliaccio", "32", "resources/pagliaccio.jpg");
array_push($prodotti, $telefono);
array_push($prodotti, $scatola);
array_push($prodotti, $libro);
array_push($prodotti, $maschera);
RiempiProdotti($prodotti);

include "footer.html";

function RiempiProdotti($prodotti)
{
    foreach($prodotti as $prodotto) {
        $nome = $prodotto->GetNome();
        $prezzo = $prodotto->GetPrezzo();
        $immagine = $prodotto->GetImmagine();
        echo "<div>";
        echo "<label>$nome |</label><label> Costo: $prezzo euro</label><br>";
        echo "<img style=' width: 300px; height: 300px;' src=$immagine/><br>";
        echo "<button>Aggiungi al carrello</button>";
        echo "</div>";
    }
}

function CreaCarrello()
{
    echo "<div style=\"height: 120px; width: 9000px; background-color: grey;\">";
    echo   "<button>
            <img src='resources/carrello.png' width='100px' height='70px'/><br>
            Il tuo carrello
            </button>";
    echo "</div>";
}