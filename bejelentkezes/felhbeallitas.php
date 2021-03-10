<?php
session_start();
require_once("connect.php");
include('session.php');
echo file_get_contents('html/header.html');
echo file_get_contents('html/felhasznalomod.html');

if (isset($_POST['submitf'])) {
    //$userid = $_SESSION['userid'];
    $userid = 1;
    if (isset($_POST['felhmod'])) {
        $usernev = $_POST['felhmod'];
        mysqli_query($conn,"UPDATE users SET felh='$usernev' WHERE id LIKE 1");
        echo $userid;
        echo 'lefutottid<br>';
    }
    else {
        echo 'ures felhasznalonev<br>';
    }
    if (isset($_POST['lakasnev'])) {
        $lakasnev = $_POST["lakasnev"];
        //mysqli_query($conn,"INSERT INTO lakas (lakasnev) VALUES ('$lakasnev')");
        $result = $conn->query("SELECT id FROM lakas WHERE lakasnev LIKE '$lakasnev'");
        $row = $result->fetch_array();
        $lakasid = $row[0];
        //mysqli_query($conn,"UPDATE users SET lakasId=$lakasid WHERE felh='fghfghf'");
        echo 'lakaslefutott<br>';
    }
    else {
        echo 'ures lakasnev<br>';
    }
}
