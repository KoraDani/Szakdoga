<link rel="stylesheet" href="../css/bootstrap.css">
<link rel="stylesheet" href="../css/bootstrap.min.css">
<div class="shadow p-3 mb-5 bg-body rounded w-25">
    <form method="POST">
        <input type="text" name="lakas" placeholder="Írja be a lakás nevét">
        <button class="btn btn-primary">küldés</button>
    </form>
</div>
<?php
session_start();
require_once('../config/connect.php');
$felhnev = $_SESSION['felhnev'];
$html = "";
if (isset($_POST['lakas'])) {
    $lakasnev = $_POST['lakas'];
    $result = $conn->query("SELECT DISTINCT id,lakasnev FROM lakas WHERE lakasnev='$lakasnev'");
    $row = $result->fetch_array(MYSQLI_NUM);
    $szam = $result->num_rows;
    echo $szam;
    $html .= '<form method="post">';
    if ($szam == 1) {
        $html .= 'létezik ilyen lakás';
        $html .= '<button type="submit" class="btn btn-primary mt-4">asd</button>';
        if (isset($row[0])) {
            $result = $conn->query("UPDATE users SET lakasId=" . $row[0] . " WHERE felh='$felhnev'");
            session_destroy();
            header('Location:bejelnt.php');
        }
    }
    else {
        $html .= 'lakás nem létezik';
        $var = mysqli_query($conn, "INSERT INTO lakas (lakasnev) VALUES ('$lakasnev')", MYSQLI_STORE_RESULT);
        if ($var) {
            header('Location:bejelent.php');
            session_destroy();
        }
    }
    $html .= '</form>';
    echo $html;
}
?>