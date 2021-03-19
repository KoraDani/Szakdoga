<?php
session_start();
require_once('connect.php');
echo file_get_contents('html/header.html');
include('session.php');

$homerseklet = "";
$paratartalom = "";
$levegomin = "";
$result2 = $conn->query('SELECT DISTINCT szoba.id, szoba.szobaNev FROM szoba WHERE szoba.lakasID=' . $_SESSION['lakasid']);
echo '<form method="post">';
while ($row1 = $result2->fetch_array()) {
	echo '<button name="szobanev" value=' . $row1[0] . '>' . $row1[1] . '</button>';
}
echo '</form>';
$szobaid = $_POST['szobanev'];
$result = $conn->query("SELECT id,homerseklet,paratartalom,levegoMin FROM adatok WHERE szobaId='$szobaid' ORDER BY id DESC LIMIT 10");

while ($row = $result->fetch_array()) {
	$homerseklet = $homerseklet . '"' . $row['homerseklet'] . '",';
	$paratartalom = $paratartalom . '"' . $row['paratartalom'] . '",';
	$levegomin = $levegomin . '"' . $row['levegoMin'] . '",';
}

$homerseklet = trim($homerseklet . ",");
$paratartalom = trim($paratartalom . ",");
$levegomin = trim($levegomin . ",");
?>
<script src="http://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js"></script>
<div id="container">
	<canvas id="chart" style="width: 100%; height: 60vh; background: #222; border: 1px solid #555652; margin-top: 10px;"></canvas>
</div>
<script>
	var ctx = document.getElementById("chart").getContext('2d');
	var myChart = new Chart(ctx, {
		type: 'line',
		data: {
			lables: [1, 2, 3, 4, 5, 6, 7, 8, 9],
			datasets: [{
					label: "Hőmérséklet",
					data: [<?php echo $homerseklet; ?>],
					backgroundColor: 'transparent',
					borderColor: 'rgba(255,99,132)',
					borderWidth: 3
				},
				{
					label: 'Paratartalom',
					data: [<?php echo $paratartalom; ?>],
					backgroundColor: 'transparent',
					borderColor: 'rgba(255,99,100)',
					borderWidth: 3
				},
				{
					label: 'LevegoMin',
					data: [<?php echo $levegomin; ?>],
					backgroundColor: 'transparent',
					borderColor: 'rgba(255,99,50)',
					borderWidth: 3
				}
			]
		},
		options: {
			scales: {
				scales: {
					yAxes: [{
						beginAtZero: false
					}],
					xAxes: [{
						autoskip: true,
						maxTicketsLimit: 20
					}]
				}
			},
			tooltips: {
				mode: 'index'
			},
			legend: {
				display: true,
				position: 'top',
				labels: {
					fontColor: 'rgb(255,255,255)',
					fontSize: 16
				}
			}
		}
	});
</script>

<?php
echo file_get_contents('html/footer.html');
?>