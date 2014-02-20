<html>
<title>Untitled Document</title>

<body>
<?php
	extract ($_REQUEST);

	if ($age >=55 OR $age<=12) {
		$price=6.5;
	}
	
	else {
		$price=9;
	}

	print "$name, it will cost you \$" . number_format($price,2) . " to attend a movie.";	
	
?>

</body>
</html>






