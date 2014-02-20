<html>
<title>Nic Lake</title>
<body>

<?php
	extract ($_REQUEST);
	print "You selected the following toppings:";
	print "<ul>";
		//for ($topping_selected=0; $topping_selected < count($topping); $topping_selected++) {
		//	print "<li>$topping[$topping_selected]</li>";
		//}
		foreach($topping AS $a_topping) {
			print "<li>$a_topping</li>";
		}
	print "</ul>";
?>

</body>
</html>
