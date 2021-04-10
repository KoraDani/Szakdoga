<?php
session_start();
require_once('connect.php');

//állítsuk át adatbázisan, hogy az adott feladat elkészült

echo$_POST['id2'];
if (!empty($_POST['id2'])){
    $id = $_POST['id2'];
    $sql = "UPDATE tobbeszkoz SET bekiE = '0' WHERE szobaID = ?";
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