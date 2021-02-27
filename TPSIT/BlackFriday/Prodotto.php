<?php

class Prodotto
{
    public function __construct($nome, $prezzo, $percorsoImmagine, $descrizione = null)
    {
        $this->nome = $nome;
        $this->prezzo = $prezzo;
        $this->immagine = $percorsoImmagine;
        if(isset($descrizione))
            $this->descrizione = $descrizione;
    }

    public function GetNome() { return $this->nome; }
    public function SetNome($nome) { $this->nome = $nome; }
    public function GetPrezzo() { return $this->prezzo; }
    public function SetPrezzo($prezzo) { $this->prezzo = $prezzo; }
    public function GetImmagine() { return $this->immagine; }
    public function SetImmagine($percorso) { $this->immagine = $percorso; }

    private $nome;
    private $descrizione;
    private $prezzo;
    private $immagine;
}