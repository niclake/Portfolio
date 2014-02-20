<html>
<title>Nic Lake</title>
<body>

<?php
	extract ($_REQUEST);
	print "You selected the following toppings:";
	print "<table border='1'>";
		for ($topping_selected=0; $topping_selected < count($topping); $topping_selected++) {
			print "<tr>
			<td>$topping[$topping_selected]</td>
			</tr>";
		}
	print "</table>";
?>

</body>
</html>
