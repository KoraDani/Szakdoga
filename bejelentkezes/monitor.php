<?php
session_start();
require_once('connect.php');
echo file_get_contents('html/header.html');
echo file_get_contents('html/logout.html');
$html = "";
?>

<div class="keret">
    <div class="monitor">
        <form method="get">
            <?php
            echo $html;
            ?>
        </form>
    </div>
    <?php
    $html = "";
    $html .= '<table>';
    if (isset($_SESSION['userid'])) {
        $userid = $_SESSION['userid'];
        $result1 = $conn->query("SELECT DISTINCT users.lakasId FROM szoba INNER JOIN users ON szoba.lakasID=users.lakasId WHERE users.id=$userid");
        $row = $result1->fetch_array();
        $lakasid = $row[0];
        //$result2 = $conn->query("SELECT DISTINCT id, szobaNev FROM szoba WHERE lakasID=$row3[0] ORDER BY id ASC");
        $result2 = $conn->query("SELECT DISTINCT id, szoba.szobaNev FROM szoba WHERE lakasID=$row[0]");
        //$row2 = $result2->fetch_array();
        //$szobaszam = $row2[0];
        $row = $result2->fetch_array();
            $html .= '<button class="button asd" name="szoba" value="' . $row[0] . '">' . $row[1] . '</button><br>';
        //$szobaiD1 = $_GET['szoba'];
        /*echo '<div >';
                while ($row1 = $result2->fetch_array()) {
                    $html .= '<p>' . $row1[1] . '</p><br>';
                    
                }

                $result = $conn->query("SELECT adatok.homerseklet, adatok.paratartalom, adatok.levegoMin, eszkozok.eszkozNev, szoba.szobaNev  FROM eszkozok INNER JOIN tobbeszkoz ON eszkozok.id=tobbeszkoz.eszkozID INNER JOIN szoba ON tobbeszkoz.szobaID=szoba.id INNER JOIN adatok ON adatok.szobaId=szoba.id WHERE adatok.szobaId=1 GROUP BY szoba.id");
                    while ($row = $result->fetch_array()) {
                    $html .= '<p>' . $row[0] . '</p><p>' . $row[1] . '</p><p>' . $row[2] . '</p><p>' . $row[3] . '</p><p>' . $row[4] . '</p>'; 
            }*/
        echo '</div>';
    }

   //if (isset($_SESSION['userid'])) {

        //if (isset($_GET['szoba'])) {
            $html .= '<p>' . $row[2] . '</p><p>' . $row[3] . '</p><p>' . $row[4] . '</p><p>' . $row[5] . '</p>';
            $html .= '<tr><td>min homérséklet</td><td>min páratartalom</td><td>min levegő minőség</td></tr>';
            $result2 = $conn->query("SELECT DISTINCT MIN(homerseklet), MIN(paratartalom), MIN(levegoMin) FROM adatok WHERE szobaId=$row[0]");
            while ($row2 = $result2->fetch_array()) {
                $html .= '<tr><td>' . $row2[0] . '</td><td>' . $row2[1] . '</td><td>' . $row2[2] . '</td>';
            }
            $html .= '</tr><td>max homérséklet</td><td>max páratartalom</td><td>max levegő minőség</td></tr>';
            $result2 = $conn->query("SELECT DISTINCT MAX(homerseklet), MAX(paratartalom), MAX(levegoMin) FROM adatok WHERE szobaId=$szobaiD1");
            while ($row2 = $result2->fetch_array()) {
                $html .= '<tr><td>' . $row2[0] . '</td><td>' . $row2[1] . '</td><td>' . $row2[2] . '</td>';
            }
            $result = $conn->query("SELECT eszkozok.eszkozNev FROM eszkozok INNER JOIN tobbeszkoz ON eszkozok.id=tobbeszkoz.eszkozID INNER JOIN szoba ON tobbeszkoz.szobaID=szoba.id INNER JOIN adatok ON adatok.szobaId=szoba.id WHERE szoba.lakasID=$lakasid");
            while ($row = $result->fetch_array()) {
                echo $row[0];
            }
    $html .= '</table>';
    $conn->close();
    ?>
    <div class="adatok">
        <?php
        echo $html;
        ?>
    </div>
</div>