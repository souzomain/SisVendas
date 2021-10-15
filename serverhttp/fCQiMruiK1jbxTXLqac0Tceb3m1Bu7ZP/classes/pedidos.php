<?php
require_once '../db/conn.php';
    class Pedidos extends Database{
        private $res;
        private $con;
        function __construct(){
            if($this->con == null)
                $this->con = new Database::Conexion();
        }
        public function getAll(){
            $this->res = $this->con->query("SELECT * FROM venda JOIN tipo ON venda.id_tipo = tipo.id WHERE finalizado = 0");
            return $this->res->fetch_array(MYSQLI_ASSOC);
        }
        public function getfromtipo($str){
            $this->res = $this->con->query("SELECT * FROM venda JOIN tipo ON venda.id_tipo = tipo.id WHERE finalizado = 0 AND tipo.nome = $str");
            return $this->res->fetch_array(MYSQLI_ASSOC);
        }
        function __destruct(){
            if($res != null)
                $res = null;
            if($con != null)
                $con = null;
        }
    }