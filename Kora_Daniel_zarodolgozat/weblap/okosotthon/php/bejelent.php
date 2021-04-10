<?php
session_start();
require_once("../config/connect.php");
echo file_get_contents('../html/header.html');
include('../config/session.php');
include('generator.php');

$error = "";
$pwd = "";
$name = "";
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['username'];
    $result = $conn->query("SELECT DISTINCT id,jelszo,lakasId FROM users WHERE felh ='$name'");
    $row = $result->fetch_array();
    if (isset($row)) {
        $pwd = $row[1];
        $pwdpost = $_POST['pwd'];
        $hash = strtoupper(hash('sha512', $pwdpost));
        if ($_POST['username'] == "" || $_POST['pwd'] == "") {
            echo 'Valamelyik mezőt nem töltötte ki';
            //$error = "Hiba van2";
        } else if ($result->num_rows == 1) {
            //$error = "Hiba van3";
            if ($hash == $pwd) {
                $_SESSION['userid'] = $row[0];
                $_SESSION['lakasid'] = $row[2];
                $_SESSION['felhnev'] = $name;
                //Mivel ez egy szimuláció ezért az adatokat is szimulálni kell ezért minden bejeletnkezésnél 5db adat lesz legenerálva hogy minden úgy jelenjen meg ahogy annak kell
                $result1 = $conn->query("SELECT id FROM szoba ORDER BY id DESC LIMIT 1");
                $row = $result1->fetch_array();
                $szobaszam = $row[0];
                //echo $szobaszam;
                for ($i = 0; $i < 5; $i++) {
                    $szobaid = rand(0, $szobaszam + 1);
                    $homerseklet = rand(14, 40);
                    $paratartalom = rand(30, 90);
                    $levegomin = rand(0, 100);
                    mysqli_query($conn, "INSERT INTO adatok (szobaId,homerseklet,paratartalom,levegoMin) VALUES ('$szobaid','$homerseklet','$paratartalom','$levegomin')");
                }
                $conn->close();
                header('Location:monitor2.php');
            } else {
                $error = "Hibás jelszó";
            }
        } else {
            $error = "Nincs ilyen felhasználó";
        }
    }else {
        $error = "Nem töltötte ki a mezőket";
    }
}
echo $error;
echo file_get_contents('../html/bejelentkezes.html');
