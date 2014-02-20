<html>
<title>Nic Lake</title>
<body>

<?php
extract ($_REQUEST);

	print "<table border='1'>
		<tr>
			<th align='center'>Toppings</th>
		</tr>";

	for ($i=0; $i < count($topping); $i++) {
		print "<tr>
			<td align='center'>".strtoupper($topping[$i])."</td>
		</tr>";
	}
	
	print "</table>";
	
?>
</body>
</html>