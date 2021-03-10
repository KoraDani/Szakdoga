<?php
session_start();
require_once('connect.php');
echo file_get_contents('html/header.html');
include('session.php');
$homerseklet = "";
$paratartalom = "";
$levegomin = "";
    $result = $conn->query("SELECT homerseklet,paratartalom,levegoMin FROM adatok");
	
	while($row = $result->fetch_array()){
		$homerseklet = $homerseklet.'"'.$row['homerseklet'].'",';
		$paratartalom = $paratartalom.'"'.$row['paratartalom'].'",';
		$levegomin = $levegomin.'"'.$row['levegoMin'].'",';
    }

	$homerseklet = trim($homerseklet.",");
	$paratartalom = trim($paratartalom.",");
	$levegomin = trim($levegomin.",");
?>
<script src="http://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js"></script>
<div id="container">
<canvas id="chart" style="width: 100%; height: 60vh; background: #222; border: 1px solid #555652; margin-top: 10px;"></canvas>
</div>
<script>
	var ctx = document.getElementById("chart").getContext('2d');
	var myChart = new Chart(ctx,{
		type: 'line',
		data: {
			lables: [1,2,3,4,5,6,7,8,9],
			datasets:[{
				lable: 'Homerseklet',
				data: [<?php echo $homerseklet;?>],
				backgroundColor: 'transparent',
				borderColor:'rgba(255,99,132)',
				borderWidth: 3
			},
			{
				lable: 'Paratartalom',
				data: [<?php echo $paratartalom;?>],
				backgroundColor: 'transparent',
				borderColor:'rgba(255,99,100)',
				borderWidth: 3
			},
			{
				lable: 'LevegoMin',
				data: [<?php echo $levegomin;?>],
				backgroundColor: 'transparent',
				borderColor:'rgba(255,99,50)',
				borderWidth: 3
			}]
		},
		options:{
			scales: {scales:{yAxes:[{beginAtZero: false}],xAxes: [{autoskip: true, maxTicketsLimit: 20}]}},
			tooltips:{mode: 'index'},
			legend:{display: true, position: 'top', labels: {fontColor: 'rgb(255,255,255)',fontSize: 16}}
		}
	});
</script>

<?php
echo file_get_contents('html/footer.html');
?>