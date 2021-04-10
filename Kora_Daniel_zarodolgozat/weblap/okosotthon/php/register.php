<?php
session_start();
require_once("../config/connect.php");
echo file_get_contents('../html/header.html');
echo file_get_contents('../html/login.html');
echo file_get_contents('../html/register.html');
function encrypt($text)
{
    $hashedPwd = hash('sha512', $text);
    return strtoupper($hashedPwd);
}
if (isset($_POST['regiszt'])) {
    $name = $_POST['user'];
    $email = $_POST['email'];
    $result = $conn->query("SELECT DISTINCT felh FROM users WHERE felh ='$name'");
    //echo $result;
    $szam = $result->num_rows;
    if ($_POST['user'] == "" || $_POST['pwd1'] == "" || $_POST['pwd2'] == "") {
    } else if (!$szam == 1) {
        if ($_POST['pwd1'] == $_POST['pwd2']) {
            $pwd = $_POST['pwd1'];
            $pattern = '/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$/';
            if (preg_match($pattern, $pwd)) {
                $pwdHash = encrypt($pwd);
                $_SESSION['felhnev'] = $name;
                mysqli_query($conn, "INSERT INTO users (felh, jelszo, emial) VALUES ('$name','$pwdHash','$email')");
                header('Location:lakas.php');
            }
        } else {
            echo '<p class="text-center">Nem egyezik a jelszó</p>';
        }
    } else {
        echo '<p class="text-center">A felhasználó név már létezik</p>';
    }
}