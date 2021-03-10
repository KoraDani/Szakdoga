<?php
session_start();
echo file_get_contents('html/header.html');
echo file_get_contents('html/login.html');
echo file_get_contents('html/register.html');
    require_once("connect.php");
    if (isset($_POST['submit'])) {
        $name = $_POST['user'];
        $email = $_POST['email'];
        $result = $conn->query("SELECT DISTINCT felh FROM users WHERE felh ='$name'");
        //echo $result;
        $szam = $result->num_rows;
        if ($_POST['user'] == "" || $_POST['pwd1'] == "" || $_POST['pwd2'] == "") {
            echo 'Üres mezők';
        } else if (!$szam == 1) {
            if ($_POST['pwd1'] == $_POST['pwd2']) {
                $pwd = $_POST['pwd1'];
                $pwdHash = hash('sha512', $pwd);
                $pwdHash = password_hash($pwdHash, PASSWORD_DEFAULT);
                mysqli_query($conn, "INSERT INTO users (felh, jelszo, emial) VALUES ('$name','$pwdHash','$email')");
                echo "Regisztrálva";
                
            } else {
                echo "Nem egyezik a jelszó";
            }
        } else {
            echo "A felhasználó név már létezik";
        }
    }
    session_destroy();