<?php
session_start();
require_once('connect.php');
echo file_get_contents('html/header.html');
echo file_get_contents('html/logout.html');
$html = null;

if (isset($_SESSION['userid'])) {
    $userid = $_SESSION['userid'];
    $result1 = $conn->query("SELECT DISTINCT users.lakasId FROM szoba INNER JOIN users ON szoba.lakasID=users.lakasId WHERE users.id=$userid");
    $row = $result1->fetch_array();
    $lakasid = $row[0];
    //echo $lakasid;
    //ciklus
    $result2 = $conn->query("SELECT DISTINCT szoba.id, szoba.szobaNev FROM szoba WHERE szoba.lakasID=$row[0]");
    $row2 = $result2->fetch_array();
    $result3 = $conn->query("SELECT adatok.homerseklet,adatok.paratartalom, adatok.levegoMin, eszkozok.eszkozNev FROM eszkozok INNER JOIN tobbeszkoz ON eszkozok.id=tobbeszkoz.eszkozID INNER JOIN szoba ON tobbeszkoz.szobaID=szoba.id INNER JOIN adatok ON adatok.szobaId=szoba.id WHERE adatok.szobaId=$row2[0] GROUP BY adatok.szobaId");
    //$row1 = $result3->fetch_array();
    while ($row2 = $result2->fetch_array()) {
        $html .= '<div class="flexkimutatas">';
        $html .= '<div class="asdasd"">';
        $html .= '<p>' . $row2[1] . '</p><br>';
        while ($row3 = $result3->fetch_array()) {
            $html .= '<p id="1">Hőmérséklet: ' . $row3[0] . '</p><br>';
            $html .= '<p id="1">Páratartalom: ' . $row3[1] . '</p><br>';
            $html .= '<p id="1">Levegő minőség: ' . $row3[2] . '</p><br>';
            $html .= '<label class="switch">';
            $html .= '<p id="1">' . $row3[3] . '</p><br><input type="checkbox">';
            $html .= '<span class="slider round"></span></label>';
            $html .= '</div></div>';
        }
    }
}

echo $html;
