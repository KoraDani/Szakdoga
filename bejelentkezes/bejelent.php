<?php
session_start();
require_once("connect.php");
include('session.php');
echo file_get_contents('html/header.html');
$error = "";

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $error = "Hiba van1";
    $name = $_POST['username'];
    $result = $conn->query("SELECT DISTINCT id,jelszo,lakasId FROM users WHERE felh ='$name'");
    $row = $result->fetch_array();
    $pwd = $row[1];
    $pwdpost = $_POST['pwd'];
    $hash = hash('sha512', $pwdpost);

    if ($_POST['username'] == "" || $_POST['pwd'] == "") {
        echo 'Üres mezők';
        $error = "Hiba van2";
    } else if ($result->num_rows == 1) {
        $error = "Hiba van3";
        if (password_verify($hash, $pwd)) {

            //echo file_get_contents('html/logout.html');
            $_SESSION['userid'] = $row[0];
            $_SESSION['lakasid'] = $row[2];
            echo 'asd';
            $conn->close();
            header('Location:adatok.php');
            $error = "Belépet";
        }
    }
}
echo $error;
echo file_get_contents('html/bejelentkezes.html');
//echo file_get_contents('html/footer.html');
//session_destroy();