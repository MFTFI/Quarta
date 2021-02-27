<?php


class ServizioAggiuntivo
{
    public function __construct($nome, $costo)
    {
        if(isset($nome))
            $this->nome = $nome;
        else
            echo"<script type='text/javascript'>alert(\"Nome vuoto\");</script>";
        if(isset($costo))
            $this->costo = $costo;
        else
            echo"<script type='text/javascript'>alert(\"Costo vuoto\");</script>";
    }

    private $nome;
    private $costo;
}