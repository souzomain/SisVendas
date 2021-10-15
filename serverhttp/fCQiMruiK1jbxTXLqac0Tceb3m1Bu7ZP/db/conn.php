<?php
    class Database{
        protected function Conexion(){
            const strcon = "PastelDaBranca171@.";
            return new Mysqli("localhost","root","","rafa");
        }
    }