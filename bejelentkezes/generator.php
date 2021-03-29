<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form method="post">
        <input type="text" name="hanyszor" placeholder="hányszor generáljon?">
        <button name="general">Generálás</button>
    </form>

    <?php
    require_once('connect.php');
    $result1 = $conn->query("SELECT COUNT(id) FROM szoba");
    $row = $result1->fetch_array();
    $szobaszam = $row[0];
    echo $szobaszam;
    if (isset($_POST['general'])) {
        for ($i = 0; $i < $_POST['hanyszor']; $i++) {
            $szobaid = rand(0, $szobaszam);
            $homerseklet = rand(14, 40);
            $paratartalom = rand(30, 90);
            $levegomin = rand(0, 100);
            mysqli_query($conn, "INSERT INTO adatok (szobaId,homerseklet,paratartalom,levegoMin) VALUES ('$szobaid','$homerseklet','$paratartalom','$levegomin')");
        }
    }
    ?>
</body>

</html>