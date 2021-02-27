<?php

class SchedaMedica
{
    public function __construct($peso, $massaGrassa, $ecg, $battitiRiposo, $battitiSforzo)
    {
        assert(isset($peso),            "Peso non inizializzato");
        assert(isset($massaGrassa),     "Massa grassa non inizializzato");
        assert(isset($ecg),             "ECG non inizializzato");
        assert(isset($battitiRiposo),   "Battiti riposo non inizializzato");
        assert(isset($battitiSforzo),   "Battiti sforzo non inizializzato");
    }

    private $peso;
    private $massaGrassa;
    private $ecg;
    private $battitiRiposo;
    private $battitiSforzo;
}