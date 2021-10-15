<?php
require_once '../db/conn.php';
    class Tipos extends Database{
        private $res;
        private $con;
        function __construct(){
            if($this->con == null)
                $this->con = new Database::Conexion();
        }
        public function getTipo($id){
            $sql = "SELECT * FROM tipo WHERE id = $id";
            $this->res = $this->con->query($sql);
            return $this->res->fetch_array(); 
        }
        function __destruct(){
            if($res != null)
                $res = null;
            if($con != null)
                $con = null;
        }
    }