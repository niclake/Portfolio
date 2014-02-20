<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);
	
	if ($hours < 12) {
		$tuition = $hours * 230;
		$time = part;
	}
	else {
		$tuition = 2762;
		$time = full;
	}
	
	print "You are registered for $hours hours.  You are considered a $time time student, and tuition is $".number_format($tuition,2).".";

?>
</body>
</html>
