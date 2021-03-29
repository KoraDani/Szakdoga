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
    $_SESSION['lakasid'] = $row[0];
    $result2 = $conn->query("SELECT DISTINCT szoba.id, szoba.szobaNev FROM szoba WHERE szoba.lakasID=$row[0]");
    $html .= '<div  style="display: flex; justify-content: space-around; flex-wrap:wrap;">';
    while ($row1 = $result2->fetch_array()) {
        //$row1 = $result3->fetch_array();
        while ($row2 = $result2->fetch_array()) {
            $result3 = $conn->query("SELECT adatok.homerseklet,adatok.paratartalom, adatok.levegoMin FROM adatok WHERE adatok.szobaId=$row1[0] GROUP BY adatok.szobaId");
            
            $html .= '<div class="m-1 bg-gradient p-2 shadow p-3 mb-5 bg-body rounded">';
            $html .= '<p>' . $row2[1] . '</p><br>';
            while ($row3 = $result3->fetch_array()) {
                $html .= '<p id="1">Hőmérséklet: ' . $row3[0] . '</p><br>';
                $html .= '<p id="1">Páratartalom: ' . $row3[1] . '</p><br>';
                $html .= '<p id="1">Levegő minőség: ' . $row3[2] . '</p><br>';
                $html .= '<div class="form-check form-switch">';
                $html .= '<input class="form-check-input done" value="" type="checkbox" id="flexSwitchCheckDefault">';
                $html .= '<label class="form-check-label" for="flexSwitchCheckDefault">Fűtés</label>';
                $html .=  '</div>';
                $html .= '<div class="form-check form-switch">';
                $html .= '<input class="form-check-input done" type="checkbox" id="flexSwitchCheckDefault">';
                $html .= '<label class="form-check-label" for="flexSwitchCheckDefault">Eszköz</label>';
                $html .= '</div>';
                $html .= '</div>';
                
            }
        }
    }
    $html .= '</div>';
}

echo $html;
