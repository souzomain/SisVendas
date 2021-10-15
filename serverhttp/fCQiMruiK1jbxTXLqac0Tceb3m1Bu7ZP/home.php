<?php
    $list = 'all';
    if(isset($_GET['list']))
        $list=$_GET['list'];
    $pedidos = new Pedidos();
    switch($list){
        case 'all':
            $r = $pedidos->getAll();
            var_dump($r);
            break;
        default:
            var_dump($pedidos->getAll());
            break;
    }