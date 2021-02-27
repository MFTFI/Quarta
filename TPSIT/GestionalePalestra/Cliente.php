<?php

class Cliente
{
    public function __construct($nome, $cognome, $eta, $indirizzo, $professione, $scheda, $schedaMedica = null)
    {
        assert(isset($nome),        "Nome non inizializzato");
        assert(isset($cognome),     "Cognome non inizializzato");
        assert(isset($eta),         "Eta non inizializzato");
        assert(isset($indirizzo),   "Indirizzo non inizializzato");
        assert(isset($professione), "Professione non inizializzato");
        assert(isset($scheda),      "Scheda non inizializzato");

        $this->nome = $nome;
        $this->cognome = $cognome;
        $this->eta = $eta;
        $this->indirizzo = $indirizzo;
        $this->professione = $professione;
        $this->scheda = $scheda;
        if(isset($schedaMedica))
            $this->schedaMedica = $schedaMedica;
        //var_dump($scheda);
    }

    public function CreaCliente()
    {

    }

    public function CalcolaCostoAbbonamento()
    {
        $tmp = (object)$this->scheda;

    }

    private $costoBase = 50;
    private $nome;
    private $cognome;
    private $eta;
    private $indirizzo;
    private $professione;
    private $schedaMedica;
    private $scheda;
}