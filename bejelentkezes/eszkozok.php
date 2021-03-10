
<?php
session_start();
require_once('connect.php');
echo file_get_contents('html/header.html');
echo file_get_contents('html/logout.html');
echo file_get_contents('html/eszkozok.html');
if ($_SERVER['REQUEST_METHOD'] == 'POST'){
    $fuggony = isset($_POST['fuggony']) == 'value1' ? 1 : 0;
    $redony = isset($_POST['redony']) == 'value2' ? 1 : 0;
    $termo = isset($_POST['termo']) == 'value3' ? 1 : 0;
    $lampa = isset($_POST['lampa']) == 'value4' ? 1 : 0;
    
    echo $fuggony." ".$redony." ".$termo." ".$lampa;
    // class="switch"
    //     // class="slider round"
}
?>

