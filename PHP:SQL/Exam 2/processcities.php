<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);
	
	print "<table border='1'>
		<tr>
			<th>Cities I've Lived In:</th>
		</tr>
		<tr>
			<td><ul>";
	
	for ($i=0; $i < count($city); $i++) {
		print "<li>".ucwords($city[$i])."</li>";
	}
	
	print "</ul></td>
		</tr>
	</table>";

?>
</body>
</html>
