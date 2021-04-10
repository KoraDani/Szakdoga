<?php
session_start();
require_once('connect.php');

//állítsuk át adatbázisan, hogy az adott feladat elkészült

echo$_POST['id1'];
if (!empty($_POST['id1'])){
    $id = $_POST['id1'];
    $sql = "UPDATE tobbeszkoz SET bekiE = '1' WHERE szobaID = ?";
    if ($stmt = $conn -> prepare($sql)){
        $stmt ->bind_param("i", $id);   // i mint integer azaz egész
        if ($stmt->execute()){
            http_response_code(200);
        } else {
            http_response_code(502);
        }
        $stmt -> close();
    } else{
        http_response_code(501);    
    }
} else {
    http_response_code(500);
}
$conn -> close();