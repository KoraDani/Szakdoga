<?php
session_start();
echo file_get_contents('html/header.html');

echo file_get_contents('html/logout.html');
require_once('connect.php');
if (isset($_POST['submit'])) {
    $userID = $_SESSION['userid'];
    $lakasid = $_SESSION['lakasid'];
    $szobanev = $_POST['szobanev'];
    $terulet = $_POST['terulet'];
    $futest = $_POST['futestipus'];
    $eszkoz = $_POST['eszkoz'];
    $sql = "INSERT INTO szoba (szobaNev, terulet, eszkozID, futesID) VALUES ('$szobanev','$terulet','$futest','$eszkoz')";
    $sql1 = "UPDATE szoba SET lakasId='$lakasid' WHERE szobaNev='$szobanev'";
    if ($conn->query($sql) === TRUE) {
        if ($conn->query($sql1) === TRUE) {
            echo "New record created successfully";
            $conn->close();
        } else {
            echo "Error: " . $sql1 . "<br>" . $conn->error;
        }
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}
echo file_get_contents('html/adatok.html');
