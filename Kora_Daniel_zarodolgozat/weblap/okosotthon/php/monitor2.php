<?php
session_start();
require_once('../config/connect.php');
echo file_get_contents('../html/header.html');
echo file_get_contents('../html/logout.html');
$html = null;

if (isset($_SESSION['userid'])) {

    $userid = $_SESSION['userid'];

    $result1 = $conn->query("SELECT DISTINCT users.lakasId FROM szoba INNER JOIN users ON szoba.lakasID=users.lakasId WHERE users.id=$userid");
    $row = $result1->fetch_array(MYSQLI_NUM);
    //$szam = $result1->num_rows;
    //if (!$result1->num_rows) {
    if (!isset($row)) {
        $html .= '<div class="container text-center">';
        $html .= '<p class="text-center">Úgy tűnik még nincs beállítva felhasználóhoz lakás vagy szoba!</p><br>';
        $html .= '<p class="text-center">Ha beállította a lakást és még mindig ez a képernyő fogadja akkor az asztali alkalmazsában szobákat kell hozzá adni a lakáshoz.</p><br>';
        $html .= '<form action="lakas.php"><button class="btn btn-primary" type="submit" href="lakas.php">Megpróbálom mégegyszer</button></form><br>';
        $html .= '<img class="rounded mx-auto d-block" width="400px" src="../képek/room2.png">';
        $html .= '</div>';
    } else {
        $result1 = $conn->query("SELECT DISTINCT users.lakasId FROM szoba INNER JOIN users ON szoba.lakasID=users.lakasId WHERE users.id=$userid");
        $row = $result1->fetch_array();
        if (isset($row)) {
            $lakasid = $row[0];
            //echo $lakasid;
            $_SESSION['lakasid'] = $row[0];
            $result2 = $conn->query("SELECT DISTINCT szoba.id, szoba.szobaNev FROM szoba RIGHT JOIN adatok ON szoba.id=adatok.szobaId WHERE szoba.lakasID=" . $row[0] . " AND szoba.lakasID IS NOT NULL"); // AND adatok.homerseklet IS NOT NULL
            $html .= '<div  style="display: flex; justify-content: space-around; flex-wrap:wrap;">';
            while ($row1 = $result2->fetch_array()) {
                //echo $row1[0]." ";
                //while ($row2 = $result2->fetch_array()) {
                $result3 = $conn->query("SELECT adatok.homerseklet,adatok.paratartalom, adatok.levegoMin FROM adatok INNER JOIN szoba ON adatok.szobaId=szoba.id  WHERE adatok.szobaId=$row1[0] GROUP BY adatok.szobaId ORDER BY adatok.id DESC LIMIT 1");
                //$result4 = $conn->query("SELECT szobaID FROM tobbeszkoz WHERE szobaID=".$row2[0]);
                //Meg kell oldani hogy ha nincs adat a szobához akkor ne jelenjen meg
                $html .= '<div class="m-1 bg-gradient p-2 shadow p-3 mb-5 bg-body rounded">';
                $html .= '<p>' . $row1[1] . '</p><br>';
                //if (mysqli_num_rows($result2)) {
                while ($row3 = $result3->fetch_array()) {
                    $html .= '<p id="1">Hőmérséklet: ' . $row3[0] . '</p><br>';
                    $html .= '<p id="1">Páratartalom: ' . $row3[1] . '</p><br>';
                    $html .= '<p id="1">Levegő minőség: ' . $row3[2] . '</p><br>';
                    //echo $result3->num_rows."sorszam";
                    //$html .= '<div class="form-check form-switch">';
                    /*$html .= ($row3[3] == 1) ? '<input class="form-check-input done" value="' . $row1[0] . '" type="checkbox" id="flexSwitchCheckDefault" checked>' : '<input class="form-check-input done" type="checkbox" id="flexSwitchCheckDefault" >';
                $html .= '<label class="form-check-label" for="flexSwitchCheckDefault">Fűtés</label>';
                $html .=  '</div>';
                $html .= '<div class="form-check form-switch">';
                $html .= ($row3[3] == 1) ? '<input class="form-check-input done" type="checkbox" id="flexSwitchCheckDefault" >' : '<input class="form-check-input done" type="checkbox" id="flexSwitchCheckDefault" checked>';
                $html .= '<input class="form-check-input done" type="checkbox" id="flexSwitchCheckDefault">';
                $html .= '<label class="form-check-label" for="flexSwitchCheckDefault">Eszköz</label>';*/
                    //$html .= '</div>';
                    $html .= '</div>';
                }
            }
            $html .= '</div>';
        }
    }
}

echo $html;
