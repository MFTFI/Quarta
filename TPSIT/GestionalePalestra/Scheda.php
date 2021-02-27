<?php

class Frequenza
{
    public static function Settimanale() { return 1; }
    public static function BiSettimanale() { return 2; }
}

class Scheda
{
    public function __construct($datascadenza, $frequenza)
    {
        if(isset($datascadenza))
            $this->dataScadenza = $datascadenza;
        else
            echo"<script type='text/javascript'>alert(\"Data di scadenza vuota\");</script>";
        if(isset($frequenza))
            $this->frequenza = $frequenza;
        else
            echo"<script type='text/javascript'>alert(\"Frequenza vuota\");</script>";
    }

    public function AggiungiEsercizio($esercizio)
    {
        array_push($this->esercizi, $esercizio);
        //var_dump($this->esercizi);
    }

    public function AggiungiOptional($optional)
    {
        array_push($this->aggiunte, $optional);
        //var_dump($this->aggiunte);
    }

    public function GetEsercizi() { return $this->esercizi; }
    public function SetEsercizi($esercizi) { $this->esercizi = $esercizi; }
    public function GetDataScadenza() { return $this->dataScadenza; }
    public function SetDataScadenza($dataScadenza) { $this->dataScadenza = $dataScadenza; }
    public function GetFrequenza() { return $this->frequenza; }
    public function SetFrequenza($frequenza) { $this->frequenza = $frequenza; }
    public function GetAggiunte() { return $this->aggiunte; }
    public function SetAggiunte($aggiunte) { $this->aggiunte = $aggiunte; }

    private $esercizi = array();
    private $dataScadenza;
    private $frequenza;
    private $aggiunte = array();
}