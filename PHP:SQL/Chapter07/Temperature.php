<html>
<title>Temperature - Sarah Schuldt</title>
<body>

<?php
	$c = -10;
	
	print "<table border = '1'>
		<tr>
			<th>Celsius</th>
			<th>Farenheit</th>
		</tr>";
		
	while ($c <= 0) {
		$f = (($c * 1.8) + 32);
		print "<tr>
			<td>$c</td>
			<td>$f</td>
		</tr>";
		$c = $c + 2;
	}
	
	print "</table>";

?>
</body>
</html>
