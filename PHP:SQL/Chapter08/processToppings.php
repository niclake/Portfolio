<html>
<body>
<?php
	extract ($_REQUEST);
	
	print "The toppings you have selected are:
		<ul>";
	
	sort ($topping);
	foreach ($topping AS $a_topping) {
		print "<li>$a_topping</li>";
	}
	
	print "</ul>"

?>

</body>
</html>