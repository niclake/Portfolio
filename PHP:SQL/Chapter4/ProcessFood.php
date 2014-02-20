<html>
<title>Nic Lake</title>
<body>

<?php
	extract ($_REQUEST);
	print "You selected the following foods:";
	print "<table border='1'>";
		for ($food_selected=0; $food_selected < count($food); $food_selected++) {
			$table_num=$food_selected+1;
			print "<tr>
			<td>$table_num</td>
			<td>$food[$food_selected]</td>
			</tr>";
		}
	print "</table>";
	print "Total number of foods selected: $table_num";
?>

</body>
</html>
