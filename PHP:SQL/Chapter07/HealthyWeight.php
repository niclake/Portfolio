<html>
<title>Healthy Weight - Nic Lake</title>
<body>

<?php
	$inches = 0;
	$startweight = 94;
	$endweight = 127;
	
	print "<table border ='1'>
		<tr>
			<th>Height</th>
			<th>Healthy Weight Range</th>
		</tr>";
	
	while ($inches < 11) {
		print "<tr>
			<td align = 'center'>5 ft. $inches in.</td>
			<td align = 'center'>$startweight - $endweight</td>
		</tr>";
		$inches = $inches + 2;
		$startweight = $startweight + 7;
		$endweight = $endweight + 9; 
	}
	
	print "</table>";

?>
</body>
</html>
