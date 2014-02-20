<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);

	if ($panthers > $opponent) {
		print "Panthers win!";
	}
	elseif ($panthers == $opponent) {
		print "It's a tie.";
	}
	else {
		print "Panthers lose.";
	}
?>

</body>
</html>