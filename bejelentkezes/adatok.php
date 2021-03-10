<?php
session_start();
echo file_get_contents('html/header.html');

echo file_get_contents('html/logout.html');
require_once('connect.php');
if (isset($_POST['submit'])) {
    $szobanev = $_POST['szobanev'];
    $terulet = $_POST['terulet'];
    $futest = $_POST['futestipus'];
    $eszkoz = $_POST['eszkoz'];
    $sql = "INSERT INTO szoba (szobaNev, terulet, eszkozID, futesID) VALUES ('$szobanev','$terulet','$futest','$eszkoz')";
    //$sql = "UPDATE users SET lakasId='$lakasid' WHERE id='$userID'";
    if ($conn->query($sql) === TRUE /*&& $conn->query($sql1) === TRUE*/) {
        echo "New record created successfully";
        $conn->close();
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}else {
    //echo 'Hiba1';
}
if (isset($_POST['lakassubmit'])) {
    $lakasnev = $_POST["lakasnev"];
    mysqli_query($conn,"INSERT INTO lakas (lakasnev) VALUES ('$lakasnev')");
    $result = $conn->query("SELECT id FROM lakas WHERE lakasnev LIKE '$lakasnev'");
    $row = $result->fetch_array();
    $lakasid = $row[0];
    $felhID = $_SESSION['userid'];
    echo $lakasid;
    mysqli_query($conn,"UPDATE users SET lakasId=$lakasid WHERE id=$felhID");
}
else {
    //echo 'Hiba2';
}
echo file_get_contents('html/adatok.html');
